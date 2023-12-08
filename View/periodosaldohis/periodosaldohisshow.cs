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

namespace OrdenaCuenta.View.periodosaldohis
{
    public partial class periodosaldohisshow : MaterialForm
    {


        PeriodoContableController periocon = new PeriodoContableController();
        PeriodoContableModel oeriodmo = new PeriodoContableModel();

        periodosaldohisController periodosalcon = new periodosaldohisController();
        periodosaldohisModel periodohismodel = new periodosaldohisModel();


        Filtros filtrarls = new Filtros();
        string usuario = Properties.Settings.Default.Usuario;
        string id = "0";

        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        List<ListViewItem> elementosorigsaldos = new List<ListViewItem>();


        public periodosaldohisshow()
        {
            InitializeComponent();
        }

        private void cargarhistorico( int  periodo)
        {

            MaterialListView materialListView = periodosalcon.Getsaldoperiodo(periodo); // clacuenta.GetClasificacionCuenta();

            // Declara una lista para almacenar todos los elementos originales.


            lsproveedores.Items.Clear();
            elementosorigsaldos.Clear();



            //   matlistCuenta.Clear();
            foreach (ListViewItem item in materialListView.Items)
            {
                //   lsclientes.Items.Add(item.Clone() as ListViewItem);
                elementosorigsaldos.Add(item.Clone() as ListViewItem);
            }
            lsproveedores.Items.AddRange(elementosorigsaldos.ToArray());
            materialListView.Clear();

            // Agrega todos los elementos originales al MaterialListView.


        }


        private void cargar()
        {

            MaterialListView materialListView = periocon.GetPeriodoContabletodos(); // clacuenta.GetClasificacionCuenta();

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


        private void periodosaldohisshow_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);

            lsclientes.Columns.Add("Id", 150); // Nombre de la columna y ancho en píxeles.
            lsclientes.Columns.Add("tippagcueid", 200); // Nombre de la columna y ancho en píxeles.
            lsclientes.Columns.Add("Inicio", 150); // Agrega más columnas según tus necesidades.
            lsclientes.Columns.Add("Fin", 200); // Nombre de la columna y ancho en píxeles.
            lsclientes.Columns.Add("Pago", 200); // Agrega más columnas según tus necesidades.
            lsclientes.Columns.Add("Corte", 150); // Nombre de la columna y ancho en píxeles.
            lsclientes.Columns.Add("frecuencia", 200); // Agrega más columnas según tus necesidades.
            lsclientes.Columns.Add("mes", 200); // Nombre de la columna y ancho en píxeles.
            lsclientes.Columns.Add("Aniocontable", 250); // Nombre de la columna y ancho en píxeles.
            lsclientes.Columns.Add("estado", 250); // Nombre de la columna y ancho en píxeles.


            lsproveedores.Columns.Add("id", 150); // Nombre de la columna y ancho en píxeles.
            lsproveedores.Columns.Add("cuentaid", 200); // Nombre de la columna y ancho en píxeles.
            lsproveedores.Columns.Add("cuenta contable", 150); // Agrega más columnas según tus necesidades.
            lsproveedores.Columns.Add("descripcion", 200); // Nombre de la columna y ancho en píxeles.
            lsproveedores.Columns.Add("saldo cuenta", 200);


            this.cargar();

            

        }

        private void txtperiodo_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, lsclientes);

        }

        private void lsclientes_Click(object sender, EventArgs e)
        {
            this.id = lsclientes.SelectedItems[0].Text;
            this.cargarhistorico( Convert.ToInt32(this.id));
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosorigsaldos, lsproveedores);
        }
    }
}
