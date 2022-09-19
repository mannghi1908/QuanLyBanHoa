using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmKhachhang : Form
    {
        //------------Khai báo lớp: BUS_CCustomer
        BUS_CCustomer bus = new BUS_CCustomer();

        public frmKhachhang()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet("dsQLKH");
        SqlDataAdapter daKhachHang;
         private void frmKhachhang_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-HPBCL9Q\SQLEXPRESS;Initial Catalog=QL_BanHoa;Integrated Security=True";
            string sQueryNhanVien = @"select n.* from khachhang n";
            daKhachHang = new SqlDataAdapter(sQueryNhanVien, conn);
            daKhachHang.Fill(ds, "tblDSKhachHang");
            dgvKhachHang.DataSource = ds.Tables["tblDSKhachHang"];
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            //---------Gọi hàm khởi tạo dữ liệu khách hàng
            DTO_CCustomer c = new DTO_CCustomer(txtMsKH.Text.Trim(), 
                                                txtTenKH.Text.Trim(), 
                                                cboPhai.Text.ToString(), 
                                                txtDiachi.Text.Trim(), 
                                                txtDienthoai.Text.Trim());
           //---------Gọi hàm thêm khách hàng mới
            bus.prThemKH(c);
        }

        private void txtXoa_Click(object sender, EventArgs e)
        {
            DTO_CCustomer cus = new DTO_CCustomer(txtMsKH.Text.Trim());
            //-----------Gọi hàm Xóa khách hàng
            bus.pr_XoaKH(cus);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DTO_CCustomer c = new DTO_CCustomer(txtMsKH.Text.Trim(),
                                                txtTenKH.Text.Trim(),
                                                cboPhai.Text.ToString(),
                                                txtDiachi.Text.Trim(),
                                                txtDienthoai.Text.Trim());
            //---------Gọi hàm chỉnh sữa khách hàng mới
            bus.pr_SuaKH(c);
        }

        private void btThoat1_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (f == DialogResult.Yes)
                this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DTO_CCustomer c = new DTO_CCustomer(txtMsKH.Text.Trim(),
                                               txtTenKH.Text.Trim(),
                                               cboPhai.Text.ToString(),
                                               txtDiachi.Text.Trim(),
                                               txtDienthoai.Text.Trim());
            //---------Gọi hàm thêm khách hàng mới
            bus.prThemKH(c);
        }

        private void btKhongluu_Click(object sender, EventArgs e)
        {
            txtMsKH.Text = "";
            txtTenKH.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            cboPhai.Text = "";
            txtMsKH.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
