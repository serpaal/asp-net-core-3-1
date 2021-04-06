using MesaAyuda.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MesaAyuda.Domain.Extensions
{
    public static class DependenciesRegistration
    {
        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            services                
                //.AddSingleton<IRequerimientoInfoMapper, RequerimientoInfoMapper>();
                .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }

        
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services
                .AddScoped<IRequerimInfService, RequerimInfService>()
                .AddScoped<IReqQdetalleService, ReqQdetalleService>()
                .AddScoped<IIncidentesInfService, IncidentesInfService>()
                .AddScoped<IIncidentesService, IncidentesService>();

            return services;
        }        
    }
}
