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
    public partial class usuariorolesShow : MaterialForm
    {
        public usuariorolesShow()
        {
            InitializeComponent();
        }

        usuariorolesController usurolcon = new usuariorolesController();
        usuariorolesModel usurolmod = new usuariorolesModel();

      
        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        Filtros filtrarls = new Filtros();
        string id = "0";



        private void cargar()
        {

            MaterialListView materialListView = usurolcon.Gettransacciones(); // clacuenta.GetClasificacionCuenta();

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

        private void usuariorolesShow_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);

            lsmonedas.Columns.Add("Id", 150); // Nombre de la columna y ancho en píxeles.
            lsmonedas.Columns.Add("usuario", 200); // Nombre de la columna y ancho en píxeles.
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
                usurolmod.ind = 2;
                usurolmod.id = Convert.ToInt64(this.id);
                usurolmod.usuid = 0;
                usurolmod.rolid = 0;
                usurolcon.Crear(usurolmod);

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

        private void btagregar_Click(object sender, EventArgs e)
        {
            usuariorolesAdd frm = new usuariorolesAdd();
            frm.ShowDialog();
            //  MaterialMessageBox.Show("Se agrego exitosamente");
            this.cargar();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, lsmonedas);
        }
    }
}
