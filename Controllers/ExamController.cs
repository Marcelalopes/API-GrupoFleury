using Microsoft.AspNetCore.Mvc;
using API_GrupoFleury.models;
using API_GrupoFleury.service;
using System;
using API_GrupoFleury.Context;
using System.Collections.Generic;

namespace API_GrupoFleury.controller
{
  [ApiController]
  [Route("api/[controller]")]
  public class ExamController : ControllerBase
  {
    private readonly ExamService _examService;

    public ExamController(AppDbContext context)
    {
      _examService = new ExamService(context);
    }

    [HttpGet]
    public IEnumerable<Exam> GetAllExams()
    {
      return _examService.GetAll();
    }

    [HttpPost]
    public void AddExam([FromBody] Exam exam)
    {
      _examService.Add(exam);
    }

    [HttpPut("{id}")]
    public void UpdateExam([FromBody] Exam exam)
    {
      _examService.Update(exam);
    }

    [HttpDelete("{id}")]
    public void DeleteExam(Guid id)
    {
      _examService.Delete(id);
    }
  }
}