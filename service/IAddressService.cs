using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Dtos;

namespace API_GrupoFleury.service
{
  public interface IAddressService
  {
    AddressNewDto Add(AddressNewDto address);
    void Update(AdressesDto address);
    Boolean Delete(Guid id);
  }
}