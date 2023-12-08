namespace OrdenaCuenta.View.opciones
{
    partial class rolesopcionesAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rolesopcionesAdd));
            this.btncancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnagregar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtbuscarusu = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lsusuarios = new MaterialSkin.Controls.MaterialListView();
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.lsrol = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncancelar.Depth = 0;
            this.btncancelar.HighEmphasis = true;
            this.btncancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btncancelar.Icon")));
            this.btncancelar.Location = new System.Drawing.Point(216, 566);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncancelar.Size = new System.Drawing.Size(124, 36);
            this.btncancelar.TabIndex = 69;
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
            this.btnagregar.Location = new System.Drawing.Point(352, 566);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnagregar.Size = new System.Drawing.Size(116, 36);
            this.btnagregar.TabIndex = 68;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnagregar.UseAccentColor = false;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(43, 93);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(129, 28);
            this.materialLabel2.TabIndex = 67;
            this.materialLabel2.Text = "Lista de roles";
            // 
            // txtbuscarusu
            // 
            this.txtbuscarusu.AnimateReadOnly = false;
            this.txtbuscarusu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscarusu.Depth = 0;
            this.txtbuscarusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbuscarusu.Hint = "Buscar";
            this.txtbuscarusu.LeadingIcon = null;
            this.txtbuscarusu.Location = new System.Drawing.Point(223, 315);
            this.txtbuscarusu.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscarusu.MaxLength = 50;
            this.txtbuscarusu.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbuscarusu.Multiline = false;
            this.txtbuscarusu.Name = "txtbuscarusu";
            this.txtbuscarusu.Size = new System.Drawing.Size(181, 50);
            this.txtbuscarusu.TabIndex = 65;
            this.txtbuscarusu.Text = "";
            this.txtbuscarusu.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtbuscarusu.TrailingIcon")));
            this.txtbuscarusu.TextChanged += new System.EventHandler(this.txtbuscarusu_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(29, 337);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(143, 28);
            this.materialLabel1.TabIndex = 66;
            this.materialLabel1.Text = "Lista de opciones";
            // 
            // lsusuarios
            // 
            this.lsusuarios.AutoSizeTable = false;
            this.lsusuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsusuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsusuarios.Depth = 0;
            this.lsusuarios.FullRowSelect = true;
            this.lsusuarios.HideSelection = false;
            this.lsusuarios.Location = new System.Drawing.Point(22, 386);
            this.lsusuarios.Margin = new System.Windows.Forms.Padding(2);
            this.lsusuarios.MinimumSize = new System.Drawing.Size(150, 81);
            this.lsusuarios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsusuarios.MouseState = MaterialSkin.MouseState.OUT;
            this.lsusuarios.Name = "lsusuarios";
            this.lsusuarios.OwnerDraw = true;
            this.lsusuarios.Size = new System.Drawing.Size(565, 158);
            this.lsusuarios.TabIndex = 64;
            this.lsusuarios.UseCompatibleStateImageBehavior = false;
            this.lsusuarios.View = System.Windows.Forms.View.Details;
            this.lsusuarios.Click += new System.EventHandler(this.lsusuarios_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.Hint = "Buscar";
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(223, 71);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(181, 50);
            this.txtnombre.TabIndex = 63;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtnombre.TrailingIcon")));
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // lsrol
            // 
            this.lsrol.AutoSizeTable = false;
            this.lsrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsrol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsrol.Depth = 0;
            this.lsrol.FullRowSelect = true;
            this.lsrol.HideSelection = false;
            this.lsrol.Location = new System.Drawing.Point(22, 143);
            this.lsrol.Margin = new System.Windows.Forms.Padding(2);
            this.lsrol.MinimumSize = new System.Drawing.Size(150, 81);
            this.lsrol.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsrol.MouseState = MaterialSkin.MouseState.OUT;
            this.lsrol.Name = "lsrol";
            this.lsrol.OwnerDraw = true;
            this.lsrol.Size = new System.Drawing.Size(565, 158);
            this.lsrol.TabIndex = 62;
            this.lsrol.UseCompatibleStateImageBehavior = false;
            this.lsrol.View = System.Windows.Forms.View.Details;
            this.lsrol.Click += new System.EventHandler(this.lsrol_Click);
            // 
            // rolesopcionesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 624);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtbuscarusu);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lsusuarios);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lsrol);
            this.Name = "rolesopcionesAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Roles opciones";
            this.Load += new System.EventHandler(this.rolesopcionesAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btncancelar;
        private MaterialSkin.Controls.MaterialButton btnagregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtbuscarusu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView lsusuarios;
        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialListView lsrol;
    }
}