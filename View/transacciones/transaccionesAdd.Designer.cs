namespace OrdenaCuenta.View.transacciones
{
    partial class transaccionesAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transaccionesAdd));
            this.txtdescripcion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtcuenta = new MaterialSkin.Controls.MaterialTextBox();
            this.btncancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnagregar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.AnimateReadOnly = false;
            this.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescripcion.Depth = 0;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtdescripcion.Hint = "Descripcion";
            this.txtdescripcion.LeadingIcon = null;
            this.txtdescripcion.Location = new System.Drawing.Point(394, 106);
            this.txtdescripcion.MaxLength = 50;
            this.txtdescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtdescripcion.Multiline = false;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(241, 50);
            this.txtdescripcion.TabIndex = 58;
            this.txtdescripcion.Text = "";
            this.txtdescripcion.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtdescripcion.TrailingIcon")));
            // 
            // txtcuenta
            // 
            this.txtcuenta.AnimateReadOnly = false;
            this.txtcuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcuenta.Depth = 0;
            this.txtcuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcuenta.Hint = "Abreviatura";
            this.txtcuenta.LeadingIcon = null;
            this.txtcuenta.Location = new System.Drawing.Point(44, 106);
            this.txtcuenta.MaxLength = 50;
            this.txtcuenta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcuenta.Multiline = false;
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.Size = new System.Drawing.Size(241, 50);
            this.txtcuenta.TabIndex = 57;
            this.txtcuenta.Text = "";
            this.txtcuenta.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtcuenta.TrailingIcon")));
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncancelar.Depth = 0;
            this.btncancelar.HighEmphasis = true;
            this.btncancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btncancelar.Icon")));
            this.btncancelar.Location = new System.Drawing.Point(236, 180);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncancelar.Size = new System.Drawing.Size(124, 36);
            this.btncancelar.TabIndex = 71;
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
            this.btnagregar.Location = new System.Drawing.Point(430, 180);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnagregar.Size = new System.Drawing.Size(116, 36);
            this.btnagregar.TabIndex = 70;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnagregar.UseAccentColor = false;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // transaccionesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 257);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcuenta);
            this.Name = "transaccionesAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar transacciones";
            this.Load += new System.EventHandler(this.transaccionesAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtdescripcion;
        private MaterialSkin.Controls.MaterialTextBox txtcuenta;
        private MaterialSkin.Controls.MaterialButton btncancelar;
        private MaterialSkin.Controls.MaterialButton btnagregar;
    }
}