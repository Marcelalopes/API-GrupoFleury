using System.Collections.Generic;
using System;
using API_GrupoFleury.models;

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
    public List<Scheduling> Schedulings { get; set; }
  }
}