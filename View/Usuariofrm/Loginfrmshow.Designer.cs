namespace OrdenaCuenta.View.Usuariofrm
{
    partial class Loginfrmshow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginfrmshow));
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.btnlogin = new MaterialSkin.Controls.MaterialButton();
            this.txtclave = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.Hint = "Usuario";
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(406, 92);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(319, 50);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtnombre.TrailingIcon")));
            // 
            // btnlogin
            // 
            this.btnlogin.AutoSize = false;
            this.btnlogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnlogin.Depth = 0;
            this.btnlogin.HighEmphasis = true;
            this.btnlogin.Icon = ((System.Drawing.Image)(resources.GetObject("btnlogin.Icon")));
            this.btnlogin.Location = new System.Drawing.Point(406, 262);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnlogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnlogin.Size = new System.Drawing.Size(319, 36);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Ingresar";
            this.btnlogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnlogin.UseAccentColor = false;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtclave
            // 
            this.txtclave.AllowPromptAsInput = true;
            this.txtclave.AnimateReadOnly = false;
            this.txtclave.AsciiOnly = false;
            this.txtclave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtclave.BeepOnError = false;
            this.txtclave.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtclave.Depth = 0;
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtclave.HidePromptOnLeave = false;
            this.txtclave.HideSelection = true;
            this.txtclave.Hint = "Clave";
            this.txtclave.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtclave.LeadingIcon = null;
            this.txtclave.Location = new System.Drawing.Point(406, 172);
            this.txtclave.Margin = new System.Windows.Forms.Padding(4);
            this.txtclave.Mask = "";
            this.txtclave.MaxLength = 32767;
            this.txtclave.MouseState = MaterialSkin.MouseState.OUT;
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '\0';
            this.txtclave.PrefixSuffixText = null;
            this.txtclave.PromptChar = '*';
            this.txtclave.ReadOnly = false;
            this.txtclave.RejectInputOnFirstFailure = false;
            this.txtclave.ResetOnPrompt = true;
            this.txtclave.ResetOnSpace = true;
            this.txtclave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtclave.SelectedText = "";
            this.txtclave.SelectionLength = 0;
            this.txtclave.SelectionStart = 0;
            this.txtclave.ShortcutsEnabled = true;
            this.txtclave.Size = new System.Drawing.Size(319, 48);
            this.txtclave.SkipLiterals = true;
            this.txtclave.TabIndex = 55;
            this.txtclave.TabStop = false;
            this.txtclave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtclave.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtclave.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtclave.TrailingIcon")));
            this.txtclave.UseSystemPasswordChar = false;
            this.txtclave.ValidatingType = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // Loginfrmshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 315);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtnombre);
            this.Name = "Loginfrmshow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.Loginfrmshow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialButton btnlogin;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtclave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}