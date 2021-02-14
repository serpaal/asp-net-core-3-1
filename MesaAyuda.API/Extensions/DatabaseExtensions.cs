using MesaAyuda.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MesaAyuda.API.Extensions
{
    public static class DatabaseExtensions
    {
        public static IServiceCollection AddMesaAyudaContext(this IServiceCollection services, string connectionString)
        {
            return services
                //.AddEntityFrameworkSqlServer()
                .AddDbContext<MesaAyudaContext>(contextOptions =>
                {
                    contextOptions.UseSqlServer(
                        connectionString,
                        serverOptions => {
                            serverOptions.MigrationsAssembly (typeof(Startup).Assembly.FullName);
                        });
                });
        }
    }
}
