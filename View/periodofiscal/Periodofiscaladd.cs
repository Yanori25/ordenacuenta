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

namespace OrdenaCuenta.View.periodofiscal
{
    public partial class Periodofiscaladd : MaterialForm
    {
        public Periodofiscaladd()
        {
            InitializeComponent();
        }

        periodofiscalController perfiscontroler = new periodofiscalController();
        periodofiscalModel perfismod = new periodofiscalModel();

        string usuario = Properties.Settings.Default.Usuario;



        private void Periodofiscaladd_Load(object sender, EventArgs e)
        {

            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            perfismod.fechaini= Convert.ToDateTime(txtfechaini.Text);
            perfismod.fechafin = Convert.ToDateTime(txtfechafin.Text);
            perfismod.idempresa = 3;
            perfismod.usuariocreacion = usuario;

         
            perfiscontroler.Crear(perfismod);
          
            this.Close();
        }

        private void calfechaini_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtfechaini.Text = calfechaini.SelectionStart.ToShortDateString();
            // Ocultar el MonthCalendar después de la selección
            calfechaini.Visible = false;
        }

        private void calfecfin_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtfechafin.Text = calfecfin.SelectionStart.ToShortDateString();
            // Ocultar el MonthCalendar después de la selección
            calfecfin.Visible = false;
        }

        private void pbfechafin_Click(object sender, EventArgs e)
        {
            calfecfin.BringToFront();

            calfecfin.Visible = true;
            calfecfin.Location = new System.Drawing.Point(
       txtfechafin.Left,
       pbfechafin.Bottom
   );
        }

        private void pbfechaini_Click(object sender, EventArgs e)
        {
            calfechaini.BringToFront();

            calfechaini.Visible = true;
            calfechaini.Location = new System.Drawing.Point(
       txtfechaini.Left,
       pbfechaini.Bottom
   );
        }
    }
}
