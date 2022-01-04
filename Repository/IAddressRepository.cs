using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using X.PagedList;
using API_GrupoFleury.Enum;

namespace API_GrupoFleury.Repository
{
  public interface IAddressRepository
  {
    Task<IPagedList<Address>> GetAll(
      int pageSize,
      int pageNumber,
      string search,
      OrderByTypeEnum orderByType,
      OrderByColumnAddressEnum orderByColumn
    );
    Task<Address> add(Address address);
    void Update(Address address);
    Boolean Delete(Guid id);
  }
}