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

namespace OrdenaCuenta.View.opciones
{
    public partial class opcionesAdd : MaterialForm
    {
        opcionesController opcionesController = new opcionesController();
        opcionesmodel opcmodel = new opcionesmodel();

        public opcionesAdd()
        {
            InitializeComponent();
        }

        private void opcionesAdd_Load(object sender, EventArgs e)
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
            opcmodel.ind = 1;
            opcmodel.id =0;
            opcmodel.Nombre = txtcuenta.Text;
            opcmodel.Nivel = txtnivel.Text;
            opcmodel.icono = txtdescripcion.Text;
            opcmodel.rutafrm = txtruta.Text;
            opcmodel.OpcionPadre = 0;

            opcionesController.Crear(opcmodel);
            this.Close();


        }
    }
}
