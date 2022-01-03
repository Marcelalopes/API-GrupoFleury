using System.Collections;
using API_GrupoFleury.Dtos;
using API_GrupoFleury.models;
using System;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Repository;
using AutoMapper;
using System.Threading.Tasks;
using System.Dynamic;

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
    public async Task<dynamic> GetAll(int pageSize, int pageNumber)
    {
      var result = await _clientRepository.GetAll(pageSize, pageNumber);
      dynamic response = new ExpandoObject();
      response.currentPage = pageNumber;
      response.pageSize = pageSize;
      response.totalPages = Math.Ceiling((double)result.TotalItemCount / pageSize);
      response.totalItems = result.TotalItemCount;
      response.data = _mapper.Map<IEnumerable<ClientsDto>>(result);


      return response;
    }

    public async Task<ClientNewDto> Add(ClientNewDto newClient)
    {
      var result = await _clientRepository.add(_mapper.Map<Client>(newClient));
      return _mapper.Map<ClientNewDto>(result);
    }

    public void Update(ClientsDto updateClient)
    {
      _clientRepository.Update(_mapper.Map<Client>(updateClient));
    }

    public void Desativar(ClientsDto desativeClient)
    {
      _clientRepository.Desativar(_mapper.Map<Client>(desativeClient));
    }

    public async Task<ClientsDto> Search(string cpf)
    {
      var result = await _clientRepository.Search(cpf);
      return _mapper.Map<ClientsDto>(result);
    }

  }
}