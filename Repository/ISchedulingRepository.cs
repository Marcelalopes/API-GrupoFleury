using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using X.PagedList;
using API_GrupoFleury.Enum;
using System.Linq.Expressions;

namespace API_GrupoFleury.Repository
{
  public interface ISchedulingRepository
  {
    Task<IPagedList<Scheduling>> GetAll(int pageNumber, int pageSize, string search, OrderByTypeEnum orderByType, OrderByColumnSchedulingEnum orderByColumn);
    Task<Scheduling> add(Scheduling scheduling);
    IEnumerable<Scheduling> Search(Expression<Func<Scheduling, bool>> predicate);
    void Update(Scheduling scheduling);
    Boolean Delete(Guid id);
  }
}