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
    public partial class balancegenfrm : MaterialForm
    {
        public balancegenfrm()
        {
            InitializeComponent();
        }
        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        Filtros filtrarls = new Filtros();
        string fecha = "";
        PartidaController partidaController = new PartidaController();
        Partida Partidamodel = new Partida();
        exportaexcel expexcel = new exportaexcel();




        private void balancegenfrm_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            estilo.frmMaterial(this);

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

        private void monthCalendar1_DockChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtfecha.Text = monthCalendar1.SelectionStart.ToShortDateString();
            // Ocultar el MonthCalendar después de la selección
            monthCalendar1.Visible = false;
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            DateTime fechaini = Convert.ToDateTime(txtfecha.Text);
            DateTime fechafin = Convert.ToDateTime(txtfechafin.Text);


            if (txtruta.Text == "")
            {
                MaterialMessageBox.Show("se debe colocar un nombre al archivo");
                return;
            }

            if (txtfecha.Text == "" && txtfechafin.Text == "")
            {
                MaterialMessageBox.Show("se debe colocar las fechas");
                return;
            }

            Partidamodel.Fecha = Convert.ToDateTime(txtfecha.Text);
            Partidamodel.FechaCreacion = Convert.ToDateTime(txtfechafin.Text);
            DataTable resultado = partidaController.Getbalancegeneralrpt(fechaini, fechafin);
     //   C: \Users\Yanori Osorto\Desktop\ordenareportes
 this.expexcel.ExportarDataTableAExcel(resultado, "C:\\Users\\Yanori Osorto\\Desktop\\ordenareportes\\" + txtruta.Text + ".xlsx", "BALANCE GENERAL");

            // this.expexcel.ExportarDataTableAExcel(resultado, "C:\\Users\\rfune3\\OneDrive - Fruit of the Loom\\Desktop\\ordenacuenta\\estadocuentaproveedor\\" + txtruta.Text + ".xlsx", "BALANCE GENERAL");
            // ExportarAExcel(resultado, "estadocuentaproveedor.xlsx");
            txtruta.Text = "";
        }
    }
}
