using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_GrupoFleury.models;
using API_GrupoFleury.service;
using System;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Dtos;

namespace API_GrupoFleury.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class AddressController : ControllerBase
  {
    private readonly IAddressService _addressService;
    public AddressController(IAddressService addressService)
    {
      _addressService = addressService;
    }

    /// <summary>Listar Endereços</summary>
    /// <returns>Este endpoint deve ser usando para listar todos osendereços</returns>
    /// <response code="200">Quando estiver OK</response>
    /// <response code="400">Quando tiver com erro</response>
    [HttpGet]
    public async Task<ActionResult> GetAllAddress(
      [FromQuery] int pageNumber = 1,
      [FromQuery] int pageSize = 5
    )
    {
      var result = await _addressService.GetAll(pageSize, pageNumber);
      return new ObjectResult(result);
    }
    /// <summary> Criar Endereço </summary>
    /// <returns> Esse endpoint deve ser usado para criar um novo endereço </returns>
    /// <remarks>
    ///     Exemplo RequestBody:
    ///
    ///         {
    ///             "street": "Rua 7 de Setembro",
    ///             "number": 12,
    ///             "district": "Centro",
    ///             "zipCode": "64255000",
    ///             "city": "Pedro II"
    ///          }
    ///
    /// </remarks>
    /// <response code="200"> Quando estiver OK </response>
    /// <response code="404"> Quando estiver com ERROR </response>
    [HttpPost]

    public async Task<ActionResult> AddAddress([FromBody] AddressNewDto address)
    {
      var result = await _addressService.Add(address);
      return new CreatedResult("", result);
    }

    /// <summary> Atualizar um endereço </summary>
    /// <returns> Esse endpoint deve ser usado quando for preciso atualizar um endereço </returns>
    /// <param name="address"></param>
    /// <param name="id"> Esse Id deve ser o do Endereço que deseja altualizar </param>
    /// <remarks>
    ///     Exemplo RequestBody:
    ///
    ///         {
    ///             "id":"3fa85f64-5717-4562-b3fc-2c963f66afa6",
    ///             "street": "Rua 7 de Setembro",
    ///             "number": 12,
    ///             "district": "Centro",
    ///             "zipCode": "64255000",
    ///             "city": "Pedro II"
    ///          }
    ///
    /// </remarks>
    /// <response code="200"> Quando estiver OK </response>
    /// <response code="204"> Quando não encontrar a Categoria </response>
    /// <response code="404"> Quando estiver com ERROR </response>
    [HttpPut("{id}:Guid")]
    public ActionResult UpdateAddress([FromBody] AdressesDto address, Guid id)
    {
      if (id != address.Id)
        return new BadRequestResult();
      _addressService.Update(address);
      return new OkObjectResult(address);
    }

    /// <summary> Deletar um endereço </summary>
    /// <returns> Esse endpoint deve ser usado quando for preciso deletar um endereço pelo seu Id </returns>
    /// <param name="id"> Esse Id deve ser o do endereço que deseja deleta </param>
    /// <response code="200"> Quando estiver OK </response>
    /// <response code="204"> Quando estiver OK </response>
    /// <response code="404"> Quando estiver com ERROR </response>
    [HttpDelete("{id}:Guid")]
    public ActionResult DeleteAddress(Guid id)
    {
      var result = _addressService.Delete(id);
      return result ? new OkResult() : new NotFoundResult();
    }
  }
}