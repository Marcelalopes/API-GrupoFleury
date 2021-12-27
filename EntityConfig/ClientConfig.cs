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
      builder.Property(prop => prop.BirthDate)
          .HasColumnType("datetime")
          .IsRequired();
      builder.Property(prop => prop.Phone)
          .HasColumnType("varchar(11)");
      builder.Property(prop => prop.Email)
          .HasColumnType("varchar(30)");
      builder.HasOne(x => x.Address).WithMany(x => x.Clients).HasForeignKey(x => x.AddressId);
    }
  }
}