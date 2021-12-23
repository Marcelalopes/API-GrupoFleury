using System;
using System.Collections.Generic;

namespace API_GrupoFleury.models
{
  public class Client
  {
    public String Cpf { get; set; }
    public String Name { get; set; }
    public DateTime BirthDate { get; set; }
    public String Phone { get; set; }
    public String Email { get; set; }
    public Boolean isDesable { get; set; }
    public Address Address { get; set; }
    public Guid AddressId { get; set; }
    public List<Scheduling> Schedulings { get; set; }
  }
}