using Microsoft.AspNetCore.Mvc;
using API_GrupoFleury.models;
using API_GrupoFleury.service;

namespace API_GrupoFleury.controller
{
  [ApiController]
  [Route("api/[controller]")]
  public class ExamController : ControllerBase
  {
    private readonly ExamService _examService;

    public ExamController()
    {
      _examService = new ExamService();
    }

    [HttpGet]
    public string GetAllExams()
    {
      return _examService.GetAll();
    }

    [HttpPost]
    public Exam AddExam([FromBody] Exam exam)
    {
      return _examService.Add(exam);
    }

    [HttpPut("{id}")]
    public string UpdateExam()
    {
      return _examService.Update();
    }

    [HttpDelete("{id}")]
    public string DeleteExam()
    {
      return _examService.Delete();
    }
  }
}