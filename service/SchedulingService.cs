using API_GrupoFleury.models;
using System;
using API_GrupoFleury.Context;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Repository;
using API_GrupoFleury.Dtos;
using AutoMapper;


namespace API_GrupoFleury.service
{
  public class SchedulingService : ISchedulingService
  {
    private readonly ISchedulingRepository _schedulingRepository;
    private readonly IMapper _mapper;
    public SchedulingService(ISchedulingRepository schedulingRepository, IMapper mapper)
    {
      _schedulingRepository = schedulingRepository;
      _mapper = mapper;
    }
    public SchedulingsDto ListarPorCpf(String cpf)
    {
      return _mapper.Map<SchedulingsDto>(_schedulingRepository.ListarPorCpf(cpf));
    }
    public SchedulingNewDto Add(SchedulingNewDto newScheduling)
    {
      _schedulingRepository.add(_mapper.Map<Scheduling>(newScheduling));
      return newScheduling;
    }
    public void Update(SchedulingsDto updateScheduling)
    {
      _schedulingRepository.Update(_mapper.Map<Scheduling>(updateScheduling));
    }
    public Boolean Delete(Guid id)
    {
      return _schedulingRepository.Delete(id);
    }
  }
}