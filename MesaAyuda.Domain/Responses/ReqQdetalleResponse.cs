using System;

namespace MesaAyuda.Domain.Responses
{
    public class ReqQdetalleResponse
    {
     public string NroReq { get; set; }
        public string CodOtr { get; set; }
        public string DescripReq { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Perfil { get; set; }
        public string Justific { get; set; }
        public string CodUDrv { get; set; }
        public string CodURbl { get; set; }
        public string Prioridad { get; set; }
        public DateTime? FechaEst { get; set; }
        public string TiempoEst { get; set; }
        public DateTime? FechaEje { get; set; }
        public string TiempoEje { get; set; }
        public int? DiasPru { get; set; }
        public string Observ { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaSys { get; set; }
        public DateTime? FechaIniTi { get; set; }
        public DateTime? FechaProEje { get; set; }
        public string JustifEje { get; set; }
        public string Excep { get; set; }
        public string MotivoExc { get; set; }
    }
}
