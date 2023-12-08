namespace OrdenaCuenta.View.opciones
{
    partial class opcionesAdd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(opcionesAdd));
            this.btncancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnagregar = new MaterialSkin.Controls.MaterialButton();
            this.txtdescripcion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtcuenta = new MaterialSkin.Controls.MaterialTextBox();
            this.txtnivel = new MaterialSkin.Controls.MaterialTextBox();
            this.txtruta = new MaterialSkin.Controls.MaterialTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncancelar.Depth = 0;
            this.btncancelar.HighEmphasis = true;
            this.btncancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btncancelar.Icon")));
            this.btncancelar.Location = new System.Drawing.Point(164, 249);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncancelar.Size = new System.Drawing.Size(124, 36);
            this.btncancelar.TabIndex = 75;
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
            this.btnagregar.Location = new System.Drawing.Point(309, 249);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnagregar.Size = new System.Drawing.Size(116, 36);
            this.btnagregar.TabIndex = 74;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnagregar.UseAccentColor = false;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.AnimateReadOnly = false;
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescripcion.Depth = 0;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtdescripcion.Hint = "Icono";
            this.txtdescripcion.LeadingIcon = null;
            this.txtdescripcion.Location = new System.Drawing.Point(295, 93);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescripcion.MaxLength = 50;
            this.txtdescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtdescripcion.Multiline = false;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(232, 50);
            this.txtdescripcion.TabIndex = 73;
            this.txtdescripcion.Text = "";
            this.toolTip1.SetToolTip(this.txtdescripcion, "Se debe agregar un icono en el image list \r\ndel menu que deseamos agregar la ruta" +
        " \r\nel icno debe tener una medida de 32x32\r\nde esta dirreccion\r\nhttps://icon-icon" +
        "s.com/es/buscar/iconos/");
            this.txtdescripcion.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtdescripcion.TrailingIcon")));
            // 
            // txtcuenta
            // 
            this.txtcuenta.AnimateReadOnly = false;
            this.txtcuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcuenta.Depth = 0;
            this.txtcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcuenta.Hint = "Nombre";
            this.txtcuenta.LeadingIcon = null;
            this.txtcuenta.Location = new System.Drawing.Point(32, 93);
            this.txtcuenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtcuenta.MaxLength = 50;
            this.txtcuenta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcuenta.Multiline = false;
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.Size = new System.Drawing.Size(181, 50);
            this.txtcuenta.TabIndex = 72;
            this.txtcuenta.Text = "";
            this.toolTip1.SetToolTip(this.txtcuenta, "es lel nombre que se mostrar en el menu \r\nal momento de agregarlo en el menu debe" +
        "mos\r\nir a configurar el menu que tiene el formulario y\r\nagregar el nombre ahi ma" +
        "s ek formulario que \r\ndeseamos llamar");
            this.txtcuenta.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtcuenta.TrailingIcon")));
            // 
            // txtnivel
            // 
            this.txtnivel.AnimateReadOnly = false;
            this.txtnivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnivel.Depth = 0;
            this.txtnivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnivel.Hint = "Nivel";
            this.txtnivel.LeadingIcon = null;
            this.txtnivel.Location = new System.Drawing.Point(32, 166);
            this.txtnivel.Margin = new System.Windows.Forms.Padding(2);
            this.txtnivel.MaxLength = 50;
            this.txtnivel.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnivel.Multiline = false;
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(181, 50);
            this.txtnivel.TabIndex = 76;
            this.txtnivel.Text = "";
            this.toolTip1.SetToolTip(this.txtnivel, "es para saber quien es el padre del menu \r\nal colocar padre formar el nivel princ" +
        "ipal\r\nsi coloco de ejemplo seguridad la opcion se mostrara\r\nen el menu de seguri" +
        "dad");
            this.txtnivel.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtnivel.TrailingIcon")));
            // 
            // txtruta
            // 
            this.txtruta.AnimateReadOnly = false;
            this.txtruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtruta.Depth = 0;
            this.txtruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtruta.Hint = "Ruta frm";
            this.txtruta.LeadingIcon = null;
            this.txtruta.Location = new System.Drawing.Point(295, 166);
            this.txtruta.Margin = new System.Windows.Forms.Padding(2);
            this.txtruta.MaxLength = 50;
            this.txtruta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtruta.Multiline = false;
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(232, 50);
            this.txtruta.TabIndex = 77;
            this.txtruta.Text = "";
            this.toolTip1.SetToolTip(this.txtruta, "se debe agreregar la ruta del formulario el cual se va abrir");
            this.txtruta.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtruta.TrailingIcon")));
            // 
            // opcionesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 324);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcuenta);
            this.Name = "opcionesAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Opciones";
            this.Load += new System.EventHandler(this.opcionesAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btncancelar;
        private MaterialSkin.Controls.MaterialButton btnagregar;
        private MaterialSkin.Controls.MaterialTextBox txtdescripcion;
        private MaterialSkin.Controls.MaterialTextBox txtcuenta;
        private MaterialSkin.Controls.MaterialTextBox txtnivel;
        private MaterialSkin.Controls.MaterialTextBox txtruta;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}