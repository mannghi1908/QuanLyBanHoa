using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CLAPHOADON
    {
        private string _MSHD;

        public string MSHD
        {
            get { return _MSHD; }
            set { _MSHD = value; }
        }
        private string _MANV;

        public string MANV
        {
            get { return _MANV; }
            set { _MANV = value; }
        }
        private string _MSKH;

        public string MSKH
        {
            get { return _MSKH; }
            set { _MSKH = value; }
        }
        private string _NGAYHD;

        public string NGAYHD
        {
            get { return _NGAYHD; }
            set { _NGAYHD = value; }
        }
        private float _TONGTIEN;

        public float TONGTIEN
        {
            get { return _TONGTIEN; }
            set { _TONGTIEN = value; }
        }
        private string _MSMH;

        public string MSMH
        {
            get { return _MSMH; }
            set { _MSMH = value; }
        }
        private int _SOLUONG;

        public int SOLUONG
        {
            get { return _SOLUONG; }
            set { _SOLUONG = value; }
        }
        private float _THANHTIEN;

        public float THANHTIEN
        {
            get { return _THANHTIEN; }
            set { _THANHTIEN = value; }
        }
        public DTO_CLAPHOADON() { }
        public DTO_CLAPHOADON(  string MSHD, string MANV, string MSKH, 
                                string NGAYHD, float TONGTIEN,
                                string MSMH, int SOLUONG, float THANHTIEN)
        {
            this.MSHD = MSHD;
            this.MANV = MANV;
            this.MSKH = MSKH;
            this.NGAYHD = NGAYHD;
            this.TONGTIEN = TONGTIEN;
            this.MSMH = MSMH;
            this.SOLUONG = SOLUONG;
            this.THANHTIEN = THANHTIEN;
        }
    }
}
