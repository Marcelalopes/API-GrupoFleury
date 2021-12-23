using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Dtos;

namespace API_GrupoFleury.service
{
  public interface IClientService
  {
    IEnumerable<ClientsDto> GetAll();
    ClientsDto Search(String cpf);
    ClientNewDto Add(ClientNewDto client);
    void Update(ClientsDto client);
    Boolean Desativar(String cpf);
  }
}