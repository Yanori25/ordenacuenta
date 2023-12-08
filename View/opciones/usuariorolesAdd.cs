using MaterialSkin.Controls;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;
using OrdenaCuenta.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.View.opciones
{
    public partial class usuariorolesAdd : MaterialForm
    {
        public usuariorolesAdd()
        {
            InitializeComponent();
        }

        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        RolController rolcon = new RolController();
        RolModel rolmod = new RolModel();

        Filtros filtrarls = new Filtros();
        string id = "0";

        string idusuario = "0";
        List<ListViewItem> elementosOriginalesusuario = new List<ListViewItem>();
        UsuarioController usercont = new UsuarioController();
        UsuarioModel usermod = new UsuarioModel();

        usuariorolesController usurolcon = new usuariorolesController();
        usuariorolesModel usurolmod = new usuariorolesModel();



        private void cargarusuario()
        {

            MaterialListView materialListView = usercont.GetbuscadorUsuario(); // clacuenta.GetClasificacionCuenta();

            // Declara una lista para almacenar todos los elementos originales.


            lsusuarios.Items.Clear();
            elementosOriginalesusuario.Clear();



            //   matlistCuenta.Clear();
            foreach (ListViewItem item in materialListView.Items)
            {
                //   lsclientes.Items.Add(item.Clone() as ListViewItem);
                elementosOriginalesusuario.Add(item.Clone() as ListViewItem);
            }
            lsusuarios.Items.AddRange(elementosOriginalesusuario.ToArray());
            materialListView.Clear();

            // Agrega todos los elementos originales al MaterialListView.


        }


        private void cargar()
        {

            MaterialListView materialListView = rolcon.GetRol(); // clacuenta.GetClasificacionCuenta();

            // Declara una lista para almacenar todos los elementos originales.


            lsrol.Items.Clear();
            elementosOriginales.Clear();



            //   matlistCuenta.Clear();
            foreach (ListViewItem item in materialListView.Items)
            {
                //   lsclientes.Items.Add(item.Clone() as ListViewItem);
                elementosOriginales.Add(item.Clone() as ListViewItem);
            }
            lsrol.Items.AddRange(elementosOriginales.ToArray());
            materialListView.Clear();

            // Agrega todos los elementos originales al MaterialListView.


        }


        private void usuariorolesAdd_Load(object sender, EventArgs e)
        {
            lsrol.Columns.Add("id", 150); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("descripcion", 200); // Agrega más columnas según tus necesidades.

            lsusuarios.Columns.Add("id", 150); // Nombre de la columna y ancho en píxeles.
            lsusuarios.Columns.Add("usuario", 200); // Agrega más columnas según tus necesidades.
            lsusuarios.Columns.Add("nombre", 200); // Agrega más columnas según tus necesidades.
          




            this.cargar();
            this.cargarusuario();

            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);


        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, lsrol);

        }

        private void lsrol_Click(object sender, EventArgs e)
        {
            this.id = lsrol.SelectedItems[0].Text;
        }

        private void lsusuarios_Click(object sender, EventArgs e)
        {
            this.idusuario = lsusuarios.SelectedItems[0].Text;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (this.id == "0" || this.idusuario == "0")
            {
                MaterialMessageBox.Show("Debe seleccionar un registro");
                return;
            }

            usurolmod.ind = 1;
            usurolmod.id = 0;
            usurolmod.usuid = Convert.ToInt64(this.idusuario);
            usurolmod.rolid = Convert.ToInt64(this.id);
            usurolcon.Crear(usurolmod);


            this.Close();

        }

        private void txtbuscarusu_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtbuscarusu.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginalesusuario, lsusuarios);
        }
    }
}
