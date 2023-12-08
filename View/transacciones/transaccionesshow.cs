using MaterialSkin.Controls;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;
using OrdenaCuenta.Utilities;
using OrdenaCuenta.View.HistoricoMoneda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.View.transacciones
{
    public partial class transaccionesshow : MaterialForm
    {
        public transaccionesshow()
        {
            InitializeComponent();
        }

        tipoTransaccionesController tipotrancon = new tipoTransaccionesController();
        tipoTransaccionesModel tipoTransaccionesModel = new tipoTransaccionesModel();

        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        Filtros filtrarls = new Filtros();
        string id = "0";


        private void cargar()
        {

            MaterialListView materialListView = tipotrancon.Gettransacciones(); // clacuenta.GetClasificacionCuenta();

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


        private void transaccionesshow_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);

            lsmonedas.Columns.Add("id", 150); // Nombre de la columna y ancho en píxeles.
            lsmonedas.Columns.Add("descripcion", 200); // Nombre de la columna y ancho en píxeles.
            lsmonedas.Columns.Add("activo", 150); // Agrega más columnas según tus necesidades.
           
            this.cargar();
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            transaccionesAdd frm = new transaccionesAdd();
            frm.ShowDialog();
            //  MaterialMessageBox.Show("Se agrego exitosamente");
            this.cargar();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, lsmonedas);

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
                tipoTransaccionesModel.id = this.id;
               
                tipotrancon.eliminar(tipoTransaccionesModel);
                id = "0";
                this.cargar();
                //  MaterialMessageBox.Show("Se borro el registro exitosamente");
            }
            else
            {
                MaterialMessageBox.Show("No se borro el registro");
            }
        }

        private void lsmonedas_Click(object sender, EventArgs e)
        {
            this.id = lsmonedas.SelectedItems[0].Text;


        }
    }
}
