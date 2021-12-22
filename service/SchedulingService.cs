using API_GrupoFleury.models;
using System;
using API_GrupoFleury.Context;
using System.Collections.Generic;
using System.Linq;

namespace API_GrupoFleury.service
{
  public class SchedulingService : ISchedulingService
  {
    private readonly AppDbContext _context;
    public SchedulingService(AppDbContext context)
    {
      _context = context;
    }
    public Scheduling ListarPorCpf(String cpf)
    {
      var scheduling = _context.Scheduling.FirstOrDefault(c => c.ClientCpf == cpf);
      return scheduling;
    }
    public Scheduling Add(Scheduling scheduling)
    {
      _context.Scheduling.Add(scheduling);
      _context.SaveChanges();
      return scheduling;
    }
    public void Update(Scheduling scheduling)
    {
      _context.Scheduling.Update(scheduling);
      _context.SaveChanges();
    }
    public Boolean Delete(Guid id)
    {
      var scheduling = _context.Scheduling.FirstOrDefault(c => c.Id == id);
      if (scheduling == null)
        return false;
      _context.Scheduling.Remove(scheduling);
      _context.SaveChanges();
      return true;
    }
  }
}