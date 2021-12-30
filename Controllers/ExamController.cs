using Microsoft.AspNetCore.Mvc;
using API_GrupoFleury.models;
using API_GrupoFleury.service;
using System;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Dtos;
using System.Threading.Tasks;

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

    /// <summary>Listar todos os Exames</summary>
    /// <returns> Esse endpoint deve ser usado quando for preciso listar todos os exames </returns>
    /// <response code="200"> Quando estiver OK </response>
    /// <response code="204"> Quando não encontrar a Categoria </response>
    /// <response code="404"> Quando estiver com ERROR </response>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ExamsDto>>> GetAllExams()
    {
      var result = await _examService.GetAll();
      return new ObjectResult(result);
    }

    /// <summary>Cadastrar um Exame</summary>
    /// <returns> Esse endpoint deve ser usado quando for preciso cadastrar um exame </returns>
    /// <remarks>
    ///     Exemplo RequestBody:
    ///
    ///              {
    ///                 "name":"Hemograma",
    ///                 "price":59.99,
    ///                 "duration":30
    ///              }
    ///
    /// </remarks>
    /// <response code="200"> Quando estiver OK </response>
    /// <response code="204"> Quando não encontrar a Categoria </response>
    /// <response code="404"> Quando estiver com ERROR </response>
    [HttpPost]
    public async Task<ActionResult> AddExam([FromBody] ExamNewDto exam)
    {
      var result = await _examService.Add(exam);
      return new CreatedResult("", result);
    }

    /// <summary> Atualizar os dados de um exame </summary>
    /// <returns> Esse endpoint deve ser usado quando for preciso atualizar os dados de um exame </returns>
    /// <param name="exam"></param>
    /// <param name="id"> Esse id deve ser o do exame que deseja altualizar </param>
    /// <remarks>
    ///     Exemplo RequestBody:
    ///
    ///              {
    ///                 "id":"3fa85f64-5717-4562-b3fc-2c963f66afa6",
    ///                 "name":"Hemograma",
    ///                 "price":59.99,
    ///                 "duration":30
    ///              }
    ///
    /// </remarks>
    /// <response code="200"> Quando estiver OK </response>
    /// <response code="204"> Quando não encontrar a Categoria </response>
    /// <response code="404"> Quando estiver com ERROR </response>
    [HttpPut("{id}:Guid")]
    public ActionResult UpdateExam([FromBody] ExamUpdateDto exam, Guid id)
    {
      if (id != exam.Id)
        return new BadRequestResult();
      _examService.Update(exam);
      return new OkObjectResult(exam);
    }
    ///<summary> Deletar um Exame</summary>
    ///<returns> Esse endpoint deve ser usado quando for preciso deletar um exame pelo seu Id</returns>
    ///<param name = "id" > Esse Id deve ser o do exame que deseja deleta</param>
    ///<response code = "200" > Quando estiver OK </response>
    ///<response code = "204" > Quando estiver OK </response>
    ///<response code = "404" > Quando estiver com ERROR</response>
    [HttpDelete("{id}:Guid")]
    public ActionResult DeleteExam(Guid id)
    {
      var result = _examService.Delete(id);
      return result ? new OkResult() : new NotFoundResult();
    }
  }
}