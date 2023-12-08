using MaterialSkin.Controls;
using OrdenaCuenta.Properties;
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
    public partial class MesanjeSioNo : MaterialForm
    {
        string respuesta = "";
        public MesanjeSioNo( )
        {
            InitializeComponent();
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            estilo.frmMaterial(this);


        }

        private void MesanjeSioNo_Load(object sender, EventArgs e)
        {
           
        }

        private void btnsi_Click(object sender, EventArgs e)
        {
            this.respuesta = "SI";
            Properties.Settings.Default.RespuestaMensaje = this.respuesta;

            this.Close();

        }

        private void btnno_Click(object sender, EventArgs e)
        {
            this.respuesta = "NO";
            Properties.Settings.Default.RespuestaMensaje = this.respuesta;
            this.Close();


        }
    }
}
