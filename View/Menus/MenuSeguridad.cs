using MaterialSkin.Controls;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;
using OrdenaCuenta.Utilities;
using OrdenaCuenta.View.opciones;
using OrdenaCuenta.View.Rolfrm;
using OrdenaCuenta.View.Usuariofrm;
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
    public partial class MenuSeguridad : MaterialForm
    {
        public MenuSeguridad()
        {
            InitializeComponent();
        }
        UsuarioController usucon = new UsuarioController();
        UsuarioModel usumod = new UsuarioModel();
        string usuario = Properties.Settings.Default.Usuario;



        private void MenuSeguridad_Load(object sender, EventArgs e)
        {

            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            estilo.frmMaterial(this);


            usumod.usuario = usuario; // "rfune3";
            usumod.dni = "Seguridad";
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
                    if (tabPageName == "TabPage_Roles")
                    {
                        // Abre el formulario correspondiente al Nombre1
                        Rolshow form1 = new Rolshow();
                        form1.ShowDialog();
                    }
                    else if (tabPageName == "TabPage_Usuarios")
                    {
                        // Abre el formulario correspondiente al Nombre2
                        UsuarioShow form2 = new UsuarioShow();
                        form2.ShowDialog();
                    }
                    else if (tabPageName == "TabPage_opciones")
                    {
                        // Abre el formulario correspondiente al Nombre2.
                        // Por ejemplo:
                        opcionesShow form2 = new opcionesShow();
                        form2.ShowDialog();
                    }
                    else if (tabPageName == "TabPage_rolopciones")
                    {
                        // Abre el formulario correspondiente al Nombre2.
                        // Por ejemplo:
                        rolesopcionesShow form2 = new rolesopcionesShow();
                        form2.ShowDialog();
                    }
                    else if (tabPageName == "TabPage_usuariorol")
                    {
                        // Abre el formulario correspondiente al Nombre2.
                        // Por ejemplo:
                        usuariorolesShow form2 = new usuariorolesShow();
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
