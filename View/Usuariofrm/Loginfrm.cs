using SIFICOPOP.capacontroller;
using SIFICOPOP.capamodelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIFICOPOP.capaview
{
    public partial class Loginfrm : Form
    {

        ClienteController controller = new ClienteController();
        ClienteModel model = new ClienteModel();
        Seguridad seg = new Seguridad();

        string rolusuario = "";

        public Loginfrm()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
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


                Mainfrm frmmenu = new Mainfrm(rolusuario);
                Loginfrm frmlogin = new Loginfrm();
             
                frmlogin.Close();
                frmmenu.Show();
              //  this.Close();

            }
            else
            {
                MessageBox.Show("Ingrese el usuario o clave valido");

            }
        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {

        }

        private void btniniciar_MouseEnter(object sender, EventArgs e)
        {
            btniniciar.ForeColor = Color.White;
        }

        private void btniniciar_MouseLeave(object sender, EventArgs e)
        {
            btniniciar.ForeColor = Color.FromArgb(0, 159, 36);
        }
    }
}
