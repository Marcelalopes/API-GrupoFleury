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

    [HttpPost]

    public async Task<ActionResult> AddAddress([FromBody] AddressNewDto address)
    {
      var result = await _addressService.Add(address);
      return new CreatedResult("", result);
    }

    [HttpPut("{id}:Guid")]
    public ActionResult UpdateAddress([FromBody] AdressesDto address, Guid id)
    {
      if (id != address.Id)
        return new BadRequestResult();
      _addressService.Update(address);
      return new OkObjectResult(address);
    }

    [HttpDelete("{id}:Guid")]
    public ActionResult DeleteAddress(Guid id)
    {
      var result = _addressService.Delete(id);
      return result ? new OkResult() : new NotFoundResult();
    }
  }
}