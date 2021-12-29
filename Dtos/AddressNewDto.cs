using System;
using System.ComponentModel.DataAnnotations;

namespace API_GrupoFleury.Dtos
{
  public class AddressNewDto
  {
    [Required(ErrorMessage = "Campo Obrigatório!")]
    [MaxLength(length: 50, ErrorMessage = "O tamanho máximo é 50")]
    public String Street { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    public int Number { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    [MaxLength(length: 16, ErrorMessage = "O tamanho máximo é 16")]
    public String District { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    [MaxLength(length: 8, ErrorMessage = "O tamanho máximo é 8")]
    public String ZipCode { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    [MaxLength(length: 20, ErrorMessage = "O tamanho máximo é 20")]
    public String City { get; set; }
  }
}