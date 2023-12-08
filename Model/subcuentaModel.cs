using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Model
{
    public class subcuentaModel
    {
        public subcuentaModel() { }

        public int id { get; set; }

        public string Cuentacontablesub { get; set; }
        public string Descripcion { get; set; }
        public int CuentaId { get; set; }
        public int SubCueIdEmpresa { get; set; }  
        public bool Activo { get; set; }
        public string usuariocreacion { get; set; }


    }
}
