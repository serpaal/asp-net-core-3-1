using MesaAyuda.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MesaAyuda.Domain.Repositories
{
    public interface IReqQdetalleRepository : IRepository
    {
        Task<IEnumerable<ReqQdetalle>> GetAsync();
        Task<ReqQdetalle> GetAsync(string id);
        ReqQdetalle Add(ReqQdetalle item);
        ReqQdetalle Update(ReqQdetalle item);
    }
}
