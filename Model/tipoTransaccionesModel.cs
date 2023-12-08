using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Model
{
    public class tipoTransaccionesModel
    {
        public tipoTransaccionesModel() { }


        public string id { get; set; }

        public string descripcion { get; set; }
   
        public int ttraidempresa { get; set; }
        public bool activo { get; set; }

    }
}
