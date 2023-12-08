using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Model
{
    public class opcionesmodel
    {
        public opcionesmodel() { }


        public int ind { get; set; }

        public int id { get; set; }

        public string Nombre { get; set; }
        public string Nivel { get; set; }
        public string icono { get; set; }
        public string rutafrm { get; set; }


        public int OpcionPadre { get; set; }
    }
}
