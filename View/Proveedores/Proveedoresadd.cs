using MaterialSkin.Controls;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;
using OrdenaCuenta.Utilities;
using OrdenaCuenta.View.Cuentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.View.Proveedores
{
    public partial class Proveedoresadd : MaterialForm
    {

        ProveedoresController provcon = new ProveedoresController();
        ProveedoresModel provmod = new ProveedoresModel();
        TipoMonedaController mon = new TipoMonedaController();
        subcuentaModel subcuemod = new subcuentaModel();
        subcuentaController subcuecon = new subcuentaController();

        string usuario = Properties.Settings.Default.Usuario;

        private ProveedoresModel parametros;
        string id = "0";
        int idsubcuenta = 0;


        string estadofrm = "";



        public Proveedoresadd( string estado , ProveedoresModel clienteparametros)
        {
            InitializeComponent();

            this.parametros = clienteparametros;

            this.estadofrm = estado;

            if (this.estadofrm == "agregar")
            {
                this.btneditar.Visible = false;


            }
            else
            {
                this.btnagregar.Visible = false;

                this.id = parametros.Id.ToString();
                this.txtnombre.Text = parametros.NombreCia;
                this.txtcontacto.Text = parametros.NombreContacto;
                this.txtrtn.Text = parametros.RTN;
                this.txtdireccion.Text = parametros.Direccion;
                this.txtemail.Text = parametros.email;
                this.txtmonto.Text = Convert.ToString( parametros.Deuda) ;
                this.txttelefono.Text = parametros.Telefono;
                this.cmbmoneda.SelectedText = parametros.Moneda;

                this.txsubcuenta.Text = parametros.subcuenta;
                subcuemod.Cuentacontablesub = this.txsubcuenta.Text;
                subcuemod.CuentaId = 0;
                subcuemod.usuariocreacion = usuario;
                if(this.txsubcuenta.Text != "" )
                {
                    idsubcuenta = subcuecon.getsubcuentaid(subcuemod);

                }

                //= parametros.CliTipMonid.ToString();

            }

        }

        private void cargarcombos()
        {


            cmbmoneda.DataSource = mon.GetipoMoneda();
            cmbmoneda.DisplayMember = "Descripcion";
            cmbmoneda.ValueMember = "Id";


        }
        private bool IsValidEmail(string email)
        {


            string patron = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            Regex regex = new Regex(patron);

            if (regex.IsMatch(email))
            {
                txtemail.Hint = "correo invalida";
                return true;

            }
            else
            {
                txtemail.Hint = "";
                return false;


            }

        }




        private void Proveedoresadd_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);

            this.cargarcombos();

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
          

            if (txtnombre.Text == "" || txtrtn.Text == "" || txtcontacto.Text == "" ||
           txtemail.Text == "" || txttelefono.Text == "" || txtdireccion.Text == "" ||
           txtmonto.Text == "" 
           )
            {
                MaterialMessageBox.Show("Se debe llenar los campos oblgatorios");
                return;
            }


            provmod.NombreCia = txtnombre.Text;
            provmod.RTN = txtrtn.Text;
            provmod.NombreContacto = txtcontacto.Text;
            provmod.email = txtemail.Text;
            provmod.Telefono = txttelefono.Text;
            provmod.Direccion = txtdireccion.Text;
            provmod.Deuda = Convert.ToDecimal( txtmonto.Text);
            provmod.ProtipMon = Convert.ToInt32(cmbmoneda.SelectedValue) ;
            provmod.ProIdEmpresa = 3;
            provmod.usuariocreacion = usuario;
            provmod.subcuentaid = idsubcuenta;



            provcon.Crear(provmod);
            
            this.Close();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtemail.Text))
            {
                txtemail.Hint = "Ingrese una dirección de correo electrónico válida";

                txtemail.ForeColor = Color.Red;
            }
            else
            {
                txtemail.Hint = "";


            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            provmod.Id =  Convert.ToInt32( this.id);
            provmod.NombreCia = txtnombre.Text;
            provmod.RTN = txtrtn.Text;
            provmod.NombreContacto = txtcontacto.Text;
            provmod.email = txtemail.Text;
            provmod.Telefono = txttelefono.Text;
            provmod.Direccion = txtdireccion.Text;
            provmod.Deuda = Convert.ToDecimal(txtmonto.Text);
            provmod.ProtipMon = Convert.ToInt32(cmbmoneda.SelectedValue);
            provmod.ProIdEmpresa = 3;
            provmod.usuariocreacion = usuario;
            provmod.subcuentaid = idsubcuenta;





            provcon.Editar(provmod);

            this.Close();

        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprimir la entrada
                e.Handled = true;
            }
        }

        private void txsubcuenta_Click(object sender, EventArgs e)
        {
            txsubcuenta.ReadOnly = false;


            SubcuentasAdd frm = new SubcuentasAdd(txtnombre.Text);
            frm.ShowDialog();
            txsubcuenta.Text = Properties.Settings.Default.subcuentacod;
            idsubcuenta = Properties.Settings.Default.idsubcuenta;


        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
