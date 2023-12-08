namespace OrdenaCuenta.View
{
    partial class Partidafrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Partidafrm));
            this.cmbcuenta = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtreferencia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtfecha = new MaterialSkin.Controls.MaterialTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cmblibro = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lspartidas = new MaterialSkin.Controls.MaterialListView();
            this.asi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cuenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Libro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Debe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Haber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idlbro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idcuenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnagregar = new MaterialSkin.Controls.MaterialButton();
            this.btncargar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtmonto = new MaterialSkin.Controls.MaterialTextBox();
            this.swinaturaleza = new MaterialSkin.Controls.MaterialSwitch();
            this.btncerrar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbcuenta
            // 
            this.cmbcuenta.AutoResize = false;
            this.cmbcuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbcuenta.Depth = 0;
            this.cmbcuenta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbcuenta.DropDownHeight = 174;
            this.cmbcuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcuenta.DropDownWidth = 121;
            this.cmbcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbcuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbcuenta.FormattingEnabled = true;
            this.cmbcuenta.IntegralHeight = false;
            this.cmbcuenta.ItemHeight = 43;
            this.cmbcuenta.Location = new System.Drawing.Point(141, 89);
            this.cmbcuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbcuenta.MaxDropDownItems = 4;
            this.cmbcuenta.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbcuenta.Name = "cmbcuenta";
            this.cmbcuenta.Size = new System.Drawing.Size(536, 49);
            this.cmbcuenta.StartIndex = 0;
            this.cmbcuenta.TabIndex = 1;
            this.cmbcuenta.SelectedIndexChanged += new System.EventHandler(this.cmbcuenta_SelectedIndexChanged);
            this.cmbcuenta.SelectedValueChanged += new System.EventHandler(this.cmbcuenta_SelectedValueChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(5, 111);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Cuenta";
            // 
            // txtreferencia
            // 
            this.txtreferencia.AnimateReadOnly = false;
            this.txtreferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtreferencia.Depth = 0;
            this.txtreferencia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtreferencia.LeadingIcon = null;
            this.txtreferencia.Location = new System.Drawing.Point(141, 164);
            this.txtreferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtreferencia.MaxLength = 50;
            this.txtreferencia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtreferencia.Multiline = false;
            this.txtreferencia.Name = "txtreferencia";
            this.txtreferencia.Size = new System.Drawing.Size(536, 50);
            this.txtreferencia.TabIndex = 4;
            this.txtreferencia.Text = "";
            this.txtreferencia.TrailingIcon = null;
            // 
            // txtfecha
            // 
            this.txtfecha.AnimateReadOnly = false;
            this.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfecha.Depth = 0;
            this.txtfecha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtfecha.LeadingIcon = null;
            this.txtfecha.Location = new System.Drawing.Point(755, 156);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfecha.MaxLength = 50;
            this.txtfecha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtfecha.Multiline = false;
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(321, 50);
            this.txtfecha.TabIndex = 6;
            this.txtfecha.Text = "";
            this.txtfecha.TrailingIcon = null;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(80, 434);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(693, 175);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(44, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Fecha";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(5, 183);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(76, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Referencia";
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
            this.cmblibro.IntegralHeight = false;
            this.cmblibro.ItemHeight = 43;
            this.cmblibro.Location = new System.Drawing.Point(755, 81);
            this.cmblibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmblibro.MaxDropDownItems = 4;
            this.cmblibro.MouseState = MaterialSkin.MouseState.OUT;
            this.cmblibro.Name = "cmblibro";
            this.cmblibro.Size = new System.Drawing.Size(321, 49);
            this.cmblibro.StartIndex = 0;
            this.cmblibro.TabIndex = 14;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(700, 95);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(37, 19);
            this.materialLabel4.TabIndex = 15;
            this.materialLabel4.Text = "Libro";
            // 
            // lspartidas
            // 
            this.lspartidas.AutoSizeTable = false;
            this.lspartidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lspartidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lspartidas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.asi,
            this.fecha,
            this.Cuenta,
            this.Libro,
            this.Debe,
            this.Haber,
            this.idlbro,
            this.idcuenta});
            this.lspartidas.Depth = 0;
            this.lspartidas.FullRowSelect = true;
            this.lspartidas.HideSelection = false;
            this.lspartidas.Location = new System.Drawing.Point(5, 358);
            this.lspartidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lspartidas.MinimumSize = new System.Drawing.Size(200, 100);
            this.lspartidas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lspartidas.MouseState = MaterialSkin.MouseState.OUT;
            this.lspartidas.Name = "lspartidas";
            this.lspartidas.OwnerDraw = true;
            this.lspartidas.Size = new System.Drawing.Size(1071, 206);
            this.lspartidas.TabIndex = 16;
            this.lspartidas.UseCompatibleStateImageBehavior = false;
            this.lspartidas.View = System.Windows.Forms.View.Details;
            this.lspartidas.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lspartidas_DrawColumnHeader);
            this.lspartidas.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lspartidas_DrawItem);
            // 
            // asi
            // 
            this.asi.Text = "Asiento";
            this.asi.Width = 90;
            // 
            // fecha
            // 
            this.fecha.Text = "Fecha";
            this.fecha.Width = 110;
            // 
            // Cuenta
            // 
            this.Cuenta.Text = "Cuenta";
            this.Cuenta.Width = 200;
            // 
            // Libro
            // 
            this.Libro.Text = "Libro";
            this.Libro.Width = 100;
            // 
            // Debe
            // 
            this.Debe.Text = "Debe";
            this.Debe.Width = 130;
            // 
            // Haber
            // 
            this.Haber.Text = "Haber";
            this.Haber.Width = 130;
            // 
            // idlbro
            // 
            this.idlbro.Text = "idlbro";
            this.idlbro.Width = 80;
            // 
            // idcuenta
            // 
            this.idcuenta.Text = "idcuenta";
            this.idcuenta.Width = 90;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1035, 162);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnagregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnagregar.Depth = 0;
            this.btnagregar.HighEmphasis = true;
            this.btnagregar.Icon = global::OrdenaCuenta.Properties.Resources.add_insert_plus_icon_149546;
            this.btnagregar.Location = new System.Drawing.Point(755, 228);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnagregar.Size = new System.Drawing.Size(180, 36);
            this.btnagregar.TabIndex = 19;
            this.btnagregar.Text = "Agregar Partida";
            this.btnagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnagregar.UseAccentColor = false;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncargar
            // 
            this.btncargar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncargar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncargar.Depth = 0;
            this.btncargar.HighEmphasis = true;
            this.btncargar.Icon = global::OrdenaCuenta.Properties.Resources._1497559423_upload_file_85001;
            this.btncargar.Location = new System.Drawing.Point(379, 581);
            this.btncargar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncargar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncargar.Name = "btncargar";
            this.btncargar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncargar.Size = new System.Drawing.Size(171, 36);
            this.btncargar.TabIndex = 20;
            this.btncargar.Text = "Cargar Partida";
            this.btncargar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btncargar.UseAccentColor = false;
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click_1);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(5, 254);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(47, 19);
            this.materialLabel5.TabIndex = 22;
            this.materialLabel5.Text = "Monto";
            // 
            // txtmonto
            // 
            this.txtmonto.AnimateReadOnly = false;
            this.txtmonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmonto.Depth = 0;
            this.txtmonto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtmonto.LeadingIcon = null;
            this.txtmonto.Location = new System.Drawing.Point(141, 234);
            this.txtmonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmonto.MaxLength = 50;
            this.txtmonto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtmonto.Multiline = false;
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(536, 50);
            this.txtmonto.TabIndex = 21;
            this.txtmonto.Text = "";
            this.txtmonto.TrailingIcon = null;
            this.txtmonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmonto_KeyPress);
            // 
            // swinaturaleza
            // 
            this.swinaturaleza.Depth = 0;
            this.swinaturaleza.Location = new System.Drawing.Point(141, 306);
            this.swinaturaleza.Margin = new System.Windows.Forms.Padding(0);
            this.swinaturaleza.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swinaturaleza.MouseState = MaterialSkin.MouseState.HOVER;
            this.swinaturaleza.Name = "swinaturaleza";
            this.swinaturaleza.Ripple = true;
            this.swinaturaleza.Size = new System.Drawing.Size(165, 33);
            this.swinaturaleza.TabIndex = 23;
            this.swinaturaleza.UseVisualStyleBackColor = true;
            this.swinaturaleza.CheckedChanged += new System.EventHandler(this.swinaturaleza_CheckedChanged);
            // 
            // btncerrar
            // 
            this.btncerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncerrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncerrar.Depth = 0;
            this.btncerrar.HighEmphasis = true;
            this.btncerrar.Icon = ((System.Drawing.Image)(resources.GetObject("btncerrar.Icon")));
            this.btncerrar.Location = new System.Drawing.Point(659, 581);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncerrar.Size = new System.Drawing.Size(89, 36);
            this.btncerrar.TabIndex = 24;
            this.btncerrar.Text = "Salir";
            this.btncerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btncerrar.UseAccentColor = false;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Partidafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1100, 655);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.swinaturaleza);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lspartidas);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.cmblibro);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtreferencia);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmbcuenta);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Partidafrm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partidafrm";
            this.Load += new System.EventHandler(this.Partidafrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox cmbcuenta;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtreferencia;
        private MaterialSkin.Controls.MaterialTextBox txtfecha;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cmblibro;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialListView lspartidas;
        private MaterialSkin.Controls.MaterialButton btnagregar;
        private MaterialSkin.Controls.MaterialButton btncargar;
        private System.Windows.Forms.ColumnHeader asi;
        private System.Windows.Forms.ColumnHeader fecha;
        private System.Windows.Forms.ColumnHeader Cuenta;
        private System.Windows.Forms.ColumnHeader Libro;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txtmonto;
        private System.Windows.Forms.ColumnHeader Debe;
        private System.Windows.Forms.ColumnHeader Haber;
        private System.Windows.Forms.ColumnHeader idlbro;
        private System.Windows.Forms.ColumnHeader idcuenta;
        private MaterialSkin.Controls.MaterialSwitch swinaturaleza;
        private MaterialSkin.Controls.MaterialButton btncerrar;
    }
}