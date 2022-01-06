using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace API_GrupoFleury.config
{
  public static class SwaggerConfig
  {
    public static void AddSwagger(this IServiceCollection services)
    {

      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo
        {
          Title = "API_GrupoFleury",
          Description = "API para o gerenciamento uma clinica",
          Version = "v1",
          Contact = new OpenApiContact
          {
            Name = "Marcela Lopes",
            Email = "marcelalopes497@gmail.com",
            Url = new Uri("https://instagram.com/marcelalop3s_")
          },
        });

        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        c.IncludeXmlComments(xmlPath);
      });
    }

    public static void UseSwaggerConfig(this IApplicationBuilder app, IWebHostEnvironment env)
    {
      app.UseSwaggerUI(c =>
          {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "API_GrupoFleury v1");
            c.RoutePrefix = "";
          }
      );
    }
  }
}