use master
go

set dateformat dmy
go

if exists(select name from master..sysdatabases where name='QL_BanHoa')
	drop database QL_BanHoa
go
go
create database QL_BanHoa
go
use QL_BanHoa
go
create table NHANVIEN
(
	MANV		char(10) 	not null primary key,
	TENNV		nvarchar(30)	not null,
	TENDANGNHAP	nvarchar(256)	not null,
	NGAYSINH	datetime	not null,
	PHAI		nchar(10)	not null,
	DIACHI		nvarchar(50)	not null,
	DIENTHOAI	nvarchar(10)	null,
	SO_HD_THUCHIEN	int		null,
	NGAYDANGNHAP	datetime	null,
	SOLANDN		int		null,
	QUYENHAN	nvarchar(20)	not null
)
go
create table KHACHHANG
(
	MsKH		char(10) primary key 	not null,
	TENKH		nvarchar(30)		not null,
	PHAI		nchar(10)		null,
	DIACHI		nvarchar(50)		not null,
	DIENTHOAI	varchar(10)		null
)
go
create table MATHANG
(
	MSMH		char(10) primary key	not null,
	TENMH		nvarchar(50)		not null,
	SL_TON		int,
	DONGIA		float,
	DONVITINH	nchar(10),
	HINHANH		nvarchar(30)		not null,
)
go
create table HOADON
(
	MSHD		char(15) primary key	not null,
	MANV		char(10)		not null,
	MSKH		char(10)		not null,
	NGAYHD		datetime		not null,
	TONGTIEN	float			null
	constraint	FK_HD_NV foreign key(MANV) references NHANVIEN(MANV),
	constraint	FK_HD_KH foreign key(MSKH) references KHACHHANG(MSKH)
)
go
create table CHITIET_HD
(
	MSHD		char(15)		not null,
	MSMH		char(10)		not null,
	SOLUONG		int			null,
	THANHTIEN	money			null
	constraint PK_CTHD primary key(MSHD,MSMH),
	constraint	FK_CT_MH foreign key(MSMH) references MATHANG(MSMH),
	constraint	FK_CT_HD foreign key(MSHD) references HOADON(MSHD)
)
)
go

---------------------------- DỮ LIỆU BẢNG NHÂN VIÊN ----------------------------------------------

insert into NHANVIEN(MANV,TENNV,TENDANGNHAP,NGAYSINH,PHAI,DIACHI,DIENTHOAI,SO_HD_THUCHIEN,NGAYDANGNHAP,SOLANDN,QUYENHAN)
	values ('NV00100001', N'Nguyễn Thị Mẫn Nghi','MANNGHI','19/08/2000',N'Nữ',N'34 TA 19 - Tân Thới An - Q.12 - HCM','0984543260',4,getdate(),1,'Admin')
insert into NHANVIEN(MANV,TENNV,TENDANGNHAP,NGAYSINH,PHAI,DIACHI,DIENTHOAI,SO_HD_THUCHIEN,NGAYDANGNHAP,SOLANDN,QUYENHAN)
	values ('NV00100002',N'Hoa Thành','HOATHANH','13/12/1993','Nam',N'804 Lê Trọng Tấn - Sơn Kỳ - Tân Phú - HCM','0341256141',4,getdate(),2,'Nhân viên')
insert into NHANVIEN(MANV,TENNV,TENDANGNHAP,NGAYSINH,PHAI,DIACHI,DIENTHOAI,SO_HD_THUCHIEN,NGAYDANGNHAP,SOLANDN,QUYENHAN)
	values ('NV00100003',N'Ngụy Vô Tiện','NGUYVOTIEN','05/02/1998','Nam',N'412 Lê Văn Sỹ - P14 - Q3 - HCM','0938803633',10,getdate(),5,'Nhân viên')

---------------------------- DỮ LIỆU BẢNG KHÁCH HÀNG ----------------------------------------------

insert into KHACHHANG(MsKH,TENKH,PHAI,DIACHI,DIENTHOAI)
	values ('KH001',N'Thẩm Thanh Thu',N'Nam',N'9 Phan Huy Ích','0903698574')
insert into KHACHHANG(MsKH,TENKH,PHAI,DIACHI,DIENTHOAI)
	values ('KH002',N'Trần Trân',N'Nam',N'12 Lạc Long Quân','0903698574')
insert into KHACHHANG(MsKH,TENKH,PHAI,DIACHI,DIENTHOAI)
	values ('KH003',N'Phạm Thị Bình',N'Nữ',N'8/9 Nguyễn Trãi','088965743')
