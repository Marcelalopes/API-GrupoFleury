using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using X.PagedList;
using API_GrupoFleury.Enum;

namespace API_GrupoFleury.Repository
{
  public interface ISchedulingRepository
  {
    Task<IPagedList<Scheduling>> GetAll(int pageNumber, int pageSize, string search, OrderByTypeEnum orderByType, OrderByColumnSchedulingEnum orderByColumn);
    Task<Scheduling> add(Scheduling scheduling);
    Task<Scheduling> ListarPorCpf(String cpf);
    void Update(Scheduling scheduling);
    Boolean Delete(Guid id);
  }
}