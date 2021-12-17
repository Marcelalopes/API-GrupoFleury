using Microsoft.EntityFrameworkCore;
using API_GrupoFleury.models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_GrupoFleury.EntityConfig
{
  public class AddressConfig : IEntityTypeConfiguration<Address>
  {
    public void Configure(EntityTypeBuilder<Address> builder)
    {
      builder.ToTable("Adresses");

      builder.HasKey(prop => prop.Id)
        .HasName("Pk_AddressId");
      builder.Property(prop => prop.Street)
        .HasColumnType("varchar(50)")
        .IsRequired();
      builder.Property(prop => prop.Number)
        .HasColumnType("int")
        .IsRequired();
      builder.Property(prop => prop.District)
        .HasColumnType("varchar(15)")
        .IsRequired();
      builder.Property(prop => prop.ZipCode)
        .HasColumnType("varchar(8)")
        .IsRequired();
      builder.Property(prop => prop.City)
        .HasColumnType("varchar(20)")
        .IsRequired();

    }
  }
}