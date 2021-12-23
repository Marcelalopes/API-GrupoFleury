using API_GrupoFleury.models;
using System;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Repository;
using API_GrupoFleury.Dtos;



namespace API_GrupoFleury.service
{
  public class ExamService : IExamService
  {
    private readonly IExamRepository _examRepository;

    public ExamService(IExamRepository examRepository)
    {
      _examRepository = examRepository;
    }
    public IEnumerable<ExamsDto> GetAll()
    {
      var result = _examRepository.GetAll().ToList();
      List<ExamsDto> listResult = new List<ExamsDto>();
      foreach (var client in result)
      {
        listResult.Add(new ExamsDto()
        {
          Id = client.Id,
          Name = client.Name,
          Duration = client.Duration,
          Price = client.Price
        });
      }
      return listResult;
    }
    public ExamNewDto Add(ExamNewDto newExam)
    {
      Exam exam = new Exam()
      {
        Name = newExam.Name,
        Duration = newExam.Duration,
        Price = newExam.Price
      };
      _examRepository.add(exam);
      return newExam;
    }
    public void Update(ExamsDto updateExam)
    {
      Exam exam = new Exam()
      {
        Name = updateExam.Name,
        Duration = updateExam.Duration,
        Price = updateExam.Price
      };
      _examRepository.Update(exam);
    }
    public Boolean Delete(Guid id)
    {
      return _examRepository.Delete(id);
    }
  }
}