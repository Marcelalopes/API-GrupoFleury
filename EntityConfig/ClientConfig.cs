using Microsoft.EntityFrameworkCore;
using API_GrupoFleury.models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_GrupoFleury.EntityConfig
{
  public class ClientConfig : IEntityTypeConfiguration<Client>
  {
    public void Configure(EntityTypeBuilder<Client> builder)
    {
      builder.ToTable("Clients");

      builder.HasKey(prop => prop.Cpf)
          .HasName("Pk_ClientCpf");

      builder.Property(prop => prop.Name)
          .HasColumnType("varchar(100)")
          .IsRequired();
      builder.Property(prop => prop.Endereco)
          .HasColumnType("varchar(300)")
          .IsRequired();
      builder.Property(prop => prop.DataNascimento)
          .HasColumnType("datetime")
          .IsRequired();
    }
  }
}