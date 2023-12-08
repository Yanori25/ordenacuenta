using MaterialSkin.Controls;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;
using OrdenaCuenta.Utilities;
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

namespace OrdenaCuenta.View.HistoricoMoneda
{
    public partial class HistoricoMonedaaddfrm : MaterialForm
    {

        HistoricoMonedaController histmoncon = new HistoricoMonedaController();
        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        HistoricoMonedaModel hitmonmodel = new HistoricoMonedaModel();

        Filtros filtrarls = new Filtros();
        string id = "0";


        public HistoricoMonedaaddfrm()
        {
            InitializeComponent();
        }



        private void cargar()
        {

            MaterialListView materialListView = histmoncon.GetHistMoneda(); // clacuenta.GetClasificacionCuenta();

            // Declara una lista para almacenar todos los elementos originales.


            lshistmonedas.Items.Clear();
            elementosOriginales.Clear();



            //   matlistCuenta.Clear();
            foreach (ListViewItem item in materialListView.Items)
            {
                //   lsclientes.Items.Add(item.Clone() as ListViewItem);
                elementosOriginales.Add(item.Clone() as ListViewItem);
            }
            lshistmonedas.Items.AddRange(elementosOriginales.ToArray());
            materialListView.Clear();

            // Agrega todos los elementos originales al MaterialListView.


        }


        private void HistoricoMonedaaddfrm_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);

            lshistmonedas.Columns.Add("Id", 150); // Nombre de la columna y ancho en píxeles.
            lshistmonedas.Columns.Add("moneda", 200); // Nombre de la columna y ancho en píxeles.
            lshistmonedas.Columns.Add("Fecha", 200); // Agrega más columnas según tus necesidades.
            lshistmonedas.Columns.Add("Valor", 200); // Nombre de la columna y ancho en píxeles.
         
            this.cargar();

        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            HistoricoMonedashowfrm frm = new HistoricoMonedashowfrm();
            frm.ShowDialog();
            //  MaterialMessageBox.Show("Se agrego exitosamente");
            this.cargar();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, lshistmonedas);


        }

        private void lshistmonedas_Click(object sender, EventArgs e)
        {
            this.id = lshistmonedas.SelectedItems[0].Text;

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
                hitmonmodel.Id = Convert.ToInt32(this.id);
                hitmonmodel.usuariocreacion = Properties.Settings.Default.Usuario;
                histmoncon.eliminar(hitmonmodel);

                
                id = "0";
                this.cargar();
                //  MaterialMessageBox.Show("Se borro el registro exitosamente");
            }
            else
            {
                MaterialMessageBox.Show("No se borro el registro");
            }
        }
    }
}
