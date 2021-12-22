using System.Collections;
using API_GrupoFleury.models;
using System;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Repository;

namespace API_GrupoFleury.service
{
  public class ClientService : IClientService
  {
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
      _clientRepository = clientRepository;
    }
    public IEnumerable<Client> GetAll()
    {
      return _clientRepository.GetAll().ToList();
    }

    public Client Search(String cpf)
    {
      return _clientRepository.Search(cpf);
    }

    public Client Add(Client client)
    {
      _clientRepository.add(client);
      return client;
    }

    public void Update(Client client)
    {
      _clientRepository.Update(client);
    }

    public Boolean Desativar(String cpf)
    {
      return _clientRepository.Desativar(cpf);
    }
  }
}