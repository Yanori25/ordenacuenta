using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Model
{
    public class TipoMonedaModel
    {
        public TipoMonedaModel() { }

        public int Id { get; set; }

        public string Descripcion { get; set; }
        public string Simbolo { get; set; }
        public string PaisIsob { get; set; }
        public string PaisIsoc { get; set; }
        public string Moneda { get; set; }
        public bool activo { get; set; }
        public int MonIdEmpresa { get; set; }
        public string usuariocreacion { get; set; }



    }
}
