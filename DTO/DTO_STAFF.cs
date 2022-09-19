using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_STAFF
    {
        //--------Khai báo các biến cho bảng Nhân viên
        //------Mã nhân viên
        public string _MANV;
        public string MANV
        {
            get { return _MANV; }
            set { _MANV = value; }
        }
        //------tên nhân viên
        public string _TENNV;
        public string TENNV
        {
            get { return _TENNV; }
            set { _TENNV = value; }
        }
        //------Tên đăng nhập
        public string _TENDANGNHAP;
        public string TENDANGNHAP
        {
            get { return _TENDANGNHAP; }
            set { _TENDANGNHAP = value; }
        }
        //------Ngày sinh
        public DateTime _NGAYSINH;
        public DateTime NGAYSINH
        {
            get { return _NGAYSINH; }
            set { _NGAYSINH = value; }
        }
        //----Phái
        private string _PHAI;
        public string PHAI
        {
            get { return _PHAI; }
            set { _PHAI = value; }
        }
        //------Địa chỉ
        private string _DIACHI;
        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }
        //-----Điện thoại
        private string _DIENTHOAI;
        public string DIENTHOAI
        {
            get { return _DIENTHOAI; }
            set { _DIENTHOAI = value; }
        }
        //----Số hóa đơn thực hiện
        public string _SO_HD_THUCHIEN;
        public string SO_HD_THUCHIEN
        {
            get { return _SO_HD_THUCHIEN; }
            set { _SO_HD_THUCHIEN = value; }
        }

        //------Ngày đăng nhập
        public DateTime _NGAYDANGNHAP;
        public DateTime NGAYDANGNHAP
        {
            get { return _NGAYDANGNHAP; }
            set { _NGAYDANGNHAP = value; }
        }
        //------Số lần đăng nhập
        public string _SOLANDN;
        public string SOLANDN
        {
            get { return _SOLANDN; }
            set { _SOLANDN = value; }
        }
        //------Quyền đăng nhập
        public string _QUYENHAN;
        public string QUYENHAN
        {
            get { return _QUYENHAN; }
            set { _QUYENHAN = value; }
        }


        //-------Viết hàm khởi tạo
        public DTO_STAFF() { }

        public DTO_STAFF(string MANV, string TENNV, string TENDANGNHAP, DateTime NGAYSINH, string PHAI, string DIACHI, string DIENTHOAI, string SO_HD_THUCHIEN,
                                              DateTime NGAYDANGNHAP, string SOLANDN, string QUYENHAN)
        {
            this.MANV = MANV;
            this.TENNV = TENNV;
            this.TENDANGNHAP = TENDANGNHAP;
            this.NGAYSINH = NGAYSINH;
            this.PHAI = PHAI;
            this.DIACHI = DIACHI;
            this.DIENTHOAI = DIENTHOAI;
            this.SO_HD_THUCHIEN = SO_HD_THUCHIEN;
            this.NGAYDANGNHAP = NGAYDANGNHAP;
            this.SOLANDN = SOLANDN;
            this.QUYENHAN = QUYENHAN;
        }
        public DTO_STAFF(string MANV)
        {
            this.MANV = MANV;
        }
    }
}
