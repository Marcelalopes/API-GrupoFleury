using System;
using System.Collections.Generic;
using API_GrupoFleury.models;

namespace API_GrupoFleury.Repository
{
  public interface IExamRepository
  {
    void add(Exam exam);
    IEnumerable<Exam> GetAll();
    void Update(Exam exam);
    Boolean Delete(Guid id);
  }
}