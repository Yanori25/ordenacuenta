using MaterialSkin.Controls;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;
using OrdenaCuenta.Utilities;
using OrdenaCuenta.View.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.View.Rolfrm
{
    public partial class Rolshow : MaterialForm
    {
        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        RolController rolcon = new  RolController();
        RolModel rolmod = new RolModel();

        Filtros filtrarls = new Filtros();
        string id = "0";



        public Rolshow()
        {
            InitializeComponent();
        }

        private void cargar()
        {

            MaterialListView materialListView = rolcon.GetRol(); // clacuenta.GetClasificacionCuenta();

            // Declara una lista para almacenar todos los elementos originales.


            lsrol.Items.Clear();
            elementosOriginales.Clear();



            //   matlistCuenta.Clear();
            foreach (ListViewItem item in materialListView.Items)
            {
                //   lsclientes.Items.Add(item.Clone() as ListViewItem);
                elementosOriginales.Add(item.Clone() as ListViewItem);
            }
            lsrol.Items.AddRange(elementosOriginales.ToArray());
            materialListView.Clear();

            // Agrega todos los elementos originales al MaterialListView.


        }


        private void Rolshow_Load(object sender, EventArgs e)
        {
            lsrol.Columns.Add("id", 150); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("descripcion", 200); // Agrega más columnas según tus necesidades.



            this.cargar();


            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);
          

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, lsrol);




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
                rolmod.rolid = Convert.ToInt32(this.id);
                rolcon.eliminar(rolmod);
                id = "0";
                this.cargar();
                //  MaterialMessageBox.Show("Se borro el registro exitosamente");
            }
            else
            {
                MaterialMessageBox.Show("No se borro el registro");
            }


        }

        private void lsrol_Click(object sender, EventArgs e)
        {
            this.id = lsrol.SelectedItems[0].Text;
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            RolAdd frm = new RolAdd();
            frm.ShowDialog();
            MaterialMessageBox.Show("Se agrego exitosamente");
            this.cargar();
        }
    }
}
