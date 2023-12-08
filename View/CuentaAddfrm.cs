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

namespace OrdenaCuenta.View
{
    public partial class CuentaAddfrm : MaterialForm
    {
        ClasificacionCuentaController clase = new ClasificacionCuentaController();

        TipoMonedaController mon  = new TipoMonedaController();

        CuentaController cuentacom = new CuentaController();

        Cuenta cuentamod = new Cuenta();


        public CuentaAddfrm()
        {
            InitializeComponent();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void CuentaAddfrm_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            estilo.frmMaterial(this);
             this.cargarcombos();

        }


        private void cargarcombos()
        {
            cmbclase.DataSource = clase.GetClasificaCuenta();
            cmbclase.DisplayMember = "TipoCuenta";
            cmbclase.ValueMember = "Id";

            cmbmoneda.DataSource = mon.GetipoMoneda();
            cmbmoneda.DisplayMember = "Descripcion";
            cmbmoneda.ValueMember = "Id";


        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void cmbmoneda_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

           

            cuentamod.CuentaContable = txtcuenta.Text;
            cuentamod.Descripcion = txtdescripcion.Text;
            cuentamod.ClaseCuentaId = Convert.ToInt32( cmbclase.SelectedValue);
            cuentamod.CuentaTipo = cmbdettipo.Text;
            cuentamod.MonedaId = Convert.ToInt32(cmbmoneda.SelectedValue);
            cuentamod.CueIdEmpresa = 3;

           
            if (txtdescripcion.Text == "" || txtcuenta.Text == "") 

            {

                MaterialMessageBox.Show("Todos los campos son obligatorios");
                return; 
            }

            cuentacom.Crear(cuentamod);
            txtdescripcion.Text = "";
            txtcuenta.Text = "";
            this.Close();
            

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
