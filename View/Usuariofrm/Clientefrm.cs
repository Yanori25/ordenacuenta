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
    public partial class Clientefrm : Form
    {

        ClienteController controller = new ClienteController();
        ParentescoController parencontrol = new ParentescoController();
        RolController rolcon = new RolController();
        BeneficiarioController bencontrol = new BeneficiarioController();
        ProductoClienteController productoclientecontroller = new ProductoClienteController();
        ProductoController producto = new ProductoController();
        TransacionController transacontrol = new TransacionController();
        OperacionController operacontrol = new OperacionController();




        ClienteModel model = new ClienteModel();
        BeneficiarioModel benmodel = new BeneficiarioModel();
        ProductoClienteModelo productoclientemodel = new ProductoClienteModelo();
        TransacionModelo transamodel = new TransacionModelo();


        Seguridad seg = new Seguridad();
        string id = "";
        string usuario = "";
        string idbeneficiario = "";
        int m, mx, my;



        public Clientefrm()
        {
            InitializeComponent();
        }

        private void cargarproductosclientes()
        {
            dgvprodcliente.DataSource = productoclientecontroller.GetProductoCliente(this.id);
        }

        private void cargarbeneficiario()
        {
            dgvbeneficiario.DataSource = bencontrol.GetBeneficiario(id);
        }

        private void refrescar()
        {
            dgvroles.DataSource = controller.getcliente();

        }

        private void generarnumero()
        {
            int min = 1;
            int max = 1000;
            Random rnd = new Random();
            usuario = Convert.ToString(rnd.Next(min, max + 1));



        }
        private void refrescarrol()
        {
            cmbrol.DataSource = rolcon.GetRol();
            cmbrol.DisplayMember = "descripcion";
            cmbrol.ValueMember = "rolid";

            cmbparentesco.DataSource = parencontrol.GetParentesco();
            cmbparentesco.DisplayMember = "descripcion";
            cmbparentesco.ValueMember = "id";


            cmbproducto.DataSource = producto.GetProducto() ;
            cmbproducto.DisplayMember = "nombre";
            cmbproducto.ValueMember = "id";
        }

        private void limpiar()
        {
            txtpnombre.Text = "";
            txtsnombre.Text = "";
            txtpapellido.Text = "";
            txtsapellido.Text = "";
            txtdni.Text = "";
            txtpreseg.Text = "";
            txtresseg.Text = "";
            txttelefono.Text = "";
            cmbsexo.Text = "";
            cmbrol.Text = "";
            txtclavea.Text = "";
            txtclaveb.Text = "";
            txtusuario.Text = "";


        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            if ((txtclavea.Text != txtclaveb.Text) || txtclavea.Text == "" || txtclaveb.Text == "")
            {
                MessageBox.Show("las claves no son iguales ");
                return;
            }

            if (txtpnombre.Text == "" || txtsnombre.Text == "" || txtpapellido.Text == "" ||
                txtsapellido.Text == "" || txtdni.Text == "" || txtpreseg.Text == "" ||
                txtresseg.Text == "" || txttelefono.Text == "" || cmbsexo.Text == "" ||
                cmbrol.Text == "")
            {
                MessageBox.Show("Se debe llenar los campos oblgatorios");
                return;
            }

            model.primernombre = txtpnombre.Text;
            model.segundonombre = txtsnombre.Text;
            model.primerapellido = txtpapellido.Text;
            model.segundoapellido = txtsapellido.Text;
            model.dni = txtdni.Text;
            model.usuario = txtusuario.Text;
            model.clave = seg.Encriptar(  txtclavea.Text);
            model.preguntaSeguridad = txtpreseg.Text;
            model.RespuestaSeguridad = seg.Encriptar( txtresseg.Text);
            model.telefono = txttelefono.Text;
            model.sexo = cmbsexo.Text;
            model.idrol = cmbrol.SelectedValue.ToString();

            controller.Crear(model);

            this.refrescar();
            this.limpiar();
            this.generarnumero();
        }

        private void txtfilpnombre_TextChanged(object sender, EventArgs e)
        {
            string filtername = "primernombre";
            ((DataTable)dgvroles.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtfilpnombre.Text);

        }

        private void Clientefrm_Load(object sender, EventArgs e)
        {
            this.refrescar();
            this.refrescarrol();
            this.generarnumero();
        }

        private void txtsapellido_TextChanged(object sender, EventArgs e)
        {
            if(txtpnombre.Text != "")
            { 
          char  pletra = txtpnombre.Text[0];
            txtusuario.Text = pletra + txtsapellido.Text+ usuario;
            }

        }

        private void btnretirar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de Retirar este cliente?", "Retirar cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                model.id = this.id;
                controller.eliminar(model);
                this.refrescar();
                this.id = "";

            }
          
        }

        private void dgvroles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = dgvroles.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.cargarproductosclientes();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtfilpapellido_TextChanged(object sender, EventArgs e)
        {
            string filtername = "primerapellido";
            ((DataTable)dgvroles.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtfilpapellido.Text);
        }

        private void txtfildni_TextChanged(object sender, EventArgs e)
        {
            string filtername = "dni";
            ((DataTable)dgvroles.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtfildni.Text);
        }

        private void txtfilusuario_TextChanged(object sender, EventArgs e)
        {
            string filtername = "usuario";
            ((DataTable)dgvroles.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtfilusuario.Text);


        }

        private void txtfiltelefono_TextChanged(object sender, EventArgs e)
        {
            string filtername = "telefono";
            ((DataTable)dgvroles.DataSource).DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", filtername,
                txtfiltelefono.Text);


        }

        private void txtporcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void limpiarbeneficiario ()
        {
            txtporcentaje.Text = "";
            txtdnibeneficiario.Text = "";
            txtbeneficiariotel.Text = "";

        }

        private void btnaddbeneficiario_Click(object sender, EventArgs e)
        {
            benmodel.idcliente = this.id;
            benmodel.porcentaje = Convert.ToDecimal( txtporcentaje.Text);
            benmodel.fechanacimiento = dtfechanacben.Value;
            benmodel.identidad = txtdnibeneficiario.Text;
            benmodel.parentesco = cmbparentesco.SelectedValue.ToString();
            benmodel.telefono = txtbeneficiariotel.Text;
            bencontrol.Crear(benmodel);
            this.limpiarbeneficiario();
            this.cargarbeneficiario();

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (tabControl1.SelectedTab == tabbeneficiario)
            {
                if(this.id != "")
                {
                    this.cargarbeneficiario();
                }
                
            }
      
        }

        private void btndelbeneficiario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar este Beneficiario?", "Eliminar Beneficiario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                benmodel.id = this.idbeneficiario;

                bencontrol.eliminar(benmodel);
                this.cargarbeneficiario();


            }

           
        }

        private void dgvbeneficiario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        

            this.idbeneficiario = dgvbeneficiario.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtpnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvroles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grpopciones_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtclaveb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtclavea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtresseg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpreseg_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbsexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbrol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtpapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtsnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabbeneficiario_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtfechanacben_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbparentesco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtbeneficiariotel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtdnibeneficiario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void txtporcentaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvbeneficiario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabproductos_Click(object sender, EventArgs e)
        {

        }

        private void btngeneraccuenta_Click(object sender, EventArgs e)
        {
            productoclientemodel.tipo = "CUENTA";
         txtcuentaproducto.Text =   productoclientecontroller.generanumeracioncuentas(productoclientemodel);
        }

        private void btnagregarprod_Click(object sender, EventArgs e)
        {
            string idproductocliente = "";
            if (this.id == "")
            {
                MessageBox.Show("Se debe seleccionar el cliente");
                return;

            }

            if (txtcuentaproducto.Text == "" || txtsaldoini.Text == "")
            {
                MessageBox.Show("Todos los campos son obigatorios");
                return;

            }

            productoclientemodel.idproducto = cmbproducto.SelectedValue.ToString();
            productoclientemodel.idcliente = this.id;
            productoclientemodel.fechaapertura = dtfechaapertura.Value;
            productoclientemodel.cuenta = txtcuentaproducto.Text;
            productoclientemodel.saldoini = 0;
            productoclientemodel.saldofin = Convert.ToDecimal(txtsaldoini.Text);
            productoclientemodel.saldoant = 0;

            productoclientecontroller.Crear(productoclientemodel);
            idproductocliente = productoclientecontroller.getidproductocliente
                (txtcuentaproducto.Text, productoclientemodel.idcliente);


            transamodel.idsucursal = Properties.Settings.Default.Empresaid;
            transamodel.idcajero = Properties.Settings.Default.Usercajero;
            transamodel.idproductocliente = idproductocliente;
            transamodel.idoperacion = operacontrol.getidoperacion("APERTURA CUENTA");
            transamodel.saldoini = 0;
            transamodel.saldofin = Convert.ToDecimal(txtsaldoini.Text);
            transamodel.saldoant = 0;



            transacontrol.Crear(transamodel);

            txtcuentaproducto.Text = "";
            txtsaldoini.Text = "";

            this.cargarproductosclientes();

        }

        private void btnagencuenta_Click(object sender, EventArgs e)
        {
            productoclientemodel.tipo = "CUENTA";
            txtcuentaproducto.Text = productoclientecontroller.generanumeracioncuentas(productoclientemodel);
        }

        private void btncaddbeneficiario_Click(object sender, EventArgs e)
        {
            benmodel.idcliente = this.id;
            benmodel.porcentaje = Convert.ToDecimal(txtporcentaje.Text);
            benmodel.fechanacimiento = dtfechanacben.Value;
            benmodel.identidad = txtdnibeneficiario.Text;
            benmodel.parentesco = cmbparentesco.SelectedValue.ToString();
            benmodel.telefono = txtbeneficiariotel.Text;
            bencontrol.Crear(benmodel);
            this.limpiarbeneficiario();
            this.cargarbeneficiario();
        }

        private void btncdelbeneficiario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar este Beneficiario?", "Eliminar Beneficiario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                benmodel.id = this.idbeneficiario;

                bencontrol.eliminar(benmodel);
                this.cargarbeneficiario();


            }
        }

        private void btncretirar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de Retirar este cliente?", "Retirar cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                model.id = this.id;
                controller.eliminar(model);
                this.refrescar();
                this.id = "";

            }
        }

        private void btncagregar_Click(object sender, EventArgs e)
        {
            if ((txtclavea.Text != txtclaveb.Text) || txtclavea.Text == "" || txtclaveb.Text == "")
            {
                MessageBox.Show("las claves no son iguales ");
                return;
            }

            if (txtpnombre.Text == "" || txtsnombre.Text == "" || txtpapellido.Text == "" ||
                txtsapellido.Text == "" || txtdni.Text == "" || txtpreseg.Text == "" ||
                txtresseg.Text == "" || txttelefono.Text == "" || cmbsexo.Text == "" ||
                cmbrol.Text == "")
            {
                MessageBox.Show("Se debe llenar los campos oblgatorios");
                return;
            }

            model.primernombre = txtpnombre.Text;
            model.segundonombre = txtsnombre.Text;
            model.primerapellido = txtpapellido.Text;
            model.segundoapellido = txtsapellido.Text;
            model.dni = txtdni.Text;
            model.usuario = txtusuario.Text;
            model.clave = seg.Encriptar(txtclavea.Text);
            model.preguntaSeguridad = txtpreseg.Text;
            model.RespuestaSeguridad = seg.Encriptar(txtresseg.Text);
            model.telefono = txttelefono.Text;
            model.sexo = cmbsexo.Text;
            model.idrol = cmbrol.SelectedValue.ToString();

            controller.Crear(model);

            this.refrescar();
            this.limpiar();
            this.generarnumero();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void Clientefrm_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void btncagregarprod_Click(object sender, EventArgs e)
        {
            string idproductocliente = "";
            if (this.id == "")
            {
                MessageBox.Show("Se debe seleccionar el cliente");
                return;

            }

            if (txtcuentaproducto.Text == "" || txtsaldoini.Text == "")
            {
                MessageBox.Show("Todos los campos son obigatorios");
                return;

            }

            productoclientemodel.idproducto = cmbproducto.SelectedValue.ToString();
            productoclientemodel.idcliente = this.id;
            productoclientemodel.fechaapertura = dtfechaapertura.Value;
            productoclientemodel.cuenta = txtcuentaproducto.Text;
            productoclientemodel.saldoini = 0;
            productoclientemodel.saldofin = Convert.ToDecimal(txtsaldoini.Text);
            productoclientemodel.saldoant = 0;

            productoclientecontroller.Crear(productoclientemodel);
            idproductocliente = productoclientecontroller.getidproductocliente
                (txtcuentaproducto.Text, productoclientemodel.idcliente);


            transamodel.idsucursal = Properties.Settings.Default.Empresaid;
            transamodel.idcajero = Properties.Settings.Default.Usercajero;
            transamodel.idproductocliente = idproductocliente;
            transamodel.idoperacion = operacontrol.getidoperacion("APERTURA CUENTA");
            transamodel.saldoini = 0;
            transamodel.saldofin = Convert.ToDecimal(txtsaldoini.Text);
            transamodel.saldoant = 0;



            transacontrol.Crear(transamodel);

            txtcuentaproducto.Text = "";
            txtsaldoini.Text = "";

            this.cargarproductosclientes();
        }

        private void Clientefrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void Clientefrm_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
