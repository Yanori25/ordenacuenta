namespace OrdenaCuenta.View
{
    partial class MesanjeSioNo
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
            this.lbmensaje = new MaterialSkin.Controls.MaterialLabel();
            this.btnsi = new MaterialSkin.Controls.MaterialButton();
            this.btnno = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbmensaje
            // 
            this.lbmensaje.AutoSize = true;
            this.lbmensaje.Depth = 0;
            this.lbmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbmensaje.Location = new System.Drawing.Point(55, 88);
            this.lbmensaje.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbmensaje.Name = "lbmensaje";
            this.lbmensaje.Size = new System.Drawing.Size(210, 19);
            this.lbmensaje.TabIndex = 0;
            this.lbmensaje.Text = "Desea Eliminar este Regsitro?";
            // 
            // btnsi
            // 
            this.btnsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsi.BackColor = System.Drawing.Color.Green;
            this.btnsi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnsi.Depth = 0;
            this.btnsi.HighEmphasis = true;
            this.btnsi.Icon = null;
            this.btnsi.Location = new System.Drawing.Point(45, 124);
            this.btnsi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsi.Name = "btnsi";
            this.btnsi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnsi.Size = new System.Drawing.Size(64, 36);
            this.btnsi.TabIndex = 1;
            this.btnsi.Text = "Si";
            this.btnsi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnsi.UseAccentColor = false;
            this.btnsi.UseVisualStyleBackColor = false;
            this.btnsi.Click += new System.EventHandler(this.btnsi_Click);
            // 
            // btnno
            // 
            this.btnno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnno.BackColor = System.Drawing.Color.Firebrick;
            this.btnno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnno.Depth = 0;
            this.btnno.HighEmphasis = true;
            this.btnno.Icon = null;
            this.btnno.Location = new System.Drawing.Point(253, 124);
            this.btnno.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnno.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnno.Name = "btnno";
            this.btnno.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnno.Size = new System.Drawing.Size(64, 36);
            this.btnno.TabIndex = 2;
            this.btnno.Text = "No";
            this.btnno.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnno.UseAccentColor = false;
            this.btnno.UseVisualStyleBackColor = false;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // MesanjeSioNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 174);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnsi);
            this.Controls.Add(this.lbmensaje);
            this.Name = "MesanjeSioNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje de Confirmacion";
            this.Load += new System.EventHandler(this.MesanjeSioNo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbmensaje;
        private MaterialSkin.Controls.MaterialButton btnsi;
        private MaterialSkin.Controls.MaterialButton btnno;
    }
}