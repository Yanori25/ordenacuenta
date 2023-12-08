using MaterialSkin.Controls;
using OfficeOpenXml;
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
using OfficeOpenXml;
using ClosedXML.Excel;


namespace OrdenaCuenta.View.Reportes
{
    public partial class estcuentaproveedor : MaterialForm
    {
        public estcuentaproveedor()
        {
            InitializeComponent();
        }

        ProveedoresController proveecon = new ProveedoresController();
        ProveedoresModel promod= new ProveedoresModel();
        exportaexcel expexcel = new exportaexcel();
        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        Filtros filtrarls = new Filtros();

        string  id = "0";
        int ind = 0;


        private void cargar()
        {

            MaterialListView materialListView = proveecon.GetProveedorBuscador(); // clacuenta.GetClasificacionCuenta();

            // Declara una lista para almacenar todos los elementos originales.


            lsclientes.Items.Clear();
            elementosOriginales.Clear();



            //   matlistCuenta.Clear();
            foreach (ListViewItem item in materialListView.Items)
            {
                //   lsclientes.Items.Add(item.Clone() as ListViewItem);
                elementosOriginales.Add(item.Clone() as ListViewItem);
            }
            lsclientes.Items.AddRange(elementosOriginales.ToArray());
            materialListView.Clear();

            // Agrega todos los elementos originales al MaterialListView.


        }

        private void estcuentaproveedor_Load(object sender, EventArgs e)
        {

            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            estilo.frmMaterial(this);
            swinaturaleza.Checked = false;
            swinaturaleza.Text = "Seleccione Proveedor";
            this.cargar();

        }

        private void btagregar_Click(object sender, EventArgs e)
        {

            if (txtruta.Text == "")
            {
                MaterialMessageBox.Show("se debe colocar un nombre al archivo");
                return;
            }
            DataTable resultado = proveecon.Getestadocuentaproveedores(this.ind, Convert.ToInt32(this.id) );
            this.expexcel.ExportarDataTableAExcel(resultado, "C:\\Users\\Yanori Osorto\\Desktop\\ordenareportes\\" + txtruta.Text  +".xlsx", "ESTADO CUENTAS PROVEEDORES");
            // ExportarAExcel(resultado, "estadocuentaproveedor.xlsx");
            txtruta.Text = "";

        }


        private void txtruta_TextChanged(object sender, EventArgs e)
        {

        }

        private void swinaturaleza_CheckedChanged(object sender, EventArgs e)
        {
            if (swinaturaleza.Checked == true)
            {
                swinaturaleza.Text = "Todos Proveedores";
                this.ind = 1;


            }
            else
            {
                swinaturaleza.Text = "Seleccione Proveedor";
                this.ind = 0;

            }
        }

        private void lsclientes_Click(object sender, EventArgs e)
        {
            this.id = lsclientes.SelectedItems[0].Text;
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, lsclientes);
        }
    }
}
