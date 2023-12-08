using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Model
{
    internal class Correlativo
    {
        public Correlativo() { }

        public int id { get; set; }

        public string Descripcion { get; set; }
        public int Asiento { get; set; }
        public Boolean Activo { get; set; }
    }
}
