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
    public class DAL_PRODUCTS
    {
        //---------2.Viết hàm gọi Stored Procedure thêm thông tin mặt hàng
        public void prThemMH(DTO_PRODUCTS p)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_ThemMH", DAL_CDBConnect.myconn);               
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSMH", System.Data.SqlDbType.Char, 10).Value = p.MSMH;
                cmd.Parameters.Add("@TENMH", System.Data.SqlDbType.NVarChar, 50).Value = p.TENMH;
                cmd.Parameters.Add("@SL_TON", System.Data.SqlDbType.NVarChar, 5).Value = p.SL_TON;
                cmd.Parameters.Add("@DONGIA", System.Data.SqlDbType.VarChar, 10).Value = p.DONGIA;
                cmd.Parameters.Add("@DONVITINH", System.Data.SqlDbType.NVarChar, 200).Value = p.DONVITINH;
                cmd.Parameters.Add("@HINHANH", System.Data.SqlDbType.NVarChar, 30).Value = p.HINHANH;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString()); //----Lấy thông báo trong Stored Procedure lên GUI
            }
        }
        //---------2.Viết hàm gọi Stored Procedure sửa thông tin mặt hàng
        public void prSuaMH(DTO_PRODUCTS p)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_SuaMH", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSMH", System.Data.SqlDbType.Char, 10).Value = p.MSMH;
                cmd.Parameters.Add("@TENMH", System.Data.SqlDbType.NVarChar, 50).Value = p.TENMH;
                cmd.Parameters.Add("@SL_TON", System.Data.SqlDbType.NVarChar, 5).Value = p.SL_TON;
                cmd.Parameters.Add("@DONGIA", System.Data.SqlDbType.VarChar, 10).Value = p.DONGIA;
                cmd.Parameters.Add("@DONVITINH", System.Data.SqlDbType.NVarChar, 200).Value = p.DONVITINH;
                cmd.Parameters.Add("@HINHANH", System.Data.SqlDbType.NVarChar, 30).Value = p.HINHANH;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString()); //----Lấy thông báo trong Stored Procedure lên GUI
            }
        }
        //---------3.Viết hàm gọi Stored Procedure xóa mặt hàng
        public void prXoaMH(DTO_PRODUCTS p)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_XoaMH", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSMH", System.Data.SqlDbType.Char, 10).Value = p.MSMH;
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
