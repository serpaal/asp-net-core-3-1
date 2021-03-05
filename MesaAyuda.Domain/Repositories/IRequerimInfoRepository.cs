﻿using MesaAyuda.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MesaAyuda.Domain.Repositories
{
    public interface IRequerimInfRepository : IRepository
    {
        Task<IEnumerable<RequerimInf>> GetAsync();
        Task<RequerimInf> GetAsync(string id);
        RequerimInf Add(RequerimInf item);
        RequerimInf Update(RequerimInf item);
    }
}