insert into KHACHHANG(MsKH,TENKH,PHAI,DIACHI,DIENTHOAI)
	values ('KH004',N'Trần Ngọc Linh',N'Nam',N'541/8 Lạc Long Quân','088741689')
insert into KHACHHANG(MsKH,TENKH,PHAI,DIACHI,DIENTHOAI)
	values ('KH005',N'Thôi Gia Bảo',N'Nam',N'789 An Dương Vương-F5-Q.5','0908756548')
insert into KHACHHANG(MsKH,TENKH,PHAI,DIACHI,DIENTHOAI)
	values ('KH006',N'Lại Trọng Nghĩa',N'Nam',N'36 Hùng Vương F6 Q.5','0908759842')
insert into KHACHHANG(MsKH,TENKH,PHAI,DIACHI,DIENTHOAI)
	values ('KH007',N'Lại Thị Minh Anh',N'Nữ',N'40 Nguyễn Thị Minh Khai Q.1','0908759789')
insert into KHACHHANG(MsKH,TENKH,PHAI,DIACHI,DIENTHOAI)
	values ('KH008',N'Ngô Bảo Như',N'Nữ',N'140 An Phú Đông Q.12','0901564892')
insert into KHACHHANG(MsKH,TENKH,PHAI,DIACHI,DIENTHOAI)
	values ('KH009',N'Hà Vĩnh An',N'Nam',N'14/3 Lê Trọng Tấn Q.Bình Tân','0347561256')
insert into KHACHHANG(MsKH,TENKH,PHAI,DIACHI,DIENTHOAI)
	values ('KH010',N'Lê Ngọc Phước Bảo',N'Nam',N' 107 Võ Oanh P25 Q.Bình Thạnh','0778942366')

---------------------------- DỮ LIỆU BẢNG MẶT HÀNG ----------------------------------------------

insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HBO04',N'HOA BÓ 04',10,1490000,N'Bó','hbo01.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HB034', N'HOA BÓ 34',10,4500000,N'Bó', 'hbo34.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HBO33',N'HOA BÓ 33',10,12500000,N'Bó', 'hbo33.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HBO40',N'HOA BÓ 40',20,3600000,N'Bó','hbo40.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HBO05',N'HOA BÓ 05',10,670000,N'Bó','hbo05.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HB010',N'HOA BÓ 10',15,1125000,N'Bó','hb010.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HC001',N'HOA CƯỚI 01',25,1190000,N'Bó','hc001.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HC003',N'HOA CƯỚI 03',7,1390000,N'Bó','hc003.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HC004',N'HOA CƯỚI 04',7,1190000,N'Bó','hc004.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HC005',N'HOA CƯỚI 05',7,1250000,N'Bó','hc005.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HC006',N'HOA CƯỚI 06',7,1490000,N'Bó','hc006.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HC007',N'HOA CƯỚI 07',7,1250000,N'Bó','hc007.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HK001',N'HOA KHÔ 01',16,560000,N'Bó','hk001.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HK002',N'HOA KHÔ 02',8,580000,N'Bó','hk002.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HK003',N'HOA KHÔ 03',7,500000,N'Bó','hk003.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HK004',N'HOA KHÔ 04',10,1190000,N'Bó','hk004.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HK005',N'HOA KHÔ 05',12,2290000,N'Bó','hk005.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HK006',N'HOA KHÔ 06',3,1990000,N'Bó','hk006.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HK007',N'HOA KHÔ 07',9,520000,N'Bó','hk007.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HKT01',N'HOA KHÁNH THÀNH 01',15,3290000,N'Lãng', 'hkt001.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HKT02',N'HOA KHÁNH THÀNH 02',4,1490000,N'Lãng', 'hkt002.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('LHĐ05',N'LAN HỒ ĐIỆP 05',10,1190000,N'Giỏ', 'lhd005.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('LHĐ19',N'LAN HỒ ĐIỆP 19',9,2290000,N'Giỏ', 'lhd019.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HM001',N'HOA MỚI 01',7,690000,N'Bó', 'spm1.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HM002',N'HOA MỚI 02',10,1260000,N'Bó', 'spm2.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HM003',N'HOA MỚI 03',5,750000,N'Bó', 'spm3.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HM004',N'HOA MỚI 04',11,2950000,N'Bó', 'spm4.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HM005',N'HOA MỚI 05',12,990000,N'Bó', 'spm5.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HM006',N'HOA MỚI 06',6,950000,N'Bó', 'spm6.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HM007',N'HOA BABY',5,450000,N'Bó', 'hoa4.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HM008',N'HOA CÔNG TY',12,950000,N'Giỏ', 'hoa3.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HSN01',N'HOA SINH NHẬT 01',5,2190000,N'Hộp', 'hh004.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HSN02',N'HOA SINH NHẬT 02',7,3000000,N'Bó', 'spm7.jpg')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HH003',N'HỘP HOA 03',15,3500000,N'Hộp', 'hh003.png')
insert into MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
	values ('HCC01',N'HOA LUXURY',8,3000000,N'Bó', 'hcc001.png')


