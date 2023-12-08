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

namespace OrdenaCuenta.View.periodo
{
    public partial class periodoshowfrmcs : MaterialForm
    {

        PeriodoContableController periocon = new PeriodoContableController();
        PeriodoContableModel oeriodmo = new PeriodoContableModel();

        Filtros filtrarls = new Filtros();
        string usuario = Properties.Settings.Default.Usuario;
        string  id = "0";
    


      

        List<ListViewItem> elementosOriginales = new List<ListViewItem>();

        public periodoshowfrmcs()
        {
            InitializeComponent();
        }


        private void cargar()
        {

            MaterialListView materialListView = periocon.GetPeriodoContable(); // clacuenta.GetClasificacionCuenta();

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



        private void periodoshowfrmcs_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);

            lsclientes.Columns.Add("id", 150); // Nombre de la columna y ancho en píxeles.
            lsclientes.Columns.Add("tippagcueid", 200); // Nombre de la columna y ancho en píxeles.
            lsclientes.Columns.Add("Inicio", 150); // Agrega más columnas según tus necesidades.
            lsclientes.Columns.Add("Fin", 200); // Nombre de la columna y ancho en píxeles.
            lsclientes.Columns.Add("Pago", 200); // Agrega más columnas según tus necesidades.
            lsclientes.Columns.Add("Corte", 150); // Nombre de la columna y ancho en píxeles.
            lsclientes.Columns.Add("frecuencia", 200); // Agrega más columnas según tus necesidades.
            lsclientes.Columns.Add("mes", 200); // Nombre de la columna y ancho en píxeles.
            lsclientes.Columns.Add("Aniocontable", 250); // Nombre de la columna y ancho en píxeles.
            lsclientes.Columns.Add("estado", 250); // Nombre de la columna y ancho en píxeles.
            lsclientes.Columns.Add("fiscal ini", 250); // Nombre de la columna y ancho en píxeles.
            lsclientes.Columns.Add("fiscal fin", 250); // Nombre de la columna y ancho en píxeles.


            this.cargar();


        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            
                   PeriodoAdd frm = new PeriodoAdd();
            frm.ShowDialog();
            this.cargar();


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (id == "0")
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
                oeriodmo.Id = Convert.ToInt32(this.id);
                oeriodmo.UsuarioCreacion = usuario;
                periocon.eliminar(oeriodmo);
              //  clicon.eliminar(climod);
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

            filtrarls.Filtrarlistview(filtro, elementosOriginales, lsclientes);

        }

        private void lsclientes_Click(object sender, EventArgs e)
        {

       
            this.id = lsclientes.SelectedItems[0].Text;
          

        }

        private void lsclientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            if (id == "0")
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
                oeriodmo.Id = Convert.ToInt32(this.id);
                oeriodmo.UsuarioCreacion = usuario;
                periocon.cerrarperiodo(oeriodmo);
                //  clicon.eliminar(climod);
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
