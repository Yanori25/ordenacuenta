using MaterialSkin.Controls;
using OrdenaCuenta.Controller;
using OrdenaCuenta.Model;
using OrdenaCuenta.Utilities;
using OrdenaCuenta.View.Cliente;
using OrdenaCuenta.View.Rolfrm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenaCuenta.View.Usuariofrm
{
    public partial class UsuarioShow : MaterialForm
    {

        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        UsuarioController usercont = new UsuarioController();
        UsuarioModel usermod = new UsuarioModel();


        Filtros filtrarls = new Filtros();
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
        string dnipar = "";
        string ususariopar = "";
        string preguntasegpar = "";
        string rolpar = "";
        string sexopar = "";



        public UsuarioShow()
        {
            InitializeComponent();
        }

        private void cargar()
        {

            MaterialListView materialListView = usercont.GetUsuario(); // clacuenta.GetClasificacionCuenta();

            // Declara una lista para almacenar todos los elementos originales.


            lsusuarios.Items.Clear();
            elementosOriginales.Clear();



            //   matlistCuenta.Clear();
            foreach (ListViewItem item in materialListView.Items)
            {
                //   lsclientes.Items.Add(item.Clone() as ListViewItem);
                elementosOriginales.Add(item.Clone() as ListViewItem);
            }
            lsusuarios.Items.AddRange(elementosOriginales.ToArray());
            materialListView.Clear();

            // Agrega todos los elementos originales al MaterialListView.


        }



        private void UsuarioShow_Load(object sender, EventArgs e)
        {
            lsusuarios.Columns.Add("id", 150); // Nombre de la columna y ancho en píxeles.
            lsusuarios.Columns.Add("nombre", 200); // Nombre de la columna y ancho en píxeles.
            lsusuarios.Columns.Add("dni", 150); // Agrega más columnas según tus necesidades.
            lsusuarios.Columns.Add("usuario", 150); // Nombre de la columna y ancho en píxeles.
            lsusuarios.Columns.Add("clave", 200); // Agrega más columnas según tus necesidades.
            lsusuarios.Columns.Add("fechaFormateada", 150); // Nombre de la columna y ancho en píxeles.
            lsusuarios.Columns.Add("telefono", 200); // Agrega más columnas según tus necesidades.
            lsusuarios.Columns.Add("rol", 150); // Nombre de la columna y ancho en píxeles.
            lsusuarios.Columns.Add("preguntaSeguridad", 200); // Nombre de la columna y ancho en píxeles.
            lsusuarios.Columns.Add("sexo", 100); // Nombre de la columna y ancho en píxeles.



            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            estilo.frmMaterial(this);

            this.cargar();


        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, lsusuarios);


        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            UsuarioModel parametros = new UsuarioModel
            {
             
            };

            UsuarioAdd frm = new UsuarioAdd("Agregar", parametros);
            frm.ShowDialog();
          //  MaterialMessageBox.Show("Se agrego exitosamente");
            this.cargar();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

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
                usermod.id = Convert.ToInt32(this.id);
                usercont.eliminar(usermod);
                
                id = "0";
                this.cargar();
                //  MaterialMessageBox.Show("Se borro el registro exitosamente");
            }
            else
            {
                MaterialMessageBox.Show("No se borro el registro");
            }
        }

        private void lsusuarios_Click(object sender, EventArgs e)
        {
            this.id = lsusuarios.SelectedItems[0].Text;

            string nombreCompleto = lsusuarios.SelectedItems[0].SubItems[1].Text.TrimStart();
            string[] palabras = nombreCompleto.Split(' ');
            this.Nombrepar = palabras[0];
            this.segundoNombrepar = palabras[1];
            this.Apellidopar = palabras[2];
            this.segundoApellidopar = palabras[3];

            this.dnipar = lsusuarios.SelectedItems[0].SubItems[2].Text;
            this.ususariopar = lsusuarios.SelectedItems[0].SubItems[3].Text;
            this.FechaIngresopar = lsusuarios.SelectedItems[0].SubItems[5].Text;
            this.Telefonopar = lsusuarios.SelectedItems[0].SubItems[6].Text;
            this.rolpar = lsusuarios.SelectedItems[0].SubItems[7].Text;
            this.preguntasegpar = lsusuarios.SelectedItems[0].SubItems[8].Text;
            this.sexopar = lsusuarios.SelectedItems[0].SubItems[9].Text;
          
        }

        private void lsusuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            UsuarioModel parametros = new UsuarioModel
            {
                id = Convert.ToInt32(this.id),
                primernombre = this.Nombrepar,
                segundonombre = this.segundoNombrepar,
                primerapellido = this.Apellidopar,
                segundoapellido = this.segundoApellidopar,
                dni = this.dnipar,
                fechaingreso = Convert.ToDateTime( this.FechaIngresopar),
                telefono = this.Telefonopar,
                idrol = this.rolpar,
                preguntaSeguridad = this.preguntasegpar,
                sexo = this.sexopar,
                usuario = this.ususariopar
            };

            UsuarioAdd frm = new UsuarioAdd("editar" , parametros);
            frm.ShowDialog();
            this.cargar();

        }
    }
}
