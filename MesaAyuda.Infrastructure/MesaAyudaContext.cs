using MesaAyuda.Domain.Entities;
using MesaAyuda.Domain.Repositories;
using MesaAyuda.Infrastructure.SchemaDefinitions;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace MesaAyuda.Infrastructure
{
    public class MesaAyudaContext : DbContext, IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "dbo";

        public DbSet<RequerimientoInfo> RequerimientoInfo { get; set; }

        public MesaAyudaContext(DbContextOptions<MesaAyudaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RequerimientoInfoEntitySchemaDefinition());
            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
