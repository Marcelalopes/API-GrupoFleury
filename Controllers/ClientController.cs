using System.Linq;
using Microsoft.AspNetCore.Mvc;
using API_GrupoFleury.models;
using API_GrupoFleury.service;
using System;
using API_GrupoFleury.Context;
using System.Collections.Generic;

namespace API_GrupoFleury.controller
{
  [ApiController]
  [Route("api/[controller]")]
  public class ClientController : ControllerBase
  {
    private readonly ClientService _clientService;
    public ClientController(AppDbContext context)
    {
      _clientService = new ClientService(context);
    }

    [HttpGet]
    public ActionResult<IEnumerable<Client>> GetAllClient()
    {
      return new ObjectResult(_clientService.GetAll().ToList());
    }
    [HttpGet("{cpf}")]
    public ActionResult<Client> SearchClient([FromBody] String cpf)
    {
      return new ObjectResult(_clientService.Search(cpf));
    }

    [HttpPost]
    public ActionResult<Client> AddClient([FromBody] Client client)
    {
      var result = _clientService.Add(client);
      return new CreatedResult("", result);
    }

    [HttpPut("{cpf}:String")]
    public ActionResult UpdateClient([FromBody] Client client, String cpf)
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