using System;
using System.Collections.Generic;
using API_GrupoFleury.models;

namespace API_GrupoFleury.service
{
  public interface IClientService
  {
    IEnumerable<Client> GetAll();
    Client Search(String cpf);
    Client Add(Client client);
    void Update(Client client);
    Boolean Desativar(String cpf);
  }
}