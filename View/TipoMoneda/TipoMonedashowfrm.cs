using MaterialSkin.Controls;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;
using OrdenaCuenta.Utilities;
using OrdenaCuenta.View.HistoricoMoneda;
using OrdenaCuenta.View.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.View.TipoMoneda
{
    public partial class TipoMonedashowfrm : MaterialForm
    {
         TipoMonedaController moncon = new TipoMonedaController();
        TipoMonedaModel monedaModel = new TipoMonedaModel();
        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        Filtros filtrarls = new Filtros();
        string id = "0";



        public TipoMonedashowfrm()
        {
            InitializeComponent();
        }

        private void cargar()
        {

            MaterialListView materialListView = moncon.ShowTipoMoneda(); // clacuenta.GetClasificacionCuenta();

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



        private void TipoMonedashowfrm_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);

            lsmonedas.Columns.Add("Id", 150); // Nombre de la columna y ancho en píxeles.
            lsmonedas.Columns.Add("Descripcion", 200); // Nombre de la columna y ancho en píxeles.
            lsmonedas.Columns.Add("Simbolo", 150); // Agrega más columnas según tus necesidades.
            lsmonedas.Columns.Add("PaisIsob", 200); // Nombre de la columna y ancho en píxeles.
            lsmonedas.Columns.Add("PaisIsoc", 200); // Agrega más columnas según tus necesidades.
            lsmonedas.Columns.Add("Moneda", 150); // Nombre de la columna y ancho en píxeles.
         
            this.cargar();


        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            TipoMonedaaddfrm frm = new TipoMonedaaddfrm();
            frm.ShowDialog();
            //  MaterialMessageBox.Show("Se agrego exitosamente");
            this.cargar();

        }

        private void lsmonedas_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void lsmonedas_Click(object sender, EventArgs e)
        {
            this.id = lsmonedas.SelectedItems[0].Text;


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
                monedaModel.Id = Convert.ToInt32(this.id);
                monedaModel.usuariocreacion = Properties.Settings.Default.Usuario;
                moncon.eliminar(monedaModel);

                id = "0";
                this.cargar();
                //  MaterialMessageBox.Show("Se borro el registro exitosamente");
            }
            else
            {
                MaterialMessageBox.Show("No se borro el registro");
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lsmonedas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {

        }
    }
}
