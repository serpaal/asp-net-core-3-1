using MesaAyuda.Domain.Entities;
using MesaAyuda.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MesaAyuda.Domain.Mapper
{
    public class RequerimientoInfoMapper : IRequerimientoInfoMapper
    {
        public RequerimientoInfoResponse Map(RequerimientoInfo requerimientoInfo)
        {
            if (requerimientoInfo == null) return null;

            var response = new RequerimientoInfoResponse
            {
                NroReq = requerimientoInfo.NroReq,
                FechaSol = requerimientoInfo.FechaSol,
                CodOtr = requerimientoInfo.CodOtr,
                DescripReq = requerimientoInfo.DescripReq,
                FechaEje = requerimientoInfo.FechaEje,
                FechaIniTi = requerimientoInfo.FechaIniTi,
                Solicitante = requerimientoInfo.Solicitante,
                Asignado = requerimientoInfo.Asignado,
                CodUDrv = requerimientoInfo.CodUDrv,
                CodURbl = requerimientoInfo.CodURbl,
                EstReq = requerimientoInfo.EstReq,
                EstDetalle = requerimientoInfo.EstDetalle,
                Detalis = requerimientoInfo.Detalle
            };           

            return response;
        }
    }
}
