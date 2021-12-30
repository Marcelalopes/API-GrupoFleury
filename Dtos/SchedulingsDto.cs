using System;
using System.Collections.Generic;

namespace API_GrupoFleury.Dtos
{
  public class SchedulingsDto
  {
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public DateTime HorarioI { get; set; }
    public DateTime HorarioF { get; set; }
    public Double ValueTotal { get; set; }
    public List<Guid> ExamIds { get; set; }
    public String ClientCpf { get; set; }
  }
}