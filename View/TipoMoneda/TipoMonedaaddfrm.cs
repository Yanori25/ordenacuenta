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

namespace OrdenaCuenta.View.TipoMoneda
{
    public partial class TipoMonedaaddfrm : MaterialForm
    {

        TipoMonedaController tipmoncon = new TipoMonedaController();
        TipoMonedaModel tipomonmod = new TipoMonedaModel();
        string usuario = Properties.Settings.Default.Usuario;


        public TipoMonedaaddfrm()
        {
            InitializeComponent();
        }

        private void TipoMonedaaddfrm_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {


            if (txtnombre.Text == "" || txtisob.Text == "" || txtisoc.Text == "" ||
           txtmoenda.Text == "" || txtsimbolo.Text == "" )
            {
                MaterialMessageBox.Show("Se debe llenar los campos oblgatorios");
                return;
            }


            tipomonmod.Descripcion = txtnombre.Text;
            tipomonmod.Simbolo = txtsimbolo.Text;
            tipomonmod.PaisIsob = txtisob.Text;
            tipomonmod.PaisIsoc = txtisoc.Text;
            tipomonmod.Moneda = txtmoenda.Text;
            tipomonmod.MonIdEmpresa = 3;
            tipomonmod.usuariocreacion = usuario ;
            tipmoncon.Crear(tipomonmod);



            this.Close();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
