using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Context;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using API_GrupoFleury.Enum;
using System.Linq.Dynamic.Core;

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

    public void Desativar(Client client)
    {
      _context.Client.Update(client);
      _context.SaveChanges();
    }

    public async Task<IPagedList<Client>> GetAll(int pageSize, int pageNumber, string search, OrderByTypeEnum orderByType, OrderByColumnClientEnum orderByColumn)
    {
      return await _context.Client
      .OrderBy($"{orderByColumn.ToString()} {orderByType.ToString()}")
      .Where(c => c.Name.Contains(search)).ToPagedListAsync(pageNumber, pageSize);
    }

    public async Task<Client> Search(string cpf)
    {
      return await _context.Client.FirstAsync(c => c.Cpf == cpf);
    }

    public void Update(Client client)
    {
      _context.Client.Update(client);
      _context.SaveChanges();
    }
  }
}