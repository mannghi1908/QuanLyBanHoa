namespace GUI
{
    partial class frmBCDSMoiMHReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btBaocao = new System.Windows.Forms.Button();
            this.dTPDenngay = new System.Windows.Forms.DateTimePicker();
            this.dTPTungay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewerP = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CR_MHTuDen1 = new GUI.CR_MHTuDen();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btBaocao);
            this.groupBox1.Controls.Add(this.dTPDenngay);
            this.groupBox1.Controls.Add(this.dTPTungay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(989, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập từ ngày - đến ngày:";
            // 
            // btThoat
            // 
            this.btThoat.Image = global::GUI.Properties.Resources.exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(712, 27);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(103, 29);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btBaocao
            // 
            this.btBaocao.Image = global::GUI.Properties.Resources.report;
            this.btBaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBaocao.Location = new System.Drawing.Point(584, 27);
            this.btBaocao.Margin = new System.Windows.Forms.Padding(2);
            this.btBaocao.Name = "btBaocao";
            this.btBaocao.Size = new System.Drawing.Size(103, 29);
            this.btBaocao.TabIndex = 2;
            this.btBaocao.Text = "Báo cáo";
            this.btBaocao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBaocao.UseVisualStyleBackColor = true;
            this.btBaocao.Click += new System.EventHandler(this.btBaocao_Click);
            // 
            // dTPDenngay
            // 
            this.dTPDenngay.CustomFormat = "dd/MM/yyyy";
            this.dTPDenngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDenngay.Location = new System.Drawing.Point(401, 33);
            this.dTPDenngay.Margin = new System.Windows.Forms.Padding(2);
            this.dTPDenngay.Name = "dTPDenngay";
            this.dTPDenngay.Size = new System.Drawing.Size(147, 22);
            this.dTPDenngay.TabIndex = 1;
            // 
            // dTPTungay
            // 
            this.dTPTungay.CustomFormat = "dd/MM/yyyy";
            this.dTPTungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPTungay.Location = new System.Drawing.Point(148, 33);
            this.dTPTungay.Margin = new System.Windows.Forms.Padding(2);
            this.dTPTungay.Name = "dTPTungay";
            this.dTPTungay.Size = new System.Drawing.Size(147, 22);
            this.dTPTungay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // crystalReportViewerP
            // 
            this.crystalReportViewerP.ActiveViewIndex = -1;
            this.crystalReportViewerP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerP.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerP.Location = new System.Drawing.Point(0, 95);
            this.crystalReportViewerP.Margin = new System.Windows.Forms.Padding(2);
            this.crystalReportViewerP.Name = "crystalReportViewerP";
            this.crystalReportViewerP.Size = new System.Drawing.Size(989, 527);
            this.crystalReportViewerP.TabIndex = 1;
            this.crystalReportViewerP.ToolPanelWidth = 145;
            // 
            // frmBCDSMoiMHReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 622);
            this.Controls.Add(this.crystalReportViewerP);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBCDSMoiMHReport";
            this.Text = "Báo cáo doanh số cho mỗi mặt hàng [Từ ngày - Đến ngày]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btBaocao;
        private System.Windows.Forms.DateTimePicker dTPDenngay;
        private System.Windows.Forms.DateTimePicker dTPTungay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerP;
        private CR_MHTuDen CR_MHTuDen1;
    }
}