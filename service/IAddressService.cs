using System.Threading.Tasks;
using System;
using API_GrupoFleury.Dtos;
using System.Collections.Generic;

namespace API_GrupoFleury.service
{
  public interface IAddressService
  {
    Task<IEnumerable<AdressesDto>> GetAll();
    Task<AddressNewDto> Add(AddressNewDto address);
    void Update(AdressesDto address);
    Boolean Delete(Guid id);
  }
}