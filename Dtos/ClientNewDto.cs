using System;
using API_GrupoFleury.models;

namespace API_GrupoFleury.Dtos
{
  public class ClientNewDto
  {
    public String Cpf { get; set; }
    public String Name { get; set; }
    public DateTime BirthDate { get; set; }
    public String Phone { get; set; }
    public String Email { get; set; }
    public Boolean isDesable { get; set; }
    public Address Address { get; set; }
    public int AddressId { get; set; }
  }
}