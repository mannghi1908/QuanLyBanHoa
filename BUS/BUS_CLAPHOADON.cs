using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CLAPHOADON
    {
        //---------Khai báo tầng DAL
        DAL_CLAPHOADON hd = new DAL_CLAPHOADON();

        //---------1.Viết hàm gọi Stoted Procedure lập hóa đơn bán hàng
        public void prThemHD(DTO_CLAPHOADON c)
        {
            hd.prThemHD(c);
        }
    }
}
