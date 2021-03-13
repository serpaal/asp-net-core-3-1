using MesaAyuda.API.Extensions;
using MesaAyuda.Domain.Extensions;
using MesaAyuda.Domain.Repositories;
using MesaAyuda.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MesaAyuda.API
{
    public class Startup
    {
        //readonly string allowSpecificOrigins = "_allowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
             .AddMesaAyudaContext(Configuration.GetSection("DataSource:ConnectionString").Value)
             .AddScoped<IRequerimInfRepository, RequerimInfRepository>()
             .AddScoped<IReqQdetalleRepository, ReqQdetalleRepository>()
             .AddScoped<IIncidentesInfRepository, IncidentesInfRepository>()
             .AddMappers()
             .AddServices()            
             .AddCors(options => options.AddPolicy("ApiCorsPolicy", builder =>
             {
                    builder.WithOrigins("http://localhost:4200")
                        .AllowAnyMethod()
                        .AllowAnyHeader();
             }))
            .AddControllers();           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection(); rompe cors cuando esta descomentado
            
            app.UseRouting();
           
            app.UseCors("ApiCorsPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
