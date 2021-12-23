using System;
using System.Collections.Generic;

namespace API_GrupoFleury.Dtos
{
  public class SchedulingNewDto
  {
    public DateTime Date { get; set; }
    public DateTime HorarioI { get; set; }
    public DateTime HorarioF { get; set; }
    public Double ValueTotal { get; set; }
    public IEnumerable<Guid> ExamIds { get; set; }
    public String ClientCpf { get; set; }
  }
}