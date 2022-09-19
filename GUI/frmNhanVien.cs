using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        //------------Khai báo lớp: BUS_STAFF
        BUS_STAFF bus = new BUS_STAFF();
        public frmNhanVien()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet("dsQLNV");
        SqlDataAdapter daNhanVien;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-HPBCL9Q\SQLEXPRESS;Initial Catalog=QL_BanHoa;Integrated Security=True";
            string sQueryNhanVien = @"select n.* from nhanvien n";
            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");
            dgvNhanVien.DataSource = ds.Tables["tblDSNhanVien"];
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_STAFF s = new DTO_STAFF(txtMANV.Text.Trim(),
                                        txtTenNV.Text.Trim(),
                                        txtTenDN.Text.Trim(),
                                        DateTime.Parse(dtpNgaySinh.Value.ToShortDateString()),
                                        cmbPhai.Text.ToString(),
                                        txtDiaChi.Text.Trim(),
                                        txtDienthoai.Text.Trim(),
                                        txtSoHDTH.Text.Trim(),
                                        DateTime.Parse(dtpNgayDN.Value.ToShortDateString()),
                                        txtSolanDN.Text.Trim(),                   
                                        cmbQuyenDN.Text.ToString());
            //---------Gọi hàm thêm khách hàng mới
            bus.prThemNV(s);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_STAFF st = new DTO_STAFF(txtMANV.Text.Trim());
            //-----------Gọi hàm Xóa khách hàng
            bus.pr_XoaNV(st);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_STAFF sta = new DTO_STAFF(txtMANV.Text.Trim(),
                                        txtTenNV.Text.Trim(),
                                        txtTenDN.Text.Trim(),
                                        DateTime.Parse(dtpNgaySinh.Value.ToShortTimeString()),
                                        cmbPhai.Text.ToString(),
                                        txtDiaChi.Text.Trim(),
                                        txtDienthoai.Text.Trim(),
                                        txtSoHDTH.Text.Trim(),
                                        DateTime.Parse(dtpNgayDN.Value.ToShortDateString()),
                                        txtSolanDN.Text.Trim(),
                                        cmbQuyenDN.Text.ToString());
            //---------Gọi hàm thêm khách hàng mới
            bus.pr_SuaNV(sta);
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtMANV.Text = "";
            txtTenDN.Text = "";
            cmbPhai.Text = "";
            txtDiaChi.Text = "";
            txtSoHDTH.Text = "";
            txtSolanDN.Text = "";
            txtTenNV.Text = "";
            txtDienthoai.Text = "";
            cmbQuyenDN.Text = "";
            txtMANV.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bnạ có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (f == DialogResult.Yes)
                this.Close();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
