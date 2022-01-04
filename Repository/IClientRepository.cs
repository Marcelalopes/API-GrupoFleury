using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using X.PagedList;
using API_GrupoFleury.Enum;

namespace API_GrupoFleury.Repository
{
  public interface IClientRepository
  {
    Task<Client> add(Client client);
    Task<IPagedList<Client>> GetAll(int pageSize, int pageNumber, string search, OrderByTypeEnum orderByType, OrderByColumnClientEnum orderByColumn);
    Task<Client> Search(String cpf);
    void Update(Client client);
    void Desativar(Client client);
  }
}