using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace OrdenaCuenta.Model
{
    public   class UsuarioModel
    {
        public int id { get; set; }

        public string primernombre { get; set; }
        public string segundonombre { get; set; }
        public string primerapellido { get; set; }
        public string segundoapellido { get; set; }

        public string estado { get; set; }


        public DateTime fechaingreso { get; set; }
        public DateTime fechaRetiro { get; set; }

        public string dni { get; set; }

        public string usuario { get; set; }

        public string clave { get; set; }


        public string preguntaSeguridad { get; set; }

        public string RespuestaSeguridad { get; set; }
        public string telefono { get; set; }
        public string sexo { get; set; }

        public string idrol { get; set; }

        public int intentos { get; set; }
        public int usuidempresa { get; set; }


        public static DataTable getcliente { get; set; }

        public UsuarioModel() { }

    }
}
