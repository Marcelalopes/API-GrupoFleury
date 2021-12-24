using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Dtos;

namespace API_GrupoFleury.service
{
  public interface ISchedulingService
  {
    Task<SchedulingsDto> ListarPorCpf(String cpf);
    Task<SchedulingNewDto> Add(SchedulingNewDto scheduling);
    void Update(SchedulingsDto scheduling);
    Boolean Delete(Guid id);
  }
}