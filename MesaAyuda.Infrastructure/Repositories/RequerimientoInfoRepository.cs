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
    public class RequerimientoInfoRepository : IRequerimientoInfoRepository
    {
        private readonly MesaAyudaContext _context;

        public IUnitOfWork UnitOfWork => _context;

        public RequerimientoInfoRepository(MesaAyudaContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<RequerimientoInfo>> GetAsync()
        {
            return await _context
                .RequerimientoInfo
                .AsNoTracking()
                .ToListAsync();
            //return await _context.RequerimientoInfo.FromSqlRaw("SELECT * FROM dbo.requerimiento_info WHERE nro_req = 'R00003'").ToListAsync();
        }

        public async Task<RequerimientoInfo> GetAsync(string id)
        {
            var item = await _context.RequerimientoInfo
                .AsNoTracking()
                .Where(x => x.NroReq == id)
                .FirstOrDefaultAsync();

            return item;
        }

        public RequerimientoInfo Add(RequerimientoInfo requerimiento)
        {
            return _context.RequerimientoInfo
                .Add(requerimiento).Entity;
        }

        public RequerimientoInfo Update(RequerimientoInfo requerimiento)
        {
            _context.Entry(requerimiento).State = EntityState.Modified;
            return requerimiento;
        }
    }
}
