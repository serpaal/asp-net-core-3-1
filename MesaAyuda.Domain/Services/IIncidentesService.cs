using MesaAyuda.Domain.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MesaAyuda.Domain.Services
{
    public interface IIncidentesService
    {
        IEnumerable<IncidentesInfoResponse> GetIncidentes(string cod_u_rbl);
    }
}
