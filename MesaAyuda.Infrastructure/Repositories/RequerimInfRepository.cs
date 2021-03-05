using MesaAyuda.Domain.Entities;
using MesaAyuda.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesaAyuda.Infrastructure.Repositories
{
    public class RequerimInfRepository : IRequerimInfRepository
    {
        private readonly MesaAyudaContext _context;

        public IUnitOfWork UnitOfWork => _context;

        public RequerimInfRepository(MesaAyudaContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<RequerimInf>> GetAsync()
        {
            return await _context
                .RequerimInf
                .AsNoTracking()
                .ToListAsync();
            //return await _context.RequerimientoInfo.FromSqlRaw("SELECT * FROM dbo.requerimiento_info WHERE nro_req = 'R00003'").ToListAsync();
        }

        public async Task<RequerimInf> GetAsync(string id)
        {
            var item = await _context.RequerimInf
                .AsNoTracking()
                .Where(x => x.NroReq == id)
                .FirstOrDefaultAsync();

            return item;
        }

        public RequerimInf Add(RequerimInf requerimiento)
        {
            return _context.RequerimInf
                .Add(requerimiento).Entity;
        }

        public RequerimInf Update(RequerimInf requerimiento)
        {
            _context.Entry(requerimiento).State = EntityState.Modified;
            return requerimiento;
        }
    }
}
