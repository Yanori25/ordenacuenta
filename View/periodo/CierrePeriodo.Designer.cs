namespace OrdenaCuenta.View.periodo
{
    partial class CierrePeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CierrePeriodo));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lsclientes = new MaterialSkin.Controls.MaterialListView();
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.btndesabilitar = new MaterialSkin.Controls.MaterialButton();
            this.btnhabilitar = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtfecha = new MaterialSkin.Controls.MaterialTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(63, 91);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 28);
            this.materialLabel1.TabIndex = 41;
            this.materialLabel1.Text = "Buscar";
            // 
            // lsclientes
            // 
            this.lsclientes.AutoSizeTable = false;
            this.lsclientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsclientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsclientes.Depth = 0;
            this.lsclientes.FullRowSelect = true;
            this.lsclientes.HideSelection = false;
            this.lsclientes.Location = new System.Drawing.Point(20, 136);
            this.lsclientes.Margin = new System.Windows.Forms.Padding(2);
            this.lsclientes.MinimumSize = new System.Drawing.Size(150, 81);
            this.lsclientes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsclientes.MouseState = MaterialSkin.MouseState.OUT;
            this.lsclientes.Name = "lsclientes";
            this.lsclientes.OwnerDraw = true;
            this.lsclientes.Size = new System.Drawing.Size(565, 158);
            this.lsclientes.TabIndex = 36;
            this.lsclientes.UseCompatibleStateImageBehavior = false;
            this.lsclientes.View = System.Windows.Forms.View.Details;
            this.lsclientes.Click += new System.EventHandler(this.lsclientes_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(204, 82);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(181, 50);
            this.txtnombre.TabIndex = 40;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtnombre.TrailingIcon")));
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // btndesabilitar
            // 
            this.btndesabilitar.AutoSize = false;
            this.btndesabilitar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndesabilitar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btndesabilitar.Depth = 0;
            this.btndesabilitar.HighEmphasis = true;
            this.btndesabilitar.Icon = ((System.Drawing.Image)(resources.GetObject("btndesabilitar.Icon")));
            this.btndesabilitar.Location = new System.Drawing.Point(448, 332);
            this.btndesabilitar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btndesabilitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btndesabilitar.Name = "btndesabilitar";
            this.btndesabilitar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btndesabilitar.Size = new System.Drawing.Size(137, 36);
            this.btndesabilitar.TabIndex = 38;
            this.btndesabilitar.Text = "Desabilitar";
            this.btndesabilitar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btndesabilitar.UseAccentColor = false;
            this.btndesabilitar.UseVisualStyleBackColor = true;
            this.btndesabilitar.Click += new System.EventHandler(this.btndesabilitar_Click);
            // 
            // btnhabilitar
            // 
            this.btnhabilitar.AutoSize = false;
            this.btnhabilitar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnhabilitar.BackColor = System.Drawing.Color.Firebrick;
            this.btnhabilitar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnhabilitar.Depth = 0;
            this.btnhabilitar.HighEmphasis = true;
            this.btnhabilitar.Icon = ((System.Drawing.Image)(resources.GetObject("btnhabilitar.Icon")));
            this.btnhabilitar.Location = new System.Drawing.Point(280, 332);
            this.btnhabilitar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnhabilitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnhabilitar.Name = "btnhabilitar";
            this.btnhabilitar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnhabilitar.Size = new System.Drawing.Size(137, 36);
            this.btnhabilitar.TabIndex = 37;
            this.btnhabilitar.Text = "Habilitar";
            this.btnhabilitar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnhabilitar.UseAccentColor = false;
            this.btnhabilitar.UseVisualStyleBackColor = false;
            this.btnhabilitar.Click += new System.EventHandler(this.btnhabilitar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 323);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.AnimateReadOnly = false;
            this.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfecha.Depth = 0;
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtfecha.Hint = "Fecha";
            this.txtfecha.LeadingIcon = null;
            this.txtfecha.Location = new System.Drawing.Point(20, 318);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtfecha.MaxLength = 50;
            this.txtfecha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtfecha.Multiline = false;
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(175, 50);
            this.txtfecha.TabIndex = 42;
            this.txtfecha.Text = "";
            this.txtfecha.TrailingIcon = null;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(308, 113);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 44;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // CierrePeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 522);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btndesabilitar);
            this.Controls.Add(this.btnhabilitar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lsclientes);
            this.Name = "CierrePeriodo";
            this.Text = "Desabilacion temporal del periodo";
            this.Load += new System.EventHandler(this.CierrePeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialButton btndesabilitar;
        private MaterialSkin.Controls.MaterialButton btnhabilitar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView lsclientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox txtfecha;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}