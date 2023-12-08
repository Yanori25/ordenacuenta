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
using MaterialSkin.Controls;


namespace OrdenaCuenta.View.Cuentas
{
    public partial class SubcuentasAdd : MaterialForm
    {
        CuentaController cuentacon = new CuentaController();
        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        subcuentaController subcuecon = new subcuentaController();
        subcuentaModel subcuenmod = new subcuentaModel();
        string id = "0";
        string usuario = Properties.Settings.Default.Usuario;




        Filtros filtrarls = new Filtros();

        public SubcuentasAdd( string operacion)
        {
            InitializeComponent();
            this.txtdescripcion.Text = operacion;

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




        private void SubcuentasAdd_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);
            // this.refrescar();
            this.cargar();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void txtnombre_TextChanged_1(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, matlistCuenta);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int idsubcuenta = 0;

            if(this.id == "0" || txtdescripcion.Text == "" || txtcuenta.Text == "")
            {
                MaterialMessageBox.Show("se deben llenar los campos obligatorio");

                return;
            }
            subcuenmod.CuentaId = Convert.ToInt32( this.id);
            subcuenmod.Descripcion = txtdescripcion.Text;
            subcuenmod.Cuentacontablesub = txtcuenta.Text;
            subcuenmod.SubCueIdEmpresa = 3;
            subcuenmod.usuariocreacion = usuario ;


            subcuecon.Crear(subcuenmod);
            idsubcuenta = subcuecon.getsubcuentashowid(subcuenmod);
            Properties.Settings.Default.idsubcuenta = idsubcuenta;
            Properties.Settings.Default.subcuentacod = txtcuenta.Text;

            this.Close();

        }

        private void matlistCuenta_Click(object sender, EventArgs e)
        {

        }

        private void matlistCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.id = matlistCuenta.SelectedItems[0].Text;
        }
    }
}
