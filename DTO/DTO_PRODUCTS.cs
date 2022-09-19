using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PRODUCTS
    {
        //--------Khai báo các biến cho bảng mặt hàng
        //------Mã mặt hàng
        private string _MSMH;
        public string MSMH
        {
            get { return _MSMH; }
            set { _MSMH = value; }
        }
        //------Tên mặt hàng
        public string _TENMH;
        public string TENMH
        {
            get { return _TENMH; }
            set { _TENMH = value; }
        }
        //-------Số lượng tồn
        public string _SL_TON;
        public string SL_TON
        {
            get { return _SL_TON; }
            set { _SL_TON = value; }
        }
        //-------Đơn giá
        public string _DONGIA;
        public string DONGIA
        {
            get { return _DONGIA; }
            set { _DONGIA = value; }
        }
        //-------Đơn vị tính
        public string _DONVITINH;
        public string DONVITINH
        {
            get { return _DONVITINH; }
            set { _DONVITINH = value; }
        }
        public string _HINHANH;
        public string HINHANH { get => _HINHANH; set => _HINHANH = value; }
        //-------Viết hàm khởi tạo
        public DTO_PRODUCTS() { }

        public DTO_PRODUCTS(string MSMH, string TENMH, string SL_TON, string DONGIA, string DONVITINH, string HINHANH)
        {
            this.MSMH = MSMH;
            this.TENMH = TENMH;
            this.SL_TON = SL_TON;
            this.DONGIA = DONGIA;
            this.DONVITINH = DONVITINH;
            this.HINHANH = HINHANH;
        }
        public DTO_PRODUCTS(string MSMH)
        {
            this.MSMH = MSMH;
        }
    }
}

