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

    [HttpGet("{cpf}:String")]
    public async Task<ActionResult<SchedulingsDto>> ListarAgendamento(String cpf)
    {
      var result = await _schedulingService.ListarPorCpf(cpf);
      return new ObjectResult(result);
    }

    [HttpPost]
    public async Task<ActionResult> AddScheduling([FromBody] SchedulingNewDto scheduling)
    {
      var result = await _schedulingService.Add(scheduling);
      return new CreatedResult("", result);
    }

    [HttpPut("{id}:Guid")]
    public ActionResult UpdateScheduling([FromBody] SchedulingsDto scheduling, Guid id)
    {
      if (id != scheduling.Id)
        return new BadRequestResult();

      _schedulingService.Update(scheduling);
      return new OkObjectResult(scheduling);
    }

    [HttpDelete("{id}:Guid")]
    public ActionResult DeleteScheduling(Guid id)
    {
      var result = _schedulingService.Delete(id);
      return result ? new OkResult() : new NotFoundResult();
    }
  }
}