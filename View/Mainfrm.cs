using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using OrdenaCuenta.Utilities;
using OrdenaCuenta.View;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;
using OrdenaCuenta.View.Menus;

namespace OrdenaCuenta
{
    // todo formulario debe heredar de material form para tomar su disenio 
    public partial class Mainfrm : MaterialForm 
    {
        private int childFormNumber = 0;

        UsuarioController usucon = new UsuarioController();
        UsuarioModel usumod = new UsuarioModel();
        string usuario = Properties.Settings.Default.Usuario;



        public Mainfrm( string rolusuario)
        {
            InitializeComponent();
            //  this.IsMdiContainer = true;

            // se llama la clase material para darle estilo al formulario la cual se encuentra en la carpeta utilidades
           
         
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //Mainfrm childForm = new Mainfrm();
            //childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            //childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {

            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            estilo.frmMaterial(this);


            usumod.usuario = usuario; // "rfune3";
            usumod.dni = "Padre";
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
                    if (tabPageName == "TabPage_Inicio")
                    {
                        // Abre el formulario correspondiente al Nombre1
                        Partidafrm form1 = new Partidafrm();
                        form1.ShowDialog();
                    }
                    else if (tabPageName == "TabPage_Contabilidad")
                    {
                        // Abre el formulario correspondiente al Nombre2
                        MenuContabilidadcs form2 = new MenuContabilidadcs();
                        form2.ShowDialog();
                    }
                    else if (tabPageName == "TabPage_Mantenimientos")
                    {
                        // Abre el formulario correspondiente al Nombre2.
                        // Por ejemplo:
                        MenuMantenimientos form2 = new MenuMantenimientos();
                        form2.ShowDialog();
                    }
                    else if (tabPageName == "TabPage_Clientes")
                    {
                        // Abre el formulario correspondiente al Nombre2.
                        // Por ejemplo:
                        MenuCliente form2 = new MenuCliente();
                        form2.ShowDialog();
                    }
                    else if (tabPageName == "TabPage_Proveedores" )
                    {
                        // Abre el formulario correspondiente al Nombre2.
                        // Por ejemplo:
                        MenuProveedor form2 = new MenuProveedor();
                        form2.ShowDialog();
                    }
                    else if (tabPageName == "TabPage_Seguridad" )
                    {
                        // Abre el formulario correspondiente al Nombre2.
                        // Por ejemplo:
                        MenuSeguridad form2 = new MenuSeguridad();
                        form2.ShowDialog();
                    }
                    else if (tabPageName == "TabPage_Reportes" )
                    {
                        // Abre el formulario correspondiente al Nombre2.
                        // Por ejemplo:
                       MenusReportes form2 = new MenusReportes("Reportes");
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
          
           


            /*
            usumod.usuario = "rfune3";

            DataTable dataTable =  usucon.getusuariomenu(usumod);
            

            foreach (DataRow menuItem in dataTable.Rows)
            {
                string nombreMenu = menuItem["Nombre"].ToString(); // Reemplaza "NombreMenu" con el nombre real de la columna.
                string icono  = menuItem["icono"].ToString(); // Reemplaza "NombreMenu" con el nombre real de la columna.
               


                TabPage topLevelMenuItem = new TabPage(nombreMenu);
               topLevelMenuItem.ImageKey = icono;
              materialTabControl1.TabPages.Add(topLevelMenuItem);

                  topLevelMenuItem.Name = "TabPage_" + nombreMenu;
                materialTabControl1.SelectedIndexChanged += (s, args) =>
                {

                    int menuseleccionado = Properties.Settings.Default.Opcmenu;


                    // Obtiene la pestaña seleccionada.
                    if (materialTabControl1.SelectedTab != null)
                    {
                        string tabPageName = materialTabControl1.SelectedTab.Name.Replace(" ", "");
                    
                        // Lógica para abrir el formulario en función del tabPageName.
                        if (tabPageName == "TabPage_Inicio"  && menuseleccionado == 0)
                        {
                            // Abre el formulario correspondiente al Nombre1.
                            // Por ejemplo:
                            Partidafrm form1 = new Partidafrm();
                            form1.ShowDialog();

                                
                    
                        }
                        else if (tabPageName == "TabPage_Contabilidad" && menuseleccionado == 0 )
                        {
                            // Abre el formulario correspondiente al Nombre2.
                            // Por ejemplo:
                            MenuContabilidadcs form2 = new MenuContabilidadcs();
                            form2.ShowDialog();
                        }
                        else if (tabPageName == "TabPage_Mantenimientos" && menuseleccionado == 0)
                        {
                            // Abre el formulario correspondiente al Nombre2.
                            // Por ejemplo:
                            MenuMantenimientos form2 = new MenuMantenimientos();
                            form2.ShowDialog();
                        }
                        else if (tabPageName == "TabPage_Clientes" && menuseleccionado == 0)
                        {
                            // Abre el formulario correspondiente al Nombre2.
                            // Por ejemplo:
                            MenuCliente form2 = new MenuCliente();
                            form2.ShowDialog();
                        }
                        else if (tabPageName == "TabPage_Proveedores" && menuseleccionado == 0)
                        {
                            // Abre el formulario correspondiente al Nombre2.
                            // Por ejemplo:
                            MenuProveedor form2 = new MenuProveedor();
                            form2.ShowDialog();
                        }
                        else if (tabPageName == "TabPage_Seguridad" && menuseleccionado == 0)
                        {
                            // Abre el formulario correspondiente al Nombre2.
                            // Por ejemplo:
                            MenuSeguridad form2  =new MenuSeguridad();
                            form2.ShowDialog();
                        }
                        else if (tabPageName == "TabPage_Reportes" && menuseleccionado == 0)
                        {
                            // Abre el formulario correspondiente al Nombre2.
                            // Por ejemplo:
                            MenusReportes form2 = new MenusReportes();
                            form2.ShowDialog();
                        }

                        // Agrega más casos según tus necesidades.
                    }
                    menuseleccionado = Properties.Settings.Default.Opcmenu = menuseleccionado + 1;

                    if (menuseleccionado > 1)
                    {
                        Properties.Settings.Default.Opcmenu = 0;
                        menuseleccionado = Properties.Settings.Default.Opcmenu;
                    }
                    //else
                    //{
                    //    materialTabControl1.SelectedTab = null;
                    //    return;
                    //}

                    //materialTabControl1.SelectedTab = null;
                    //return;


                    // materialTabControl1.SelectedIndex = -1;
                };
               


            }*/



        }

        private void AbrirFormularioSecundario(Form formularioSecundario, string tituloPestaña )
        {

            TabPage tabPage = new TabPage(tituloPestaña);
            formularioSecundario.TopLevel = false;
            formularioSecundario.FormBorderStyle = FormBorderStyle.None;
            formularioSecundario.Dock = DockStyle.Fill;

            tabPage.Controls.Add(formularioSecundario);
            materialTabControl1.TabPages.Add(tabPage);

            formularioSecundario.Show();


        }



        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  switch (materialTabControl1.SelectedIndex)
            {
                case 0: // Índice de la primera pestaña
                    Cuentasfrm form1 = new Cuentasfrm(); // Reemplaza Form1 con el nombre de tu formulario               
                    form1.Show();
                    break;
                case 1: // Índice de la segunda pestaña

                    Form1 forms = new Form1();

                    AbrirFormularioSecundario(forms , "tabPage2");

                    break;
                    // Agrega más casos para otras pestañas si es necesario
            }*/
        }
    }
}
