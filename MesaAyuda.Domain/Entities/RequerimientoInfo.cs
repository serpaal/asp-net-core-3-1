using System;
using System.Collections.Generic;
using System.Text;

namespace MesaAyuda.Domain.Entities
{
    public class RequerimientoInfo
    {
        public string NroReq { get; set; }
        public DateTime? FechaSol { get; set; }
        public string CodOtr { get; set; }
        public string DescripReq { get; set; }
        public DateTime? FechaEje { get; set; }
        public DateTime? FechaIniTi { get; set; }
        public string Solicitante { get; set; }
        public string Asignado { get; set; }
        public string CodUDrv { get; set; }
        public string CodURbl { get; set; }
        public string EstReq { get; set; }
        public string EstDetalle { get; set; }
        public string Detalle { get; set; }
    }
}