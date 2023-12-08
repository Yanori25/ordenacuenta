namespace OrdenaCuenta.View.opciones
{
    partial class usuariorolesAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuariorolesAdd));
            this.lsrol = new MaterialSkin.Controls.MaterialListView();
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtbuscarusu = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lsusuarios = new MaterialSkin.Controls.MaterialListView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btncancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnagregar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lsrol
            // 
            this.lsrol.AutoSizeTable = false;
            this.lsrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsrol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsrol.Depth = 0;
            this.lsrol.FullRowSelect = true;
            this.lsrol.HideSelection = false;
            this.lsrol.Location = new System.Drawing.Point(16, 142);
            this.lsrol.Margin = new System.Windows.Forms.Padding(2);
            this.lsrol.MinimumSize = new System.Drawing.Size(150, 81);
            this.lsrol.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsrol.MouseState = MaterialSkin.MouseState.OUT;
            this.lsrol.Name = "lsrol";
            this.lsrol.OwnerDraw = true;
            this.lsrol.Size = new System.Drawing.Size(565, 158);
            this.lsrol.TabIndex = 30;
            this.lsrol.UseCompatibleStateImageBehavior = false;
            this.lsrol.View = System.Windows.Forms.View.Details;
            this.lsrol.Click += new System.EventHandler(this.lsrol_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.Hint = "Buscar";
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(217, 70);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(181, 50);
            this.txtnombre.TabIndex = 52;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtnombre.TrailingIcon")));
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txtbuscarusu
            // 
            this.txtbuscarusu.AnimateReadOnly = false;
            this.txtbuscarusu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscarusu.Depth = 0;
            this.txtbuscarusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbuscarusu.Hint = "Buscar";
            this.txtbuscarusu.LeadingIcon = null;
            this.txtbuscarusu.Location = new System.Drawing.Point(217, 314);
            this.txtbuscarusu.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscarusu.MaxLength = 50;
            this.txtbuscarusu.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbuscarusu.Multiline = false;
            this.txtbuscarusu.Name = "txtbuscarusu";
            this.txtbuscarusu.Size = new System.Drawing.Size(181, 50);
            this.txtbuscarusu.TabIndex = 57;
            this.txtbuscarusu.Text = "";
            this.txtbuscarusu.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtbuscarusu.TrailingIcon")));
            this.txtbuscarusu.TextChanged += new System.EventHandler(this.txtbuscarusu_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(23, 336);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(143, 28);
            this.materialLabel1.TabIndex = 58;
            this.materialLabel1.Text = "Lista de usuarios";
            // 
            // lsusuarios
            // 
            this.lsusuarios.AutoSizeTable = false;
            this.lsusuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsusuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsusuarios.Depth = 0;
            this.lsusuarios.FullRowSelect = true;
            this.lsusuarios.HideSelection = false;
            this.lsusuarios.Location = new System.Drawing.Point(16, 385);
            this.lsusuarios.Margin = new System.Windows.Forms.Padding(2);
            this.lsusuarios.MinimumSize = new System.Drawing.Size(150, 81);
            this.lsusuarios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsusuarios.MouseState = MaterialSkin.MouseState.OUT;
            this.lsusuarios.Name = "lsusuarios";
            this.lsusuarios.OwnerDraw = true;
            this.lsusuarios.Size = new System.Drawing.Size(565, 158);
            this.lsusuarios.TabIndex = 53;
            this.lsusuarios.UseCompatibleStateImageBehavior = false;
            this.lsusuarios.View = System.Windows.Forms.View.Details;
            this.lsusuarios.Click += new System.EventHandler(this.lsusuarios_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(37, 92);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(129, 28);
            this.materialLabel2.TabIndex = 59;
            this.materialLabel2.Text = "Lista de roles";
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncancelar.Depth = 0;
            this.btncancelar.HighEmphasis = true;
            this.btncancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btncancelar.Icon")));
            this.btncancelar.Location = new System.Drawing.Point(210, 565);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncancelar.Size = new System.Drawing.Size(124, 36);
            this.btncancelar.TabIndex = 61;
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
            this.btnagregar.Location = new System.Drawing.Point(346, 565);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnagregar.Size = new System.Drawing.Size(116, 36);
            this.btnagregar.TabIndex = 60;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnagregar.UseAccentColor = false;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // usuariorolesAdd
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
            this.Name = "usuariorolesAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR USUARIOS ROLES";
            this.Load += new System.EventHandler(this.usuariorolesAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialListView lsrol;
        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialTextBox txtbuscarusu;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView lsusuarios;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btncancelar;
        private MaterialSkin.Controls.MaterialButton btnagregar;
    }
}