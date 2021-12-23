using System;
using System.Collections.Generic;
using API_GrupoFleury.models;

namespace API_GrupoFleury.Repository
{
  public interface IAddressRepository
  {
    void add(Address address);
    void Update(Address address);
    Boolean Delete(Guid id);
  }
}