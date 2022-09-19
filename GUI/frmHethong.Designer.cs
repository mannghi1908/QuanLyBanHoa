namespace GUI
{
    partial class frmHethong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHethong));
            this.menuHethong = new System.Windows.Forms.MenuStrip();
            this.mnuHT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHKN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBR = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDMKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuINHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKDT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDTNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDTMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTCHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTG = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHethong.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuHethong
            // 
            this.menuHethong.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuHethong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHT,
            this.mnuDM,
            this.mnuHD,
            this.mnuBC,
            this.mnuTC,
            this.mnuTG});
            this.menuHethong.Location = new System.Drawing.Point(0, 0);
            this.menuHethong.Name = "menuHethong";
            this.menuHethong.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuHethong.Size = new System.Drawing.Size(1067, 38);
            this.menuHethong.TabIndex = 0;
            this.menuHethong.Text = "menuStrip1";
            // 
            // mnuHT
            // 
            this.mnuHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDN,
            this.toolStripSeparator1,
            this.mnuHKN,
            this.toolStripSeparator2,
            this.mnuBR,
            this.toolStripSeparator3,
            this.mnuThoat});
            this.mnuHT.Image = global::GUI.Properties.Resources.system;
            this.mnuHT.Name = "mnuHT";
            this.mnuHT.Size = new System.Drawing.Size(113, 32);
            this.mnuHT.Text = "Hệ thống";
            // 
            // mnuDN
            // 
            this.mnuDN.Image = ((System.Drawing.Image)(resources.GetObject("mnuDN.Image")));
            this.mnuDN.Name = "mnuDN";
            this.mnuDN.Size = new System.Drawing.Size(223, 26);
            this.mnuDN.Text = "Đăng nhập";
            this.mnuDN.Click += new System.EventHandler(this.mnuDN_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // mnuHKN
            // 
            this.mnuHKN.Image = global::GUI.Properties.Resources.cancel;
            this.mnuHKN.Name = "mnuHKN";
            this.mnuHKN.Size = new System.Drawing.Size(223, 26);
            this.mnuHKN.Text = "Hủy kết nối";
            this.mnuHKN.Click += new System.EventHandler(this.mnuHKN_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(220, 6);
            // 
            // mnuBR
            // 
            this.mnuBR.Image = global::GUI.Properties.Resources.backup;
            this.mnuBR.Name = "mnuBR";
            this.mnuBR.Size = new System.Drawing.Size(223, 26);
            this.mnuBR.Text = "Backup and Restore";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = global::GUI.Properties.Resources.exit;
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(223, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDM
            // 
            this.mnuDM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDMMH,
            this.mnuDMNV,
            this.mnuDMKH});
            this.mnuDM.Image = global::GUI.Properties.Resources.category;
            this.mnuDM.Name = "mnuDM";
            this.mnuDM.Size = new System.Drawing.Size(118, 32);
            this.mnuDM.Text = "Danh mục";
            // 
            // mnuDMMH
            // 
            this.mnuDMMH.Image = global::GUI.Properties.Resources.product;
            this.mnuDMMH.Name = "mnuDMMH";
            this.mnuDMMH.Size = new System.Drawing.Size(169, 26);
            this.mnuDMMH.Text = "Mặt hàng";
            this.mnuDMMH.Click += new System.EventHandler(this.mnuDMMH_Click);
            // 
            // mnuDMNV
            // 
            this.mnuDMNV.Image = global::GUI.Properties.Resources.staff;
            this.mnuDMNV.Name = "mnuDMNV";
            this.mnuDMNV.Size = new System.Drawing.Size(169, 26);
            this.mnuDMNV.Text = "Nhân viên";
            this.mnuDMNV.Click += new System.EventHandler(this.mnuDMNV_Click);
            // 
            // mnuDMKH
            // 
            this.mnuDMKH.Image = global::GUI.Properties.Resources.customer;
            this.mnuDMKH.Name = "mnuDMKH";
            this.mnuDMKH.Size = new System.Drawing.Size(169, 26);
            this.mnuDMKH.Text = "Khách hàng";
            this.mnuDMKH.Click += new System.EventHandler(this.mnuDMKH_Click);
            // 
            // mnuHD
            // 
            this.mnuHD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLHD});
            this.mnuHD.Image = global::GUI.Properties.Resources.bill;
            this.mnuHD.Name = "mnuHD";
            this.mnuHD.Size = new System.Drawing.Size(109, 32);
            this.mnuHD.Text = "Hóa đơn";
            // 
            // mnuLHD
            // 
            this.mnuLHD.Image = global::GUI.Properties.Resources.create_bill;
            this.mnuLHD.Name = "mnuLHD";
            this.mnuLHD.Size = new System.Drawing.Size(175, 26);
            this.mnuLHD.Text = "Lập hóa đơn";
            this.mnuLHD.Click += new System.EventHandler(this.mnuLHD_Click);
            // 
            // mnuBC
            // 
            this.mnuBC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuINHD,
            this.mnuTKDT});
            this.mnuBC.Image = global::GUI.Properties.Resources.report;
            this.mnuBC.Name = "mnuBC";
            this.mnuBC.Size = new System.Drawing.Size(105, 32);
            this.mnuBC.Text = "Báo cáo";
            // 
            // mnuINHD
            // 
            this.mnuINHD.Image = global::GUI.Properties.Resources.printer;
            this.mnuINHD.Name = "mnuINHD";
            this.mnuINHD.Size = new System.Drawing.Size(290, 26);
            this.mnuINHD.Text = "In hóa đơn";
            // 
            // mnuTKDT
            // 
            this.mnuTKDT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDTNV,
            this.mnuDTMH});
            this.mnuTKDT.Image = global::GUI.Properties.Resources.trend;
            this.mnuTKDT.Name = "mnuTKDT";
            this.mnuTKDT.Size = new System.Drawing.Size(290, 26);
            this.mnuTKDT.Text = "Thống kê doanh thu bán hàng";
            this.mnuTKDT.Click += new System.EventHandler(this.mnuTKDT_Click);
            // 
            // mnuDTNV
            // 
            this.mnuDTNV.Image = global::GUI.Properties.Resources.staff_meeting;
            this.mnuDTNV.Name = "mnuDTNV";
            this.mnuDTNV.Size = new System.Drawing.Size(286, 26);
            this.mnuDTNV.Text = "Doanh thu cho mỗi nhân viên";
            this.mnuDTNV.Click += new System.EventHandler(this.mnuDTNV_Click);
            // 
            // mnuDTMH
            // 
            this.mnuDTMH.Image = global::GUI.Properties.Resources.presentation;
            this.mnuDTMH.Name = "mnuDTMH";
            this.mnuDTMH.Size = new System.Drawing.Size(286, 26);
            this.mnuDTMH.Text = "Doanh thu cho mỗi mặt hàng";
            this.mnuDTMH.Click += new System.EventHandler(this.mnuDTMH_Click);
            // 
            // mnuTC
            // 
            this.mnuTC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTCNV,
            this.mnuTCMH,
            this.mnuTCKH,
            this.mnuTCHD});
            this.mnuTC.Image = ((System.Drawing.Image)(resources.GetObject("mnuTC.Image")));
            this.mnuTC.Name = "mnuTC";
            this.mnuTC.Size = new System.Drawing.Size(99, 32);
            this.mnuTC.Text = "Tra cứu";
            // 
            // mnuTCNV
            // 
            this.mnuTCNV.Image = global::GUI.Properties.Resources.staff;
            this.mnuTCNV.Name = "mnuTCNV";
            this.mnuTCNV.Size = new System.Drawing.Size(232, 34);
            this.mnuTCNV.Text = "Nhân viên";
            this.mnuTCNV.Click += new System.EventHandler(this.mnuTCNV_Click);
            // 
            // mnuTCMH
            // 
            this.mnuTCMH.Image = global::GUI.Properties.Resources.product;
            this.mnuTCMH.Name = "mnuTCMH";
            this.mnuTCMH.Size = new System.Drawing.Size(232, 34);
            this.mnuTCMH.Text = "Mặt hàng";
            // 
            // mnuTCKH
            // 
            this.mnuTCKH.Image = global::GUI.Properties.Resources.customer;
            this.mnuTCKH.Name = "mnuTCKH";
            this.mnuTCKH.Size = new System.Drawing.Size(232, 34);
            this.mnuTCKH.Text = "Khách hàng";
            // 
            // mnuTCHD
            // 
            this.mnuTCHD.Image = global::GUI.Properties.Resources.bill;
            this.mnuTCHD.Name = "mnuTCHD";
            this.mnuTCHD.Size = new System.Drawing.Size(232, 34);
            this.mnuTCHD.Text = "Hóa đơn";
            this.mnuTCHD.Click += new System.EventHandler(this.mnuTCHD_Click);
            // 
            // mnuTG
            // 
            this.mnuTG.Image = global::GUI.Properties.Resources.help;
            this.mnuTG.Name = "mnuTG";
            this.mnuTG.Size = new System.Drawing.Size(106, 32);
            this.mnuTG.Text = "Trợ giúp";
            // 
            // frmHethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources._4;
            this.ClientSize = new System.Drawing.Size(1067, 666);
            this.Controls.Add(this.menuHethong);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuHethong;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHethong";
            this.Text = "Hệ thống quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHethong_Load);
            this.menuHethong.ResumeLayout(false);
            this.menuHethong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHethong;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuLHD;
        private System.Windows.Forms.ToolStripMenuItem mnuINHD;
        private System.Windows.Forms.ToolStripMenuItem mnuTKDT;
        private System.Windows.Forms.ToolStripMenuItem mnuDTNV;
        private System.Windows.Forms.ToolStripMenuItem mnuDTMH;
        private System.Windows.Forms.ToolStripMenuItem mnuTCNV;
        private System.Windows.Forms.ToolStripMenuItem mnuTCMH;
        private System.Windows.Forms.ToolStripMenuItem mnuTCKH;
        private System.Windows.Forms.ToolStripMenuItem mnuTCHD;
        private System.Windows.Forms.ToolStripMenuItem mnuTG;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripMenuItem mnuHT;
        public System.Windows.Forms.ToolStripMenuItem mnuDN;
        public System.Windows.Forms.ToolStripMenuItem mnuHKN;
        public System.Windows.Forms.ToolStripMenuItem mnuBR;
        public System.Windows.Forms.ToolStripMenuItem mnuDM;
        public System.Windows.Forms.ToolStripMenuItem mnuDMMH;
        public System.Windows.Forms.ToolStripMenuItem mnuDMNV;
        public System.Windows.Forms.ToolStripMenuItem mnuDMKH;
        public System.Windows.Forms.ToolStripMenuItem mnuHD;
        public System.Windows.Forms.ToolStripMenuItem mnuBC;
        public System.Windows.Forms.ToolStripMenuItem mnuTC;
    }
}