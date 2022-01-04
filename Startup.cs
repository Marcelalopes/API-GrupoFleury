using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using API_GrupoFleury.Context;
using API_GrupoFleury.service;
using API_GrupoFleury.Repository;
using API_GrupoFleury.config;
using System.IO;
using System.Reflection;
using System.Text.Json.Serialization;

namespace API_GrupoFleury
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      string connection = Configuration.GetConnectionString("conexaoMySQL");
      services.AddDbContextPool<AppDbContext>(
        options => options.UseMySql(
          connection, ServerVersion.AutoDetect(connection)
        )
      );

      services.AddControllers()
        .AddJsonOptions(options =>
          options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter())
        );
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "API_GrupoFleury", Version = "v1" });
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        c.IncludeXmlComments(xmlPath);
      });
      // Injeção de Dependência
      services.AddScoped<IClientService, ClientService>();
      services.AddScoped<IClientRepository, ClientRepository>();

      services.AddScoped<IExamService, ExamService>();
      services.AddScoped<IExamRepository, ExamRepository>();

      services.AddScoped<ISchedulingService, SchedulingService>();
      services.AddScoped<ISchedulingRepository, SchedulingRepository>();

      services.AddScoped<IAddressService, AddressService>();
      services.AddScoped<IAddressRepository, AddressRepository>();

      //AutoMapper
      services.AddAutoMapper(typeof(AutoMapperProfile));
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c =>
            {
              c.SwaggerEndpoint("/swagger/v1/swagger.json", "API_GrupoFleury v1");
              c.RoutePrefix = "";
            }
        );
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
