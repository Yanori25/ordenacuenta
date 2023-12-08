using MaterialSkin.Controls;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.View.transacciones
{
    public partial class transaccionesAdd : MaterialForm
    {
        public transaccionesAdd()
        {
            InitializeComponent();
        }
        tipoTransaccionesController tipotrancon = new tipoTransaccionesController();
        tipoTransaccionesModel tipoTransaccionesModel = new tipoTransaccionesModel();


        private void transaccionesAdd_Load(object sender, EventArgs e)
        {
           

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            tipoTransaccionesModel.id = txtcuenta.Text;
            tipoTransaccionesModel.descripcion = txtdescripcion.Text;
            tipoTransaccionesModel.ttraidempresa = 3;
            tipotrancon.Crear(tipoTransaccionesModel);

            this.Close();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
