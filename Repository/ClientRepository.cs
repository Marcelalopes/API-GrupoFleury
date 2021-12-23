using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Context;
using System.Linq;

namespace API_GrupoFleury.Repository
{
  public class ClientRepository : IClientRepository
  {
    private readonly AppDbContext _context;

    public ClientRepository(AppDbContext context)
    {
      _context = context;
    }

    public void add(Client client)
    {
      _context.Client.Add(client);
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
      return false;
    }

    public IEnumerable<Client> GetAll()
    {
      return _context.Client.ToList();
    }

    public Client Search(string cpf)
    {
      var client = _context.Client.First(c => c.Cpf == cpf);
      return client;
    }

    public void Update(Client client)
    {
      _context.Client.Update(client);
      _context.SaveChanges();
    }
  }
}