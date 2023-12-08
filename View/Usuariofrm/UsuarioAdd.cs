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

namespace OrdenaCuenta.View.Usuariofrm
{
    public partial class UsuarioAdd : MaterialForm
    {

        UsuarioController usucon = new UsuarioController();
        UsuarioModel usumod = new UsuarioModel();
        string usuario = "";
        Seguridad seg = new Seguridad();
        string estadofrm = "";
        string id = "";
        private UsuarioModel parametros;



        public UsuarioAdd(string estado , UsuarioModel usuarioparametro)
        {
            InitializeComponent();
            this.estadofrm = estado;
            this.parametros = usuarioparametro;

            if (this.estadofrm == "Agregar")
            {
                this.btneditar.Visible = false;
            }
            else
            {
                this.btneditar.Visible = true;
                this.btnagregar.Visible = false;
                this.txtresseg.Enabled = false;
                this.txtclavea.Enabled = false;
                this.txtclaveb.Enabled = false;

                this.id = parametros.id.ToString();
                this.txtnombre.Text = parametros.primernombre;
                this.txtnombresegundo.Text = parametros.segundonombre;
                this.txtapellido.Text = parametros.primerapellido;
                this.txtapellidosegundo.Text = parametros.segundoapellido;
                this.txtfecha.Text = parametros.fechaingreso.ToString("yyyy-MM-dd");
                this.txttelefono.Text = parametros.telefono;
                this.cmbsexo.SelectedText = parametros.sexo.ToString();
                this.txtusuario.Text = parametros.usuario.ToString();
                this.txtdni.Text = parametros.dni;
                this.txtpregunta.Text = parametros.preguntaSeguridad.ToString();

                //string fechaConHora = fila["fechaIngreso"].ToString(); // Supongo que tienes la fecha en una variable.
                //DateTime fecha = DateTime.Parse(fechaConHora); // Convierte la cadena a un objeto DateTime.

                //string fechaFormateada = fecha.ToString("yyyy-MM-dd"); // Formatea la fecha como "AAAA-MM-DD" sin la hora.


            }

        }


  



        private void UsuarioAdd_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();
            estilo.frmMaterial(this);

            txtclavea.UseSystemPasswordChar = true;

            txtclaveb.UseSystemPasswordChar = true;

            txtresseg.UseSystemPasswordChar = true;



        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            if ((txtclavea.Text != txtclaveb.Text) || txtclavea.Text == "" || txtclaveb.Text == "")
            {
                MaterialMessageBox.Show("las claves no son iguales ");
                return;
            }

            if (txtnombre.Text == "" || txtnombresegundo.Text == "" || txtapellido.Text == "" ||
           txtapellidosegundo.Text == "" || txtdni.Text == "" || txtpregunta.Text == "" ||
           txtresseg.Text == "" || txttelefono.Text == "" || cmbsexo.Text == "" 
           )
            {
                MaterialMessageBox.Show("Se debe llenar los campos oblgatorios");
                return;
            }


            usumod.primernombre = txtnombre.Text;
            usumod.segundonombre= txtnombresegundo.Text;
            usumod.primerapellido = txtapellido.Text;
            usumod.segundoapellido = txtapellidosegundo.Text;
            usumod.dni = txtdni.Text;
            usumod.usuario = txtusuario.Text;
            usumod.clave = seg.Encriptar( txtclavea.Text);
            usumod.preguntaSeguridad = txtpregunta.Text;
            usumod.RespuestaSeguridad = seg.Encriptar( txtresseg.Text);
            usumod.telefono = txttelefono.Text;
            usumod.sexo = cmbsexo.Text;
            usumod.idrol = "1";
            usumod.usuidempresa = 3; 
            usumod.fechaingreso = Convert.ToDateTime( txtfecha.Text );



            usucon.Crear(usumod);
            this.Close();

        }

        private void txtapellidosegundo_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.Text != "")
            {
                char pletra = txtnombre .Text[0];
                txtusuario.Text = pletra + txtapellidosegundo.Text + usuario;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            monthCalendar1.BringToFront();

            monthCalendar1.Visible = true;
            monthCalendar1.Location = new System.Drawing.Point(
       txtfecha.Left,
       pictureBox1.Bottom
   );


        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Actualizar el TextBox con la fecha seleccionada
            txtfecha.Text = monthCalendar1.SelectionStart.ToShortDateString();
            // Ocultar el MonthCalendar después de la selección
            monthCalendar1.Visible = false;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            usumod.primernombre = txtnombre.Text;
            usumod.segundonombre = txtnombresegundo.Text;
            usumod.primerapellido = txtapellido.Text;
            usumod.segundoapellido = txtapellidosegundo.Text;
            usumod.dni = txtdni.Text;
            usumod.usuario = txtusuario.Text;
            usumod.clave = seg.Encriptar(txtclavea.Text);
            usumod.preguntaSeguridad = txtpregunta.Text;
            usumod.RespuestaSeguridad = seg.Encriptar(txtresseg.Text);
            usumod.telefono = txttelefono.Text;
            usumod.sexo = cmbsexo.Text;
            usumod.idrol = "1";
            usumod.usuidempresa = 3;
            usumod.fechaingreso = Convert.ToDateTime( txtfecha.Text);

            usumod.id = Convert.ToInt32( this.id);


            usucon.Editar(usumod);
            this.Close();

        }
    }
}
