using API_GrupoFleury.Dtos;
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
    public IEnumerable<ClientsDto> GetAll()
    {
      var result = _clientRepository.GetAll().ToList();

      List<ClientsDto> listResult = new List<ClientsDto>();

      foreach (var client in result)
      {
        listResult.Add(new ClientsDto()
        {
          Cpf = client.Cpf,
          Name = client.Name,
          BirthDate = client.BirthDate,
          Phone = client.Phone,
          Email = client.Email
        });
      }

      return listResult;
    }

    public ClientNewDto Add(ClientNewDto newClient)
    {
      Client client = new Client()
      {
        Cpf = newClient.Cpf,
        Name = newClient.Name,
        BirthDate = newClient.BirthDate,
        Phone = newClient.Phone,
        Email = newClient.Email,
        AddressId = newClient.AddressId,
        isDesable = newClient.isDesable
      };

      _clientRepository.add(client);
      return newClient;
    }

    public void Update(ClientsDto updateClient)
    {
      Client client = new Client()
      {
        Cpf = updateClient.Cpf,
        Name = updateClient.Name,
        BirthDate = updateClient.BirthDate,
        Phone = updateClient.Phone,
        Email = updateClient.Email
      };
      _clientRepository.Update(client);
    }

    public Boolean Desativar(String cpf)
    {
      return _clientRepository.Desativar(cpf);
    }

    public ClientsDto Search(string cpf)
    {
      var result = _clientRepository.Search(cpf);
      ClientsDto client = new ClientsDto()
      {
        Cpf = result.Cpf,
        Name = result.Name,
        BirthDate = result.BirthDate,
        Phone = result.Phone,
        Email = result.Email
      };
      return client;
    }
  }
}