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
    public partial class frmMatHang : Form
    {
        //------------Khai báo lớp: BUS_PRODUCTS
        BUS_PRODUCTS bus = new BUS_PRODUCTS();
        public frmMatHang()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet("dsQLMH");
        SqlDataAdapter daMatHang;
        private void frmMatHang_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-HPBCL9Q\SQLEXPRESS;Initial Catalog=QL_BanHoa;Integrated Security=True";
            string sQueryMatHang = @"select n.* from mathang n";
            daMatHang = new SqlDataAdapter(sQueryMatHang, conn);
            daMatHang.Fill(ds, "tblDSMatHang");
            dgvMatHang.DataSource = ds.Tables["tblDSMatHang"];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_PRODUCTS p = new DTO_PRODUCTS(txtMSMH.Text.Trim(),
                                              txtTenmathang.Text.Trim(),
                                              txtSoluongton.Text.ToString(),
                                              txtDongia.Text.Trim(),
                                              txtDonvitinh.Text.Trim(),
                                              txtHinhAnh.Text.Trim());
            //---------Gọi hàm thêm mặt hàng mới
            bus.prThemMH(p);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_PRODUCTS pr = new DTO_PRODUCTS(txtMSMH.Text.Trim());
            //-----------Gọi hàm Xóa mặt hàng
            bus.pr_XoaMH(pr);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_PRODUCTS pro = new DTO_PRODUCTS(txtMSMH.Text.Trim(),
                                                txtTenmathang.Text.Trim(),
                                                txtSoluongton.Text.ToString(),
                                                txtDongia.Text.Trim(),
                                                txtDonvitinh.Text.Trim(),
                                                txtHinhAnh.Text.Trim());
            //---------Gọi hàm chỉnh sữa mặt hàng mới
            bus.pr_SuaMH(pro);
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtMSMH.Text = "";
            txtTenmathang.Text = "";
            txtSoluongton.Text = "";
            txtDongia.Text = "";
            txtDonvitinh.Text = "";
            txtHinhAnh.Text = "";
            txtMSMH.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (f == DialogResult.Yes)
                this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow dr = dgvMatHang.SelectedRows[0];
            //txtMSMH.Text = dr.Cells["msmh"].Value.ToString();
            //txtTenmathang.Text = dr.Cells["tenmh"].Value.ToString();
            ////txtSoluongton.Text = dr.Cells["slton"].Value.ToString();
            ////txtDongia.Text = dr.Cells["dongia"].Value.ToString();
            ////txtDonvitinh.Text = dr.Cells["dvtinh"].Value.ToString();
        }
    }
}
