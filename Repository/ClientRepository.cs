using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Context;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API_GrupoFleury.Repository
{
  public class ClientRepository : IClientRepository
  {
    private readonly AppDbContext _context;

    public ClientRepository(AppDbContext context)
    {
      _context = context;
    }

    public async Task<Client> add(Client client)
    {
      var result = await _context.Client.AddAsync(client);
      _context.SaveChanges();
      return result.Entity;
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

    public async Task<IEnumerable<Client>> GetAll()
    {
      return await _context.Client.ToListAsync();
    }

    public async Task<Client> Search(string cpf)
    {
      var client = await _context.Client.FirstAsync(c => c.Cpf == cpf);
      return client;
    }

    public void Update(Client client)
    {
      _context.Client.Update(client);
      _context.SaveChanges();
    }
  }
}