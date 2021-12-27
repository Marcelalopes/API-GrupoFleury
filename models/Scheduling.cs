using System.Collections.Generic;
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
    public DateTime Date { get; set; }
    public DateTime HorarioI { get; set; }
    public DateTime HorarioF { get; set; }
    public Double ValueTotal { get; set; }
    public Guid ExamId { get; set; }
    public List<Exam> Exams { get; set; }
    public Client Client { get; set; }
    public String ClientCpf { get; set; }
  }
}