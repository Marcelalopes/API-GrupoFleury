using API_GrupoFleury.models;
using System;
using API_GrupoFleury.Context;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Repository;
using API_GrupoFleury.Dtos;
using AutoMapper;
using System.Threading.Tasks;
using System.Dynamic;

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
    public async Task<dynamic> GetAll(int pageNumber, int pageSize)
    {
      var result = await _schedulingRepository.GetAll(pageNumber, pageSize);
      dynamic response = new ExpandoObject();
      response.currentPage = pageNumber;
      response.pageSize = pageSize;
      response.totalPages = Math.Ceiling((double)result.TotalItemCount / pageSize);
      response.totalItems = result.TotalItemCount;
      response.data = _mapper.Map<IEnumerable<SchedulingsDto>>(result);


      return response;
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
    public void Update(SchedulingUpdateDto updateScheduling)
    {
      _schedulingRepository.Update(_mapper.Map<Scheduling>(updateScheduling));
    }
    public Boolean Delete(Guid id)
    {
      return _schedulingRepository.Delete(id);
    }
  }
}