namespace OrdenaCuenta.View
{
    partial class Cuentasfrm
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
            this.matlistCuenta = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btagregar = new MaterialSkin.Controls.MaterialButton();
            this.btneditar = new MaterialSkin.Controls.MaterialButton();
            this.btneliminar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // matlistCuenta
            // 
            this.matlistCuenta.AutoSizeTable = false;
            this.matlistCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matlistCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matlistCuenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader4,
            this.columnHeader5});
            this.matlistCuenta.Depth = 0;
            this.matlistCuenta.FullRowSelect = true;
            this.matlistCuenta.HideSelection = false;
            this.matlistCuenta.Location = new System.Drawing.Point(18, 151);
            this.matlistCuenta.MinimumSize = new System.Drawing.Size(200, 100);
            this.matlistCuenta.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matlistCuenta.MouseState = MaterialSkin.MouseState.OUT;
            this.matlistCuenta.Name = "matlistCuenta";
            this.matlistCuenta.OwnerDraw = true;
            this.matlistCuenta.Size = new System.Drawing.Size(900, 268);
            this.matlistCuenta.TabIndex = 0;
            this.matlistCuenta.UseCompatibleStateImageBehavior = false;
            this.matlistCuenta.View = System.Windows.Forms.View.Details;
            this.matlistCuenta.ItemActivate += new System.EventHandler(this.matlistCuenta_ItemActivate);
            this.matlistCuenta.SelectedIndexChanged += new System.EventHandler(this.matlistCuenta_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CuentaContable";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descripcion";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CuentaTipo";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TipoCuenta";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Moneda";
            this.columnHeader5.Width = 150;
            // 
            // btagregar
            // 
            this.btagregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btagregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btagregar.Depth = 0;
            this.btagregar.HighEmphasis = true;
            this.btagregar.Icon = global::OrdenaCuenta.Properties.Resources.add_insert_plus_icon_1495461;
            this.btagregar.Location = new System.Drawing.Point(726, 495);
            this.btagregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btagregar.Name = "btagregar";
            this.btagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btagregar.Size = new System.Drawing.Size(116, 36);
            this.btagregar.TabIndex = 5;
            this.btagregar.Text = "Agregar";
            this.btagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btagregar.UseAccentColor = false;
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // btneditar
            // 
            this.btneditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneditar.Depth = 0;
            this.btneditar.HighEmphasis = true;
            this.btneditar.Icon = global::OrdenaCuenta.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.btneditar.Location = new System.Drawing.Point(471, 495);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btneditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneditar.Name = "btneditar";
            this.btneditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneditar.Size = new System.Drawing.Size(99, 36);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btneditar.UseAccentColor = false;
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btneliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneliminar.Depth = 0;
            this.btneliminar.HighEmphasis = true;
            this.btneliminar.Icon = global::OrdenaCuenta.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.btneliminar.Location = new System.Drawing.Point(260, 495);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btneliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneliminar.Size = new System.Drawing.Size(116, 36);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btneliminar.UseAccentColor = false;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            this.btneliminar.MouseEnter += new System.EventHandler(this.btneliminar_MouseEnter);
            // 
            // Cuentasfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 582);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.matlistCuenta);
            this.Name = "Cuentasfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentasfrm";
            this.Load += new System.EventHandler(this.Cuentasfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView matlistCuenta;
        private MaterialSkin.Controls.MaterialButton btneliminar;
        private MaterialSkin.Controls.MaterialButton btneditar;
        private MaterialSkin.Controls.MaterialButton btagregar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}