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
    public partial class rolesopcionesShow : MaterialForm
    {
        public rolesopcionesShow()
        {
            InitializeComponent();
        }

        rolesopcionesController rolopccon = new rolesopcionesController();
        rolesopcionesModel rolopcmod = new rolesopcionesModel();


        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        Filtros filtrarls = new Filtros();
        string id = "0";



        private void cargar()
        {

            MaterialListView materialListView = rolopccon.Gettransacciones(); // clacuenta.GetClasificacionCuenta();

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


        private void rolesopcionesShow_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);

            lsmonedas.Columns.Add("Id", 150); // Nombre de la columna y ancho en píxeles.
            lsmonedas.Columns.Add("Nombre", 250); // Nombre de la columna y ancho en píxeles.
            lsmonedas.Columns.Add("descripcion", 200); // Agrega más columnas según tus necesidades.



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
                rolopcmod.ind = 2;
                rolopcmod.id = Convert.ToInt64(this.id);
                rolopcmod.usuid = 0;
                rolopcmod.rolid = 0;
                rolopccon.Crear(rolopcmod);

                id = "0";
                this.cargar();
                //  MaterialMessageBox.Show("Se borro el registro exitosamente");
            }
            else
            {
                MaterialMessageBox.Show("No se borro el registro");
            }
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            rolesopcionesAdd frm = new rolesopcionesAdd();
            frm.ShowDialog();
            //  MaterialMessageBox.Show("Se agrego exitosamente");
            this.cargar();
        }

        private void lsmonedas_Click(object sender, EventArgs e)
        {
            this.id = lsmonedas.SelectedItems[0].Text;
        }
    }
}
