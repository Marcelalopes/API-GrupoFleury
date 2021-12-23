using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Dtos;

namespace API_GrupoFleury.service
{
  public interface ISchedulingService
  {
    SchedulingsDto ListarPorCpf(String cpf);
    SchedulingNewDto Add(SchedulingNewDto scheduling);
    void Update(SchedulingsDto scheduling);
    Boolean Delete(Guid id);
  }
}