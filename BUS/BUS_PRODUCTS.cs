using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PRODUCTS
    {
        //-----------Khai báo lớp: DAL_CCustomer
        DAL_PRODUCTS p = new DAL_PRODUCTS();
        public void pr_XoaMH(DTO_PRODUCTS cus)
        {
            p.prXoaMH(cus);
        }
        //Gọi hàm Sữa KH bên tầng DAL
        public void pr_SuaMH(DTO_PRODUCTS ct)
        {
            p.prSuaMH(ct);
        }
        //----------Viết hàm gọi hàm thêm khách hàng ở tầng DAL
        public void prThemMH(DTO_PRODUCTS cc)
        {
            p.prThemMH(cc); //-----Gọi hàm thêm KH ở tầng DAL
        }
        //Gọi hàm Xóa KH bên tầng DAL
    }
}
