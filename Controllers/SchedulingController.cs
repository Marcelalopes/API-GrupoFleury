using Microsoft.AspNetCore.Mvc;
using API_GrupoFleury.models;
using API_GrupoFleury.service;

namespace API_GrupoFleury.controller
{
  [ApiController]
  [Route("api/[controller]")]
  public class SchedulingController : ControllerBase
  {
    private readonly SchedulingService _schedulingService;
    public SchedulingController()
    {
      _schedulingService = new SchedulingService();
    }

    [HttpGet("{cpf}")]
    public string ListarAgendamento()
    {
      return _schedulingService.ListarPorCpf();
    }

    [HttpPost]
    public Scheduling AddScheduling([FromBody] Scheduling scheduling)
    {
      return _schedulingService.Add(scheduling);
    }

    [HttpPut]
    public string UpdateScheduling()
    {
      return _schedulingService.Update();
    }

    [HttpDelete]
    public string DeleteScheduling()
    {
      return _schedulingService.Delete();
    }
  }
}