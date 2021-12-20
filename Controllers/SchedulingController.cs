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

    [HttpGet("{cpf}")]
    public IEnumerable<Scheduling> ListarAgendamento()
    {
      return _schedulingService.ListarPorCpf();
    }

    [HttpPost]
    public void AddScheduling([FromBody] Scheduling scheduling)
    {
      _schedulingService.Add(scheduling);
    }

    [HttpPut]
    public void UpdateScheduling([FromBody] Scheduling scheduling)
    {
      _schedulingService.Update(scheduling);
    }

    [HttpDelete("{id}")]
    public void DeleteScheduling(Guid id)
    {
      _schedulingService.Delete(id);
    }
  }
}