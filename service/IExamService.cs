using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Dtos;

namespace API_GrupoFleury.service
{
  public interface IExamService
  {
    Task<IEnumerable<ExamsDto>> GetAll();
    Task<ExamNewDto> Add(ExamNewDto exam);
    void Update(ExamsDto exam);
    Boolean Delete(Guid id);
  }
}