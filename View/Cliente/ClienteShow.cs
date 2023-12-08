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

namespace OrdenaCuenta.View.Cliente
{
    public partial class ClienteShow : MaterialForm
    {

        ClienteController clicon = new ClienteController();
        Filtros filtrarls = new Filtros();
        ClienteModel climod = new ClienteModel();

        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        string id = "0";
        string Nombrepar = "";
        string segundoNombrepar = "";
        string Apellidopar = "";
        string segundoApellidopar = "";
        string emailpar = "";
        string FechaIngresopar = "";
        string Telefonopar = "";
        string Abonopar = "";
        string monedapar = "";
        string dirrecion = "";
        string rtncia = "";
        string nombrecia = "";
        string subcuentas = "";






        public ClienteShow()
        {
            InitializeComponent();
        }


        private void cargar()
        {

            MaterialListView materialListView = clicon.GetCliente(); // clacuenta.GetClasificacionCuenta();

            // Declara una lista para almacenar todos los elementos originales.
          

            lsclientes.Items.Clear();
            elementosOriginales.Clear();



            //   matlistCuenta.Clear();
            foreach (ListViewItem item in materialListView.Items)
            {
             //   lsclientes.Items.Add(item.Clone() as ListViewItem);
                elementosOriginales.Add(item.Clone() as ListViewItem);
            }
            lsclientes.Items.AddRange(elementosOriginales.ToArray());
            materialListView.Clear();

            // Agrega todos los elementos originales al MaterialListView.
            

        }

        private void ClienteShow_Load(object sender, EventArgs e)
        {
            this.cargar();


            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            
            estilo.frmMaterial(this);

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro , elementosOriginales, lsclientes);

           



        }

        private void lsclientes_Click(object sender, EventArgs e)
        {
           

      


            this.id = lsclientes.SelectedItems[0].Text;
            this.Nombrepar = lsclientes.SelectedItems[0].SubItems[1].Text;
            this.segundoNombrepar = lsclientes.SelectedItems[0].SubItems[2].Text;
            this.Apellidopar = lsclientes.SelectedItems[0].SubItems[3].Text;
            this.segundoApellidopar = lsclientes.SelectedItems[0].SubItems[4].Text;
            this.emailpar = lsclientes.SelectedItems[0].SubItems[5].Text;
            this.FechaIngresopar = lsclientes.SelectedItems[0].SubItems[6].Text;
            this.Telefonopar = lsclientes.SelectedItems[0].SubItems[7].Text;
            this.Abonopar = lsclientes.SelectedItems[0].SubItems[8].Text;
            this.monedapar = lsclientes.SelectedItems[0].SubItems[10].Text;
            this.dirrecion = lsclientes.SelectedItems[0].SubItems[11].Text;
            this.subcuentas = lsclientes.SelectedItems[0].SubItems[12].Text;
            this.rtncia = lsclientes.SelectedItems[0].SubItems[14].Text;
            this.nombrecia = lsclientes.SelectedItems[0].SubItems[15].Text;


        }

        private void lsclientes_ItemActivate(object sender, EventArgs e)
        {


            ClienteModel parametros = new ClienteModel
            {
                Id = Convert.ToInt32(this.id),
                Nombre = this.Nombrepar,
                segundoNombre = this.segundoNombrepar,
                Apellido = this.Apellidopar,
                segundoApellido = this.segundoApellidopar,
                email = this.emailpar,
                FechaIngresostr = this.FechaIngresopar,
                Telefono = this.Telefonopar,
                Abono = Convert.ToDecimal( this.Abonopar),
                CliTipMonid = Convert.ToInt32( this.monedapar),
                Direccion = this.dirrecion,
                subcuenta = this.subcuentas,
                RTN = this.rtncia,
                NombreCia = this.nombrecia
            };

            ClienteAdd frm = new ClienteAdd("editar", parametros);
            frm.ShowDialog();
            this.cargar();



        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (id == "0")
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
                climod.Id = Convert.ToInt32(this.id);
                clicon.eliminar(climod);
                id = "0";
                this.cargar();
                //  MaterialMessageBox.Show("Se borro el registro exitosamente");
            }
            else
            {
                MaterialMessageBox.Show("No se borro el registro");
            }


        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            ClienteModel parametros = new ClienteModel
            {
                Id = Convert.ToInt32("0"),
                Nombre = "",
                segundoNombre = "",
                Apellido = "",
                segundoApellido = "",
                email = "",
                FechaIngresostr = "",
                Telefono = ""   ,
                Abono = Convert.ToDecimal("0"),
                CliTipMonid = Convert.ToInt32("0")
            };

            ClienteAdd frm = new ClienteAdd("agregar", parametros);
            frm.ShowDialog();
            this.cargar();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

        }
    }
}
