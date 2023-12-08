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
    public partial class PeriodoAdd : MaterialForm
    {

        PeriodoContableController periodocon = new PeriodoContableController();
        PeriodoContableModel periodmod = new PeriodoContableModel();
        string usuario = Properties.Settings.Default.Usuario;



        public PeriodoAdd()
        {
            InitializeComponent();
        }

        private void PeriodoAdd_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void pbfechafin_Click(object sender, EventArgs e)
        {
            calfecfin.BringToFront();

            calfecfin.Visible = true;
            calfecfin.Location = new System.Drawing.Point(
       txtfechafin.Left,
       pbfechafin.Bottom
   );
        }

        private void pbfecpago_Click(object sender, EventArgs e)
        {
            calfecpago.BringToFront();

            calfecpago.Visible = true;
            calfecpago.Location = new System.Drawing.Point(
       txtfechapago.Left,
       pbfecpago.Bottom
   );
        }

        private void pbfechcorte_Click(object sender, EventArgs e)
        {
            calfeccorte.BringToFront();

            calfeccorte.Visible = true;
            calfeccorte.Location = new System.Drawing.Point(
       txtfeccorte.Left,
       pbfechcorte.Bottom
   );
        }

        private void calfeccorte_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Actualizar el TextBox con la fecha seleccionada
            txtfeccorte.Text = calfeccorte.SelectionStart.ToShortDateString();
            // Ocultar el MonthCalendar después de la selección
            calfeccorte.Visible = false;
        }

        private void calfecpago_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtfechapago.Text = calfecpago.SelectionStart.ToShortDateString();
            // Ocultar el MonthCalendar después de la selección
            calfecpago.Visible = false;
        }

        private void calfecfin_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtfechafin.Text = calfecfin.SelectionStart.ToShortDateString();
            // Ocultar el MonthCalendar después de la selección
            calfecfin.Visible = false;
        }

        private void calfechaini_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtfechaini.Text = calfechaini.SelectionStart.ToShortDateString();
            // Ocultar el MonthCalendar después de la selección
            calfechaini.Visible = false;

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            periodmod.FechaIni = Convert.ToDateTime( txtfechaini.Text);

            periodmod.FechaFin = Convert.ToDateTime(txtfechafin.Text);
            periodmod.FechaCorte = Convert.ToDateTime(txtfeccorte.Text);
            periodmod.FechaPago = Convert.ToDateTime(txtfechapago.Text);
            periodmod.Frecuencia = cmbdettipo.Text ;
            periodmod.Estado = "Generado";
            periodmod.IdPerEmpresa = 3;
            periodmod.UsuarioCreacion = usuario;

            periodocon.Crear(periodmod);
            this.Close();
        }
    }
}
