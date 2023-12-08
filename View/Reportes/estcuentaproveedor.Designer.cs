namespace OrdenaCuenta.View.Reportes
{
    partial class estcuentaproveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estcuentaproveedor));
            this.btagregar = new MaterialSkin.Controls.MaterialButton();
            this.txtruta = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lsclientes = new MaterialSkin.Controls.MaterialListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.segundoNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.segundoApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moneda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtrtn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.swinaturaleza = new MaterialSkin.Controls.MaterialSwitch();
            this.SuspendLayout();
            // 
            // btagregar
            // 
            this.btagregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btagregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btagregar.Depth = 0;
            this.btagregar.HighEmphasis = true;
            this.btagregar.Icon = global::OrdenaCuenta.Properties.Resources.add_insert_plus_icon_1495461;
            this.btagregar.Location = new System.Drawing.Point(374, 388);
            this.btagregar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btagregar.Name = "btagregar";
            this.btagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btagregar.Size = new System.Drawing.Size(182, 36);
            this.btagregar.TabIndex = 34;
            this.btagregar.Text = "Generar reporte";
            this.btagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btagregar.UseAccentColor = false;
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // txtruta
            // 
            this.txtruta.AnimateReadOnly = false;
            this.txtruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtruta.Depth = 0;
            this.txtruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtruta.Hint = "Nombre del archivo";
            this.txtruta.LeadingIcon = null;
            this.txtruta.Location = new System.Drawing.Point(14, 317);
            this.txtruta.Margin = new System.Windows.Forms.Padding(2);
            this.txtruta.MaxLength = 50;
            this.txtruta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtruta.Multiline = false;
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(327, 50);
            this.txtruta.TabIndex = 78;
            this.txtruta.Text = "";
            this.txtruta.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtruta.TrailingIcon")));
            this.txtruta.TextChanged += new System.EventHandler(this.txtruta_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(57, 86);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 28);
            this.materialLabel1.TabIndex = 81;
            this.materialLabel1.Text = "Buscar";
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
            this.txtrtn});
            this.lsclientes.Depth = 0;
            this.lsclientes.FullRowSelect = true;
            this.lsclientes.HideSelection = false;
            this.lsclientes.Location = new System.Drawing.Point(14, 142);
            this.lsclientes.Margin = new System.Windows.Forms.Padding(2);
            this.lsclientes.MinimumSize = new System.Drawing.Size(150, 81);
            this.lsclientes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsclientes.MouseState = MaterialSkin.MouseState.OUT;
            this.lsclientes.Name = "lsclientes";
            this.lsclientes.OwnerDraw = true;
            this.lsclientes.Size = new System.Drawing.Size(565, 158);
            this.lsclientes.TabIndex = 79;
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
            this.Nombre.Text = "Empresa";
            this.Nombre.Width = 200;
            // 
            // segundoNombre
            // 
            this.segundoNombre.Text = "Contacto";
            this.segundoNombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.Text = "email";
            this.Apellido.Width = 150;
            // 
            // segundoApellido
            // 
            this.segundoApellido.Text = "Telefono";
            this.segundoApellido.Width = 200;
            // 
            // Abono
            // 
            this.Abono.Text = "RTN";
            this.Abono.Width = 200;
            // 
            // moneda
            // 
            this.moneda.Text = "Deuda";
            this.moneda.Width = 250;
            // 
            // txtrtn
            // 
            this.txtrtn.Text = "Moneda";
            this.txtrtn.Width = 200;
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.Hint = "Buscar";
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(198, 77);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(181, 50);
            this.txtnombre.TabIndex = 80;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtnombre.TrailingIcon")));
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // swinaturaleza
            // 
            this.swinaturaleza.Depth = 0;
            this.swinaturaleza.Location = new System.Drawing.Point(361, 340);
            this.swinaturaleza.Margin = new System.Windows.Forms.Padding(0);
            this.swinaturaleza.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swinaturaleza.MouseState = MaterialSkin.MouseState.HOVER;
            this.swinaturaleza.Name = "swinaturaleza";
            this.swinaturaleza.Ripple = true;
            this.swinaturaleza.Size = new System.Drawing.Size(218, 27);
            this.swinaturaleza.TabIndex = 82;
            this.swinaturaleza.UseVisualStyleBackColor = true;
            this.swinaturaleza.CheckedChanged += new System.EventHandler(this.swinaturaleza_CheckedChanged);
            // 
            // estcuentaproveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.swinaturaleza);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lsclientes);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.btagregar);
            this.Name = "estcuentaproveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTADO DE CUENTA DE PROVEEDORES";
            this.Load += new System.EventHandler(this.estcuentaproveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btagregar;
        private MaterialSkin.Controls.MaterialTextBox txtruta;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView lsclientes;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader segundoNombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader segundoApellido;
        private System.Windows.Forms.ColumnHeader Abono;
        private System.Windows.Forms.ColumnHeader moneda;
        private System.Windows.Forms.ColumnHeader txtrtn;
        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialSwitch swinaturaleza;
    }
}