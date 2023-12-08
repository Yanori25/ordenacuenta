namespace OrdenaCuenta.View.Menus
{
    partial class MenuSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSeguridad));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.imglistmenu = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imglistmenu;
            this.materialTabControl1.Location = new System.Drawing.Point(2, 52);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(628, 377);
            this.materialTabControl1.TabIndex = 20;
            // 
            // imglistmenu
            // 
            this.imglistmenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistmenu.ImageStream")));
            this.imglistmenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistmenu.Images.SetKeyName(0, "home_house_3526.png");
            this.imglistmenu.Images.SetKeyName(1, "note-task-comment-message-edit-write_108613 (1).png");
            this.imglistmenu.Images.SetKeyName(2, "business_application_addmale_useradd_insert_add_user_client_2312.png");
            this.imglistmenu.Images.SetKeyName(3, "1455739708_Kitchen_Bold_Line_Color_Mix-04_icon-icons.com_53405.png");
            this.imglistmenu.Images.SetKeyName(4, "dollar-coin-money_icon-icons.com_56177.png");
            this.imglistmenu.Images.SetKeyName(5, "1489436636-coindollarcurrencymoney_81873.png");
            this.imglistmenu.Images.SetKeyName(6, "Maintenance_36750.png");
            this.imglistmenu.Images.SetKeyName(7, "customer_person_people_man_you_1625.png");
            this.imglistmenu.Images.SetKeyName(8, "ic-vendor_97612.png");
            this.imglistmenu.Images.SetKeyName(9, "40_104848.png");
            this.imglistmenu.Images.SetKeyName(10, "business_table_order_report_history_2332.png");
            this.imglistmenu.Images.SetKeyName(11, "records_notes_journal_edited_9479.png");
            this.imglistmenu.Images.SetKeyName(12, "ledger_icon_246675.png");
            this.imglistmenu.Images.SetKeyName(13, "payment_financial_tax_report_payable_budget_dollar_accounting_account_icon_258663" +
        ".png");
            this.imglistmenu.Images.SetKeyName(14, "cash_icon-icons.com_51090.png");
            this.imglistmenu.Images.SetKeyName(15, "accounting_calculator_banking_currency_dollar_bank_business_money_making_icon_258" +
        "655.png");
            this.imglistmenu.Images.SetKeyName(16, "community_users_12977.png");
            this.imglistmenu.Images.SetKeyName(17, "systemusers_104569.png");
            this.imglistmenu.Images.SetKeyName(18, "folder_options_15429.png");
            this.imglistmenu.Images.SetKeyName(19, "settings_options_preferences_gears_icon_124617.png");
            this.imglistmenu.Images.SetKeyName(20, "rotation_102346.png");
            this.imglistmenu.Images.SetKeyName(21, "rotation_usurol.png");
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(2, 429);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(628, 22);
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MenuSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.statusStrip);
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuSeguridad";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Seguridad";
            this.Load += new System.EventHandler(this.MenuSeguridad_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.ImageList imglistmenu;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
    }
}