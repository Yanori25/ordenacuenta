namespace OrdenaCuenta.View.Reportes
{
    partial class MovestadoCuentasfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovestadoCuentasfrm));
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtfechafin = new MaterialSkin.Controls.MaterialTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtfecha = new MaterialSkin.Controls.MaterialTextBox();
            this.btagregar = new MaterialSkin.Controls.MaterialButton();
            this.txtruta = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(32, 165);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 50;
            this.monthCalendar2.Visible = false;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(665, 96);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtfechafin
            // 
            this.txtfechafin.AnimateReadOnly = false;
            this.txtfechafin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfechafin.Depth = 0;
            this.txtfechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtfechafin.Hint = "Fecha Final";
            this.txtfechafin.LeadingIcon = null;
            this.txtfechafin.Location = new System.Drawing.Point(473, 89);
            this.txtfechafin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfechafin.MaxLength = 50;
            this.txtfechafin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtfechafin.Multiline = false;
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(233, 50);
            this.txtfechafin.TabIndex = 48;
            this.txtfechafin.Text = "";
            this.txtfechafin.TrailingIcon = null;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(524, 187);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 47;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.AnimateReadOnly = false;
            this.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfecha.Depth = 0;
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtfecha.Hint = "Fecha Inicial";
            this.txtfecha.LeadingIcon = null;
            this.txtfecha.Location = new System.Drawing.Point(61, 89);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfecha.MaxLength = 50;
            this.txtfecha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtfecha.Multiline = false;
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(233, 50);
            this.txtfecha.TabIndex = 45;
            this.txtfecha.Text = "";
            this.txtfecha.TrailingIcon = null;
            // 
            // btagregar
            // 
            this.btagregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btagregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btagregar.Depth = 0;
            this.btagregar.HighEmphasis = true;
            this.btagregar.Icon = global::OrdenaCuenta.Properties.Resources.add_insert_plus_icon_1495461;
            this.btagregar.Location = new System.Drawing.Point(524, 165);
            this.btagregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btagregar.Name = "btagregar";
            this.btagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btagregar.Size = new System.Drawing.Size(182, 36);
            this.btagregar.TabIndex = 44;
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
            this.txtruta.Location = new System.Drawing.Point(61, 165);
            this.txtruta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtruta.MaxLength = 50;
            this.txtruta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtruta.Multiline = false;
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(436, 50);
            this.txtruta.TabIndex = 79;
            this.txtruta.Text = "";
            this.txtruta.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtruta.TrailingIcon")));
            // 
            // MovestadoCuentasfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 406);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.btagregar);
            this.Name = "MovestadoCuentasfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esatado de cuentas";
            this.Load += new System.EventHandler(this.MovCuentasfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialTextBox txtfechafin;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox txtfecha;
        private MaterialSkin.Controls.MaterialButton btagregar;
        private MaterialSkin.Controls.MaterialTextBox txtruta;
    }
}