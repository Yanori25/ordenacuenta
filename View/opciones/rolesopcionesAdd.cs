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
    public partial class rolesopcionesAdd : MaterialForm
    {

        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        RolController rolcon = new RolController();
        RolModel rolmod = new RolModel();

        Filtros filtrarls = new Filtros();
        string id = "0";


        opcionesController opcionesController = new opcionesController();
        opcionesmodel opcmodel = new opcionesmodel();
        List<ListViewItem> elementosOriginalesopcion = new List<ListViewItem>();
   
        string idopcion = "0";

        rolesopcionesController rolopccon = new rolesopcionesController();
        rolesopcionesModel rolopcmod = new rolesopcionesModel();



        public rolesopcionesAdd()
        {
            InitializeComponent();
        }

        private void cargaropciones()
        {

            MaterialListView materialListView = opcionesController.Getopcbuscador(); // clacuenta.GetClasificacionCuenta();

            // Declara una lista para almacenar todos los elementos originales.


            lsusuarios.Items.Clear();
            elementosOriginalesopcion.Clear();



            //   matlistCuenta.Clear();
            foreach (ListViewItem item in materialListView.Items)
            {
                //   lsclientes.Items.Add(item.Clone() as ListViewItem);
                elementosOriginalesopcion.Add(item.Clone() as ListViewItem);
            }
            lsusuarios.Items.AddRange(elementosOriginalesopcion.ToArray());
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


        private void rolesopcionesAdd_Load(object sender, EventArgs e)
        {
            lsrol.Columns.Add("id", 150); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("descripcion", 200); // Agrega más columnas según tus necesidades.

            lsusuarios.Columns.Add("id", 150); // Nombre de la columna y ancho en píxeles.
            lsusuarios.Columns.Add("Nombre", 200); // Agrega más columnas según tus necesidades.
            lsusuarios.Columns.Add("descripcion", 200); // Agrega más columnas según tus necesidades.





            this.cargar();
            this.cargaropciones();

            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);

           

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (this.id == "0" || this.idopcion == "0")
            {
                MaterialMessageBox.Show("Debe seleccionar un registro");
                return;
            }

            rolopcmod.ind = 1;
            rolopcmod.id = 0;
            rolopcmod.usuid = Convert.ToInt64(this.idopcion);
            rolopcmod.rolid = Convert.ToInt64(this.id);
            rolopccon.Crear(rolopcmod);


            this.id = "0";
            this.idopcion = "0";
            this.Close();
          


        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, lsrol);
        }

        private void txtbuscarusu_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginalesopcion, lsusuarios);
        }

        private void lsrol_Click(object sender, EventArgs e)
        {
            this.id = lsrol.SelectedItems[0].Text;
        }

        private void lsusuarios_Click(object sender, EventArgs e)
        {
            this.idopcion = lsusuarios.SelectedItems[0].Text;
        }
    }
}
