using API_GrupoFleury.Repository;
using API_GrupoFleury.service;
using Microsoft.Extensions.DependencyInjection;

namespace API_GrupoFleury.config
{
  public static class DependenciConfig
  {
    public static void AddDependeci(this IServiceCollection services)
    {
      services.AddScoped<IClientService, ClientService>();
      services.AddScoped<IClientRepository, ClientRepository>();

      services.AddScoped<IExamService, ExamService>();
      services.AddScoped<IExamRepository, ExamRepository>();

      services.AddScoped<ISchedulingService, SchedulingService>();
      services.AddScoped<ISchedulingRepository, SchedulingRepository>();

      services.AddScoped<IAddressService, AddressService>();
      services.AddScoped<IAddressRepository, AddressRepository>();
    }
  }
}