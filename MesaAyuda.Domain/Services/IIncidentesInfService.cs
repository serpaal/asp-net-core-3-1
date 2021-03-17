using MesaAyuda.Domain.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MesaAyuda.Domain.Services
{
    public interface IIncidentesInfService
    {
        Task<IEnumerable<IncidentesInfResponse>> GetIncidentesInfAsync();
        Task<IEnumerable<IncidentesInfoResponse>> GetIncidentesAsync(string cod_u_rbl);
    }
}
