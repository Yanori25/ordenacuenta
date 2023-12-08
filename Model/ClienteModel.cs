using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Model
{
    public class ClienteModel
    {
        public ClienteModel() { }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string email { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Telefono { get; set; }
        public int CliIdEmpresa { get; set; }
        public Decimal Abono { get; set; }
        public string segundoNombre { get; set; }
        public string segundoApellido { get; set; }
        public int CliTipMonid { get; set; }
        public string FechaIngresostr { get; set; }
        public int subcueidcli {  get; set; }
        public string NombreCia { get; set; }
        public string RTN { get; set; }
        public string usuariocreacion { get; set; }
        public string subcuenta { get; set; }







    }
}
