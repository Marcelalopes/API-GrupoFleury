using Microsoft.AspNetCore.Mvc;
using API_GrupoFleury.models;
using API_GrupoFleury.service;

namespace API_GrupoFleury.controller
{
  [ApiController]
  [Route("api/[controller]")]
  public class ClientController : ControllerBase
  {
    private readonly ClientService _clientService;
    public ClientController()
    {
      _clientService = new ClientService();
    }

    [HttpGet]
    public string GetAllClient()
    {
      return _clientService.GetAll();
    }
    [HttpGet("{name}")]
    public string SearchClient()
    {
      return _clientService.Search();
    }

    [HttpPost]
    public Client AddClient([FromBody] Client client)
    {
      return _clientService.Add(client);
    }

    [HttpPut("{cpf}")]
    public string UpdateClient()
    {
      return _clientService.Update();
    }

    [HttpDelete]
    public string DesativarClient()
    {
      return _clientService.Desativar();
    }
  }
}