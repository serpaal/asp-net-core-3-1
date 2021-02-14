using MesaAyuda.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MesaAyuda.Domain.Repositories
{
    public interface IRequerimientoInfoRepository : IRepository
    {
        Task<IEnumerable<RequerimientoInfo>> GetAsync();
        Task<RequerimientoInfo> GetAsync(string id);
        RequerimientoInfo Add(RequerimientoInfo item);
        RequerimientoInfo Update(RequerimientoInfo item);
    }
}
