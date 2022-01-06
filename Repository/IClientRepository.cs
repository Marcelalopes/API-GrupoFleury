using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using X.PagedList;
using API_GrupoFleury.Enum;
using System.Linq.Expressions;

namespace API_GrupoFleury.Repository
{
  public interface IClientRepository
  {
    Task<Client> add(Client client);
    Task<IPagedList<Client>> GetAll(int pageSize, int pageNumber, string search, OrderByTypeEnum orderByType, OrderByColumnClientEnum orderByColumn);
    IEnumerable<Client> Search(Expression<Func<Client, bool>> predicate);
    void Update(Client client);
    void Desativar(Client client);
  }
}