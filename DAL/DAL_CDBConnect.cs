using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_CDBConnect
    {
        //-----------1.Khai báo lớp kết nối CSDL (Database)
        public static SqlConnection myconn = null;

        //-----------2.Khai báo biến để chứa chuỗi kết nối CSDL
        public static string strconn = null;
        
        //----------3.Viết hàm kết nối CSDL
        public bool DBConnect(DTO_CLogIn lg)
        {
            try
            {
                strconn =   "Data Source=" + lg.ServerName + 
                            ";Initial Catalog=" + lg.Database + 
                            ";User ID=" + lg.UserID + 
                            ";Password=" + lg.Password;

                myconn = new SqlConnection(strconn);
                myconn.Open();  //-----Mở kết nối CSDL
                return true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
                return false;
            }            
        }
        //----------4.Viết hàm hủy kết nối
        public bool DisDBConnect()
        {
            try
            {
                myconn.Close(); //-----Đóng kết nối CSDL
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        //----------5.Viết hàm đưa dữ liệu lên DataTable
        public DataTable getDataTable(DataTable dt, string sql)
        {
            try
            {
                SqlDataAdapter myDA = new SqlDataAdapter(sql, myconn);
                myDA.Fill(dt);
                return dt;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
                return null;
            }
        }
        //----------6.Viết hàm GỌI STORED PROCEDURE không có tham số
        public SqlDataReader getDataStoredProcedure(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, myconn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
                return null;
            }
        }
    }
}
