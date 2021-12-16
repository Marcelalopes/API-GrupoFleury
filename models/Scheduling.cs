using System;
using API_GrupoFleury.models;

namespace API_GrupoFleury.models
{
  public class Scheduling
  {
    public Scheduling()
    {
      Id = new Guid();
    }
    public Guid Id { get; set; }
    public DateTime DateHour { get; set; }
    public Double Total { get; set; }
  }
}