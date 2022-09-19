using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CCustomer
    {
        //-----------Khai báo lớp: DAL_CCustomer
        DAL_CCustomer c = new DAL_CCustomer();
        public void pr_XoaKH(DTO_CCustomer cus)
        {
            c.prXoaKH(cus);
        }
        //Gọi hàm Sữa KH bên tầng DAL
        public void pr_SuaKH(DTO_CCustomer ct)
        {
            c.prSuaKH(ct);
        }
        //----------Viết hàm gọi hàm thêm khách hàng ở tầng DAL
        public void prThemKH(DTO_CCustomer cc)
        {
            c.prThemKH(cc); //-----Gọi hàm thêm KH ở tầng DAL
        }
        //Gọi hàm Xóa KH bên tầng DAL
        
    }
}
