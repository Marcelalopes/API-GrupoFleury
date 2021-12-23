using System.Collections;
using API_GrupoFleury.Dtos;
using API_GrupoFleury.models;
using System;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Repository;
using AutoMapper;

namespace API_GrupoFleury.service
{
  public class ClientService : IClientService
  {
    private readonly IClientRepository _clientRepository;
    private readonly IMapper _mapper;

    public ClientService(IClientRepository clientRepository, IMapper mapper)
    {
      _clientRepository = clientRepository;
      _mapper = mapper;
    }
    public IEnumerable<ClientsDto> GetAll()
    {
      return _mapper.Map<IEnumerable<ClientsDto>>(_clientRepository.GetAll().ToList());
    }

    public ClientNewDto Add(ClientNewDto newClient)
    {
      _clientRepository.add(_mapper.Map<Client>(newClient));
      return newClient;
    }

    public void Update(ClientsDto updateClient)
    {
      _clientRepository.Update(_mapper.Map<Client>(updateClient));
    }

    public Boolean Desativar(String cpf)
    {
      return _clientRepository.Desativar(cpf);
    }

    public ClientsDto Search(string cpf)
    {
      return _mapper.Map<ClientsDto>(_clientRepository.Search(cpf));
    }
  }
}