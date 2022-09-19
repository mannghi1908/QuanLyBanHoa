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
    public class DAL_CCustomer
    {
        //---------1.Viết hàm gọi Stoted Procedure thêm khách hàng mới
        public void prThemKH(DTO_CCustomer c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_ThemKH", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MsKH", System.Data.SqlDbType.Char, 10).Value = c.MsKH;
                cmd.Parameters.Add("@TENKH", System.Data.SqlDbType.NVarChar, 50).Value = c.TENKH;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NVarChar, 5).Value = c.PHAI;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 200).Value = c.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.VarChar, 10).Value = c.DIENTHOAI;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString()); //----Lấy thông báo trong Stored Procedure lên GUI
            }
        }
        //---------2.Viết hàm gọi Stored Procedure sửa thông tin khách hàng
        public void prSuaKH(DTO_CCustomer c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_SuaKH", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MsKH", System.Data.SqlDbType.Char, 10).Value = c.MsKH;
                cmd.Parameters.Add("@TENKH", System.Data.SqlDbType.NVarChar, 50).Value = c.TENKH;
                cmd.Parameters.Add("@PHAI", System.Data.SqlDbType.NVarChar, 5).Value = c.PHAI;
                cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 200).Value = c.DIACHI;
                cmd.Parameters.Add("@DIENTHOAI", System.Data.SqlDbType.VarChar, 10).Value = c.DIENTHOAI;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString()); //----Lấy thông báo trong Stored Procedure lên GUI
            }
        }
        //---------3.Viết hàm gọi Stored Procedure xóa khách hàng
        public void prXoaKH(DTO_CCustomer c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("pr_XoaKH", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MsKH", System.Data.SqlDbType.Char, 10).Value = c.MsKH;
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
