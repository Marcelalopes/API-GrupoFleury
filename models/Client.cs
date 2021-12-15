using System;

namespace API_GrupoFleury.models
{
  public class Client
  {
    public String Cpf { get; set; }
    public String Name { get; set; }
    public String Endereco { get; set; }
    public DateTime DataNascimento { get; set; }
  }
}