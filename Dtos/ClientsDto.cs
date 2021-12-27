using System;

namespace API_GrupoFleury.Dtos
{
  public class ClientsDto
  {
    public String Cpf { get; set; }
    public String Name { get; set; }
    public DateTime BirthDate { get; set; }
    public String Phone { get; set; }
    public String Email { get; set; }
    public Boolean isDesable { get; set; }
    public Guid AddressId { get; set; }
  }
}