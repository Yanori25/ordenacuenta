namespace OrdenaCuenta.View.Reportes
{
    partial class MovCuentasfrmcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovCuentasfrmcs));
            this.matlistCuenta = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.lsrol = new MaterialSkin.Controls.MaterialListView();
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
            this.columnHeader3});
            this.matlistCuenta.Depth = 0;
            this.matlistCuenta.FullRowSelect = true;
            this.matlistCuenta.HideSelection = false;
            this.matlistCuenta.Location = new System.Drawing.Point(33, 190);
            this.matlistCuenta.MinimumSize = new System.Drawing.Size(200, 100);
            this.matlistCuenta.MouseLocation = new System.Drawing.Point(-1, -1);
            this.matlistCuenta.MouseState = MaterialSkin.MouseState.OUT;
            this.matlistCuenta.Name = "matlistCuenta";
            this.matlistCuenta.OwnerDraw = true;
            this.matlistCuenta.Size = new System.Drawing.Size(749, 268);
            this.matlistCuenta.TabIndex = 50;
            this.matlistCuenta.UseCompatibleStateImageBehavior = false;
            this.matlistCuenta.View = System.Windows.Forms.View.Details;
            this.matlistCuenta.Click += new System.EventHandler(this.matlistCuenta_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CuentaContable";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descripcion";
            this.columnHeader3.Width = 250;
            // 
            // txtnombre
            // 
            this.txtnombre.AnimateReadOnly = false;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombre.Hint = "Buscar";
            this.txtnombre.LeadingIcon = null;
            this.txtnombre.Location = new System.Drawing.Point(191, 108);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(241, 50);
            this.txtnombre.TabIndex = 51;
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
            this.lsrol.Location = new System.Drawing.Point(33, 495);
            this.lsrol.MinimumSize = new System.Drawing.Size(200, 100);
            this.lsrol.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsrol.MouseState = MaterialSkin.MouseState.OUT;
            this.lsrol.Name = "lsrol";
            this.lsrol.OwnerDraw = true;
            this.lsrol.Size = new System.Drawing.Size(749, 194);
            this.lsrol.TabIndex = 52;
            this.lsrol.UseCompatibleStateImageBehavior = false;
            this.lsrol.View = System.Windows.Forms.View.Details;
            // 
            // MovCuentasfrmcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 781);
            this.Controls.Add(this.lsrol);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.matlistCuenta);
            this.Name = "MovCuentasfrmcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos de cuentas";
            this.Load += new System.EventHandler(this.MovCuentasfrmcs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView matlistCuenta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialListView lsrol;
    }
}