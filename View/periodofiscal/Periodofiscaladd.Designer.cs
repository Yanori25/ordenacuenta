namespace OrdenaCuenta.View.periodofiscal
{
    partial class Periodofiscaladd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Periodofiscaladd));
            this.btncancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnagregar = new MaterialSkin.Controls.MaterialButton();
            this.calfecfin = new System.Windows.Forms.MonthCalendar();
            this.pbfechafin = new System.Windows.Forms.PictureBox();
            this.txtfechafin = new MaterialSkin.Controls.MaterialTextBox();
            this.calfechaini = new System.Windows.Forms.MonthCalendar();
            this.pbfechaini = new System.Windows.Forms.PictureBox();
            this.txtfechaini = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbfechafin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfechaini)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncancelar.Depth = 0;
            this.btncancelar.HighEmphasis = true;
            this.btncancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btncancelar.Icon")));
            this.btncancelar.Location = new System.Drawing.Point(161, 215);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncancelar.Size = new System.Drawing.Size(124, 36);
            this.btncancelar.TabIndex = 56;
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
            this.btnagregar.Location = new System.Drawing.Point(399, 215);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnagregar.Size = new System.Drawing.Size(116, 36);
            this.btnagregar.TabIndex = 55;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnagregar.UseAccentColor = false;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // calfecfin
            // 
            this.calfecfin.Location = new System.Drawing.Point(339, 236);
            this.calfecfin.Name = "calfecfin";
            this.calfecfin.TabIndex = 51;
            this.calfecfin.Visible = false;
            this.calfecfin.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calfecfin_DateSelected);
            // 
            // pbfechafin
            // 
            this.pbfechafin.Image = ((System.Drawing.Image)(resources.GetObject("pbfechafin.Image")));
            this.pbfechafin.Location = new System.Drawing.Point(557, 112);
            this.pbfechafin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbfechafin.Name = "pbfechafin";
            this.pbfechafin.Size = new System.Drawing.Size(32, 32);
            this.pbfechafin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbfechafin.TabIndex = 46;
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
            this.txtfechafin.Location = new System.Drawing.Point(365, 106);
            this.txtfechafin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfechafin.MaxLength = 50;
            this.txtfechafin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtfechafin.Multiline = false;
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(233, 50);
            this.txtfechafin.TabIndex = 45;
            this.txtfechafin.Text = "";
            this.txtfechafin.TrailingIcon = null;
            // 
            // calfechaini
            // 
            this.calfechaini.Location = new System.Drawing.Point(455, 201);
            this.calfechaini.Name = "calfechaini";
            this.calfechaini.TabIndex = 44;
            this.calfechaini.Visible = false;
            this.calfechaini.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calfechaini_DateSelected);
            // 
            // pbfechaini
            // 
            this.pbfechaini.Image = ((System.Drawing.Image)(resources.GetObject("pbfechaini.Image")));
            this.pbfechaini.Location = new System.Drawing.Point(253, 112);
            this.pbfechaini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbfechaini.Name = "pbfechaini";
            this.pbfechaini.Size = new System.Drawing.Size(32, 32);
            this.pbfechaini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbfechaini.TabIndex = 43;
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
            this.txtfechaini.Location = new System.Drawing.Point(61, 106);
            this.txtfechaini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfechaini.MaxLength = 50;
            this.txtfechaini.MouseState = MaterialSkin.MouseState.OUT;
            this.txtfechaini.Multiline = false;
            this.txtfechaini.Name = "txtfechaini";
            this.txtfechaini.Size = new System.Drawing.Size(233, 50);
            this.txtfechaini.TabIndex = 42;
            this.txtfechaini.Text = "";
            this.txtfechaini.TrailingIcon = null;
            // 
            // Periodofiscaladd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 424);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.calfecfin);
            this.Controls.Add(this.pbfechafin);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.calfechaini);
            this.Controls.Add(this.pbfechaini);
            this.Controls.Add(this.txtfechaini);
            this.Name = "Periodofiscaladd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Periodo Fiscal";
            this.Load += new System.EventHandler(this.Periodofiscaladd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbfechafin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbfechaini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btncancelar;
        private MaterialSkin.Controls.MaterialButton btnagregar;
        private System.Windows.Forms.MonthCalendar calfecfin;
        private System.Windows.Forms.PictureBox pbfechafin;
        private MaterialSkin.Controls.MaterialTextBox txtfechafin;
        private System.Windows.Forms.MonthCalendar calfechaini;
        private System.Windows.Forms.PictureBox pbfechaini;
        private MaterialSkin.Controls.MaterialTextBox txtfechaini;
    }
}