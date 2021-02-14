using MesaAyuda.Domain.Entities;
using MesaAyuda.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MesaAyuda.Domain.Mapper
{
    public interface IRequerimientoInfoMapper
    {
        RequerimientoInfoResponse Map(RequerimientoInfo requerimientoInfo);
    }
}
