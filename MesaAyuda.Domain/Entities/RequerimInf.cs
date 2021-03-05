using System;

namespace MesaAyuda.Domain.Entities
{
    public partial class RequerimInf
    {
        public string NroReq { get; set; }
        public DateTime FechaSol { get; set; }
        public string CodUsr { get; set; }
        public string CodVinc { get; set; }
        public string CodArea { get; set; }
        public string Proyecto { get; set; }
        public string CodURbl { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string CodURcp { get; set; }
        public string Observ { get; set; }
        public string ArchAdj { get; set; }
        public string Estado { get; set; }
    }
}
