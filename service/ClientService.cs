using API_GrupoFleury.models;

namespace API_GrupoFleury.service
{
  public class ClientService
  {
    public string GetAll()
    {
      return "Todas os Clientes";
    }

    public string Search()
    {
      return "Buscar Clientes";
    }

    public Client Add(Client client)
    {
      return client;
    }

    public string Update()
    {
      return "Atualizar Clientes";
    }

    public string Desativar()
    {
      return "Desativar Clientes";
    }
  }
}