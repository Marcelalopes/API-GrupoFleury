using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Dtos;
using API_GrupoFleury.Enum;

namespace API_GrupoFleury.service
{
  public interface ISchedulingService
  {
    Task<dynamic> GetAll(int pageNumber, int pageSize, string search, OrderByTypeEnum orderByType, OrderByColumnSchedulingEnum orderByColumn);
    SchedulingsDto SearchByCpf(String cpf);
    SchedulingsDto SearchByDate(DateTime date);
    Task<SchedulingNewDto> Add(SchedulingNewDto scheduling);
    void Update(SchedulingUpdateDto scheduling);
    Boolean Delete(Guid id);
  }
}