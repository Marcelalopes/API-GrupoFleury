using System;
using System.Collections.Generic;
using API_GrupoFleury.models;

namespace API_GrupoFleury.service
{
  public interface IAddressService
  {
    Address Add(Address address);
    void Update(Address address);
    Boolean Delete(Guid id);
  }
}