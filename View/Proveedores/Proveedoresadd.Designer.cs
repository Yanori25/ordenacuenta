namespace OrdenaCuenta.View.Proveedores
{
    partial class Proveedoresadd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedoresadd));
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtmonto = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbmoneda = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txttelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtemail = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtdireccion = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtrtn = new MaterialSkin.Controls.MaterialTextBox();
            this.txtcontacto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.btneditar = new MaterialSkin.Controls.MaterialButton();
            this.btncancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnagregar = new MaterialSkin.Controls.MaterialButton();
            this.txsubcuenta = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialLabel9
            // 
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(34, 385);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(128, 75);
            this.materialLabel9.TabIndex = 44;
            this.materialLabel9.Text = "Deuda";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(432, 317);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(95, 19);
            this.materialLabel8.TabIndex = 43;
            this.materialLabel8.Text = "Tipo Moneda";
            // 
            // txtmonto
            // 
            this.txtmonto.AnimateReadOnly = false;
            this.txtmonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmonto.Depth = 0;
            this.txtmonto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtmonto.LeadingIcon = null;
            this.txtmonto.Location = new System.Drawing.Point(168, 380);
            this.txtmonto.MaxLength = 50;
            this.txtmonto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmonto.Multiline = false;
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(233, 50);
            this.txtmonto.TabIndex = 42;
            this.txtmonto.Text = "";
            this.txtmonto.TrailingIcon = null;
            this.txtmonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmonto_KeyPress);
            // 
            // cmbmoneda
            // 
            this.cmbmoneda.AutoResize = false;
            this.cmbmoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbmoneda.Depth = 0;
            this.cmbmoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbmoneda.DropDownHeight = 174;
            this.cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmoneda.DropDownWidth = 121;
            this.cmbmoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbmoneda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbmoneda.FormattingEnabled = true;
            this.cmbmoneda.IntegralHeight = false;
            this.cmbmoneda.ItemHeight = 43;
            this.cmbmoneda.Location = new System.Drawing.Point(617, 314);
            this.cmbmoneda.MaxDropDownItems = 4;
            this.cmbmoneda.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbmoneda.Name = "cmbmoneda";
            this.cmbmoneda.Size = new System.Drawing.Size(233, 49);
            this.cmbmoneda.StartIndex = 0;
            this.cmbmoneda.TabIndex = 41;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(432, 249);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(64, 19);
            this.materialLabel7.TabIndex = 40;
            this.materialLabel7.Text = "Telefono";
            // 
            // txttelefono
            // 
            this.txttelefono.AnimateReadOnly = false;
            this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttelefono.Depth = 0;
            this.txttelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txttelefono.LeadingIcon = null;
            this.txttelefono.Location = new System.Drawing.Point(617, 236);
            this.txttelefono.MaxLength = 50;
            this.txttelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txttelefono.Multiline = false;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(233, 50);
            this.txttelefono.TabIndex = 39;
            this.txttelefono.Text = "";
            this.txttelefono.TrailingIcon = null;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(432, 178);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(41, 19);
            this.materialLabel6.TabIndex = 37;
            this.materialLabel6.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.AnimateReadOnly = false;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Depth = 0;
            this.txtemail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtemail.LeadingIcon = null;
            this.txtemail.Location = new System.Drawing.Point(617, 165);
            this.txtemail.MaxLength = 50;
            this.txtemail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtemail.Multiline = false;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(233, 50);
            this.txtemail.TabIndex = 36;
            this.txtemail.Text = "";
            this.txtemail.TrailingIcon = null;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(33, 251);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(67, 19);
            this.materialLabel5.TabIndex = 35;
            this.materialLabel5.Text = "Direccion";
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdireccion.Depth = 0;
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtdireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtdireccion.Location = new System.Drawing.Point(168, 238);
            this.txtdireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(233, 96);
            this.txtdireccion.TabIndex = 34;
            this.txtdireccion.Text = "";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(33, 177);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(32, 19);
            this.materialLabel4.TabIndex = 33;
            this.materialLabel4.Text = "RTN";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(432, 113);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(65, 19);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Contacto";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(34, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 58);
            this.materialLabel1.TabIndex = 30;
            this.materialLabel1.Text = "Nombre\r\nEmpresa";
            // 
            // txtrtn
            // 
            this.txtrtn.AnimateReadOnly = false;
            this.txtrtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrtn.Depth = 0;
            this.txtrtn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtrtn.LeadingIcon = null;
            this.txtrtn.Location = new System.Drawing.Point(168, 165);
            this.txtrtn.MaxLength = 50;
            this.txtrtn.MouseState = MaterialSkin.MouseState.OUT;
            this.txtrtn.Multiline = false;
            this.txtrtn.Name = "txtrtn";
            this.txtrtn.Size = new System.Drawing.Size(233, 50);
            this.txtrtn.TabIndex = 28;
            this.txtrtn.Text = "";
            this.txtrtn.TrailingIcon = null;
            // 
            // txtcontacto
            // 
            this.txtcontacto.AnimateReadOnly = false;
            this.txtcontacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontacto.Depth = 0;
            this.txtcontacto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcontacto.LeadingIcon = null;
            this.txtcontacto.Location = new System.Drawing.Point(617, 96);
            this.txtcontacto.MaxLength = 50;
            this.txtcontacto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcontacto.Multiline = false;
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(233, 50);
            this.txtcontacto.TabIndex = 27;
            this.txtcontacto.Text = "";
            this.txtcontacto.TrailingIcon = null;
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(168, 96);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(233, 50);
            this.txtnombre.TabIndex = 26;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = null;
            // 
            // btneditar
            // 
            this.btneditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneditar.Depth = 0;
            this.btneditar.HighEmphasis = true;
            this.btneditar.Icon = global::OrdenaCuenta.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.btneditar.Location = new System.Drawing.Point(514, 467);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btneditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneditar.Name = "btneditar";
            this.btneditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneditar.Size = new System.Drawing.Size(99, 36);
            this.btneditar.TabIndex = 50;
            this.btneditar.Text = "Editar";
            this.btneditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btneditar.UseAccentColor = false;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncancelar.Depth = 0;
            this.btncancelar.HighEmphasis = true;
            this.btncancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btncancelar.Icon")));
            this.btncancelar.Location = new System.Drawing.Point(315, 467);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncancelar.Size = new System.Drawing.Size(124, 36);
            this.btncancelar.TabIndex = 45;
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
            this.btnagregar.Location = new System.Drawing.Point(497, 467);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnagregar.Size = new System.Drawing.Size(116, 36);
            this.btnagregar.TabIndex = 38;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnagregar.UseAccentColor = false;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txsubcuenta
            // 
            this.txsubcuenta.AnimateReadOnly = false;
            this.txsubcuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txsubcuenta.Depth = 0;
            this.txsubcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txsubcuenta.Hint = "Sub Cuenta";
            this.txsubcuenta.LeadingIcon = null;
            this.txsubcuenta.Location = new System.Drawing.Point(617, 385);
            this.txsubcuenta.MaxLength = 50;
            this.txsubcuenta.MouseState = MaterialSkin.MouseState.OUT;
            this.txsubcuenta.Multiline = false;
            this.txsubcuenta.Name = "txsubcuenta";
            this.txsubcuenta.ReadOnly = true;
            this.txsubcuenta.Size = new System.Drawing.Size(233, 50);
            this.txsubcuenta.TabIndex = 51;
            this.txsubcuenta.Text = "";
            this.txsubcuenta.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txsubcuenta.TrailingIcon")));
            this.txsubcuenta.Click += new System.EventHandler(this.txsubcuenta_Click);
            // 
            // Proveedoresadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 528);
            this.Controls.Add(this.txsubcuenta);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.cmbmoneda);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtrtn);
            this.Controls.Add(this.txtcontacto);
            this.Controls.Add(this.txtnombre);
            this.Name = "Proveedoresadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Proveedores";
            this.Load += new System.EventHandler(this.Proveedoresadd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btneditar;
        private MaterialSkin.Controls.MaterialButton btncancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox txtmonto;
        private MaterialSkin.Controls.MaterialComboBox cmbmoneda;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox txttelefono;
        private MaterialSkin.Controls.MaterialButton btnagregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txtemail;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtdireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtrtn;
        private MaterialSkin.Controls.MaterialTextBox txtcontacto;
        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialTextBox txsubcuenta;
    }
}