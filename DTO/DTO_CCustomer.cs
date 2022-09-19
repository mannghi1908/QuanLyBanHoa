using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{ 
    public class DTO_CCustomer
    {
        //--------Khai báo các biến cho bảng khách hàng
        private string _MsKH;
        public string MsKH
        {
            get { return _MsKH; }
            set { _MsKH = value; }
        }

        private string _TENKH;
        public string TENKH
        {
            get { return _TENKH; }
            set { _TENKH = value; }
        }

        private string _PHAI;
        public string PHAI
        {
            get { return _PHAI; }
            set { _PHAI = value; }
        }

        private string _DIACHI;
        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }

        private string _DIENTHOAI;
        public string DIENTHOAI
        {
            get { return _DIENTHOAI; }
            set { _DIENTHOAI = value; }
        }

        //-------Viết hàm khởi tạo
        public DTO_CCustomer() { }

        public DTO_CCustomer(string MsKH, string TENKH, string PHAI, string DIACHI, string DIENTHOAI)
        {
            this.MsKH = MsKH;
            this.TENKH = TENKH;
            this.PHAI = PHAI;
            this.DIACHI = DIACHI;
            this.DIENTHOAI = DIENTHOAI;
        }
        public DTO_CCustomer(string MsKH)
        {
            this.MsKH = MsKH;
        }
    }
}
