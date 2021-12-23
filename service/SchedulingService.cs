using API_GrupoFleury.models;
using System;
using API_GrupoFleury.Context;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Repository;
using API_GrupoFleury.Dtos;


namespace API_GrupoFleury.service
{
  public class SchedulingService : ISchedulingService
  {
    private readonly ISchedulingRepository _schedulingRepository;
    public SchedulingService(ISchedulingRepository schedulingRepository)
    {
      _schedulingRepository = schedulingRepository;
    }
    public SchedulingsDto ListarPorCpf(String cpf)
    {
      var result = _schedulingRepository.ListarPorCpf(cpf);
      SchedulingsDto scheduling = new SchedulingsDto()
      {
        Date = result.Date,
        HorarioI = result.HorarioI,
        HorarioF = result.HorarioF,
        ValueTotal = result.ValueTotal,
        ExamIds = result.ExamIds,
        ClientCpf = result.ClientCpf
      };
      return scheduling;
    }
    public SchedulingNewDto Add(SchedulingNewDto newScheduling)
    {
      Scheduling scheduling = new Scheduling()
      {
        Date = newScheduling.Date,
        HorarioI = newScheduling.HorarioI,
        HorarioF = newScheduling.HorarioF,
        ValueTotal = newScheduling.ValueTotal,
        ExamIds = newScheduling.ExamIds,
        ClientCpf = newScheduling.ClientCpf
      };
      _schedulingRepository.add(scheduling);
      return newScheduling;
    }
    public void Update(SchedulingsDto updateScheduling)
    {
      Scheduling scheduling = new Scheduling()
      {
        Date = updateScheduling.Date,
        HorarioI = updateScheduling.HorarioI,
        HorarioF = updateScheduling.HorarioF
      };
      _schedulingRepository.Update(scheduling);
    }
    public Boolean Delete(Guid id)
    {
      return _schedulingRepository.Delete(id);
    }
  }
}