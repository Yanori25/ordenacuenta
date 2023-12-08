namespace OrdenaCuenta.View
{
    partial class CuentaAddfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuentaAddfrm));
            this.txtdescripcion = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbclase = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbmoneda = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbdettipo = new MaterialSkin.Controls.MaterialComboBox();
            this.txtcuenta = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnagregar = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.AnimateReadOnly = false;
            this.txtdescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtdescripcion.Depth = 0;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtdescripcion.HideSelection = true;
            this.txtdescripcion.LeadingIcon = null;
            this.txtdescripcion.Location = new System.Drawing.Point(161, 226);
            this.txtdescripcion.MaxLength = 32767;
            this.txtdescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.PasswordChar = '\0';
            this.txtdescripcion.PrefixSuffixText = null;
            this.txtdescripcion.ReadOnly = false;
            this.txtdescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdescripcion.SelectedText = "";
            this.txtdescripcion.SelectionLength = 0;
            this.txtdescripcion.SelectionStart = 0;
            this.txtdescripcion.ShortcutsEnabled = true;
            this.txtdescripcion.Size = new System.Drawing.Size(314, 48);
            this.txtdescripcion.TabIndex = 1;
            this.txtdescripcion.TabStop = false;
            this.txtdescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtdescripcion.TrailingIcon = null;
            this.txtdescripcion.UseSystemPasswordChar = false;
            // 
            // cmbclase
            // 
            this.cmbclase.AutoResize = false;
            this.cmbclase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbclase.Depth = 0;
            this.cmbclase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbclase.DropDownHeight = 174;
            this.cmbclase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbclase.DropDownWidth = 121;
            this.cmbclase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbclase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbclase.FormattingEnabled = true;
            this.cmbclase.IntegralHeight = false;
            this.cmbclase.ItemHeight = 43;
            this.cmbclase.Location = new System.Drawing.Point(162, 149);
            this.cmbclase.MaxDropDownItems = 4;
            this.cmbclase.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbclase.Name = "cmbclase";
            this.cmbclase.Size = new System.Drawing.Size(313, 49);
            this.cmbclase.StartIndex = 0;
            this.cmbclase.TabIndex = 3;
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
            this.cmbmoneda.Location = new System.Drawing.Point(162, 80);
            this.cmbmoneda.MaxDropDownItems = 4;
            this.cmbmoneda.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbmoneda.Name = "cmbmoneda";
            this.cmbmoneda.Size = new System.Drawing.Size(313, 49);
            this.cmbmoneda.StartIndex = 0;
            this.cmbmoneda.TabIndex = 4;
            this.cmbmoneda.SelectedIndexChanged += new System.EventHandler(this.cmbmoneda_SelectedIndexChanged);
            // 
            // cmbdettipo
            // 
            this.cmbdettipo.AutoResize = false;
            this.cmbdettipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbdettipo.Depth = 0;
            this.cmbdettipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbdettipo.DropDownHeight = 174;
            this.cmbdettipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdettipo.DropDownWidth = 121;
            this.cmbdettipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbdettipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbdettipo.FormattingEnabled = true;
            this.cmbdettipo.IntegralHeight = false;
            this.cmbdettipo.ItemHeight = 43;
            this.cmbdettipo.Items.AddRange(new object[] {
            "DETALLE",
            "AGRUPADO"});
            this.cmbdettipo.Location = new System.Drawing.Point(664, 94);
            this.cmbdettipo.MaxDropDownItems = 4;
            this.cmbdettipo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbdettipo.Name = "cmbdettipo";
            this.cmbdettipo.Size = new System.Drawing.Size(313, 49);
            this.cmbdettipo.StartIndex = 0;
            this.cmbdettipo.TabIndex = 5;
            // 
            // txtcuenta
            // 
            this.txtcuenta.AnimateReadOnly = false;
            this.txtcuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtcuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcuenta.Depth = 0;
            this.txtcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcuenta.HideSelection = true;
            this.txtcuenta.LeadingIcon = null;
            this.txtcuenta.Location = new System.Drawing.Point(664, 164);
            this.txtcuenta.MaxLength = 32767;
            this.txtcuenta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.PasswordChar = '\0';
            this.txtcuenta.PrefixSuffixText = null;
            this.txtcuenta.ReadOnly = false;
            this.txtcuenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcuenta.SelectedText = "";
            this.txtcuenta.SelectionLength = 0;
            this.txtcuenta.SelectionStart = 0;
            this.txtcuenta.ShortcutsEnabled = true;
            this.txtcuenta.Size = new System.Drawing.Size(314, 48);
            this.txtcuenta.TabIndex = 6;
            this.txtcuenta.TabStop = false;
            this.txtcuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcuenta.TrailingIcon = null;
            this.txtcuenta.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(491, 179);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(133, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Cuenta\r\n Contable:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(15, 236);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(88, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Descripcion:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(15, 163);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(98, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Clase Cuenta:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(15, 94);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(63, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Moneda:";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(491, 94);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(91, 19);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Tipo Cuenta:";
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnagregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnagregar.Depth = 0;
            this.btnagregar.HighEmphasis = true;
            this.btnagregar.Icon = global::OrdenaCuenta.Properties.Resources.add_insert_plus_icon_149546;
            this.btnagregar.Image = global::OrdenaCuenta.Properties.Resources.add_insert_plus_icon_149546;
            this.btnagregar.Location = new System.Drawing.Point(510, 236);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnagregar.Size = new System.Drawing.Size(176, 36);
            this.btnagregar.TabIndex = 13;
            this.btnagregar.Text = "Agregar Cuenta";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnagregar.UseAccentColor = false;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.Image = global::OrdenaCuenta.Properties.Resources.add_insert_plus_icon_149546;
            this.materialButton1.Location = new System.Drawing.Point(804, 238);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(124, 36);
            this.materialButton1.TabIndex = 14;
            this.materialButton1.Text = "Cancelar";
            this.materialButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // CuentaAddfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 365);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtcuenta);
            this.Controls.Add(this.cmbdettipo);
            this.Controls.Add(this.cmbmoneda);
            this.Controls.Add(this.cmbclase);
            this.Controls.Add(this.txtdescripcion);
            this.Name = "CuentaAddfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cuenta";
            this.Load += new System.EventHandler(this.CuentaAddfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 txtdescripcion;
        private MaterialSkin.Controls.MaterialComboBox cmbclase;
        private MaterialSkin.Controls.MaterialComboBox cmbmoneda;
        private MaterialSkin.Controls.MaterialComboBox cmbdettipo;
        private MaterialSkin.Controls.MaterialTextBox2 txtcuenta;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton btnagregar;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}