using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CgetData
    {
        //-----Khai báo tầng DAL
        DAL_CDBConnect cn = new DAL_CDBConnect();

        //----------5.Viết hàm đưa dữ liệu lên DataTable
        public DataTable getDataTable(DataTable dt, string sql)
        {
            return cn.getDataTable(dt, sql);
        }

         //----------6.Viết hàm GỌI STORED PROCEDURE không có tham số
        public SqlDataReader getDataStoredProcedure(string sql)
        {
            return cn.getDataStoredProcedure(sql);
        }

    }
}
