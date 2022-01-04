using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using X.PagedList;
using API_GrupoFleury.Enum;

namespace API_GrupoFleury.Repository
{
  public interface IExamRepository
  {
    Task<Exam> add(Exam exam);
    Task<IPagedList<Exam>> GetAll(
      int pageSize,
      int pageNumber,
      string search,
      OrderByTypeEnum orderByType,
      OrderByColumnExamEnum orderByColumn
    );
    void Update(Exam exam);
    Boolean Delete(Guid id);
  }
}