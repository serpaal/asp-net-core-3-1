using MesaAyuda.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MesaAyuda.Domain.Repositories
{
    public interface IIncidentesRepository
    {
       IEnumerable<IncidentesInfo> GetIncidentes(string cod_u_rbl);
    }
}
