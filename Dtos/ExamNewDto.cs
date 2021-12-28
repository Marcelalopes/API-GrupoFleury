using System;
using System.ComponentModel.DataAnnotations;

namespace API_GrupoFleury.Dtos
{
  public class ExamNewDto
  {
    [Required(ErrorMessage = "Campo Obrigatório!")]
    [MaxLength(length: 100, ErrorMessage = "O tamanho máximo é 100")]
    public String Name { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    public Double Price { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    public int Duration { get; set; }
  }
}