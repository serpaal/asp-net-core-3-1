using MesaAyuda.Domain.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MesaAyuda.Domain.Services
{
    public interface IRequerimInfService
    {
        Task<IEnumerable<RequerimInfResponse>> GetRequerimInfAsync();
        Task<IEnumerable<RequerimientoInfoResponse>> GetRequerimientosAsync(string cod_u_rbl);
    }
}
