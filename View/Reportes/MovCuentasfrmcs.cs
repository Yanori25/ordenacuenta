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

namespace OrdenaCuenta.View.Reportes
{
    public partial class MovCuentasfrmcs : MaterialForm
    {

        CuentaController cuentacon = new CuentaController();
        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        subcuentaController subcuecon = new subcuentaController();
        subcuentaModel subcuenmod = new subcuentaModel();
        string id = "0";
        string usuario = Properties.Settings.Default.Usuario;

        PartidaController partidaController = new PartidaController();

        Partida partidamodel = new Partida();


        List<ListViewItem> elementosOriginalescuenta = new List<ListViewItem>();


        Filtros filtrarls = new Filtros();

        public MovCuentasfrmcs()
        {
            InitializeComponent();
        }


        private void cargar()
        {

            MaterialListView materialListView = cuentacon.GetCuentaBuscador(); // clacuenta.GetClasificacionCuenta();

            // Declara una lista para almacenar todos los elementos originales.


            matlistCuenta.Items.Clear();
            elementosOriginales.Clear();



            //   matlistCuenta.Clear();
            foreach (ListViewItem item in materialListView.Items)
            {
                //   lsclientes.Items.Add(item.Clone() as ListViewItem);
                elementosOriginales.Add(item.Clone() as ListViewItem);
            }
            matlistCuenta.Items.AddRange(elementosOriginales.ToArray());
            materialListView.Clear();

            // Agrega todos los elementos originales al MaterialListView.


        }

        private void cargarcuenta()
        {

            partidamodel.Id = Convert.ToInt32(this.id);

            MaterialListView materialListView = partidaController.Getmovimientoscuentapartida(partidamodel); // clacuenta.GetClasificacionCuenta();

            // Declara una lista para almacenar todos los elementos originales.


            lsrol.Items.Clear();
            elementosOriginalescuenta.Clear();



            //   matlistCuenta.Clear();
            foreach (ListViewItem item in materialListView.Items)
            {
                //   lsclientes.Items.Add(item.Clone() as ListViewItem);
                elementosOriginalescuenta.Add(item.Clone() as ListViewItem);
            }
            lsrol.Items.AddRange(elementosOriginalescuenta.ToArray());
            materialListView.Clear();

            // Agrega todos los elementos originales al MaterialListView.


        }

        private void MovCuentasfrmcs_Load(object sender, EventArgs e)
        {

            lsrol.Columns.Add("id", 150); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("asiento", 150); // Agrega más columnas según tus necesidades.
            lsrol.Columns.Add("CuentaPar", 150); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("fechapartida", 150); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("cuentacontable", 200); // Agrega más columnas según tus necesidades.
            lsrol.Columns.Add("descripcion", 200); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("debe", 200); // Agrega más columnas según tus necesidades.
            lsrol.Columns.Add("haber", 200); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("Referencia", 200); // Agrega más columnas según tus necesidades.
            lsrol.Columns.Add("libro", 200); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("tippagcueid", 200); // Agrega más columnas según tus necesidades.
            lsrol.Columns.Add("fechaini", 150); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("fechafin", 150); // Agrega más columnas según tus necesidades.


            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            estilo.frmMaterial(this);

            this.cargar();
        }

        private void matlistCuenta_Click(object sender, EventArgs e)
        {

            this.id = matlistCuenta.SelectedItems[0].Text;
            this.cargarcuenta();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, matlistCuenta);
        }
    }
}
