using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Dtos;

namespace API_GrupoFleury.service
{
  public interface IClientService
  {
    Task<IEnumerable<ClientsDto>> GetAll();
    Task<ClientsDto> Search(String cpf);
    Task<ClientNewDto> Add(ClientNewDto client);
    void Update(ClientsDto client);
    Boolean Desativar(String cpf);
  }
}