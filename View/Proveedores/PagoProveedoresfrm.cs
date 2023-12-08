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

namespace OrdenaCuenta.View.Proveedores
{
    public partial class PagoProveedoresfrm : MaterialForm
    {

        ProveedoresController provecon = new ProveedoresController();


        ClienteController clicon = new ClienteController();
        Filtros filtrarls = new Filtros();
        ClienteModel climod = new ClienteModel();
        List<ListViewItem> elementosOriginales = new List<ListViewItem>();
        LibroController librocon = new LibroController();
        TipoPagoController tipopagcon = new TipoPagoController();

        subcuentaController subcuentacon = new subcuentaController();

        CorrelativoController correlativocon = new CorrelativoController();
        PartidaController partidacon = new PartidaController();
        CorrelativoController correlacon = new CorrelativoController();

        Partida partidamod = new Partida();
        Correlativo correlamod = new Correlativo();
        PeriodoContableController periodocontablecon = new PeriodoContableController();
        PeriodoContableModel periodocontablemod = new PeriodoContableModel();
        periodoinformeController periodoinfocon = new periodoinformeController();
        periodoinformeModel periodoinfomod = new periodoinformeModel();


        HistoricoMonedaController histmonedacon = new HistoricoMonedaController();
        HistoricoMonedaModel HistoricoMonedaModel = new HistoricoMonedaModel();
        TipoMonedaController monedaController = new TipoMonedaController();
        TipoMonedaModel monedaModel = new TipoMonedaModel();


        string id = "0";
        int idsubcuenta = 0;
        int idcuenta = 0;
        int idpagocuenta = 0;

        decimal Abonopar = 0;
        string usuario = Properties.Settings.Default.Usuario;

        string correlativo = null;


        public PagoProveedoresfrm()
        {
            InitializeComponent();
        }

