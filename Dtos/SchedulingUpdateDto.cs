using System;

namespace API_GrupoFleury.Dtos
{
  public class SchedulingUpdateDto
  {
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public DateTime HorarioI { get; set; }
    public DateTime HorarioF { get; set; }
    public Guid ExamId { get; set; }
    public String ClientCpf { get; set; }
  }
}