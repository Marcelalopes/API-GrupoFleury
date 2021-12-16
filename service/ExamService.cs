using API_GrupoFleury.models;


namespace API_GrupoFleury.service
{
  public class ExamService
  {
    public string GetAll()
    {
      return "Listar Exames";
    }
    public Exam Add(Exam exam)
    {
      return exam;
    }
    public string Update()
    {
      return "Atualiza Exame";
    }
    public string Delete()
    {
      return "Deleta Exame";
    }
  }
}