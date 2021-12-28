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
    /// <summary>Listar Clientes</summary>
    /// <returns>Este endpoint deve ser usando para listar todos os Clientes cadastrados</returns>
    /// <response code="200">Quando estiver OK</response>
    /// <response code="400">Quando tiver com erro</response>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ClientsDto>>> GetAllClient()
    {
      var result = await _clientService.GetAll();
      return new ObjectResult(result);
    }

    /// <summary>Listar Clientes por CPF</summary>
    /// <returns>Este endpoint deve ser usando para listar um cliente pelo seu CPF</returns>
    /// <response code="200">Quando estiver OK</response>
    /// <response code="400">Quando tiver com erro</response>
    [HttpGet("{cpf}")]
    public async Task<ActionResult<ClientsDto>> SearchClient(String cpf)
    {
      var result = await _clientService.Search(cpf);
      return new ObjectResult(result);
    }

    /// <summary>Cadastrar Clientes</summary>
    /// <returns>Este endpoint deve ser usando para cadastrar clientes</returns>
    /// <remarks>
    ///     Exemplo RequestBody:
    ///
    ///              {
    ///                 "cpf":"06568386290",
    ///                 "name":"Marcela dos Santos Lopes",
    ///                 "birthDate":"2021-12-28T13:55:50.061Z",
    ///                 "phone":"86987435689",
    ///                 "email":"marcela@gmail.com",
    ///                 "isDesable":false,
    ///                 "addressId":"3fa85f64-5717-4562-b3fc-2c963f66afa6"
    ///              }
    ///
    /// </remarks>
    /// <response code="200">Quando estiver OK</response>
    /// <response code="400">Quando tiver com erro</response>
    [HttpPost]
    public async Task<ActionResult> AddClient([FromBody] ClientNewDto client)
    {
      var result = await _clientService.Add(client);
      return new CreatedResult("", result);
    }

    /// <summary> Atualizar os dados de um cliente </summary>
    /// <returns> Esse endpoint deve ser usado quando for preciso atualizar os dados de um cliente </returns>
    /// <param name="cpf"> Esse cpf deve ser o do Cliente que deseja altualizar </param>
    /// <remarks>
    ///     Exemplo RequestBody:
    ///
    ///              {
    ///                 "cpf":"06568386290",
    ///                 "name":"Marcela dos Santos Lopes",
    ///                 "birthDate":"2021-12-28T13:55:50.061Z",
    ///                 "phone":"86987435689",
    ///                 "email":"marcela@gmail.com",
    ///                 "isDesable":false,
    ///                 "addressId":"3fa85f64-5717-4562-b3fc-2c963f66afa6"
    ///              }
    ///
    /// </remarks>
    /// <response code="200"> Quando estiver OK </response>
    /// <response code="204"> Quando não encontrar a Categoria </response>
    /// <response code="404"> Quando estiver com ERROR </response>
    [HttpPut("{cpf}:String")]
    public ActionResult UpdateClient([FromBody] ClientsDto client, String cpf)
    {
      if (cpf != client.Cpf)
        return new BadRequestResult();

      _clientService.Update(client);
      return new OkObjectResult(client);
    }

    /// <summary> Desativar um cliente </summary>
    /// <returns> Esse endpoint deve ser usado quando for preciso desativar um cliente </returns>
    /// <param name="cpf"> Esse cpf deve ser o do Cliente que deseja desativar </param>
    /// <remarks>
    ///     Exemplo RequestBody:
    ///
    ///              {
    ///                 "cpf":"06568386290",
    ///                 "name":"Marcela dos Santos Lopes",
    ///                 "birthDate":"2021-12-28T13:55:50.061Z",
    ///                 "phone":"86987435689",
    ///                 "email":"marcela@gmail.com",
    ///                 "isDesable":true,
    ///                 "addressId":"3fa85f64-5717-4562-b3fc-2c963f66afa6"
    ///              }
    ///
    /// </remarks>
    /// <response code="200"> Quando estiver OK </response>
    /// <response code="204"> Quando não encontrar a Categoria </response>
    /// <response code="404"> Quando estiver com ERROR </response>
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