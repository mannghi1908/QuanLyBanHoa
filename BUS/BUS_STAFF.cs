using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_STAFF
    {
        //-----------Khai báo lớp: DAL_CCustomer
        DAL_STAFF p = new DAL_STAFF();
        public void pr_XoaNV(DTO_STAFF s)
        {
            p.prXoaNV(s);
        }
        //Gọi hàm Sữa KH bên tầng DAL
        public void pr_SuaNV(DTO_STAFF st)
        {
            p.prSuaNV(st);
        }
        //----------Viết hàm gọi hàm thêm khách hàng ở tầng DAL
        public void prThemNV(DTO_STAFF sta)
        {
            p.prThemNV(sta); //-----Gọi hàm thêm KH ở tầng DAL
        }
        //Gọi hàm Xóa KH bên tầng DAL
    }
}
