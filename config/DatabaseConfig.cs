using API_GrupoFleury.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API_GrupoFleury.config
{
  public static class DatabaseConfig
  {
    public static void AddDatabase(this IServiceCollection services, IConfiguration Configuration)
    {
      string connection = Configuration.GetConnectionString("conexaoMySQL");
      services.AddDbContextPool<AppDbContext>(
        options => options.UseMySql(
          connection, ServerVersion.AutoDetect(connection)
        )
      );
    }
  }
}