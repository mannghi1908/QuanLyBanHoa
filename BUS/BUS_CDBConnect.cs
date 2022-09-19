using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_CDBConnect
    {
        //-----Khai lớp kết nối CSDL
        DAL_CDBConnect lg = new DAL_CDBConnect();

        //-----Viết hàm gọi hàm kết nối CSDL
        public bool DBConnect(DTO_CLogIn lgin) //A -> B
        {
            bool timhieu = lg.DBConnect(lgin);
            return timhieu;
        }
        //-----Viết hàm gọi hàm hủy kết nối
        public bool DisDBConnect()
        {
            return lg.DisDBConnect();
        }
    }
}
