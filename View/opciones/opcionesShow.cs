using MaterialSkin.Controls;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;
using OrdenaCuenta.Utilities;
using OrdenaCuenta.View.transacciones;
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
    public partial class opcionesShow : MaterialForm
    {

        opcionesController opcionesController= new opcionesController();
        opcionesmodel opcmodel = new opcionesmodel();
        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        Filtros filtrarls = new Filtros();
        string id = "0";





        public opcionesShow()
        {
            InitializeComponent();
        }


        private void cargar()
        {

            MaterialListView materialListView = opcionesController.Gettransacciones(); // clacuenta.GetClasificacionCuenta();

            // Declara una lista para almacenar todos los elementos originales.


            lsmonedas.Items.Clear();
            elementosOriginales.Clear();



            //   matlistCuenta.Clear();
            foreach (ListViewItem item in materialListView.Items)
            {
                //   lsclientes.Items.Add(item.Clone() as ListViewItem);
                elementosOriginales.Add(item.Clone() as ListViewItem);
            }
            lsmonedas.Items.AddRange(elementosOriginales.ToArray());
            materialListView.Clear();

            // Agrega todos los elementos originales al MaterialListView.


        }



        private void opcionesShow_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);

            lsmonedas.Columns.Add("Id", 150); // Nombre de la columna y ancho en píxeles.
            lsmonedas.Columns.Add("Nombre", 200); // Nombre de la columna y ancho en píxeles.
            lsmonedas.Columns.Add("Nivel", 150); // Agrega más columnas según tus necesidades.
            lsmonedas.Columns.Add("icono", 300); // Agrega más columnas según tus necesidades.

            lsmonedas.Columns.Add("rutafrm", 200); // Agrega más columnas según tus necesidades.



            this.cargar();

        }

        private void btagregar_Click(object sender, EventArgs e)
        {

            opcionesAdd frm = new opcionesAdd();
            frm.ShowDialog();
            //  MaterialMessageBox.Show("Se agrego exitosamente");
            this.cargar();

          

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (this.id == "0")
            {
                MaterialMessageBox.Show("Debe seleccionar un registro");
                return;
            }


            MesanjeSioNo frm = new MesanjeSioNo();
            //  frm.Show();

            DialogResult resultado = frm.ShowDialog();

            string respuesta = Properties.Settings.Default.RespuestaMensaje;

            if (respuesta == "SI")
            {
                opcmodel.ind = 2;
                opcmodel.id = Convert.ToInt32(this.id);
                opcmodel.Nombre = "";
                opcmodel.Nivel = "";
                opcmodel.icono = "";
                opcmodel.rutafrm = "";
                opcmodel.OpcionPadre = 0;

                opcionesController.Crear(opcmodel);
                id = "0";
                this.cargar();
                //  MaterialMessageBox.Show("Se borro el registro exitosamente");
            }
            else
            {
                MaterialMessageBox.Show("No se borro el registro");
            }


        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, lsmonedas);
        }

        private void lsmonedas_Click(object sender, EventArgs e)
        {
            this.id = lsmonedas.SelectedItems[0].Text;

        }

        private void lsmonedas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
