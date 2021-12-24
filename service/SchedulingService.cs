using API_GrupoFleury.models;
using System;
using API_GrupoFleury.Context;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Repository;
using API_GrupoFleury.Dtos;
using AutoMapper;
using System.Threading.Tasks;

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
    public async Task<SchedulingsDto> ListarPorCpf(String cpf)
    {
      var result = await _schedulingRepository.ListarPorCpf(cpf);
      return _mapper.Map<SchedulingsDto>(result);
    }
    public async Task<SchedulingNewDto> Add(SchedulingNewDto newScheduling)
    {
      var result = await _schedulingRepository.add(_mapper.Map<Scheduling>(newScheduling));
      return _mapper.Map<SchedulingNewDto>(result);
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