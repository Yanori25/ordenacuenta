using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Model
{
    public class ProveedoresModel
    {
        public ProveedoresModel() { }

        public long Id { get; set; }
        public string NombreCia { get; set; }
        public string NombreContacto { get; set; }
        public string email { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string RTN { get; set; }
        public string Direccion { get; set; }
        public Decimal Deuda { get; set; }
        public int ProIdEmpresa { get; set; }
        public string usuariocreacion { get; set; }
        public int ProtipMon { get; set; }
        public string FechaCreacionstr { get; set; }
        public string Moneda { get; set; }
        public int subcuentaid { get; set; }
        public string subcuenta { get; set; }

    }
}
