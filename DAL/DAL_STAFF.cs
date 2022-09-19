using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_STAFF
    {
        //---------1.Viết hàm gọi Stored Procedure Thêm nhân viên
        public void prThemNV(DTO_STAFF s)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_ThemNV", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = s.MANV;
                cmd.Parameters.Add("@TENNV", System.Data.SqlDbType.NVarChar, 30).Value = s.TENNV;
                cmd.Parameters.Add("@TENDANGNHAP", System.Data.SqlDbType.NVarChar, 256).Value = s.TENDANGNHAP ;
                cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.DateTime).Value = s.NGAYSINH;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NChar, 10).Value = s.PHAI;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 50).Value = s.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = s.DIENTHOAI;
                cmd.Parameters.Add("@SO_HD_THUCHIEN", System.Data.SqlDbType.Int).Value = s.SO_HD_THUCHIEN;
                cmd.Parameters.Add("@NGAYDANGNHAP", System.Data.SqlDbType.DateTime).Value = s.NGAYDANGNHAP;
                cmd.Parameters.Add("@SOLANDN", System.Data.SqlDbType.Int).Value = s.SOLANDN;
                cmd.Parameters.Add("@QUYENHAN", System.Data.SqlDbType.NVarChar, 20).Value = s.QUYENHAN;
                cmd.ExecuteNonQuery();//-----Thực thi Stored Procedure
                cmd.Parameters.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString()); //----Lấy thông báo trong Stored Procedure lên GUI
            }
        }
        //---------2.Viết hàm gọi Stored Procedure sửa thông tin khách hàng
        public void prSuaNV(DTO_STAFF s)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_SuaNV", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = s.MANV;
                cmd.Parameters.Add("@TENNV", System.Data.SqlDbType.NVarChar, 30).Value = s.TENNV;
                cmd.Parameters.Add("@TENDANGNHAP", System.Data.SqlDbType.NVarChar, 256).Value = s.TENDANGNHAP;
                cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.DateTime).Value = s.NGAYSINH;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NChar, 10).Value = s.PHAI;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 50).Value = s.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.NVarChar, 10).Value = s.DIENTHOAI;
                cmd.Parameters.Add("@SO_HD_THUCHIEN", System.Data.SqlDbType.Int).Value = s.SO_HD_THUCHIEN;
                cmd.Parameters.Add("@NGAYDANGNHAP", System.Data.SqlDbType.DateTime).Value = s.NGAYDANGNHAP;
                cmd.Parameters.Add("@SOLANDN", System.Data.SqlDbType.Int).Value = s.SOLANDN;
                cmd.Parameters.Add("@QUYENHAN", System.Data.SqlDbType.NVarChar, 20).Value = s.QUYENHAN;
                cmd.ExecuteNonQuery();//-----Thực thi Stored Procedure
                cmd.Parameters.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString()); //----Lấy thông báo trong Stored Procedure lên GUI
            }
        }
        //---------3.Viết hàm gọi Stored Procedure xóa khách hàng
        public void prXoaNV(DTO_STAFF s)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_XoaNV", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = s.MANV;
                cmd.ExecuteNonQuery(); //-----Thực thi Stored Procedure
                cmd.Parameters.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
    }
}
