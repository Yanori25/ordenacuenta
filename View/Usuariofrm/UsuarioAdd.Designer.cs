namespace OrdenaCuenta.View.Usuariofrm
{
    partial class UsuarioAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioAdd));
            this.btneditar = new MaterialSkin.Controls.MaterialButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtfecha = new MaterialSkin.Controls.MaterialTextBox();
            this.btncancelar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbsexo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txttelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.btnagregar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtdni = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtpregunta = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtapellidosegundo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtapellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtnombresegundo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtresseg = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtusuario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtclavea = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtclaveb = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btneditar
            // 
            this.btneditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btneditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btneditar.Depth = 0;
            this.btneditar.HighEmphasis = true;
            this.btneditar.Icon = global::OrdenaCuenta.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.btneditar.Location = new System.Drawing.Point(918, 341);
            this.btneditar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btneditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneditar.Name = "btneditar";
            this.btneditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btneditar.Size = new System.Drawing.Size(99, 36);
            this.btneditar.TabIndex = 50;
            this.btneditar.Text = "Editar";
            this.btneditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btneditar.UseAccentColor = false;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Visible = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(113, 187);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 49;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // materialLabel10
            // 
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(730, 147);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(110, 40);
            this.materialLabel10.TabIndex = 48;
            this.materialLabel10.Text = "Fecha\r\nIngreso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(977, 147);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.AnimateReadOnly = false;
            this.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfecha.Depth = 0;
            this.txtfecha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtfecha.LeadingIcon = null;
            this.txtfecha.Location = new System.Drawing.Point(844, 137);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtfecha.MaxLength = 50;
            this.txtfecha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtfecha.Multiline = false;
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(175, 50);
            this.txtfecha.TabIndex = 46;
            this.txtfecha.Text = "";
            this.txtfecha.TrailingIcon = null;
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncancelar.Depth = 0;
            this.btncancelar.HighEmphasis = true;
            this.btncancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btncancelar.Icon")));
            this.btncancelar.Location = new System.Drawing.Point(769, 341);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncancelar.Size = new System.Drawing.Size(124, 36);
            this.btncancelar.TabIndex = 45;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btncancelar.UseAccentColor = false;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(14, 341);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(105, 61);
            this.materialLabel9.TabIndex = 44;
            this.materialLabel9.Text = "Respuesta de seguridad";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(730, 81);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(97, 19);
            this.materialLabel8.TabIndex = 43;
            this.materialLabel8.Text = "Sexo";
            // 
            // cmbsexo
            // 
            this.cmbsexo.AutoResize = false;
            this.cmbsexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbsexo.Depth = 0;
            this.cmbsexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbsexo.DropDownHeight = 174;
            this.cmbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsexo.DropDownWidth = 121;
            this.cmbsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbsexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.IntegralHeight = false;
            this.cmbsexo.ItemHeight = 43;
            this.cmbsexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbsexo.Location = new System.Drawing.Point(843, 77);
            this.cmbsexo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbsexo.MaxDropDownItems = 4;
            this.cmbsexo.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(176, 49);
            this.cmbsexo.StartIndex = 0;
            this.cmbsexo.TabIndex = 41;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(730, 207);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(64, 19);
            this.materialLabel7.TabIndex = 40;
            this.materialLabel7.Text = "Telefono";
            // 
            // txttelefono
            // 
            this.txttelefono.AnimateReadOnly = false;
            this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttelefono.Depth = 0;
            this.txttelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txttelefono.LeadingIcon = null;
            this.txttelefono.Location = new System.Drawing.Point(844, 204);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txttelefono.MaxLength = 50;
            this.txttelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txttelefono.Multiline = false;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(175, 50);
            this.txttelefono.TabIndex = 39;
            this.txttelefono.Text = "";
            this.txttelefono.TrailingIcon = null;
            // 
            // btnagregar
            // 
            this.btnagregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnagregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnagregar.Depth = 0;
            this.btnagregar.HighEmphasis = true;
            this.btnagregar.Icon = ((System.Drawing.Image)(resources.GetObject("btnagregar.Icon")));
            this.btnagregar.Location = new System.Drawing.Point(905, 341);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnagregar.Size = new System.Drawing.Size(116, 36);
            this.btnagregar.TabIndex = 38;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnagregar.UseAccentColor = false;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(372, 217);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(64, 27);
            this.materialLabel6.TabIndex = 37;
            this.materialLabel6.Text = "DNI";
            // 
            // txtdni
            // 
            this.txtdni.AnimateReadOnly = false;
            this.txtdni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdni.Depth = 0;
            this.txtdni.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtdni.LeadingIcon = null;
            this.txtdni.Location = new System.Drawing.Point(523, 205);
            this.txtdni.Margin = new System.Windows.Forms.Padding(2);
            this.txtdni.MaxLength = 50;
            this.txtdni.MouseState = MaterialSkin.MouseState.OUT;
            this.txtdni.Multiline = false;
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(175, 50);
            this.txtdni.TabIndex = 36;
            this.txtdni.Text = "";
            this.txtdni.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(38, 247);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(102, 74);
            this.materialLabel5.TabIndex = 35;
            this.materialLabel5.Text = "Pregunta Seguridad";
            // 
            // txtpregunta
            // 
            this.txtpregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtpregunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpregunta.Depth = 0;
            this.txtpregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtpregunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtpregunta.Location = new System.Drawing.Point(152, 242);
            this.txtpregunta.Margin = new System.Windows.Forms.Padding(2);
            this.txtpregunta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtpregunta.Name = "txtpregunta";
            this.txtpregunta.Size = new System.Drawing.Size(175, 78);
            this.txtpregunta.TabIndex = 34;
            this.txtpregunta.Text = "";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(38, 149);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(58, 19);
            this.materialLabel4.TabIndex = 33;
            this.materialLabel4.Text = "Apellido";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(372, 146);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(125, 19);
            this.materialLabel3.TabIndex = 32;
            this.materialLabel3.Text = "Segundo Apellido";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(372, 92);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(124, 19);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Segundo Nombre";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(39, 92);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 30;
            this.materialLabel1.Text = "Nombre";
            // 
            // txtapellidosegundo
            // 
            this.txtapellidosegundo.AnimateReadOnly = false;
            this.txtapellidosegundo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapellidosegundo.Depth = 0;
            this.txtapellidosegundo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtapellidosegundo.LeadingIcon = null;
            this.txtapellidosegundo.Location = new System.Drawing.Point(522, 145);
            this.txtapellidosegundo.Margin = new System.Windows.Forms.Padding(2);
            this.txtapellidosegundo.MaxLength = 50;
            this.txtapellidosegundo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtapellidosegundo.Multiline = false;
            this.txtapellidosegundo.Name = "txtapellidosegundo";
            this.txtapellidosegundo.Size = new System.Drawing.Size(175, 50);
            this.txtapellidosegundo.TabIndex = 29;
            this.txtapellidosegundo.Text = "";
            this.txtapellidosegundo.TrailingIcon = null;
            this.txtapellidosegundo.TextChanged += new System.EventHandler(this.txtapellidosegundo_TextChanged);
            // 
            // txtapellido
            // 
            this.txtapellido.AnimateReadOnly = false;
            this.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtapellido.Depth = 0;
            this.txtapellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtapellido.LeadingIcon = null;
            this.txtapellido.Location = new System.Drawing.Point(152, 147);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtapellido.MaxLength = 50;
            this.txtapellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtapellido.Multiline = false;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(175, 50);
            this.txtapellido.TabIndex = 28;
            this.txtapellido.Text = "";
            this.txtapellido.TrailingIcon = null;
            // 
            // txtnombresegundo
            // 
            this.txtnombresegundo.AnimateReadOnly = false;
            this.txtnombresegundo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombresegundo.Depth = 0;
            this.txtnombresegundo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombresegundo.LeadingIcon = null;
            this.txtnombresegundo.Location = new System.Drawing.Point(522, 79);
            this.txtnombresegundo.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombresegundo.MaxLength = 50;
            this.txtnombresegundo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombresegundo.Multiline = false;
            this.txtnombresegundo.Name = "txtnombresegundo";
            this.txtnombresegundo.Size = new System.Drawing.Size(175, 50);
            this.txtnombresegundo.TabIndex = 27;
            this.txtnombresegundo.Text = "";
            this.txtnombresegundo.TrailingIcon = null;
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(152, 81);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(175, 50);
            this.txtnombre.TabIndex = 26;
            this.txtnombre.Text = "";
            this.txtnombre.TrailingIcon = null;
            // 
            // txtresseg
            // 
            this.txtresseg.AllowPromptAsInput = true;
            this.txtresseg.AnimateReadOnly = false;
            this.txtresseg.AsciiOnly = false;
            this.txtresseg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtresseg.BeepOnError = false;
            this.txtresseg.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtresseg.Depth = 0;
            this.txtresseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtresseg.HidePromptOnLeave = false;
            this.txtresseg.HideSelection = true;
            this.txtresseg.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtresseg.LeadingIcon = null;
            this.txtresseg.Location = new System.Drawing.Point(152, 341);
            this.txtresseg.Mask = "";
            this.txtresseg.MaxLength = 32767;
            this.txtresseg.MouseState = MaterialSkin.MouseState.OUT;
            this.txtresseg.Name = "txtresseg";
            this.txtresseg.PasswordChar = '\0';
            this.txtresseg.PrefixSuffixText = null;
            this.txtresseg.PromptChar = '*';
            this.txtresseg.ReadOnly = false;
            this.txtresseg.RejectInputOnFirstFailure = false;
            this.txtresseg.ResetOnPrompt = true;
            this.txtresseg.ResetOnSpace = true;
            this.txtresseg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtresseg.SelectedText = "";
            this.txtresseg.SelectionLength = 0;
            this.txtresseg.SelectionStart = 0;
            this.txtresseg.ShortcutsEnabled = true;
            this.txtresseg.Size = new System.Drawing.Size(175, 48);
            this.txtresseg.SkipLiterals = true;
            this.txtresseg.TabIndex = 51;
            this.txtresseg.TabStop = false;
            this.txtresseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtresseg.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtresseg.TrailingIcon = null;
            this.txtresseg.UseSystemPasswordChar = false;
            this.txtresseg.ValidatingType = null;
            // 
            // materialLabel11
            // 
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(730, 273);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(57, 19);
            this.materialLabel11.TabIndex = 53;
            this.materialLabel11.Text = "Usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.AnimateReadOnly = false;
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Depth = 0;
            this.txtusuario.Enabled = false;
            this.txtusuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtusuario.LeadingIcon = null;
            this.txtusuario.Location = new System.Drawing.Point(844, 270);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtusuario.MaxLength = 50;
            this.txtusuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtusuario.Multiline = false;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(175, 50);
            this.txtusuario.TabIndex = 52;
            this.txtusuario.Text = "";
            this.txtusuario.TrailingIcon = null;
            // 
            // txtclavea
            // 
            this.txtclavea.AllowPromptAsInput = true;
            this.txtclavea.AnimateReadOnly = false;
            this.txtclavea.AsciiOnly = false;
            this.txtclavea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtclavea.BeepOnError = false;
            this.txtclavea.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtclavea.Depth = 0;
            this.txtclavea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtclavea.HidePromptOnLeave = false;
            this.txtclavea.HideSelection = true;
            this.txtclavea.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtclavea.LeadingIcon = null;
            this.txtclavea.Location = new System.Drawing.Point(522, 273);
            this.txtclavea.Mask = "";
            this.txtclavea.MaxLength = 32767;
            this.txtclavea.MouseState = MaterialSkin.MouseState.OUT;
            this.txtclavea.Name = "txtclavea";
            this.txtclavea.PasswordChar = '\0';
            this.txtclavea.PrefixSuffixText = null;
            this.txtclavea.PromptChar = '*';
            this.txtclavea.ReadOnly = false;
            this.txtclavea.RejectInputOnFirstFailure = false;
            this.txtclavea.ResetOnPrompt = true;
            this.txtclavea.ResetOnSpace = true;
            this.txtclavea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtclavea.SelectedText = "";
            this.txtclavea.SelectionLength = 0;
            this.txtclavea.SelectionStart = 0;
            this.txtclavea.ShortcutsEnabled = true;
            this.txtclavea.Size = new System.Drawing.Size(175, 48);
            this.txtclavea.SkipLiterals = true;
            this.txtclavea.TabIndex = 54;
            this.txtclavea.TabStop = false;
            this.txtclavea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtclavea.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtclavea.TrailingIcon = null;
            this.txtclavea.UseSystemPasswordChar = false;
            this.txtclavea.ValidatingType = null;
            // 
            // txtclaveb
            // 
            this.txtclaveb.AllowPromptAsInput = true;
            this.txtclaveb.AnimateReadOnly = false;
            this.txtclaveb.AsciiOnly = false;
            this.txtclaveb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtclaveb.BeepOnError = false;
            this.txtclaveb.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtclaveb.Depth = 0;
            this.txtclaveb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtclaveb.HidePromptOnLeave = false;
            this.txtclaveb.HideSelection = true;
            this.txtclaveb.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtclaveb.LeadingIcon = null;
            this.txtclaveb.Location = new System.Drawing.Point(522, 341);
            this.txtclaveb.Mask = "";
            this.txtclaveb.MaxLength = 32767;
            this.txtclaveb.MouseState = MaterialSkin.MouseState.OUT;
            this.txtclaveb.Name = "txtclaveb";
            this.txtclaveb.PasswordChar = '\0';
            this.txtclaveb.PrefixSuffixText = null;
            this.txtclaveb.PromptChar = '*';
            this.txtclaveb.ReadOnly = false;
            this.txtclaveb.RejectInputOnFirstFailure = false;
            this.txtclaveb.ResetOnPrompt = true;
            this.txtclaveb.ResetOnSpace = true;
            this.txtclaveb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtclaveb.SelectedText = "";
            this.txtclaveb.SelectionLength = 0;
            this.txtclaveb.SelectionStart = 0;
            this.txtclaveb.ShortcutsEnabled = true;
            this.txtclaveb.Size = new System.Drawing.Size(175, 48);
            this.txtclaveb.SkipLiterals = true;
            this.txtclaveb.TabIndex = 55;
            this.txtclaveb.TabStop = false;
            this.txtclaveb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtclaveb.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtclaveb.TrailingIcon = null;
            this.txtclaveb.UseSystemPasswordChar = false;
            this.txtclaveb.ValidatingType = null;
            // 
            // materialLabel12
            // 
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(372, 273);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(64, 27);
            this.materialLabel12.TabIndex = 56;
            this.materialLabel12.Text = "Clave";
            // 
            // materialLabel13
            // 
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(372, 345);
            this.materialLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(124, 44);
            this.materialLabel13.TabIndex = 57;
            this.materialLabel13.Text = "Repetir clave";
            // 
            // UsuarioAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 412);
            this.Controls.Add(this.materialLabel13);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.txtclaveb);
            this.Controls.Add(this.txtclavea);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtresseg);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.cmbsexo);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtpregunta);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtapellidosegundo);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombresegundo);
            this.Controls.Add(this.txtnombre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsuarioAdd";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Usuarios";
            this.Load += new System.EventHandler(this.UsuarioAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btneditar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox txtfecha;
        private MaterialSkin.Controls.MaterialButton btncancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox cmbsexo;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox txttelefono;
        private MaterialSkin.Controls.MaterialButton btnagregar;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txtdni;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtpregunta;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtapellidosegundo;
        private MaterialSkin.Controls.MaterialTextBox txtapellido;
        private MaterialSkin.Controls.MaterialTextBox txtnombresegundo;
        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtresseg;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox txtusuario;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtclavea;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtclaveb;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
    }
}