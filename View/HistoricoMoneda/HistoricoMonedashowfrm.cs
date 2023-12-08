using MaterialSkin.Controls;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;
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
    public partial class HistoricoMonedashowfrm : MaterialForm
    {
        TipoMonedaController mon = new TipoMonedaController();
        HistoricoMonedaController histcont = new HistoricoMonedaController();
        HistoricoMonedaModel histmod = new HistoricoMonedaModel();
        string usuario = Properties.Settings.Default.Usuario; 





        public HistoricoMonedashowfrm()
        {
            InitializeComponent();
        }
        private void cargarcombos()
        {


            cmbmoneda.DataSource = mon.GetipoMoneda();
            cmbmoneda.DisplayMember = "Descripcion";
            cmbmoneda.ValueMember = "Id";


        }


        private void HistoricoMonedashowfrm_Load(object sender, EventArgs e)
        {
            this.cargarcombos();
        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprimir la entrada
                e.Handled = true;
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtm_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtsimbolo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmonto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprimir la entrada
                e.Handled = true;
            }
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
            // Actualizar el TextBox con la fecha seleccionada
            txtfecha.Text = monthCalendar1.SelectionStart.ToShortDateString();
            // Ocultar el MonthCalendar después de la selección
            monthCalendar1.Visible = false;

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
          
            if (txtmonto.Text == "" || txtfecha.Text == ""  )
            {
                MaterialMessageBox.Show("Debse llenar los campos requeridos");
                return;

            }

           
            histmod.Fecha= Convert.ToDateTime(txtfecha.Text);
           
            histmod.Valor = Convert.ToDecimal(txtmonto.Text);
            histmod.HistMon = Convert.ToInt32(cmbmoneda.SelectedValue);
            histmod.HistMonEmpresa = 3;
            histmod.usuariocreacion = usuario;


            histcont.Crear(histmod);
            this.Close();
          
        }
    }
}
