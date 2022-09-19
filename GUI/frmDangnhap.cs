using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangnhap : Form
    {
        //------------1.Khai báo lớp: DTO_CLogIn
        DTO_CLogIn lgin = new DTO_CLogIn();
        
        //------------2.Khai báo lớp: BUS_CDBConnect
        BUS_CDBConnect cn = new BUS_CDBConnect();

        //------------3.Khai báo lớp: GUI_CEnableMenu
        GUI_CEnableMenu mnu = new GUI_CEnableMenu();

        public frmDangnhap()
        {
            InitializeComponent();
        }

        public static string SV;
        public static string DB;
        public static string UI;
        public static string Pass;

        //-------- A(btDangnhap_Click) -> B (EnableMenu)
        private void btDangnhap_Click(object sender, EventArgs e) //A
        {
            SV = txtServername.Text.Trim();
            DB = txtDatabase.Text.Trim();
            UI = txtUserID.Text.Trim();
            Pass = txtPassword.Text.Trim();
            //----------Gọi hàm khởi tạo
            lgin = new DTO_CLogIn(txtServername.Text.Trim(),
                                  txtDatabase.Text.Trim(),
                                  txtUserID.Text.Trim(),
                                  txtPassword.Text.Trim()); //C
            if (cn.DBConnect(lgin) == true) //F
            {
                mnu.EnableMenu(false, true); //B
                this.Close();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
                Application.Exit();
        }
    }
}
