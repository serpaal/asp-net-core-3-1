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
    public class IncidentesInfRepository : IIncidentesInfRepository
    {
        private readonly MesaAyudaContext _context;

        public IUnitOfWork UnitOfWork => _context;

        public IncidentesInfRepository(MesaAyudaContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<IncidentesInf>> GetAsync()
        {
            var estados = new List<String>() { "N", "R", "Z" };
            return await _context
                .IncidentesInf
                .Where(x => x.CodURbl == "VBUS01" && estados.Contains(x.Estado))
                .AsNoTracking()
                .ToListAsync();          
        }

        public async Task<IEnumerable<IncidentesInfo>> GetIncidentesAsync()
        {           
            var user = "VBUS01";          
            
            return await _context.IncidentesInfo.FromSqlRaw(
                    "SELECT i.*, u.nomb_comp, d.descrip " +
                    "FROM INCIDENTES_INF i, " +
                    "INC_DETALLE d, " +
                    "USUARIOS u " +
                    "INNER JOIN USR_PERFILES p " +
                    "ON p.login = u.login " +
                    "WHERE i.nro_inc = d.nro_inc " +
                    "AND i.cod_usr = p.cod_usr " +
                    "AND d.cod_u_rbl = {0} " +
                    "AND d.estado in ('N', 'R', 'Z') " +
                    "ORDER BY fecha_sol ASC", user
                    ).ToListAsync();
        }

        public async Task<IncidentesInf> GetAsync(string id)
        {
            var item = await _context.IncidentesInf
                .AsNoTracking()
                .Where(x => x.NroInc == id)
                .FirstOrDefaultAsync();

            return item;
        }

        public IncidentesInf Add(IncidentesInf incidente)
        {
            return _context.IncidentesInf
                .Add(incidente).Entity;
        }

        public IncidentesInf Update(IncidentesInf incidente)
        {
            _context.Entry(incidente).State = EntityState.Modified;
            return incidente;
        }
    }
}
