using Microsoft.EntityFrameworkCore;
using API_GrupoFleury.models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_GrupoFleury.EntityConfig
{
  public class SchedulingConfig : IEntityTypeConfiguration<Scheduling>
  {
    public void Configure(EntityTypeBuilder<Scheduling> builder)
    {
      builder.ToTable("Schedulings");

      builder.HasKey(prop => prop.Id)
          .HasName("Pk_SchedulingId");

      builder.Property(prop => prop.Date)
          .HasColumnType("datetime")
          .IsRequired();
      builder.Property(prop => prop.HorarioI)
      .HasColumnType("datetime")
      .IsRequired();
      builder.Property(prop => prop.HorarioF)
      .HasColumnType("datetime")
      .IsRequired();
      builder.Property(prop => prop.ValueTotal)
          .HasColumnType("double")
          .HasPrecision(4, 2)
          .IsRequired();
    }
  }
}