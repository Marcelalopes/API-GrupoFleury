using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using API_GrupoFleury.models;

namespace API_GrupoFleury.Dtos
{
  public class SchedulingNewDto
  {
    [Required(ErrorMessage = "Campo Obrigatório!")]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    public DateTime HorarioI { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    public DateTime HorarioF { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    public Double ValueTotal { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    public List<Guid> ExamIds { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    [MaxLength(length: 11, ErrorMessage = "O tamanho máximo é 11")]
    public String ClientCpf { get; set; }
  }
}