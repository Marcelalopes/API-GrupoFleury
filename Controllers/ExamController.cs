using Microsoft.AspNetCore.Mvc;
using API_GrupoFleury.models;
using API_GrupoFleury.service;
using System;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Dtos;

namespace API_GrupoFleury.controller
{
  [ApiController]
  [Route("api/[controller]")]
  public class ExamController : ControllerBase
  {
    private readonly IExamService _examService;

    public ExamController(IExamService examService)
    {
      _examService = examService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ExamsDto>> GetAllExams()
    {
      return new ObjectResult(_examService.GetAll().ToList());
    }

    [HttpPost]
    public ActionResult<ExamNewDto> AddExam([FromBody] ExamNewDto exam)
    {
      var result = _examService.Add(exam);
      return new CreatedResult("", result);
    }

    [HttpPut("{id}:Guid")]
    public ActionResult UpdateExam([FromBody] ExamsDto exam, Guid id)
    {
      if (id != exam.Id)
        return new BadRequestResult();
      _examService.Update(exam);
      return new OkObjectResult(exam);
    }

    [HttpDelete("{id}:Guid")]
    public ActionResult DeleteExam(Guid id)
    {
      var result = _examService.Delete(id);
      return result ? new OkResult() : new NotFoundResult();
    }
  }
}