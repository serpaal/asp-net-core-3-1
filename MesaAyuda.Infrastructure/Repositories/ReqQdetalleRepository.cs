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
    public class ReqQdetalleRepository : IReqQdetalleRepository
    {
        private readonly MesaAyudaContext _context;

        public IUnitOfWork UnitOfWork => _context;

        public ReqQdetalleRepository(MesaAyudaContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<ReqQdetalle>> GetAsync()
        {
            var estados = new List<String>() { "N", "R", "Z" };
            return await _context
                .ReqQdetalle
                .Where(x => x.CodURbl == "VBUS01" && estados.Contains(x.Estado))
                .AsNoTracking()
                .ToListAsync();
            //return await _context.RequerimientoInfo.FromSqlRaw("SELECT * FROM dbo.requerimiento_info WHERE nro_req = 'R00003'").ToListAsync();
        }

        public async Task<ReqQdetalle> GetAsync(string id)
        {
            var item = await _context.ReqQdetalle
                .AsNoTracking()
                .Where(x => x.NroReq == id)
                .FirstOrDefaultAsync();

            return item;
        }

        public ReqQdetalle Add(ReqQdetalle requerimiento)
        {
            return _context.ReqQdetalle
                .Add(requerimiento).Entity;
        }

        public ReqQdetalle Update(ReqQdetalle requerimiento)
        {
            _context.Entry(requerimiento).State = EntityState.Modified;
            return requerimiento;
        }
    }
}
