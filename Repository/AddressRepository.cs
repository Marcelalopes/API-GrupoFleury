using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Context;
using System.Linq;

namespace API_GrupoFleury.Repository
{
  public class AddressRepository : IAddressRepository
  {
    private readonly AppDbContext _context;

    public AddressRepository(AppDbContext context)
    {
      _context = context;
    }

    public void add(Address address)
    {
      _context.Address.Add(address);
      _context.SaveChanges();
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