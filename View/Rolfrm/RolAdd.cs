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


namespace OrdenaCuenta.View.Rolfrm
{
    public partial class RolAdd : MaterialForm
    {
        RolController rolcon = new RolController();
        RolModel rolmod = new RolModel();


        public RolAdd()
        {
            InitializeComponent();
        }

        private void RolAdd_Load(object sender, EventArgs e)
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
            if (txtnombre.Text == "")
            {
                MaterialMessageBox.Show("Debse llenar los campos requeridos");
                return;

                
            }
            rolmod.descripcion = txtnombre.Text;
            rolmod.roldEmpresa = 3;
            rolcon.Crear(rolmod);
            this.Close();
           // MaterialMessageBox.Show("Se agrego exitosamente");


        }


    }
}
