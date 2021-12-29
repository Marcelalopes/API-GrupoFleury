using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Dtos;

namespace API_GrupoFleury.service
{
  public interface ISchedulingService
  {
    Task<IEnumerable<SchedulingsDto>> GetAll();
    Task<SchedulingsDto> ListarPorCpf(String cpf);
    Task<SchedulingNewDto> Add(SchedulingNewDto scheduling);
    void Update(SchedulingUpdateDto scheduling);
    Boolean Delete(Guid id);
  }
}