using MaterialSkin.Controls;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;
using OrdenaCuenta.Utilities;
using OrdenaCuenta.View.Cliente;
using OrdenaCuenta.View.Usuariofrm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.View.Proveedores
{
    public partial class Proveedoresshow : MaterialForm
    {

        ProveedoresController procon = new ProveedoresController();
        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        ProveedoresModel promod = new ProveedoresModel();

        Filtros filtrarls = new Filtros();
        string id = "0";
        string NombreCiapar = "";
        string NombreContactopar = "";
        string emailpar = "";
        string Telefonopar = "";
        string RTNpar = "";
        string Deudapar = "";
    
        string monedapar = "";
        string Direccionpar = "";
        string subcuentas = "";







        public Proveedoresshow()
        {
            InitializeComponent();
        }


        private void cargar()
        {

            MaterialListView materialListView = procon.GetProveedor(); // clacuenta.GetClasificacionCuenta();

            // Declara una lista para almacenar todos los elementos originales.


            lsproveedores.Items.Clear();
            elementosOriginales.Clear();



            //   matlistCuenta.Clear();
            foreach (ListViewItem item in materialListView.Items)
            {
                //   lsclientes.Items.Add(item.Clone() as ListViewItem);
                elementosOriginales.Add(item.Clone() as ListViewItem);
            }
            lsproveedores.Items.AddRange(elementosOriginales.ToArray());
            materialListView.Clear();

            // Agrega todos los elementos originales al MaterialListView.


        }


        private void Proveedoresshow_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);

            lsproveedores.Columns.Add("id", 150); // Nombre de la columna y ancho en píxeles.
            lsproveedores.Columns.Add("NombreCia", 200); // Nombre de la columna y ancho en píxeles.
            lsproveedores.Columns.Add("NombreContacto", 150); // Agrega más columnas según tus necesidades.
            lsproveedores.Columns.Add("email", 200); // Nombre de la columna y ancho en píxeles.
            lsproveedores.Columns.Add("Telefono", 200); // Agrega más columnas según tus necesidades.
            lsproveedores.Columns.Add("RTN", 150); // Nombre de la columna y ancho en píxeles.
            lsproveedores.Columns.Add("Deuda", 200); // Agrega más columnas según tus necesidades.
            lsproveedores.Columns.Add("moneda", 200); // Nombre de la columna y ancho en píxeles.
            lsproveedores.Columns.Add("Direccion", 250); // Nombre de la columna y ancho en píxeles.
            lsproveedores.Columns.Add("subcuenta", 250); // Nombre de la columna y ancho en píxeles.
            lsproveedores.Columns.Add("cuenta", 250); // Nombre de la columna y ancho en píxeles.

            this.cargar();



        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, lsproveedores);


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (this.id == "0")
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
                promod.Id = Convert.ToInt32(this.id);
                promod.usuariocreacion = Properties.Settings.Default.Usuario;
                 procon.eliminar(promod);

                id = "0";
                this.cargar();
                //  MaterialMessageBox.Show("Se borro el registro exitosamente");
            }
            else
            {
                MaterialMessageBox.Show("No se borro el registro");
            }
        }

        private void lsproveedores_Click(object sender, EventArgs e)
        {
            this.id = lsproveedores.SelectedItems[0].Text;
            this.NombreCiapar = lsproveedores.SelectedItems[0].SubItems[1].Text;
            this.NombreContactopar = lsproveedores.SelectedItems[0].SubItems[2].Text;
            this.emailpar = lsproveedores.SelectedItems[0].SubItems[3].Text;
            this.Telefonopar = lsproveedores.SelectedItems[0].SubItems[4].Text;
            this.RTNpar = lsproveedores.SelectedItems[0].SubItems[5].Text;
            this.Deudapar = lsproveedores.SelectedItems[0].SubItems[6].Text;
            this.monedapar = lsproveedores.SelectedItems[0].SubItems[7].Text;
            this.Direccionpar = lsproveedores.SelectedItems[0].SubItems[8].Text;
            this.subcuentas = lsproveedores.SelectedItems[0].SubItems[9].Text;









        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            ProveedoresModel parametros = new ProveedoresModel
            {
          
            };

            Proveedoresadd frm = new Proveedoresadd("agregar", parametros);
            frm.ShowDialog();
            //  MaterialMessageBox.Show("Se agrego exitosamente");
            this.cargar();

        }

        private void lsproveedores_DoubleClick(object sender, EventArgs e)
        {
            ProveedoresModel parametros = new ProveedoresModel
            {
                Id = Convert.ToInt32(this.id),
                NombreCia = this.NombreCiapar,
                NombreContacto = this.NombreContactopar,
                email = this.emailpar,
                Telefono = this.Telefonopar,
                RTN = this.RTNpar,
                Direccion = this.Direccionpar,
                ProIdEmpresa = 3,
                Deuda = Convert.ToDecimal(this.Deudapar),
                //   ProtipMon = Convert.ToInt32(this.monedapar),
                Moneda = this.monedapar,
                usuariocreacion = "",
                subcuenta = this.subcuentas 

            };

            Proveedoresadd frm = new Proveedoresadd("editar", parametros);
            frm.ShowDialog();
            this.cargar();


        }

        private void lsproveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
