using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class GUI_CEnableMenu
    {
        //-------------Khai báo form hệ thống
        public static frmHethong frmHT = new frmHethong();
        //-------------Viết hàm Ẩn/Hiện menu hệ thống
        public void EnableMenu(bool d1, bool d2)
        {
            frmHT.mnuDN.Enabled = d1;
            frmHT.mnuDM.Enabled = d2;
            frmHT.mnuHD.Enabled = d2;
            frmHT.mnuBC.Enabled = d2;
            frmHT.mnuTC.Enabled = d2;
            frmHT.mnuHKN.Enabled = d2;
            frmHT.mnuBR.Enabled = d2;
        }
        //------------Viết hàm chính để chạy form hệ thống: frmHethong
        static void Main()
        {
            Application.Run(frmHT);
        }
    }
}
