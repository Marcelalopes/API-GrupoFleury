using System.Collections;
using API_GrupoFleury.models;
using System;
using API_GrupoFleury.Context;
using System.Collections.Generic;
using System.Linq;

namespace API_GrupoFleury.service
{
  public class ClientService : IClientService
  {
    private readonly AppDbContext _context;

    public ClientService(AppDbContext context)
    {
      _context = context;
    }
    public IEnumerable<Client> GetAll()
    {
      return _context.Client.ToList();
    }

    public Client Search(String cpf)
    {
      var client = _context.Client.First(c => c.Cpf == cpf);
      return client;
    }

    public Client Add(Client client)
    {
      _context.Client.Add(client);
      _context.SaveChanges();
      return client;
    }

    public void Update(Client client)
    {
      _context.Client.Update(client);
      _context.SaveChanges();
    }

    public Boolean Desativar(String cpf)
    {
      var client = _context.Client.FirstOrDefault(c => c.Cpf == cpf);
      if (client.isDesable != true)
      {
        client.isDesable = true;
        _context.SaveChanges();
      }
      return client.isDesable;
    }
  }
}