namespace OrdenaCuenta.View.periodosaldohis
{
    partial class periodosaldohisshow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(periodosaldohisshow));
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.btagregar = new MaterialSkin.Controls.MaterialButton();
            this.btneditar = new MaterialSkin.Controls.MaterialButton();
            this.btneliminar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lsproveedores = new MaterialSkin.Controls.MaterialListView();
            this.txtperiodo = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lsclientes = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(214, 329);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(181, 50);
            this.txtnombre.TabIndex = 34;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtnombre.TrailingIcon")));
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // btagregar
            // 
            this.btagregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btagregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btagregar.Depth = 0;
            this.btagregar.HighEmphasis = true;
            this.btagregar.Icon = global::OrdenaCuenta.Properties.Resources.add_insert_plus_icon_1495461;
            this.btagregar.Location = new System.Drawing.Point(434, 572);
            this.btagregar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btagregar.Name = "btagregar";
            this.btagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btagregar.Size = new System.Drawing.Size(116, 36);
            this.btagregar.TabIndex = 33;
            this.btagregar.Text = "Agregar";
            this.btagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btagregar.UseAccentColor = false;
            this.btagregar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneditar.Depth = 0;
            this.btneditar.HighEmphasis = true;
            this.btneditar.Icon = global::OrdenaCuenta.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.btneditar.Location = new System.Drawing.Point(267, 572);
            this.btneditar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btneditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneditar.Name = "btneditar";
            this.btneditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneditar.Size = new System.Drawing.Size(99, 36);
            this.btneditar.TabIndex = 32;
            this.btneditar.Text = "Editar";
            this.btneditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btneditar.UseAccentColor = false;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Visible = false;
            // 
            // btneliminar
            // 
            this.btneliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btneliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneliminar.Depth = 0;
            this.btneliminar.HighEmphasis = true;
            this.btneliminar.Icon = global::OrdenaCuenta.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.btneliminar.Location = new System.Drawing.Point(98, 572);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btneliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneliminar.Size = new System.Drawing.Size(116, 36);
            this.btneliminar.TabIndex = 31;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btneliminar.UseAccentColor = false;
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(80, 351);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 28);
            this.materialLabel1.TabIndex = 35;
            this.materialLabel1.Text = "Buscar";
            // 
            // lsproveedores
            // 
            this.lsproveedores.AutoSizeTable = false;
            this.lsproveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsproveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsproveedores.Depth = 0;
            this.lsproveedores.FullRowSelect = true;
            this.lsproveedores.HideSelection = false;
            this.lsproveedores.Location = new System.Drawing.Point(39, 398);
            this.lsproveedores.Margin = new System.Windows.Forms.Padding(2);
            this.lsproveedores.MinimumSize = new System.Drawing.Size(150, 81);
            this.lsproveedores.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsproveedores.MouseState = MaterialSkin.MouseState.OUT;
            this.lsproveedores.Name = "lsproveedores";
            this.lsproveedores.OwnerDraw = true;
            this.lsproveedores.Size = new System.Drawing.Size(565, 158);
            this.lsproveedores.TabIndex = 30;
            this.lsproveedores.UseCompatibleStateImageBehavior = false;
            this.lsproveedores.View = System.Windows.Forms.View.Details;
            // 
            // txtperiodo
            // 
            this.txtperiodo.AnimateReadOnly = false;
            this.txtperiodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtperiodo.Depth = 0;
            this.txtperiodo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtperiodo.LeadingIcon = null;
            this.txtperiodo.Location = new System.Drawing.Point(214, 74);
            this.txtperiodo.Margin = new System.Windows.Forms.Padding(2);
            this.txtperiodo.MaxLength = 50;
            this.txtperiodo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtperiodo.Multiline = false;
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.Size = new System.Drawing.Size(181, 50);
            this.txtperiodo.TabIndex = 37;
            this.txtperiodo.Text = "";
            this.txtperiodo.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtperiodo.TrailingIcon")));
            this.txtperiodo.TextChanged += new System.EventHandler(this.txtperiodo_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(73, 83);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 28);
            this.materialLabel2.TabIndex = 38;
            this.materialLabel2.Text = "Buscar";
            // 
            // lsclientes
            // 
            this.lsclientes.AutoSizeTable = false;
            this.lsclientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsclientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsclientes.Depth = 0;
            this.lsclientes.FullRowSelect = true;
            this.lsclientes.HideSelection = false;
            this.lsclientes.Location = new System.Drawing.Point(30, 128);
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
            // periodosaldohisshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 623);
            this.Controls.Add(this.txtperiodo);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lsclientes);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lsproveedores);
            this.Name = "periodosaldohisshow";
            this.Text = "Mostrar saldos historicos de periodo";
            this.Load += new System.EventHandler(this.periodosaldohisshow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialButton btagregar;
        private MaterialSkin.Controls.MaterialButton btneditar;
        private MaterialSkin.Controls.MaterialButton btneliminar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListView lsproveedores;
        private MaterialSkin.Controls.MaterialTextBox txtperiodo;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialListView lsclientes;
    }
}