using API_GrupoFleury.models;

namespace API_GrupoFleury.service
{
  public class SchedulingService
  {
    public string ListarPorCpf()
    {
      return "Lista agendamentos de um cpf";
    }
    public Scheduling Add(Scheduling scheduling)
    {
      return scheduling;
    }
    public string Update()
    {
      return "Atualiza data e hora de um agendamento";
    }
    public string Delete()
    {
      return "Deleta um agendamento";
    }
  }
}