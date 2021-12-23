using Microsoft.EntityFrameworkCore;
using API_GrupoFleury.models;
using API_GrupoFleury.EntityConfig;

namespace API_GrupoFleury.Context
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Client> Client { get; set; }
    public DbSet<Exam> Exam { get; set; }
    public DbSet<Scheduling> Scheduling { get; set; }
    public DbSet<Address> Address { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Client>(new ClientConfig().Configure);
      modelBuilder.Entity<Exam>(new ExamConfig().Configure);
      modelBuilder.Entity<Scheduling>(new SchedulingConfig().Configure);
      modelBuilder.Entity<Address>(new AddressConfig().Configure);
    }
  }
}