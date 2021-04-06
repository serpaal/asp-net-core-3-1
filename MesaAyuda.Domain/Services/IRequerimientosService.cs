using MesaAyuda.Domain.Responses;
using System.Collections.Generic;

namespace MesaAyuda.Domain.Services
{
    public interface IRequerimientosService
    {
        IEnumerable<RequerimientoInfoResponse> GetRequerimientos(string cod_u_rbl);
    }
}
