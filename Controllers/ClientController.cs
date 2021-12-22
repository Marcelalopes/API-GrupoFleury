using System.Collections;
using System.Security.AccessControl;
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
    public IEnumerable<Client> GetAllClient()
    {
      return _clientService.GetAll();
    }
    [HttpGet("{cpf}")]
    public Client SearchClient([FromBody] String cpf)
    {
      return _clientService.Search(cpf);
    }

    [HttpPost]
    public void AddClient([FromBody] Client client)
    {
      _clientService.Add(client);
    }

    [HttpPut("{cpf}")]
    public void UpdateClient([FromBody] Client client)
    {
      _clientService.Update(client);
    }

    [HttpDelete("{cpf}")]
    public void DesativarClient(String Cpf)
    {
      _clientService.Desativar(Cpf);
    }
  }
}