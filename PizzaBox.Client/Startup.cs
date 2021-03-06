using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaBox.Storing;

namespace PizzaBox.Client
{
  public class Startup
  {
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public IConfiguration Configuation { get; set; }

    public Startup(IConfiguration configuation)
    {
      Configuation = configuation;
    }
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllersWithViews();
      services.AddScoped<UnitOfWork>();
      services.AddDbContext<PizzaBoxContext>(option =>
      {

        //if (string.IsNullOrWhiteSpace(Configuation.GetConnectionString("mssql")))
        //{
        option.UseSqlServer(Configuation.GetConnectionString("mssql"), ops => ops.EnableRetryOnFailure(3));
        //}
        //else
        //{
        //option.UseNpgsql(Configuation.GetConnectionString("pgsql"), ops => ops.EnableRetryOnFailure(3));
        //}
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
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
