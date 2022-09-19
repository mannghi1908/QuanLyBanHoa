using BUS;
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
    public partial class frmHethong : Form
    {
        //-------------Khai báo lớp: GUI_CEnableMenu
        GUI_CEnableMenu mnu = new GUI_CEnableMenu();

        //-------------Khai báo lớp: BUS_CDBConnect
        BUS_CDBConnect cn = new BUS_CDBConnect();
        public frmHethong()
        {
            InitializeComponent();
        }

        private void frmHethong_Load(object sender, EventArgs e)
        {
            mnu.EnableMenu(true, false);
            frmDangnhap frm = new frmDangnhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuHKN_Click(object sender, EventArgs e)
        {
            if (cn.DisDBConnect() == true)
            {
                mnu.EnableMenu(true, false);
            }
        }

        private void mnuDN_Click(object sender, EventArgs e)
        {
            frmDangnhap frm = new frmDangnhap();
            frm.ShowDialog();
        }

        private void mnuDMKH_Click(object sender, EventArgs e)
        {
            frmKhachhang frm = new frmKhachhang();
            frm.ShowDialog();
        }

        private void mnuDTMH_Click(object sender, EventArgs e)
        {
            frmBCDSMoiMHReport frm = new frmBCDSMoiMHReport();
            frm.ShowDialog();
        }

        private void mnuLHD_Click(object sender, EventArgs e)
        {
            frmHoadon frm = new frmHoadon();
            frm.ShowDialog();
        }

        private void mnuTCHD_Click(object sender, EventArgs e)
        {
            //----------Gọi form in hóa đơn
            frmINHOADON frm = new frmINHOADON();
            frm.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (f == DialogResult.Yes)
                Application.Exit();
        }

        private void mnuDMMH_Click(object sender, EventArgs e)
        {
            frmMatHang frm = new frmMatHang();
            frm.ShowDialog();
        }

        private void mnuDMNV_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.ShowDialog();
        }

        private void mnuDTNV_Click(object sender, EventArgs e)
        {
            frmBCDSMoiNVReport frm = new frmBCDSMoiNVReport();
            frm.ShowDialog();
        }

        private void mnuTKDT_Click(object sender, EventArgs e)
        {

        }

        private void mnuTCNV_Click(object sender, EventArgs e)
        {
            
        }
    }
}
