using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Model
{
    internal class Partida
    {
        public Partida() { }

        public int Id { get; set; }

        public int Asiento { get; set; }
        public DateTime Fecha { get; set; }
        public int CuentaPar { get; set; }
        public int Parcial { get; set; }
        public int Debe { get; set; }
        public int Haber { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }

        public string Referencia { get; set; }
        public int ParIdEmpresa { get; set; }
        public int ParIdLibro { get; set; }
        public string UsuarioCreacion { get; set; }
        public string TipoTransaccion { get; set; }
        public string estado { get; set; }
        public int subcueid { get; set; }


    }
}
