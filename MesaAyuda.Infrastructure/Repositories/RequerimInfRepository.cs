using MesaAyuda.Domain.Entities;
using MesaAyuda.Domain.Responses;
using MesaAyuda.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var estados = new List<String>() { "N", "R", "Z" };
            return await _context
                .RequerimInf
                .Where(x => x.CodURbl == "VBUS01" && estados.Contains(x.Estado))
                .AsNoTracking()
                .ToListAsync();          
        }

        public async Task<IEnumerable<RequerimientoInfo>> GetRequerimientosAsync(string cod_u_rbl)
        {           
            var user = cod_u_rbl;          
            
            return await _context.RequerimientoInfos.FromSqlRaw(
                    "SELECT  " + 
                    "r.nro_req, r.fecha_sol, u.nomb_comp, r.cod_usr, r.cod_vinc, r.cod_area, r.proyecto, q.cod_u_rbl,  " +
                    "r.fecha_cierre, r.cod_u_rcp, r.observ, r.arch_adj,  q.descrip_req, q.justific, q.estado " +
                    "FROM REQUERIM_INF r, REQ_QDETALLE q, " + 
                    "USUARIOS u INNER JOIN USR_PERFILES p " +
                    "ON p.login = u.login " +
                    "WHERE r.nro_req = q.nro_req " +
                    "AND r.cod_usr = p.cod_usr " +
                    "AND q.cod_u_rbl = {0} " + 
                    "AND q.estado IN ('N', 'R', 'Z')" + 
                    "ORDER BY r.fecha_sol ASC", user
                    ).ToListAsync();
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
