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

namespace OrdenaCuenta.View.Reportes
{
    public partial class movdiariorpt : MaterialForm
    {
        public movdiariorpt()
        {
            InitializeComponent();
        }


        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        Filtros filtrarls = new Filtros();
        string fecha = "";
        PartidaController partidaController = new PartidaController();
        Partida Partidamodel = new Partida();



        private void cargar()
        {

            Partidamodel.Fecha = Convert.ToDateTime( txtfecha.Text);
            Partidamodel.FechaCreacion = Convert.ToDateTime(txtfechafin.Text);  

            MaterialListView materialListView = partidaController.Getmovimientodiariopartidas(Partidamodel); // clacuenta.GetClasificacionCuenta();

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


        private void movdiariorpt_Load(object sender, EventArgs e)
        {

            lsrol.Columns.Add("id", 150); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("asiento", 150); // Agrega más columnas según tus necesidades.
            lsrol.Columns.Add("CuentaPar", 150); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("fechapartida", 150); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("cuentacontable", 200); // Agrega más columnas según tus necesidades.
            lsrol.Columns.Add("descripcion", 200); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("debe", 200); // Agrega más columnas según tus necesidades.
            lsrol.Columns.Add("haber", 200); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("Referencia", 200); // Agrega más columnas según tus necesidades.
            lsrol.Columns.Add("libro", 200); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("tippagcueid", 200); // Agrega más columnas según tus necesidades.
            lsrol.Columns.Add("fechaini", 150); // Nombre de la columna y ancho en píxeles.
            lsrol.Columns.Add("fechafin", 150); // Agrega más columnas según tus necesidades.


            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            estilo.frmMaterial(this);

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, lsrol);

        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            this.cargar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            monthCalendar1.BringToFront();

            monthCalendar1.Visible = true;
            monthCalendar1.Location = new System.Drawing.Point(
       txtfecha.Left,
       pictureBox1.Bottom
   );
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtfecha.Text = monthCalendar1.SelectionStart.ToShortDateString();
            // Ocultar el MonthCalendar después de la selección
            monthCalendar1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            monthCalendar2.BringToFront();

            monthCalendar2.Visible = true;
            monthCalendar2.Location = new System.Drawing.Point(
       txtfechafin.Left,
       pictureBox2.Bottom
         );

        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtfechafin.Text = monthCalendar2.SelectionStart.ToShortDateString();
            // Ocultar el MonthCalendar después de la selección
            monthCalendar2.Visible = false;
        }
    }
}
