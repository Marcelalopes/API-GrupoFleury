using System;
using System.Collections.Generic;
using API_GrupoFleury.models;

namespace API_GrupoFleury.Repository
{
  public interface ISchedulingRepository
  {
    void add(Scheduling scheduling);
    Scheduling ListarPorCpf(String cpf);
    void Update(Scheduling scheduling);
    Boolean Delete(Guid id);
  }
}