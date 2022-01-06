using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Dtos;
using API_GrupoFleury.Enum;

namespace API_GrupoFleury.service
{
  public interface IClientService
  {
    Task<dynamic> GetAll(
      int pageSize,
      int pageNumber,
      string search,
      OrderByTypeEnum orderByType,
      OrderByColumnClientEnum orderByColumn
    );

    ClientsDto SearchByCpf(string cpf);
    IEnumerable<ClientsDto> SearchByName(string name);
    Task<ClientNewDto> Add(ClientNewDto client);
    void Update(ClientsDto client);
    void Desativar(ClientsDto client);
  }
}