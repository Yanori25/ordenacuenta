using MaterialSkin.Controls;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Utilities;
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
using OrdenaCuenta.Model;
using OrdenaCuenta.View.Cuentas;

namespace OrdenaCuenta.View.Cliente
{
    public partial class ClienteAdd : MaterialForm
    {
        
        ClienteController clientecon = new ClienteController();
        TipoMonedaController mon = new TipoMonedaController();
        subcuentaController subcuecon = new subcuentaController();


        ClienteModel clientmod = new ClienteModel();
        subcuentaModel subcuemod = new subcuentaModel();

        private ClienteModel parametros;
        string id = "0";
        string usuario = Properties.Settings.Default.Usuario;
        int idsubcuenta = 0;


        string estadofrm = "";


        public ClienteAdd(string estado , ClienteModel clienteparametros)
        {
            InitializeComponent();
            this.parametros = clienteparametros;
          
            this.estadofrm = estado;

            if (this.estadofrm == "agregar")
            {
                this.btneditar.Visible = false;


            }
            else {
                this.btnagregar.Visible = false;

                this.id = parametros.Id.ToString();
                this.txtnombre.Text = parametros.Nombre;
                this.txtnombresegundo.Text = parametros.segundoNombre;
                this.txtapellido.Text = parametros.Apellido;
                this.txtapellidosegundo.Text = parametros.segundoApellido;
                this.txtemail.Text = parametros.email;
                this.txtfecha.Text = parametros.FechaIngresostr;
                this.txttelefono.Text = parametros.Telefono;
                this.txtmonto.Text = parametros.Abono.ToString();
                this.txtdireccion.Text = parametros.Direccion.ToString();
                this.txtdireccion.Text = parametros.Direccion;
                this.cmbmoneda.SelectedText = parametros.CliTipMonid.ToString();
                this.txtrnt.Text = parametros.RTN.ToString();
                this.txtnombrecia.Text= parametros.NombreCia.ToString();
                this.txsubcuenta.ReadOnly= false;
                this.txsubcuenta.Text = parametros.subcuenta;
                subcuemod.Cuentacontablesub = this.txsubcuenta.Text;
                subcuemod.CuentaId = 0;
                subcuemod.usuariocreacion = usuario;
                idsubcuenta = subcuecon.getsubcuentaid(subcuemod);


                //= parametros.CliTipMonid.ToString();

            }


        }



        private void cargarcombos()
        {
           

            cmbmoneda.DataSource = mon.GetipoMoneda();
            cmbmoneda.DisplayMember = "Descripcion";
            cmbmoneda.ValueMember = "Id";


        }

        private void ClienteAdd_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            estilo.frmMaterial(this);
            monthCalendar1.Visible = false;
            this.cargarcombos();

           // txsubcuenta.Text = "202304";

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

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if  (!this.txtemail.Text.Contains("@") || !this.txtemail.Text.Contains("."))
            {
                MaterialMessageBox.Show("por favor no ingrese correo valido debe llevar punto . y @ ", "Invalid Email", MessageBoxButtons.OK,  MessageBoxIcon.None);
                // MaterialMessageBox.Show("por favor no ingrese correo valido debe llevar punto . y @ ", "Invalid Email");
                return;
            }
            if(txtnombre.Text == "" || txtapellido.Text == "" || txtemail.Text == ""||
                 txtfecha.Text == "" || txtmonto.Text == "")
            {
                MaterialMessageBox.Show("Debse llenar los campos requeridos");
                return;

            }

            clientmod.Nombre = txtnombre.Text;
            clientmod.Apellido = txtapellido.Text;
            clientmod.Direccion = txtdireccion.Text;
            clientmod.email = txtemail.Text;
            clientmod.FechaIngreso = Convert.ToDateTime(txtfecha.Text) ;
            clientmod.Telefono = txttelefono.Text;
            clientmod.CliIdEmpresa = 3;
            clientmod.Abono = Convert.ToDecimal( txtmonto.Text);
            clientmod.segundoApellido = txtapellidosegundo.Text;
            clientmod.segundoNombre = txtnombresegundo.Text;
            clientmod.CliTipMonid = Convert.ToInt32(cmbmoneda.SelectedValue);
            clientmod.subcueidcli = idsubcuenta;// Convert.ToInt32(txsubcuenta.Text);
            clientmod.NombreCia = txtnombrecia.Text;
            clientmod.RTN = txtrnt.Text;
            clientmod.usuariocreacion = usuario;


            clientecon.Crear(clientmod);
            this.Close();




        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter no válido.
            }

           
            

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!this.txtemail.Text.Contains("@") || !this.txtemail.Text.Contains("."))
            {
                MaterialMessageBox.Show("por favor no ingrese correo valido debe llevar punto . y @ ", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.None);
                // MaterialMessageBox.Show("por favor no ingrese correo valido debe llevar punto . y @ ", "Invalid Email");
            }

            clientmod.Id = Convert.ToInt32(this.id);
            clientmod.Nombre = txtnombre.Text;
            clientmod.Apellido = txtapellido.Text;
            clientmod.Direccion = txtdireccion.Text;
            clientmod.email = txtemail.Text;
            clientmod.FechaIngreso = Convert.ToDateTime(txtfecha.Text);
            clientmod.Telefono = txttelefono.Text;
            clientmod.CliIdEmpresa = 3;
            clientmod.Abono = Convert.ToDecimal(txtmonto.Text);
            clientmod.segundoApellido = txtapellidosegundo.Text;
            clientmod.segundoNombre = txtnombresegundo.Text;
            clientmod.CliTipMonid = Convert.ToInt32(cmbmoneda.SelectedValue);
            clientmod.subcueidcli = idsubcuenta;// Convert.ToInt32(txsubcuenta.Text);
            clientmod.NombreCia = txtnombrecia.Text;
            clientmod.RTN = txtrnt.Text;
            clientmod.usuariocreacion = usuario;



            clientecon.Editar(clientmod);
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

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void txtfecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbmoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txsubcuenta_Click(object sender, EventArgs e)
        {
            txsubcuenta.ReadOnly = false;

           
            SubcuentasAdd frm = new SubcuentasAdd( txtnombrecia.Text );
            frm.ShowDialog();
            txsubcuenta.Text = Properties.Settings.Default.subcuentacod;
            idsubcuenta = Properties.Settings.Default.idsubcuenta;


            // Vuelve a habilitar el modo de solo lectura para evitar ediciones.
            //    txsubcuenta.ReadOnly = true;


        }

        private void txsubcuenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
