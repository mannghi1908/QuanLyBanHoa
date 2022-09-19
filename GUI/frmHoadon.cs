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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class frmHoadon : Form
    {
        public frmHoadon()
        {
            InitializeComponent();
        }

        //---------Khai báo tầng BUS
        BUS_CgetData dt = new BUS_CgetData();
        BUS_CLAPHOADON hd = new BUS_CLAPHOADON();

        private void frmHoadon_Load(object sender, EventArgs e)
        {
            //----------1.Gọi hàm đưa dữ liệu lên ComboBox Mặt Hàng
            DataTable myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT MSMH, TENMH FROM MATHANG");
            this.cboMathang.DataSource = myDT;
            this.cboMathang.ValueMember = "MSMH";
            this.cboMathang.DisplayMember = "TENMH";
            this.cboMathang.DropDownStyle = ComboBoxStyle.DropDownList;

            //----------2.Gọi hàm đưa dữ liệu lên ComboBox Khách Hàng
            myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT MsKH, TENKH FROM KHACHHANG");
            this.cboKhachhang.DataSource = myDT;
            this.cboKhachhang.ValueMember = "MsKH";
            this.cboKhachhang.DisplayMember = "TENKH";
            this.cboKhachhang.DropDownStyle = ComboBoxStyle.DropDownList;

            //----------2.1.Load thông tin khách hàng theo MsKH
            myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT DIACHI, PHAI, DIENTHOAI FROM KHACHHANG WHERE MsKH = '" + this.cboKhachhang.SelectedValue.ToString() + "'");
            this.txtDiachi.Text = myDT.Rows[0][0].ToString();
            this.cboPhai.Text = myDT.Rows[0][1].ToString();
            this.txtDienthoai.Text = myDT.Rows[0][2].ToString();

            //----------3.Gọi hàm đưa dữ liệu lên ComboBox NHÂN VIÊN
            myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT MANV, TENNV FROM NHANVIEN");
            this.cboNhanvien.DataSource = myDT;
            this.cboNhanvien.ValueMember = "MANV";
            this.cboNhanvien.DisplayMember = "TENNV";
            this.cboNhanvien.DropDownStyle = ComboBoxStyle.DropDownList;

            //----------4.Gọi hàm tạo mã số hóa đơn
            SqlDataReader dr = dt.getDataStoredProcedure("prTaomaHD");
            if (dr.Read() == true)
            {
                this.txtMaHD.Text = dr.GetSqlString(0).ToString();
                dr.Close();
            }
        }

        private void btKhachhang_Click(object sender, EventArgs e)
        {
            frmKhachhang frm = new frmKhachhang();
            frm.ShowDialog();
        }
        //-----------Khai báo các DataRow và DataTable
        private DataRow myRow = null;
        private DataTable myTable = new DataTable();

        private void btThem_Click(object sender, EventArgs e)
        {
            //-----------1.Lấy Đơn vị tính, Đơn giá của mặt
            DataTable myDT = new DataTable();
            dt.getDataTable(myDT, "SELECT DONVITINH, DONGIA FROM MATHANG WHERE MSMH = '" + this.cboMathang.SelectedValue.ToString() + "'");
           
            //-----------2.Thêm dữ liệu vào DataGridView
            myTable = this.dataSetMATHANG.Tables[0];
            myRow = myTable.NewRow();
            myRow[1] = this.cboMathang.SelectedValue.ToString();
            myRow[2] = this.cboMathang.Text.Trim();
            myRow[3] = myDT.Rows[0][0].ToString();
            myRow[4] = int.Parse(this.txtSoluong.Text.Trim());
            myRow[5] = double.Parse(myDT.Rows[0][1].ToString());
            myRow[6] = int.Parse(this.txtSoluong.Text.Trim()) * double.Parse(myDT.Rows[0][1].ToString());
            myTable.Rows.Add(myRow);
            this.dGVMATHANG.DataSource = myTable;

            //-----------3.Tính tổng tiền
            double tong = 0.0;
            for (int i = 0; i < myTable.Rows.Count; i++)
            {
                tong = tong + double.Parse(myTable.Rows[i][6].ToString());
            }
            this.txtTongtien.Text = tong.ToString();
        }
        //---------------Khai báo biến lưu mã số hóa đơn để in report
        public static string masoshoadon = string.Empty;

        private void btLuu_Click(object sender, EventArgs e)
        {
            masoshoadon = txtMaHD.Text.Trim();
            //-----------Khai báo tầng DTO
            for(int i=0; i<myTable.Rows.Count; i++)
            {
                DTO_CLAPHOADON lhd = new DTO_CLAPHOADON(txtMaHD.Text.Trim(),
                                                        cboNhanvien.SelectedValue.ToString(),
                                                        cboKhachhang.SelectedValue.ToString(),
                                                        dTPNgayLHD.Value.ToShortDateString(),
                                                        float.Parse(txtTongtien.Text.Trim()),
                                                        myTable.Rows[i][1].ToString(),
                                                        int.Parse(myTable.Rows[i][4].ToString()),
                                                        float.Parse(myTable.Rows[i][6].ToString()));
                hd.prThemHD(lhd);
            }
            //----------Gọi form in hóa đơn
            frmINHOADON frm = new frmINHOADON();
            frm.ShowDialog();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
                this.Close();
        }

        private void btKhongluu_Click(object sender, EventArgs e)
        {
            cboNhanvien.Text = "";
            cboKhachhang.Text = "";
            txtDiachi.Text = "";
            txtDienthoai.Text = "";
            cboPhai.Text = "";
            txtSoluong.Text = "";
            cboNhanvien.Focus();
        }

        private void btLaphoadon_Click(object sender, EventArgs e)
        {
            masoshoadon = txtMaHD.Text.Trim();
            //-----------Khai báo tầng DTO
            for (int i = 0; i < myTable.Rows.Count; i++)
            {
                DTO_CLAPHOADON lhd = new DTO_CLAPHOADON(txtMaHD.Text.Trim(),
                                                        cboNhanvien.SelectedValue.ToString(),
                                                        cboKhachhang.SelectedValue.ToString(),
                                                        dTPNgayLHD.Value.ToShortDateString(),
                                                        float.Parse(txtTongtien.Text.Trim()),
                                                        myTable.Rows[i][1].ToString(),
                                                        int.Parse(myTable.Rows[i][4].ToString()),
                                                        float.Parse(myTable.Rows[i][6].ToString()));
                hd.prThemHD(lhd);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMatHang frmMH = new frmMatHang();
            frmMH.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.ShowDialog();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
