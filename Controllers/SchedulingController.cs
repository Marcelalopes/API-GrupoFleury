using System.Collections;
using Microsoft.AspNetCore.Mvc;
using API_GrupoFleury.models;
using API_GrupoFleury.service;
using System.Collections.Generic;
using System;
using API_GrupoFleury.Dtos;
using System.Threading.Tasks;

namespace API_GrupoFleury.controller
{
  [ApiController]
  [Route("api/[controller]")]
  public class SchedulingController : ControllerBase
  {
    private readonly ISchedulingService _schedulingService;
    public SchedulingController(ISchedulingService schedulingService)
    {
      _schedulingService = schedulingService;
    }

    /// <summary>Listar Agendamentos</summary>
    /// <returns>Este endpoint deve ser usando para listar todos os agendamentos marcados</returns>
    /// <response code="200">Quando estiver OK</response>
    /// <response code="400">Quando tiver com erro</response>
    [HttpGet]
    public async Task<ActionResult> GetAllScheduling(
      [FromQuery] int pageNumber = 1,
      [FromQuery] int pageSize = 5
    )
    {
      var result = await _schedulingService.GetAll(pageNumber, pageSize);
      return new ObjectResult(result);
    }

    /// <summary> Listar um agendamento por cpf </summary>
    /// <returns> Esse endpoint deve ser usado quando for preciso listar um agendamento pelo cpf do cliente</returns>
    /// <param name="cpf"> Esse cpf deve ser o do client do agendamento que deseja listar </param>
    /// <response code="200"> Quando estiver OK </response>
    /// <response code="204"> Quando não encontrar a Categoria </response>
    /// <response code="404"> Quando estiver com ERROR </response>
    [HttpGet("{cpf}:String")]
    public async Task<ActionResult<SchedulingsDto>> ListarAgendamento(String cpf)
    {
      var result = await _schedulingService.ListarPorCpf(cpf);
      return new ObjectResult(result);
    }

    /// <summary>Criar um agendamento </summary>
    /// <returns> Esse endpoint deve ser usado quando for preciso criar um agendamento </returns>
    /// <remarks>
    ///     Exemplo RequestBody:
    ///
    ///              {
    ///                 "valueTotal":90,
    ///                 "date":"2021-12-28T14:23:56.959Z",
    ///                 "horarioI":"2021-12-28T14:23:56.959Z",
    ///                 "horarioF":"2021-12-28T14:23:56.959Z",
    ///                 "examId":"3fa85f64-5717-4562-b3fc-2c963f66aff4",
    ///                 "clientCpf":"09876898760"
    ///              }
    ///
    /// </remarks>
    /// <response code="200"> Quando estiver OK </response>
    /// <response code="204"> Quando não encontrar a Categoria </response>
    /// <response code="404"> Quando estiver com ERROR </response>
    [HttpPost]
    public async Task<ActionResult> AddScheduling([FromBody] SchedulingNewDto scheduling)
    {
      var result = await _schedulingService.Add(scheduling);
      return new CreatedResult("", result);
    }

    /// <summary> Atualizar os dados de um agendamento </summary>
    /// <returns> Esse endpoint deve ser usado quando for preciso atualizar os dados de um agendamento </returns>
    /// <param name="scheduling"></param>
    /// <param name="id"> Esse id deve ser o do agendamento que deseja altualizar </param>
    /// <remarks>
    ///     Exemplo RequestBody:
    ///
    ///              {
    ///                 "id":"3fa85f64-5717-4562-b3fc-2c963f66afa6",
    ///                 "date":"2021-12-28T14:23:56.959Z",
    ///                 "horarioI":"2021-12-28T14:23:56.959Z",
    ///                 "horarioF":"2021-12-28T14:23:56.959Z",
    ///                 "examId":"3fa85f64-5717-4562-b3fc-2c963f66aff4",
    ///                 "clientCpf":"09876898760"
    ///              }
    ///
    /// </remarks>
    /// <response code="200"> Quando estiver OK </response>
    /// <response code="204"> Quando não encontrar a Categoria </response>
    /// <response code="404"> Quando estiver com ERROR </response>
    [HttpPut("{id}:Guid")]
    public ActionResult UpdateScheduling([FromBody] SchedulingUpdateDto scheduling, Guid id)
    {
      if (id != scheduling.Id)
        return new BadRequestResult();
      _schedulingService.Update(scheduling);
      return new OkObjectResult(scheduling);
    }

    ///<summary> Deletar um Agendamento</summary>
    ///<returns> Esse endpoint deve ser usado quando for preciso deletar um agendamento pelo seu Id</returns>
    ///<param name = "id" > Esse Id deve ser o do agendamento que deseja deletar</param>
    ///<response code = "200" > Quando estiver OK </response>
    ///<response code = "204" > Quando estiver OK </response>
    ///<response code = "404" > Quando estiver com ERROR</response>
    [HttpDelete("{id}:Guid")]
    public ActionResult DeleteScheduling(Guid id)
    {
      var result = _schedulingService.Delete(id);
      return result ? new OkResult() : new NotFoundResult();
    }
  }
}