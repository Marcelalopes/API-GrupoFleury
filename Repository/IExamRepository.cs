using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;

namespace API_GrupoFleury.Repository
{
  public interface IExamRepository
  {
    Task<Exam> add(Exam exam);
    Task<IEnumerable<Exam>> GetAll();
    void Update(Exam exam);
    Boolean Delete(Guid id);
  }
}