using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Model
{
    public class periodofiscalModel
    {
        public periodofiscalModel() { }

        public int id { get; set; }
        public int periodocontableid { get; set; }



        public string TippagcueId { get; set; }

        public DateTime fechaini { get; set; }

        public DateTime fechafin { get; set; }

     
        public string estado { get; set; }

        public int idempresa { get; set; }

        public bool activo { get; set; }

        public string usuariocreacion { get; set; }

        public DateTime fechacreacion { get; set; }

        public string usuariomodifica { get; set; }

        public DateTime fechamodificacion { get; set; }
    }
}
