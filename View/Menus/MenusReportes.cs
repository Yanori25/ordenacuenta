using MaterialSkin.Controls;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;
using OrdenaCuenta.Utilities;
using OrdenaCuenta.View.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.View.Menus
{
    public partial class MenusReportes : MaterialForm
    {
        UsuarioController usucon = new UsuarioController();
        UsuarioModel usumod = new UsuarioModel();
        string usuario = Properties.Settings.Default.Usuario;

        public MenusReportes(string menu)
        {
            InitializeComponent();
        }

        private void MenusReportes_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            estilo.frmMaterial(this);


            usumod.usuario = usuario;// "rfune3";
            usumod.dni = "Reportes";
            DataTable dataTable = usucon.getusuariomenu(usumod);


            int menuseleccionado = 0; // Declarar e inicializar fuera del evento
            int cuenta = 0;

            // Registra el manejador de eventos una vez, fuera del bucle
            materialTabControl1.SelectedIndexChanged += (s, args) =>
            {
                //  int menuseleccionado = Properties.Settings.Default.Opcmenu;

                // Obtiene la pestaña seleccionada
                if (materialTabControl1.SelectedTab != null)
                {
                    string tabPageName = materialTabControl1.SelectedTab.Name.Replace(" ", "");

                    // Lógica para abrir el formulario en función del tabPageName
                    if (tabPageName == "TabPage_MovDIario")
                    {
                        // Abre el formulario correspondiente al Nombre1
                        movdiariorpt form1 = new movdiariorpt();
                        form1.ShowDialog();
                    }
                    else if (tabPageName == "TabPage_MovCuentas")
                    {
                        // Abre el formulario correspondiente al Nombre2
                        MovCuentasfrmcs form2 = new MovCuentasfrmcs();
                        form2.ShowDialog();
                    }
                    else if (tabPageName == "TabPage_EstCuentaprov")
                    {
                        // Abre el formulario correspondiente al Nombre2.
                        // Por ejemplo:

                        estcuentaproveedor form2 = new estcuentaproveedor();
                        form2.ShowDialog();
                    }
              
                    else if (tabPageName == "TabPage_BalanceGeneral")
                    {
                        // Abre el formulario correspondiente al Nombre2.
                        // Por ejemplo:
                        balancegenfrm form2 = new balancegenfrm();
                        form2.ShowDialog();
                    }
                    else if (tabPageName == "TabPage_Estadoresultado")
                    {
                        // Abre el formulario correspondiente al Nombre2.
                        // Por ejemplo:
                        MovestadoCuentasfrm form2 = new MovestadoCuentasfrm();
                        form2.ShowDialog();
                    }
                  
                    menuseleccionado++;
                    // Agrega más casos según tus necesidades
                }

                // menuseleccionado = Properties.Settings.Default.Opcmenu = menuseleccionado + 1;

                //if (menuseleccionado > 1)
                //{
                //    Properties.Settings.Default.Opcmenu = 0;
                //    menuseleccionado = Properties.Settings.Default.Opcmenu;
                //}
            };


            foreach (DataRow menuItem in dataTable.Rows)
            {
                string nombreMenu = menuItem["Nombre"].ToString();
                string icono = menuItem["icono"].ToString();

                TabPage topLevelMenuItem = new TabPage(nombreMenu);
                topLevelMenuItem.ImageKey = icono;
                materialTabControl1.TabPages.Add(topLevelMenuItem);
                topLevelMenuItem.Name = "TabPage_" + nombreMenu;
                cuenta++;
                // return;

                if (dataTable.Rows.Count == cuenta)
                {
                    return;
                }

            }

        }
    }
}
