using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Model
{
    internal class ClasificacionCuenta
    {
        public int id { get; set; }

        public string clase { get; set; }
        public string TipoCuenta { get; set; }
        public string Naturaleza { get; set; }


        public bool Activo { get; set; }
        public int ClaIdempresa { get; set; }


        public ClasificacionCuenta() { }


    }
}
