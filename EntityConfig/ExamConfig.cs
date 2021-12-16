using Microsoft.EntityFrameworkCore;
using API_GrupoFleury.models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_GrupoFleury.EntityConfig
{
  public class ExamConfig : IEntityTypeConfiguration<Exam>
  {
    public void Configure(EntityTypeBuilder<Exam> builder)
    {
      builder.ToTable("Exams");

      builder.HasKey(prop => prop.Id)
          .HasName("Pk_ClientCpf");

      builder.Property(prop => prop.Name)
          .HasColumnType("varchar(100)")
          .IsRequired();
      builder.Property(prop => prop.Price)
          .HasColumnType("double")
          .IsRequired();
    }
  }
}