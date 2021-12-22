using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Context;
using System.Linq;

namespace API_GrupoFleury.Repository
{
  public class SchedulingRepository : ISchedulingRepository
  {
    private readonly AppDbContext _context;
    public SchedulingRepository(AppDbContext context)
    {
      _context = context;
    }

    public void add(Scheduling scheduling)
    {
      _context.Scheduling.Add(scheduling);
      _context.SaveChanges();
    }

    public bool Delete(Guid id)
    {
      var scheduling = _context.Scheduling.FirstOrDefault(s => s.Id == id);

      if (scheduling == null)
        return false;

      _context.Scheduling.Remove(scheduling);
      _context.SaveChanges();
      return true;
    }

    public Scheduling ListarPorCpf(String cpf)
    {
      var scheduling = _context.Scheduling.First(s => s.ClientCpf == cpf);
      return scheduling;
    }

    public void Update(Scheduling scheduling)
    {
      _context.Scheduling.Update(scheduling);
      _context.SaveChanges();
    }
  }
}