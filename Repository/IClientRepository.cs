using System;
using System.Collections.Generic;
using API_GrupoFleury.models;

namespace API_GrupoFleury.Repository
{
  public interface IClientRepository
  {
    void add(Client client);
    IEnumerable<Client> GetAll();
    Client Search(String cpf);
    void Update(Client client);
    Boolean Desativar(String cpf);
  }
}