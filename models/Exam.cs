using System;

namespace API_GrupoFleury.models
{
  public class Exam
  {
    public Exam()
    {
      Id = new Guid();
    }
    public Guid Id { get; set; }
    public String Name { get; set; }
    public Double Price { get; set; }
    public int Duration { get; set; }
  }
}