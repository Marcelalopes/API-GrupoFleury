using System.Threading.Tasks;
using System;
using API_GrupoFleury.Dtos;

namespace API_GrupoFleury.service
{
  public interface IAddressService
  {
    Task<AddressNewDto> Add(AddressNewDto address);
    void Update(AdressesDto address);
    Boolean Delete(Guid id);
  }
}