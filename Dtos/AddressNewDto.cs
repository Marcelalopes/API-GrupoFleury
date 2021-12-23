using System;

namespace API_GrupoFleury.Dtos
{
  public class AddressNewDto
  {
    public String Street { get; set; }
    public int Number { get; set; }
    public String District { get; set; }
    public String ZipCode { get; set; }
    public String City { get; set; }
    public String ClientCpf { get; set; }
  }
}