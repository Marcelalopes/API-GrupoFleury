using System;

namespace API_GrupoFleury.Dtos
{
  public class ExamUpdateDto
  {
    public Guid Id { get; set; }
    public String Name { get; set; }
    public Double Price { get; set; }
    public int Duration { get; set; }
  }
}