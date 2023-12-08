namespace OrdenaCuenta.View.periodo
{
    partial class PeriodoAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodoAdd));
            this.calfechaini = new System.Windows.Forms.MonthCalendar();
            this.pbfechaini = new System.Windows.Forms.PictureBox();
            this.txtfechaini = new MaterialSkin.Controls.MaterialTextBox();
            this.pbfechafin = new System.Windows.Forms.PictureBox();
            this.txtfechafin = new MaterialSkin.Controls.MaterialTextBox();
            this.pbfecpago = new System.Windows.Forms.PictureBox();
            this.txtfechapago = new MaterialSkin.Controls.MaterialTextBox();
            this.pbfechcorte = new System.Windows.Forms.PictureBox();
            this.txtfeccorte = new MaterialSkin.Controls.MaterialTextBox();
            this.calfecfin = new System.Windows.Forms.MonthCalendar();
            this.calfecpago = new System.Windows.Forms.MonthCalendar();
            this.calfeccorte = new System.Windows.Forms.MonthCalendar();
            this.cmbdettipo = new MaterialSkin.Controls.MaterialComboBox();
            this.btneditar = new MaterialSkin.Controls.MaterialButton();
            this.btncancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnagregar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbfechaini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfechafin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfecpago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfechcorte)).BeginInit();
            this.SuspendLayout();
            // 
            // calfechaini
            // 
            this.calfechaini.Location = new System.Drawing.Point(349, 309);
            this.calfechaini.Margin = new System.Windows.Forms.Padding(7);
            this.calfechaini.Name = "calfechaini";
            this.calfechaini.TabIndex = 28;
            this.calfechaini.Visible = false;
            this.calfechaini.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calfechaini_DateSelected);
            // 
            // pbfechaini
            // 
            this.pbfechaini.Image = ((System.Drawing.Image)(resources.GetObject("pbfechaini.Image")));
            this.pbfechaini.Location = new System.Drawing.Point(160, 94);
            this.pbfechaini.Margin = new System.Windows.Forms.Padding(2);
            this.pbfechaini.Name = "pbfechaini";
            this.pbfechaini.Size = new System.Drawing.Size(32, 32);
            this.pbfechaini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbfechaini.TabIndex = 26;
            this.pbfechaini.TabStop = false;
            this.pbfechaini.Click += new System.EventHandler(this.pbfechaini_Click);
            // 
            // txtfechaini
            // 
            this.txtfechaini.AnimateReadOnly = false;
            this.txtfechaini.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfechaini.Depth = 0;
            this.txtfechaini.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtfechaini.Hint = "Fecha Inicio";
            this.txtfechaini.LeadingIcon = null;
            this.txtfechaini.Location = new System.Drawing.Point(16, 89);
            this.txtfechaini.Margin = new System.Windows.Forms.Padding(2);
            this.txtfechaini.MaxLength = 50;
            this.txtfechaini.MouseState = MaterialSkin.MouseState.OUT;
            this.txtfechaini.Multiline = false;
            this.txtfechaini.Name = "txtfechaini";
            this.txtfechaini.Size = new System.Drawing.Size(175, 50);
            this.txtfechaini.TabIndex = 25;
            this.txtfechaini.Text = "";
            this.txtfechaini.TrailingIcon = null;
            // 
            // pbfechafin
            // 
            this.pbfechafin.Image = ((System.Drawing.Image)(resources.GetObject("pbfechafin.Image")));
            this.pbfechafin.Location = new System.Drawing.Point(388, 94);
            this.pbfechafin.Margin = new System.Windows.Forms.Padding(2);
            this.pbfechafin.Name = "pbfechafin";
            this.pbfechafin.Size = new System.Drawing.Size(32, 32);
            this.pbfechafin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbfechafin.TabIndex = 30;
            this.pbfechafin.TabStop = false;
            this.pbfechafin.Click += new System.EventHandler(this.pbfechafin_Click);
            // 
            // txtfechafin
            // 
            this.txtfechafin.AnimateReadOnly = false;
            this.txtfechafin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfechafin.Depth = 0;
            this.txtfechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtfechafin.Hint = "Fecha fin";
            this.txtfechafin.LeadingIcon = null;
            this.txtfechafin.Location = new System.Drawing.Point(244, 89);
            this.txtfechafin.Margin = new System.Windows.Forms.Padding(2);
            this.txtfechafin.MaxLength = 50;
            this.txtfechafin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtfechafin.Multiline = false;
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(175, 50);
            this.txtfechafin.TabIndex = 29;
            this.txtfechafin.Text = "";
            this.txtfechafin.TrailingIcon = null;
            // 
            // pbfecpago
            // 
            this.pbfecpago.Image = ((System.Drawing.Image)(resources.GetObject("pbfecpago.Image")));
            this.pbfecpago.Location = new System.Drawing.Point(160, 180);
            this.pbfecpago.Margin = new System.Windows.Forms.Padding(2);
            this.pbfecpago.Name = "pbfecpago";
            this.pbfecpago.Size = new System.Drawing.Size(32, 32);
            this.pbfecpago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbfecpago.TabIndex = 32;
            this.pbfecpago.TabStop = false;
            this.pbfecpago.Click += new System.EventHandler(this.pbfecpago_Click);
            // 
            // txtfechapago
            // 
            this.txtfechapago.AnimateReadOnly = false;
            this.txtfechapago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfechapago.Depth = 0;
            this.txtfechapago.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtfechapago.Hint = "Fecha pago";
            this.txtfechapago.LeadingIcon = null;
            this.txtfechapago.Location = new System.Drawing.Point(16, 175);
            this.txtfechapago.Margin = new System.Windows.Forms.Padding(2);
            this.txtfechapago.MaxLength = 50;
            this.txtfechapago.MouseState = MaterialSkin.MouseState.OUT;
            this.txtfechapago.Multiline = false;
            this.txtfechapago.Name = "txtfechapago";
            this.txtfechapago.Size = new System.Drawing.Size(175, 50);
            this.txtfechapago.TabIndex = 31;
            this.txtfechapago.Text = "";
            this.txtfechapago.TrailingIcon = null;
            // 
            // pbfechcorte
            // 
            this.pbfechcorte.Image = ((System.Drawing.Image)(resources.GetObject("pbfechcorte.Image")));
            this.pbfechcorte.Location = new System.Drawing.Point(388, 180);
            this.pbfechcorte.Margin = new System.Windows.Forms.Padding(2);
            this.pbfechcorte.Name = "pbfechcorte";
            this.pbfechcorte.Size = new System.Drawing.Size(32, 32);
            this.pbfechcorte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbfechcorte.TabIndex = 34;
            this.pbfechcorte.TabStop = false;
            this.pbfechcorte.Click += new System.EventHandler(this.pbfechcorte_Click);
            // 
            // txtfeccorte
            // 
            this.txtfeccorte.AnimateReadOnly = false;
            this.txtfeccorte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfeccorte.Depth = 0;
            this.txtfeccorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtfeccorte.Hint = "Fecha Corte";
            this.txtfeccorte.LeadingIcon = null;
            this.txtfeccorte.Location = new System.Drawing.Point(244, 175);
            this.txtfeccorte.Margin = new System.Windows.Forms.Padding(2);
            this.txtfeccorte.MaxLength = 50;
            this.txtfeccorte.MouseState = MaterialSkin.MouseState.OUT;
            this.txtfeccorte.Multiline = false;
            this.txtfeccorte.Name = "txtfeccorte";
            this.txtfeccorte.Size = new System.Drawing.Size(175, 50);
            this.txtfeccorte.TabIndex = 33;
            this.txtfeccorte.Text = "";
            this.txtfeccorte.TrailingIcon = null;
            // 
            // calfecfin
            // 
            this.calfecfin.Location = new System.Drawing.Point(262, 337);
            this.calfecfin.Margin = new System.Windows.Forms.Padding(7);
            this.calfecfin.Name = "calfecfin";
            this.calfecfin.TabIndex = 35;
            this.calfecfin.Visible = false;
            this.calfecfin.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calfecfin_DateSelected);
            // 
            // calfecpago
            // 
            this.calfecpago.Location = new System.Drawing.Point(100, 353);
            this.calfecpago.Margin = new System.Windows.Forms.Padding(7);
            this.calfecpago.Name = "calfecpago";
            this.calfecpago.TabIndex = 36;
            this.calfecpago.Visible = false;
            this.calfecpago.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calfecpago_DateSelected);
            // 
            // calfeccorte
            // 
            this.calfeccorte.Location = new System.Drawing.Point(35, 353);
            this.calfeccorte.Margin = new System.Windows.Forms.Padding(7);
            this.calfeccorte.Name = "calfeccorte";
            this.calfeccorte.TabIndex = 37;
            this.calfeccorte.Visible = false;
            this.calfeccorte.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calfeccorte_DateSelected);
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
            this.cmbdettipo.Hint = "Seleccione la frecuencia";
            this.cmbdettipo.IntegralHeight = false;
            this.cmbdettipo.ItemHeight = 43;
            this.cmbdettipo.Items.AddRange(new object[] {
            "Semanal",
            "Quincenal",
            "Mensual"});
            this.cmbdettipo.Location = new System.Drawing.Point(16, 251);
            this.cmbdettipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbdettipo.MaxDropDownItems = 4;
            this.cmbdettipo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbdettipo.Name = "cmbdettipo";
            this.cmbdettipo.Size = new System.Drawing.Size(236, 49);
            this.cmbdettipo.StartIndex = 0;
            this.cmbdettipo.TabIndex = 38;
            // 
            // btneditar
            // 
            this.btneditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneditar.Depth = 0;
            this.btneditar.HighEmphasis = true;
            this.btneditar.Icon = global::OrdenaCuenta.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.btneditar.Location = new System.Drawing.Point(320, 320);
            this.btneditar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btneditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneditar.Name = "btneditar";
            this.btneditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneditar.Size = new System.Drawing.Size(99, 36);
            this.btneditar.TabIndex = 41;
            this.btneditar.Text = "Editar";
            this.btneditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btneditar.UseAccentColor = false;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncancelar.Depth = 0;
            this.btncancelar.HighEmphasis = true;
            this.btncancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btncancelar.Icon")));
            this.btncancelar.Location = new System.Drawing.Point(128, 320);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncancelar.Size = new System.Drawing.Size(124, 36);
            this.btncancelar.TabIndex = 40;
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
            this.btnagregar.Location = new System.Drawing.Point(307, 320);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnagregar.Size = new System.Drawing.Size(116, 36);
            this.btnagregar.TabIndex = 39;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnagregar.UseAccentColor = false;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // PeriodoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 569);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.cmbdettipo);
            this.Controls.Add(this.calfeccorte);
            this.Controls.Add(this.calfecpago);
            this.Controls.Add(this.calfecfin);
            this.Controls.Add(this.pbfechcorte);
            this.Controls.Add(this.txtfeccorte);
            this.Controls.Add(this.pbfecpago);
            this.Controls.Add(this.txtfechapago);
            this.Controls.Add(this.pbfechafin);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.calfechaini);
            this.Controls.Add(this.pbfechaini);
            this.Controls.Add(this.txtfechaini);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PeriodoAdd";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeriodoAdd";
            this.Load += new System.EventHandler(this.PeriodoAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbfechaini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfechafin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfecpago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfechcorte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calfechaini;
        private System.Windows.Forms.PictureBox pbfechaini;
        private MaterialSkin.Controls.MaterialTextBox txtfechaini;
        private System.Windows.Forms.PictureBox pbfechafin;
        private MaterialSkin.Controls.MaterialTextBox txtfechafin;
        private System.Windows.Forms.PictureBox pbfecpago;
        private MaterialSkin.Controls.MaterialTextBox txtfechapago;
        private System.Windows.Forms.PictureBox pbfechcorte;
        private MaterialSkin.Controls.MaterialTextBox txtfeccorte;
        private System.Windows.Forms.MonthCalendar calfecfin;
        private System.Windows.Forms.MonthCalendar calfecpago;
        private System.Windows.Forms.MonthCalendar calfeccorte;
        private MaterialSkin.Controls.MaterialComboBox cmbdettipo;
        private MaterialSkin.Controls.MaterialButton btneditar;
        private MaterialSkin.Controls.MaterialButton btncancelar;
        private MaterialSkin.Controls.MaterialButton btnagregar;
    }
}