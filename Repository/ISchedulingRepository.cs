using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;

namespace API_GrupoFleury.Repository
{
  public interface ISchedulingRepository
  {
    Task<Scheduling> add(Scheduling scheduling);
    Task<Scheduling> ListarPorCpf(String cpf);
    void Update(Scheduling scheduling);
    Boolean Delete(Guid id);
  }
}