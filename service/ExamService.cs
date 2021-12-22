using API_GrupoFleury.models;
using System;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Repository;



namespace API_GrupoFleury.service
{
  public class ExamService : IExamService
  {
    private readonly IExamRepository _examRepository;

    public ExamService(IExamRepository examRepository)
    {
      _examRepository = examRepository;
    }
    public IEnumerable<Exam> GetAll()
    {
      return _examRepository.GetAll().ToList();
    }
    public Exam Add(Exam exam)
    {
      _examRepository.add(exam);
      return exam;
    }
    public void Update(Exam exam)
    {
      _examRepository.Update(exam);
    }
    public Boolean Delete(Guid id)
    {
      return _examRepository.Delete(id);
    }
  }
}