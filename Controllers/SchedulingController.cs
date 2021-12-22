using System.Collections;
using Microsoft.AspNetCore.Mvc;
using API_GrupoFleury.models;
using API_GrupoFleury.service;
using API_GrupoFleury.Context;
using System.Collections.Generic;
using System;

namespace API_GrupoFleury.controller
{
  [ApiController]
  [Route("api/[controller]")]
  public class SchedulingController : ControllerBase
  {
    private readonly SchedulingService _schedulingService;
    public SchedulingController(AppDbContext context)
    {
      _schedulingService = new SchedulingService(context);
    }

    [HttpGet("{cpf}:String")]
    public ActionResult<Scheduling> ListarAgendamento(String cpf)
    {
      return new ObjectResult(_schedulingService.ListarPorCpf(cpf));
    }

    [HttpPost]
    public ActionResult<Scheduling> AddScheduling([FromBody] Scheduling scheduling)
    {
      var result = _schedulingService.Add(scheduling);
      return new CreatedResult("", result);
    }

    [HttpPut("{id}:Guid")]
    public ActionResult UpdateScheduling([FromBody] Scheduling scheduling, Guid id)
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