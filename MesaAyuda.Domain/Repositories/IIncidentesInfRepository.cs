using MesaAyuda.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MesaAyuda.Domain.Repositories
{
    public interface IIncidentesInfRepository : IRepository
    {
        Task<IEnumerable<IncidentesInf>> GetAsync();
        Task<IncidentesInf> GetAsync(string id);
        IncidentesInf Add(IncidentesInf item);
        IncidentesInf Update(IncidentesInf item);

        Task<IEnumerable<IncidentesInfo>> GetIncidentesAsync(string cod_u_rbl);
    }
}
