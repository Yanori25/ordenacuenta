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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.View.Usuariofrm
{
    public partial class Loginfrmshow : MaterialForm
    {


        UsuarioController controller = new UsuarioController();
        UsuarioModel model = new UsuarioModel();
        Seguridad seg = new Seguridad();

        string rolusuario = "";

        public Loginfrmshow()
        {
            InitializeComponent();
        }

        private void Loginfrmshow_Load(object sender, EventArgs e)
        {

            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);
            txtclave.UseSystemPasswordChar = true;


        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            model.usuario = txtnombre.Text;
            bool ingreso = false;

            string clave = controller.claveencriptada(model);
            string clavedigiatada = seg.Desencriptar(clave);
            model.clave = clave;

            if (clavedigiatada == txtclave.Text)
            {
                ingreso = controller.loguear(model);


            }
            if (ingreso == true)
            {
                rolusuario = controller.getrol(model);
                Properties.Settings.Default.Usercajero = controller.getidcliente(txtnombre.Text);
                Properties.Settings.Default.Usuario = txtnombre.Text;

                Mainfrm frmmenu = new Mainfrm(rolusuario);
                Loginfrmshow frmlogin = new Loginfrmshow();

                frmlogin.Close();
                frmmenu.Show();
                //  this.Close();

            }
            else
            {
                MaterialMessageBox.Show("Ingrese el usuario o clave valido");

            }
        }
    }
}
