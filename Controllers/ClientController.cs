using System.Linq;
using Microsoft.AspNetCore.Mvc;
using API_GrupoFleury.models;
using API_GrupoFleury.service;
using System;
using System.Collections.Generic;
using API_GrupoFleury.Dtos;

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
    public ActionResult<IEnumerable<ClientsDto>> GetAllClient()
    {
      return new ObjectResult(_clientService.GetAll().ToList());
    }
    [HttpGet("{cpf}")]
    public ActionResult<ClientsDto> SearchClient([FromBody] String cpf)
    {
      return new ObjectResult(_clientService.Search(cpf));
    }

    [HttpPost]
    public ActionResult<ClientNewDto> AddClient([FromBody] ClientNewDto client)
    {
      var result = _clientService.Add(client);
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

    [HttpDelete("{cpf}:String")]
    public ActionResult DesativarClient(String Cpf)
    {
      var result = _clientService.Desativar(Cpf);
      return result ? new OkResult() : new NotFoundResult();
    }
  }
}