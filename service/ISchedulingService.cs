using System;
using System.Collections.Generic;
using API_GrupoFleury.models;

namespace API_GrupoFleury.service
{
  public interface ISchedulingService
  {
    Scheduling ListarPorCpf(String cpf);
    Scheduling Add(Scheduling scheduling);
    void Update(Scheduling scheduling);
    Boolean Delete(Guid id);
  }
}