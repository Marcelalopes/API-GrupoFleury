using System.Collections;
using API_GrupoFleury.models;
using System;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Repository;
using API_GrupoFleury.Dtos;
using AutoMapper;

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
    public IEnumerable<ExamsDto> GetAll()
    {
      return _mapper.Map<IEnumerable<ExamsDto>>(_examRepository.GetAll().ToList());
    }
    public ExamNewDto Add(ExamNewDto newExam)
    {
      _examRepository.add(_mapper.Map<Exam>(newExam));
      return newExam;
    }
    public void Update(ExamsDto updateExam)
    {
      _examRepository.Update(_mapper.Map<Exam>(updateExam));
    }
    public Boolean Delete(Guid id)
    {
      return _examRepository.Delete(id);
    }
  }
}