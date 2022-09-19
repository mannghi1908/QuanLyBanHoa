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
    public class DAL_CLAPHOADON
    {
        //---------1.Viết hàm gọi Stoted Procedure lập hóa đơn bán hàng
        public void prThemHD(DTO_CLAPHOADON c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("prLapHD", DAL_CDBConnect.myconn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@MSHD", System.Data.SqlDbType.Char, 15).Value = c.MSHD;
                cmd.Parameters.Add("@MANV", System.Data.SqlDbType.Char, 10).Value = c.MANV;
                cmd.Parameters.Add("@MSKH", System.Data.SqlDbType.Char, 10).Value = c.MSKH;
                cmd.Parameters.Add("@NGAYHD", System.Data.SqlDbType.DateTime).Value = c.NGAYHD;
                cmd.Parameters.Add("@TONGTIEN", System.Data.SqlDbType.Float).Value = c.TONGTIEN;
                cmd.Parameters.Add("@MSMH", System.Data.SqlDbType.Char, 10).Value = c.MSMH;
                cmd.Parameters.Add("@SOLUONG", System.Data.SqlDbType.Int).Value = c.SOLUONG;
                cmd.Parameters.Add("@THANHTIEN", System.Data.SqlDbType.Float).Value = c.THANHTIEN;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString()); //----Lấy thông báo trong Stored Procedure lên GUI
            }
        }
    }
}