---------------------------- DỮ LIỆU BẢNG HÓA ĐƠN ----------------------------------------------

insert into HOADON(MSHD,MANV,MSKH,NGAYHD,TONGTIEN)
	values ('HD001','NV00100001','KH010','21/01/2021',8000000)
insert into HOADON(MSHD,MANV,MSKH,NGAYHD,TONGTIEN)
	values ('HD002','NV00100003','KH005','30/04/2021',20500000)
insert into HOADON(MSHD,MANV,MSKH,NGAYHD,TONGTIEN)
	values ('HD003','NV00100003','KH004','08/09/2021',15400000)
insert into HOADON(MSHD,MANV,MSKH,NGAYHD,TONGTIEN)
	values ('HD004','NV00100002','KH008','11/08/2021',10200000)
insert into HOADON(MSHD,MANV,MSKH,NGAYHD,TONGTIEN)
	values ('HD005','NV00100002','KH009','28/05/2021',40000000)
insert into HOADON(MSHD,MANV,MSKH,NGAYHD,TONGTIEN)
	values ('HD006','NV00100001','KH003','30/03/2021',10000000)
insert into HOADON(MSHD,MANV,MSKH,NGAYHD,TONGTIEN)
	values ('HD007','NV00100003','KH007','29/04/2021',17600000)
insert into HOADON(MSHD,MANV,MSKH,NGAYHD,TONGTIEN)
	values ('HD008','NV00100002','KH002','10/05/2021',25800000)
insert into HOADON(MSHD,MANV,MSKH,NGAYHD,TONGTIEN)
	values ('HD009','NV00100001','KH001','03/08/2021',30000000)
insert into HOADON(MSHD,MANV,MSKH,NGAYHD,TONGTIEN)
	values ('HD010','NV00100003','KH006','20/07/2021',32400000)

---------------------------- DỮ LIỆU BẢNG CT HÓA ĐƠN ----------------------------------------------

insert into CHITIET_HD(MSHD,MSMH,SOLUONG,THANHTIEN)
	values ('HD001','HBO05',2,2500000)
insert into CHITIET_HD(MSHD,MSMH,SOLUONG,THANHTIEN)
	values ('HD001','HK002',3,4470000)
insert into CHITIET_HD(MSHD,MSMH,SOLUONG,THANHTIEN)
	values ('HD002','HKT02',3,41960000)
insert into CHITIET_HD(MSHD,MSMH,SOLUONG,THANHTIEN)
	values ('HD002','HC001',2,2380000)
insert into CHITIET_HD(MSHD,MSMH,SOLUONG,THANHTIEN)
	values ('HD003','HSN01',1,2190000)
insert into CHITIET_HD(MSHD,MSMH,SOLUONG,THANHTIEN)
	values ('HD003','HM008',2,1900000)
insert into CHITIET_HD(MSHD,MSMH,SOLUONG,THANHTIEN)
	values ('HD004','LHĐ05',1,1190000)
insert into CHITIET_HD(MSHD,MSMH,SOLUONG,THANHTIEN)
	values ('HD005','HM007',3,1350000)
insert into CHITIET_HD(MSHD,MSMH,SOLUONG,THANHTIEN)
	values ('HD006','HC007',2,27980000.000)
insert into CHITIET_HD(MSHD,MSMH,SOLUONG,THANHTIEN)
	values ('HD007','HCC01',1,3000000)
insert into CHITIET_HD(MSHD,MSMH,SOLUONG,THANHTIEN)
	values ('HD008','HBO33',1,12500000)
insert into CHITIET_HD(MSHD,MSMH,SOLUONG,THANHTIEN)
	values ('HD009','HM005',2,1980000)
insert into CHITIET_HD(MSHD,MSMH,SOLUONG,THANHTIEN)
	values ('HD010','HC006',1,1490000)



select * from NHANVIEN
select * from KHACHHANG
select * from MATHANG
select * from HOADON
select * from CHITIET_HD
