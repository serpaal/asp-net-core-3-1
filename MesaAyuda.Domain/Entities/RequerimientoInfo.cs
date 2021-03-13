using System;
using System.Collections.Generic;
using System.Text;

namespace MesaAyuda.Domain.Entities
{
    public class RequerimientoInfo
    {
         public string nro_req { get; set; }
        public DateTime fecha_sol { get; set; }
        public string cod_usr { get; set; }
        public string cod_vinc { get; set; }
        public string cod_area { get; set; }
        public string proyecto { get; set; }
        public string cod_u_rbl { get; set; }
        public DateTime? fecha_cierre { get; set; }
        public string cod_u_rcp { get; set; }
        public string observ { get; set; }
        public string arch_adj { get; set; }
        public string estado { get; set; }
        public string descrip_req { get; set; }
        public string justific { get; set; }
        public string nomb_comp { get; set; }        
    }
}