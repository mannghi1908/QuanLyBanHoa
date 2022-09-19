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
    public partial class frmBCDSMoiNVReport : Form
    {
        public frmBCDSMoiNVReport()
        {
            InitializeComponent();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            BCDSNVReport rp = new BCDSNVReport();

            //----------2.Cung cấp thông tin đăng nhập cho CrystalReport: CR_MHTuDen
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
            CrystalDecisions.Shared.ParameterDiscreteValue PDVTungay = new CrystalDecisions.Shared.ParameterDiscreteValue();
            CrystalDecisions.Shared.ParameterDiscreteValue PDVDenngay = new CrystalDecisions.Shared.ParameterDiscreteValue();

            //----------4. Truyền tham số Từ ngày - Đến ngày (Form)
            //-----4.1. Truyền tham số Từ ngày
            PDVTungay.Value = this.dTPTungay.Value;
            myVL.Add(PDVTungay);
            rp.DataDefinition.ParameterFields["@TUDAY"].ApplyCurrentValues(myVL);
            myVL.Clear();
            //-----4.2. Truyền tham số Đến ngày
            PDVDenngay.Value = this.DTPDenngay.Value;
            myVL.Add(PDVDenngay);
            rp.DataDefinition.ParameterFields["@DENNGAY"].ApplyCurrentValues(myVL);
            myVL.Clear();

            //-----------5.Gán CrystalReport vào crystalReportViewerP
            crystalReportViewer1.ReportSource = rp;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (f == DialogResult.Yes)
                this.Close();
        }
    }
}
