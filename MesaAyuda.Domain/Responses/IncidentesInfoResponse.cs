using System;

namespace MesaAyuda.Domain.Responses
{
    public class IncidentesInfoResponse
    {
        public string nro_inc { get; set; }
        public DateTime fecha_sol { get; set; }
        //public string cod_usr { get; set; }
        //public string cod_vinc { get; set; }
        //public string cod_area { get; set; }
        public string cod_u_rbl { get; set; }
        //public DateTime? fecha_cierre { get; set; }
        //public string cod_u_rcp { get; set; }
        public string observ { get; set; }
        public string arch_adj { get; set; }
        public string estado { get; set; }
        public string nomb_comp { get; set; }
         public string descrip { get; set; }  
    }
}
