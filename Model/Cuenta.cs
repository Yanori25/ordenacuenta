using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Model
{
    internal class Cuenta
    {

        public int id { get; set; }

        public string CuentaContable { get; set; }
        public string Descripcion { get; set; }
        public int ClaseCuentaId { get; set; }
        public string CuentaTipo { get; set; }
        public int MonedaId { get; set; }
        public int CueIdEmpresa { get; set; }
        public bool Activo { get; set; }

        public Cuenta() { }

    }
}
