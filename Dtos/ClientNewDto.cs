using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using API_GrupoFleury.models;

namespace API_GrupoFleury.Dtos
{
  public class ClientNewDto
  {
    [Required(ErrorMessage = "Campo Obrigatório!")]
    [MaxLength(length: 11, ErrorMessage = "O tamanho máximo é 11")]
    public String Cpf { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    [MaxLength(length: 100, ErrorMessage = "O tamanho máximo é 100")]
    public String Name { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    public DateTime BirthDate { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    [MaxLength(length: 11, ErrorMessage = "O tamanho máximo é 11")]
    public String Phone { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório!")]
    [MaxLength(length: 30, ErrorMessage = "O tamanho máximo é 30")]
    public String Email { get; set; }

    [DefaultValueAttribute(false)]
    public Boolean isDesable { get; set; }
    public Guid AddressId { get; set; }
  }
}