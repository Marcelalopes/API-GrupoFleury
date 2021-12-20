using System.Collections;
using API_GrupoFleury.models;
using System;
using API_GrupoFleury.Context;
using System.Collections.Generic;
using System.Linq;

namespace API_GrupoFleury.service
{
  public class ClientService
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

    public IEnumerable<Client> Search()
    {
      return _context.Client.ToList();
    }

    public void Add(Client client)
    {
      _context.Client.Add(client);
      _context.SaveChanges();
    }

    public void Update(Client client)
    {
      _context.Client.Update(client);
      _context.SaveChanges();
    }

    public void Desativar(String cpf)
    {
      /* Client c = _context.Get(cpf);
      if (c == null)
      {
        return false;
      }
      c.Active = true;
      _context.Update(c.Cpf, c);
      return true; */
    }
  }
}