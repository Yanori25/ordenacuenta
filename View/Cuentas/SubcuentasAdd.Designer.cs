namespace OrdenaCuenta.View.Cuentas
{
    partial class SubcuentasAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubcuentasAdd));
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.matlistCuenta = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btncancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnagregar = new MaterialSkin.Controls.MaterialButton();
            this.txtcuenta = new MaterialSkin.Controls.MaterialTextBox();
            this.txtdescripcion = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(236, 87);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(241, 50);
            this.txtnombre.TabIndex = 50;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtnombre.TrailingIcon")));
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(47, 99);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(119, 34);
            this.materialLabel1.TabIndex = 51;
            this.materialLabel1.Text = "Buscar";
            // 
            // matlistCuenta
            // 
            this.matlistCuenta.AutoSizeTable = false;
            this.matlistCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matlistCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matlistCuenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.matlistCuenta.Depth = 0;
            this.matlistCuenta.FullRowSelect = true;
            this.matlistCuenta.HideSelection = false;
            this.matlistCuenta.Location = new System.Drawing.Point(6, 164);
            this.matlistCuenta.MinimumSize = new System.Drawing.Size(200, 100);
            this.matlistCuenta.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matlistCuenta.MouseState = MaterialSkin.MouseState.OUT;
            this.matlistCuenta.Name = "matlistCuenta";
            this.matlistCuenta.OwnerDraw = true;
            this.matlistCuenta.Size = new System.Drawing.Size(749, 268);
            this.matlistCuenta.TabIndex = 49;
            this.matlistCuenta.UseCompatibleStateImageBehavior = false;
            this.matlistCuenta.View = System.Windows.Forms.View.Details;
            this.matlistCuenta.SelectedIndexChanged += new System.EventHandler(this.matlistCuenta_SelectedIndexChanged);
            this.matlistCuenta.Click += new System.EventHandler(this.matlistCuenta_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CuentaContable";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descripcion";
            this.columnHeader3.Width = 250;
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSize = false;
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncancelar.Depth = 0;
            this.btncancelar.HighEmphasis = true;
            this.btncancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btncancelar.Icon")));
            this.btncancelar.Location = new System.Drawing.Point(157, 536);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncancelar.Size = new System.Drawing.Size(180, 36);
            this.btncancelar.TabIndex = 53;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btncancelar.UseAccentColor = false;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.AutoSize = false;
            this.btnagregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnagregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnagregar.Depth = 0;
            this.btnagregar.HighEmphasis = true;
            this.btnagregar.Icon = ((System.Drawing.Image)(resources.GetObject("btnagregar.Icon")));
            this.btnagregar.Location = new System.Drawing.Point(421, 536);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnagregar.Size = new System.Drawing.Size(180, 36);
            this.btnagregar.TabIndex = 52;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnagregar.UseAccentColor = false;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtcuenta
            // 
            this.txtcuenta.AnimateReadOnly = false;
            this.txtcuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcuenta.Depth = 0;
            this.txtcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcuenta.Hint = "Cuenta";
            this.txtcuenta.LeadingIcon = null;
            this.txtcuenta.Location = new System.Drawing.Point(50, 467);
            this.txtcuenta.MaxLength = 50;
            this.txtcuenta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcuenta.Multiline = false;
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.Size = new System.Drawing.Size(241, 50);
            this.txtcuenta.TabIndex = 54;
            this.txtcuenta.Text = "";
            this.txtcuenta.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtcuenta.TrailingIcon")));
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.AnimateReadOnly = false;
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescripcion.Depth = 0;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtdescripcion.Hint = "Descripcion";
            this.txtdescripcion.LeadingIcon = null;
            this.txtdescripcion.Location = new System.Drawing.Point(455, 467);
            this.txtdescripcion.MaxLength = 50;
            this.txtdescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtdescripcion.Multiline = false;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(241, 50);
            this.txtdescripcion.TabIndex = 56;
            this.txtdescripcion.Text = "";
            this.txtdescripcion.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtdescripcion.TrailingIcon")));
            // 
            // SubcuentasAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 600);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcuenta);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.matlistCuenta);
            this.Name = "SubcuentasAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Sub Cuentas";
            this.Load += new System.EventHandler(this.SubcuentasAdd_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView matlistCuenta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialButton btncancelar;
        private MaterialSkin.Controls.MaterialButton btnagregar;
        private MaterialSkin.Controls.MaterialTextBox txtcuenta;
        private MaterialSkin.Controls.MaterialTextBox txtdescripcion;
    }
}