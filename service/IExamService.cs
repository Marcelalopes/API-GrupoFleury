using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Dtos;

namespace API_GrupoFleury.service
{
  public interface IExamService
  {
    IEnumerable<ExamsDto> GetAll();
    ExamNewDto Add(ExamNewDto exam);
    void Update(ExamsDto exam);
    Boolean Delete(Guid id);
  }
}