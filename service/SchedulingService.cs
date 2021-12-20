using API_GrupoFleury.models;
using System;
using API_GrupoFleury.Context;
using System.Collections.Generic;
using System.Linq;

namespace API_GrupoFleury.service
{
  public class SchedulingService
  {
    private readonly AppDbContext _context;
    public SchedulingService(AppDbContext context)
    {
      _context = context;
    }
    public IEnumerable<Scheduling> ListarPorCpf()
    {
      return _context.Scheduling.ToList();
    }
    public void Add(Scheduling scheduling)
    {
      _context.Scheduling.Add(scheduling);
      _context.SaveChanges();
    }
    public void Update(Scheduling scheduling)
    {
      _context.Scheduling.Update(scheduling);
      _context.SaveChanges();
    }
    public void Delete(Guid id)
    {
      var scheduling = _context.Scheduling.First(c => c.Id == id);
      if (scheduling != null)
      {
        _context.Scheduling.Remove(scheduling);
        _context.SaveChanges();
      }
    }
  }
}