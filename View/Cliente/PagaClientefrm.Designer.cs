namespace OrdenaCuenta.View.Cliente
{
    partial class PagaClientefrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagaClientefrm));
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.lsclientes = new MaterialSkin.Controls.MaterialListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.segundoNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.segundoApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moneda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtrtn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtmonto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtdescripcion = new MaterialSkin.Controls.MaterialTextBox();
            this.btncancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnagregar = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtfecha = new MaterialSkin.Controls.MaterialTextBox();
            this.cmblibro = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbtipopago = new MaterialSkin.Controls.MaterialComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.Hint = "Buscar";
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(270, 95);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(241, 50);
            this.txtnombre.TabIndex = 12;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtnombre.TrailingIcon")));
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // lsclientes
            // 
            this.lsclientes.AutoSizeTable = false;
            this.lsclientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsclientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsclientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nombre,
            this.segundoNombre,
            this.Apellido,
            this.segundoApellido,
            this.Abono,
            this.moneda,
            this.txtrtn,
            this.columnHeader2});
            this.lsclientes.Depth = 0;
            this.lsclientes.FullRowSelect = true;
            this.lsclientes.HideSelection = false;
            this.lsclientes.Location = new System.Drawing.Point(24, 162);
            this.lsclientes.MinimumSize = new System.Drawing.Size(200, 100);
            this.lsclientes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsclientes.MouseState = MaterialSkin.MouseState.OUT;
            this.lsclientes.Name = "lsclientes";
            this.lsclientes.OwnerDraw = true;
            this.lsclientes.Size = new System.Drawing.Size(753, 194);
            this.lsclientes.TabIndex = 11;
            this.lsclientes.UseCompatibleStateImageBehavior = false;
            this.lsclientes.View = System.Windows.Forms.View.Details;
            this.lsclientes.Click += new System.EventHandler(this.lsclientes_Click);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 100;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 100;
            // 
            // segundoNombre
            // 
            this.segundoNombre.Text = "Seg Nombre";
            this.segundoNombre.Width = 130;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 100;
            // 
            // segundoApellido
            // 
            this.segundoApellido.Text = "Seg Apellido";
            this.segundoApellido.Width = 130;
            // 
            // Abono
            // 
            this.Abono.Text = "Abono";
            this.Abono.Width = 120;
            // 
            // moneda
            // 
            this.moneda.Text = "moneda";
            // 
            // txtrtn
            // 
            this.txtrtn.Text = "rtn";
            this.txtrtn.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NombreCia";
            this.columnHeader2.Width = 200;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(81, 107);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(119, 34);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Buscar";
            // 
            // txtmonto
            // 
            this.txtmonto.AnimateReadOnly = false;
            this.txtmonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmonto.Depth = 0;
            this.txtmonto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtmonto.Hint = "Monto";
            this.txtmonto.LeadingIcon = null;
            this.txtmonto.Location = new System.Drawing.Point(24, 452);
            this.txtmonto.MaxLength = 50;
            this.txtmonto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmonto.Multiline = false;
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(321, 50);
            this.txtmonto.TabIndex = 14;
            this.txtmonto.Text = "";
            this.txtmonto.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtmonto.TrailingIcon")));
            this.txtmonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmonto_KeyPress);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.AnimateReadOnly = false;
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescripcion.Depth = 0;
            this.txtdescripcion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtdescripcion.Hint = "Descripcion";
            this.txtdescripcion.LeadingIcon = null;
            this.txtdescripcion.Location = new System.Drawing.Point(372, 379);
            this.txtdescripcion.MaxLength = 50;
            this.txtdescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtdescripcion.Multiline = false;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(405, 50);
            this.txtdescripcion.TabIndex = 15;
            this.txtdescripcion.Text = "";
            this.txtdescripcion.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtdescripcion.TrailingIcon")));
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncancelar.Depth = 0;
            this.btncancelar.HighEmphasis = true;
            this.btncancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btncancelar.Icon")));
            this.btncancelar.Location = new System.Drawing.Point(626, 526);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncancelar.Size = new System.Drawing.Size(124, 36);
            this.btncancelar.TabIndex = 22;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btncancelar.UseAccentColor = false;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnagregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnagregar.Depth = 0;
            this.btnagregar.HighEmphasis = true;
            this.btnagregar.Icon = ((System.Drawing.Image)(resources.GetObject("btnagregar.Icon")));
            this.btnagregar.Location = new System.Drawing.Point(456, 526);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnagregar.Size = new System.Drawing.Size(116, 36);
            this.btnagregar.TabIndex = 21;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnagregar.UseAccentColor = false;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 385);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.AnimateReadOnly = false;
            this.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfecha.Depth = 0;
            this.txtfecha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtfecha.Hint = "Fecha";
            this.txtfecha.LeadingIcon = null;
            this.txtfecha.Location = new System.Drawing.Point(24, 379);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfecha.MaxLength = 50;
            this.txtfecha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtfecha.Multiline = false;
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(321, 50);
            this.txtfecha.TabIndex = 23;
            this.txtfecha.Text = "";
            this.txtfecha.TrailingIcon = null;
            // 
            // cmblibro
            // 
            this.cmblibro.AutoResize = false;
            this.cmblibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmblibro.Depth = 0;
            this.cmblibro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmblibro.DropDownHeight = 174;
            this.cmblibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblibro.DropDownWidth = 121;
            this.cmblibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmblibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmblibro.FormattingEnabled = true;
            this.cmblibro.Hint = "Seleccionar Libro";
            this.cmblibro.IntegralHeight = false;
            this.cmblibro.ItemHeight = 43;
            this.cmblibro.Location = new System.Drawing.Point(372, 453);
            this.cmblibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmblibro.MaxDropDownItems = 4;
            this.cmblibro.MouseState = MaterialSkin.MouseState.OUT;
            this.cmblibro.Name = "cmblibro";
            this.cmblibro.Size = new System.Drawing.Size(405, 49);
            this.cmblibro.StartIndex = 0;
            this.cmblibro.TabIndex = 25;
            // 
            // cmbtipopago
            // 
            this.cmbtipopago.AutoResize = false;
            this.cmbtipopago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbtipopago.Depth = 0;
            this.cmbtipopago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbtipopago.DropDownHeight = 174;
            this.cmbtipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipopago.DropDownWidth = 121;
            this.cmbtipopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbtipopago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbtipopago.FormattingEnabled = true;
            this.cmbtipopago.Hint = "Seleccionar Tipo de pago";
            this.cmbtipopago.IntegralHeight = false;
            this.cmbtipopago.ItemHeight = 43;
            this.cmbtipopago.Location = new System.Drawing.Point(24, 526);
            this.cmbtipopago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbtipopago.MaxDropDownItems = 4;
            this.cmbtipopago.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbtipopago.Name = "cmbtipopago";
            this.cmbtipopago.Size = new System.Drawing.Size(373, 49);
            this.cmbtipopago.StartIndex = 0;
            this.cmbtipopago.TabIndex = 26;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(310, 149);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // PagaClientefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.cmbtipopago);
            this.Controls.Add(this.cmblibro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lsclientes);
            this.Name = "PagaClientefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por Cobrar (Clientes)";
            this.Load += new System.EventHandler(this.PagaClientefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialListView lsclientes;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader segundoNombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader segundoApellido;
        private System.Windows.Forms.ColumnHeader Abono;
        private System.Windows.Forms.ColumnHeader moneda;
        private System.Windows.Forms.ColumnHeader txtrtn;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtmonto;
        private MaterialSkin.Controls.MaterialTextBox txtdescripcion;
        private MaterialSkin.Controls.MaterialButton btncancelar;
        private MaterialSkin.Controls.MaterialButton btnagregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox txtfecha;
        private MaterialSkin.Controls.MaterialComboBox cmblibro;
        private MaterialSkin.Controls.MaterialComboBox cmbtipopago;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}