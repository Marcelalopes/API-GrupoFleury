using System;
using System.Collections.Generic;
using API_GrupoFleury.models;

namespace API_GrupoFleury.service
{
  public interface IExamService
  {
    IEnumerable<Exam> GetAll();
    Exam Add(Exam exam);
    void Update(Exam exam);
    Boolean Delete(Guid id);
  }
}