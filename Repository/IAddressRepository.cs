using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;

namespace API_GrupoFleury.Repository
{
  public interface IAddressRepository
  {
    Task<Address> add(Address address);
    void Update(Address address);
    Boolean Delete(Guid id);
  }
}