        private void cargar()
        {

            MaterialListView materialListView = provecon.GetProveedorBuscador(); // clacuenta.GetClasificacionCuenta();

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



        private void cargarcmb()
        {
            cmblibro.DataSource = librocon.GetLibro();

            cmblibro.DisplayMember = "Descripcion";
            cmblibro.ValueMember = "Id";

            cmbtipopago.DataSource = tipopagcon.GetTipoPago();

            cmbtipopago.DisplayMember = "pago";
            cmbtipopago.ValueMember = "id";

            correlativo = correlativocon.GetCorrelativo();

        }



        private void PagoProveedoresfrm_Load(object sender, EventArgs e)
        {
            MaterialFrmEstilo estilo = new MaterialFrmEstilo();

            estilo.frmMaterial(this);

            this.cargar();
            this.cargarcmb();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int periodogenerado = 0;
            int periodoinforme = 0;
            decimal tasacambio = 1;
            string montoconvertido = "";
            string TipoMonedalocal = "";

            if (Convert.ToDecimal(txtmonto.Text) > Convert.ToDecimal(Abonopar))
            {
                MaterialMessageBox.Show("el monto de la deuda supera el monto a pagar");
                return;
            }


            if (txtdescripcion.Text == "" || txtmonto.Text == "0" || id == "0" || txtfecha.Text == "")
            {
                MaterialMessageBox.Show("Se deben llenar los campos obligatorios");
                return;

            }

            periodoinfomod.fechainforme = Convert.ToDateTime(txtfecha.Text);

            periodoinforme = periodoinfocon.periodoinformeestperiodo(periodoinfomod);

            if (periodoinforme > 0)
            {
                MaterialMessageBox.Show("No se puede ingresar movimientos por cierres contables");
                return;
            }


            periodocontablemod.FechaIni = Convert.ToDateTime(txtfecha.Text);

            periodogenerado = periodocontablecon.periodonogenerado(periodocontablemod);


            if (periodogenerado == 0)
            {
                MaterialMessageBox.Show("Se debe de generar un periodo contable");
                return;
            }

            idsubcuenta = provecon.getproveedorsubcue(Convert.ToInt32(this.id));
            idcuenta = subcuentacon.getsubcuentaidcuenta(idsubcuenta);
            idpagocuenta = tipopagcon.getTipoPagogetcuenta(Convert.ToInt32(cmbtipopago.SelectedValue.ToString()));

            monedaModel.Id = idcuenta;
            TipoMonedalocal = monedaController.TipoMonedalocal(monedaModel);

            if (TipoMonedalocal != "HNL")
            {
                HistoricoMonedaModel.Fecha = Convert.ToDateTime(txtfecha.Text);
                HistoricoMonedaModel.Id = idcuenta;
                HistoricoMonedaModel.estado = "paga";

                tasacambio = histmonedacon.HistoricoMonedaconversion(HistoricoMonedaModel);
            }
            montoconvertido = Convert.ToString(tasacambio * Convert.ToDecimal(txtmonto.Text));





            // crea el debe 
            partidamod.Asiento = Convert.ToInt32(correlativo); // Suponiendo que la primera columna contiene el dato que deseas insertar
            partidamod.Fecha = Convert.ToDateTime(txtfecha.Text); // Suponiendo que la segunda columna contiene otro dato
            partidamod.CuentaPar = idcuenta;// Convert.ToInt32(item.SubItems[6].Text);
            partidamod.Parcial = 0;
            partidamod.Debe = (int)Math.Round(Convert.ToDecimal(montoconvertido));
            partidamod.Haber = 0;
            partidamod.Referencia = txtdescripcion.Text;
            partidamod.ParIdEmpresa = 3;
            partidamod.ParIdLibro = Convert.ToInt32(cmblibro.SelectedValue.ToString());
            partidamod.UsuarioCreacion = usuario;
            partidamod.TipoTransaccion = "Pagoproveedor";
            partidamod.estado = "partproveedor";
            partidamod.subcueid = idsubcuenta;

            partidacon.Crear(partidamod);

            // crea el haber 
            partidamod.Asiento = Convert.ToInt32(correlativo); // Suponiendo que la primera columna contiene el dato que deseas insertar
            partidamod.Fecha = Convert.ToDateTime(txtfecha.Text); // Suponiendo que la segunda columna contiene otro dato
            partidamod.CuentaPar = idpagocuenta  ;// Convert.ToInt32(item.SubItems[6].Text);
            partidamod.Parcial = 0;
            partidamod.Debe = 0;
            partidamod.Haber = (int)Math.Round(Convert.ToDecimal(montoconvertido));
            partidamod.Referencia = txtdescripcion.Text;
            partidamod.ParIdEmpresa = 3;
            partidamod.ParIdLibro = Convert.ToInt32(cmblibro.SelectedValue.ToString());
            partidamod.UsuarioCreacion = usuario;
            partidamod.TipoTransaccion = "Pagoproveedor";
            partidamod.estado = "partproveedorpaga";
            partidamod.subcueid = idsubcuenta;

            partidacon.Crear(partidamod);




            correlamod.Descripcion = "Asiento";

            correlacon.Crear(correlamod);

            txtdescripcion.Text = "";
            txtfecha.Text = "";
            txtmonto.Text = "";

            this.cargar();
            MaterialMessageBox.Show("Se agrego exitosamente");
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprimir la entrada
                e.Handled = true;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtfecha.Text = monthCalendar1.SelectionStart.ToShortDateString();
            // Ocultar el MonthCalendar después de la selección
            monthCalendar1.Visible = false;

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

        private void lsclientes_Click(object sender, EventArgs e)
        {
            this.id = lsclientes.SelectedItems[0].Text;
            this.Abonopar = Convert.ToDecimal(lsclientes.SelectedItems[0].SubItems[6].Text);

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtnombre.Text.ToLower();

            filtrarls.Filtrarlistview(filtro, elementosOriginales, lsclientes);
        }
    }
}
