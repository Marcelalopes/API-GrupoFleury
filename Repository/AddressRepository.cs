using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Context;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace API_GrupoFleury.Repository
{
  public class AddressRepository : IAddressRepository
  {
    private readonly AppDbContext _context;

    public AddressRepository(AppDbContext context)
    {
      _context = context;
    }
    public async Task<IPagedList<Address>> GetAll(int pageSize, int pageNumber)
    {
      return await _context.Address.ToPagedListAsync(pageNumber, pageSize);
    }

    public async Task<Address> add(Address address)
    {
      var result = await _context.Address.AddAsync(address);
      _context.SaveChanges();
      return result.Entity;
    }

    public bool Delete(Guid id)
    {
      var address = _context.Address.FirstOrDefault(a => a.Id == id);
      if (address == null)
        return false;
      _context.Address.Remove(address);
      _context.SaveChanges();
      return true;
    }

    public void Update(Address address)
    {
      _context.Address.Update(address);
      _context.SaveChanges();
    }
  }
}