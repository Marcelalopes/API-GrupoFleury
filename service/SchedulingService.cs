using API_GrupoFleury.models;
using System;
using API_GrupoFleury.Context;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Repository;


namespace API_GrupoFleury.service
{
  public class SchedulingService : ISchedulingService
  {
    private readonly ISchedulingRepository _schedulingRepository;
    public SchedulingService(ISchedulingRepository schedulingRepository)
    {
      _schedulingRepository = schedulingRepository;
    }
    public Scheduling ListarPorCpf(String cpf)
    {
      var scheduling = _schedulingRepository.ListarPorCpf(cpf);
      return scheduling;
    }
    public Scheduling Add(Scheduling scheduling)
    {
      _schedulingRepository.add(scheduling);
      return scheduling;
    }
    public void Update(Scheduling scheduling)
    {
      _schedulingRepository.Update(scheduling);
    }
    public Boolean Delete(Guid id)
    {
      return _schedulingRepository.Delete(id);
    }
  }
}