using MesaAyuda.Domain.Entities;
using System.Collections.Generic;

namespace MesaAyuda.Domain.Repositories
{
    public interface IRequerimientosRepository 
    {
        IEnumerable<RequerimientoInfo> GetRequerimientos(string cod_u_rbl);
    }
}
