using System.Collections;
using API_GrupoFleury.models;
using System;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Repository;
using API_GrupoFleury.Dtos;
using AutoMapper;
using System.Threading.Tasks;

namespace API_GrupoFleury.service
{
  public class ExamService : IExamService
  {
    private readonly IExamRepository _examRepository;
    private readonly IMapper _mapper;

    public ExamService(IExamRepository examRepository, IMapper mapper)
    {
      _examRepository = examRepository;
      _mapper = mapper;
    }
    public async Task<IEnumerable<ExamsDto>> GetAll()
    {
      var result = await _examRepository.GetAll();
      return _mapper.Map<IEnumerable<ExamsDto>>(result);
    }
    public async Task<ExamNewDto> Add(ExamNewDto newExam)
    {
      var result = await _examRepository.add(_mapper.Map<Exam>(newExam));
      return _mapper.Map<ExamNewDto>(result);
    }
    public void Update(ExamUpdateDto updateExam)
    {
      _examRepository.Update(_mapper.Map<Exam>(updateExam));
    }
    public Boolean Delete(Guid id)
    {
      return _examRepository.Delete(id);
    }
  }
}