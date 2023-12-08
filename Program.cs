using OrdenaCuenta.View;
using OrdenaCuenta.View.Cliente;
using OrdenaCuenta.View.Cuentas;
using OrdenaCuenta.View.HistoricoMoneda;
using OrdenaCuenta.View.opciones;
using OrdenaCuenta.View.periodo;
using OrdenaCuenta.View.periodofiscal;
using OrdenaCuenta.View.periodosaldohis;
using OrdenaCuenta.View.Proveedores;
using OrdenaCuenta.View.Reportes;
using OrdenaCuenta.View.Rolfrm;
using OrdenaCuenta.View.TipoMoneda;
using OrdenaCuenta.View.transacciones;
using OrdenaCuenta.View.Usuariofrm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //  Application.Run(new Mainfrm("rol"));
           // Application.Run(new balancegenfrm());
            Application.Run(new Loginfrmshow());

            // Application.Run(new Partidafrm());
        }
    }
}
