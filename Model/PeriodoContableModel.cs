using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Model
{
    public  class PeriodoContableModel
    {
        public PeriodoContableModel() { }

        public int Id { get; set; }

        public string TippagcueId { get; set; }

        public DateTime FechaIni { get; set; }

        public DateTime FechaFin { get; set; }

        public DateTime FechaPago { get; set; }

        public DateTime FechaCorte { get; set; }

        public string Frecuencia { get; set; }

        public int Mes { get; set; }

        public int AnioContable { get; set; }

        public string Estado { get; set; }

        public int IdPerEmpresa { get; set; }

        public bool Activo { get; set; }

        public string UsuarioCreacion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public string UsuarioModifica { get; set; }

        public DateTime FechaModificacion { get; set; }

    }
}
