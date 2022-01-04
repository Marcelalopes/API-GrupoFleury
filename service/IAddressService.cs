using System.Threading.Tasks;
using System;
using API_GrupoFleury.Dtos;
using System.Collections.Generic;
using API_GrupoFleury.Enum;

namespace API_GrupoFleury.service
{
  public interface IAddressService
  {
    Task<dynamic> GetAll(
      int pageSize,
      int pageNumber,
      string search,
      OrderByTypeEnum orderByType,
      OrderByColumnAddressEnum orderByColumn
    );
    Task<AddressNewDto> Add(AddressNewDto address);
    void Update(AdressesDto address);
    Boolean Delete(Guid id);
  }
}