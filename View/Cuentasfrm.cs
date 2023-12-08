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
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using OrdenaCuenta.Model;

namespace OrdenaCuenta.View
{
    public partial class Cuentasfrm : MaterialForm
    {

        ClasificacionCuentaController clacuenta = new ClasificacionCuentaController();
        CuentaController cuenta = new CuentaController();
        Cuenta cuentamodel = new Cuenta();


        string id = "0";



        public Cuentasfrm()
        {
            InitializeComponent();
           
        }

        private void refrescar()
        {
            MaterialListView materialListView = cuenta.GetCuenta(); // clacuenta.GetClasificacionCuenta();

            matlistCuenta.Items.Clear();
         //   matlistCuenta.Clear();
            foreach (ListViewItem item in materialListView.Items)
            {
                matlistCuenta.Items.Add(item.Clone() as ListViewItem);
            }
            materialListView.Clear();
         //   matlistCuenta.Refresh();




        }


        private void Cuentasfrm_Load(object sender, EventArgs e)
        {
            btneliminar.BackColor = Color.Red;

            
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            btneliminar.BackColor = Color.Red;

            estilo.frmMaterial(this);
            btneliminar.BackColor = Color.Red;



             this.refrescar();
        }

        private void matlistCuenta_ItemActivate(object sender, EventArgs e)
        {

             this.id = matlistCuenta.SelectedItems[0].Text;

            // Haz algo con el ID, como mostrarlo en un MessageBox
           

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }

        private void matlistCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (id ==  "0")
            {
                MaterialMessageBox.Show("Debe seleccionar un registro");
                return;
            }


            MesanjeSioNo frm = new MesanjeSioNo();
          //  frm.Show();

            DialogResult resultado = frm.ShowDialog();

            string respuesta = Properties.Settings.Default.RespuestaMensaje;

            if (respuesta == "SI")
            {
                cuentamodel.id = Convert.ToInt32( this.id) ;
                cuenta.eliminar(cuentamodel);
                id = "0";
                this.refrescar();
                //  MaterialMessageBox.Show("Se borro el registro exitosamente");
            }
            else
            {
                MaterialMessageBox.Show("No se borro el registro");
            }


        }

        private void btneliminar_MouseEnter(object sender, EventArgs e)
        {
            ((MaterialButton)sender).BackColor = Color.Red;
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            CuentaAddfrm frm = new CuentaAddfrm();
            frm.ShowDialog();

            this.refrescar();
        
                }
    }
}
