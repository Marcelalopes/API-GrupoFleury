using System;
using System.Linq.Dynamic.Core;
using API_GrupoFleury.models;
using API_GrupoFleury.Context;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using API_GrupoFleury.Enum;

namespace API_GrupoFleury.Repository
{
  public class SchedulingRepository : ISchedulingRepository
  {
    private readonly AppDbContext _context;
    public SchedulingRepository(AppDbContext context)
    {
      _context = context;
    }
    public async Task<IPagedList<Scheduling>> GetAll(int pageNumber, int pageSize, string search, OrderByTypeEnum orderByType, OrderByColumnSchedulingEnum orderByColumn)
    {
      return await _context.Scheduling
      .OrderBy($"{orderByColumn.ToString()} {orderByType.ToString()}")
      .Where(c => c.ClientCpf.Contains(search)).ToPagedListAsync(pageNumber, pageSize);
    }
    public async Task<Scheduling> add(Scheduling scheduling)
    {
      var result = await _context.Scheduling.AddAsync(scheduling);
      _context.SaveChanges();
      return result.Entity;
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

    public async Task<Scheduling> ListarPorCpf(String cpf)
    {
      var scheduling = await _context.Scheduling.FirstAsync(s => s.ClientCpf == cpf);
      return scheduling;
    }

    public void Update(Scheduling scheduling)
    {
      var result = _context.Scheduling.FirstOrDefault(x => x.Id == scheduling.Id);
      result.Date = scheduling.Date;
      result.HorarioI = scheduling.HorarioI;
      result.HorarioF = scheduling.HorarioF;
      _context.Scheduling.Update(result);
      _context.SaveChanges();
    }
  }
}