using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Dtos;
using API_GrupoFleury.Enum;

namespace API_GrupoFleury.service
{
  public interface IExamService
  {
    Task<dynamic> GetAll(
      int pageNumber,
      int pageSize,
      string search,
      OrderByTypeEnum orderByType,
      OrderByColumnExamEnum orderByColumn
    );
    Task<ExamNewDto> Add(ExamNewDto exam);
    void Update(ExamUpdateDto exam);
    Boolean Delete(Guid id);
  }
}