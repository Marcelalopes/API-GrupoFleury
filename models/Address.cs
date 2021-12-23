using System.Collections.Generic;
using System;
namespace API_GrupoFleury.models
{
  public class Address
  {
    public Address()
    {
      Id = new Guid();
    }
    public Guid Id { get; set; }
    public String Street { get; set; }
    public int Number { get; set; }
    public String District { get; set; }
    public String ZipCode { get; set; }
    public String City { get; set; }
    public List<Client> Clients { get; set; }
    public String ClientCpf { get; set; }
  }
}