using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Model
{
    public class HistoricoMonedaModel
    {
         public HistoricoMonedaModel() { }

        public int Id { get; set; }

        public DateTime Fecha { get; set; }
        public Decimal Valor { get; set; }
        public bool activo { get; set; }
        public int HistMonEmpresa { get; set; }
        public int HistMon { get; set; }
        public string estado { get; set; }


    public string usuariocreacion { get; set; }

    }
}
