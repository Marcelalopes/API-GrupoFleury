using System.Linq;
using Microsoft.AspNetCore.Mvc;
using API_GrupoFleury.models;
using API_GrupoFleury.service;
using System;
using System.Collections.Generic;
using API_GrupoFleury.Dtos;
using System.Threading.Tasks;

namespace API_GrupoFleury.controller
{
  [ApiController]
  [Route("api/[controller]")]
  public class ClientController : ControllerBase
  {
    private readonly IClientService _clientService;
    public ClientController(IClientService clientService)
    {
      _clientService = clientService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ClientsDto>>> GetAllClient()
    {
      var result = await _clientService.GetAll();
      return new ObjectResult(result);
    }
    [HttpGet("{cpf}")]
    public async Task<ActionResult<ClientsDto>> SearchClient(String cpf)
    {
      var result = await _clientService.Search(cpf);
      return new ObjectResult(result);
    }

    [HttpPost]
    public async Task<ActionResult> AddClient([FromBody] ClientNewDto client)
    {
      var result = await _clientService.Add(client);
      return new CreatedResult("", result);
    }

    [HttpPut("{cpf}:String")]
    public ActionResult UpdateClient([FromBody] ClientsDto client, String cpf)
    {
      if (cpf != client.Cpf)
        return new BadRequestResult();

      _clientService.Update(client);
      return new OkObjectResult(client);
    }

    [HttpPut("desativar/{cpf}:String")]
    public ActionResult DesativarClient([FromBody] ClientsDto client, String cpf)
    {
      if (cpf != client.Cpf)
        return new BadRequestResult();

      _clientService.Desativar(client);
      return new OkObjectResult(client);
    }
  }
}