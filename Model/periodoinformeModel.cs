using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenaCuenta.Model
{
    public class periodoinformeModel
    {
        public periodoinformeModel() { }

        public int id { get; set; }

        public int idperiodo { get; set; }

        public DateTime fechainforme { get; set; }

        public bool activo { get; set; }

        public string estado { get; set; }

        public string usuariocreacion { get; set; }

    }
}
