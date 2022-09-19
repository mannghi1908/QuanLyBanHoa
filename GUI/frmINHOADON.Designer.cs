namespace GUI
{
    partial class frmINHOADON
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
            this.btINHOADON = new System.Windows.Forms.Button();
            this.txtMahD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewerHD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::GUI.Properties.Resources._2;
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btINHOADON);
            this.groupBox1.Controls.Add(this.txtMahD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1057, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btThoat
            // 
            this.btThoat.Image = global::GUI.Properties.Resources.cancel;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(597, 25);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(103, 31);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btINHOADON
            // 
            this.btINHOADON.Image = global::GUI.Properties.Resources.printer;
            this.btINHOADON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btINHOADON.Location = new System.Drawing.Point(469, 25);
            this.btINHOADON.Margin = new System.Windows.Forms.Padding(2);
            this.btINHOADON.Name = "btINHOADON";
            this.btINHOADON.Size = new System.Drawing.Size(103, 31);
            this.btINHOADON.TabIndex = 2;
            this.btINHOADON.Text = "In hóa đơn";
            this.btINHOADON.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btINHOADON.UseVisualStyleBackColor = true;
            this.btINHOADON.Click += new System.EventHandler(this.btINHOADON_Click);
            // 
            // txtMahD
            // 
            this.txtMahD.Location = new System.Drawing.Point(204, 25);
            this.txtMahD.Margin = new System.Windows.Forms.Padding(2);
            this.txtMahD.Multiline = true;
            this.txtMahD.Name = "txtMahD";
            this.txtMahD.Size = new System.Drawing.Size(189, 31);
            this.txtMahD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // crystalReportViewerHD
            // 
            this.crystalReportViewerHD.ActiveViewIndex = -1;
            this.crystalReportViewerHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerHD.Location = new System.Drawing.Point(0, 73);
            this.crystalReportViewerHD.Margin = new System.Windows.Forms.Padding(2);
            this.crystalReportViewerHD.Name = "crystalReportViewerHD";
            this.crystalReportViewerHD.Size = new System.Drawing.Size(1057, 490);
            this.crystalReportViewerHD.TabIndex = 1;
            this.crystalReportViewerHD.ToolPanelWidth = 145;
            // 
            // frmINHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 563);
            this.Controls.Add(this.crystalReportViewerHD);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmINHOADON";
            this.Text = "Tìm kiếm hóa đoen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmINHOADON_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btINHOADON;
        private System.Windows.Forms.TextBox txtMahD;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerHD;
    }
}