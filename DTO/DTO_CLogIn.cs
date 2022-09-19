using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CLogIn
    {
        //-----------Khai báo các biến lưu thông tin kết nối CSDL
        private string _ServerName;

        public string ServerName
        {
            get { return _ServerName; }
            set { _ServerName = value; }
        }
        private string _Database;

        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }
        private string _UserID;

        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        //------------Get/Set
        //public string ServerName { get => _ServerName; set => _ServerName = value; }
        //public string Database { get => _Database; set => _Database = value; }
        //public string UserID { get => _UserID; set => _UserID = value; }
        //public string Password { get => _Password; set => _Password = value; }

        //--------Khai báo hàm khởi tạo
        public DTO_CLogIn() { }
        public DTO_CLogIn(string SV, string DB, string US, string PW)
        {
            this.ServerName = SV;
            this.Database = DB;
            this.UserID = US;
            this.Password = PW;
        }
    }
}
