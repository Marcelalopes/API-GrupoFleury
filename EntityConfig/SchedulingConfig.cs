using Microsoft.EntityFrameworkCore;
using System;
using API_GrupoFleury.models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
// using System.Data.Entity.ModelConfiguration;

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
      builder.HasOne(s => s.Client)
          .WithMany(c => c.Schedulings)
          .HasForeignKey(s => s.ClientCpf)
          .IsRequired();
      /* builder.HasMany(s => s.Exams)
          .WithMany(e => e.Schedulings)
          .Map(x => x.toTable("ExamScheduling").MapLeftKey("SchedulingId").MapRightKey("ExamId")); */    
    }
  }
}