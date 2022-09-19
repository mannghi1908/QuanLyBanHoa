using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmINHOADON : Form
    {
        public frmINHOADON()
        {
            InitializeComponent();
        }

        private void frmINHOADON_Load(object sender, EventArgs e)
        {
            txtMahD.Text = frmHoadon.masoshoadon;
            if ( txtMahD.Text.Trim()!= "")
            {
                    INHOADON(txtMahD.Text.Trim());
            }
        }

        public void INHOADON(string ms)
        {
            //----------1.Khai báo CrystalReport: CrystalReportHD.rpt
            CrystalReportHD rp = new CrystalReportHD();

            //----------2.Cung cấp thông tin đăng nhập cho CrystalReport: CrystalReportHD
            ConnectionInfo myConn = new ConnectionInfo();
            myConn.ServerName = frmDangnhap.SV;
            myConn.DatabaseName = frmDangnhap.DB;
            myConn.UserID = frmDangnhap.UI;
            myConn.Password = frmDangnhap.Pass;
            TableLogOnInfo myTable = new TableLogOnInfo();
            myTable.ConnectionInfo = myConn;
            rp.Database.Tables[0].ApplyLogOnInfo(myTable);

            //----------3.Khai báo kết nối tham số với CrystalReport
            CrystalDecisions.Shared.ParameterValues myVL = new CrystalDecisions.Shared.ParameterValues();
            CrystalDecisions.Shared.ParameterDiscreteValue PDVMaHD = new CrystalDecisions.Shared.ParameterDiscreteValue();
        

            //----------4. Truyền tham số Từ ngày - Đến ngày (Form)
            //-----4.1. Truyền tham số Từ ngày
            PDVMaHD.Value = ms;
            myVL.Add(PDVMaHD);
            rp.DataDefinition.ParameterFields["@MSHD"].ApplyCurrentValues(myVL);
            myVL.Clear();
           
            //-----------5.Gán CrystalReport vào crystalReportViewerP
            crystalReportViewerHD.ReportSource = rp;
        }

        private void btINHOADON_Click(object sender, EventArgs e)
        {
            if (txtMahD.Text.Trim() != "")
            {
                INHOADON(txtMahD.Text.Trim());
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (f == DialogResult.Yes)
                this.Close();
        }
    }
}
