using MesaAyuda.Domain.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MesaAyuda.Domain.Services
{
    public interface IRequerimientoInfoService
    {
        Task<IEnumerable<RequerimientoInfoResponse>> GetRequerimientosInfoAsync();
    }
}
