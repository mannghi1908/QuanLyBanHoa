use QL_BanHoa
go
------1.Viết Stored Procedure thêm khách hàng mới
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME ='pr_ThemKH')
	DROP PROC pr_ThemKH
GO
CREATE PROC pr_ThemKH
(
	@MsKH		CHAR(10), 
	@TENKH		NVARCHAR(50), 
	@PHAI		NCHAR(5), 
	@DIACHI		NVARCHAR(150), 
	@DIENTHOAI	VARCHAR(10)
)
AS
BEGIN
	DECLARE @MAKH VARCHAR(10)
	SET @MAKH = RTRIM(@MsKH)
	IF EXISTS(SELECT MSKH FROM KHACHHANG WHERE MSKH = @MsKH)
		RAISERROR(N'Mã số khách hàng: %s này đã có trong bảng khách hàng!', 16, 1, @MAKH)
	ELSE
	BEGIN
		INSERT INTO KHACHHANG(MsKH, TENKH, PHAI, DIACHI, DIENTHOAI)
			VALUES(@MsKH, @TENKH, @PHAI, @DIACHI, @DIENTHOAI)
		RAISERROR(N'Thêm khách hàng: %s - %s mới thành công!', 16, 1, @MAKH, @TENKH)
	END
END
GO
SELECT * FROM KHACHHANG
--------------------------------------------------------------------
----2.Viết Stored Procedure sửa thông tin khách hàng
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME ='pr_SuaKH')
	DROP PROC pr_SuaKH
GO
CREATE PROC pr_SuaKH
(
	@MsKH		CHAR(10),
	@TENKH		NVARCHAR(30),
	@PHAI		NCHAR(10),
	@DIACHI		NVARCHAR(50),
	@DIENTHOAI	VARCHAR(10)
)
AS
BEGIN
	IF EXISTS(SELECT MSKH FROM KHACHHANG WHERE MsKH = @MsKH)
	BEGIN
		UPDATE	KHACHHANG
		SET		TENKH = @TENKH,
				PHAI  = @PHAI,
				DIACHI = @DIACHI,
				DIENTHOAI = @DIENTHOAI
		WHERE	MsKH = @MsKH	
		RAISERROR(N'Sửa thông tin khách hàng thành công!', 16, 1)
	END
	ELSE 
		RAISERROR(N'Khách hàng này không tồn tại!', 16, 1)
END
GO

SELECT * FROM KHACHHANG
---------------------------------------------------------------------
----3.Viết Stored Procedure xóa thông tin khách hàng
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME ='pr_XoaKH')
	DROP PROC pr_XoaKH
GO
CREATE PROC pr_XoaKH
(
	@MSKH			CHAR(10)
)
AS
BEGIN
	------Trường hợp 1: Khách hàng chưa có hóa đơn
	IF EXISTS(SELECT MSKH FROM KHACHHANG WHERE MsKH = @MSKH)
		IF NOT EXISTS(SELECT MSKH FROM HOADON WHERE MSKH = @MSKH)
		BEGIN
			DELETE KHACHHANG WHERE MsKH = @MSKH
			RAISERROR(N'Đã xóa thành công khách hàng chưa có mua hàng!', 16, 1)
		END
	ELSE
		------Trường hợp 2: Khách hàng đã mua hàng
		IF EXISTS(SELECT * FROM HOADON hd, CHITIET_HD ct WHERE hd.MSHD = ct.MSHD and hd.MSKH = @MSKH)
		BEGIN
			declare @hd char(10)
			SELECT @hd = MSHD FROM HOADON WHERE MSKH = @MSKH
			----------------------------------------------
			DELETE CHITIET_HD WHERE MSHD = @hd				--Xóa các mặt hàng theo hóa đơn
			DELETE HOADON WHERE MSKH = @MSKH AND MSHD = @hd	--Xóa các hơn đơn theo khách hàng
			DELETE KHACHHANG WHERE MsKH = @MSKH				--Xóa khách hàng trong bảng khách hàng
		END
END
GO

SELECT * FROM KHACHHANG
---------------------------------------------------------------------------
------4.Viết Stored Procedure báo cáo doanh số cho từng mặt hàng [từ ngày - đến ngày]
IF EXISTS(SELECT name FROM SYSOBJECTS WHERE NAME ='pr_BCDSMH')
	DROP PROC pr_BCDSMH
GO
CREATE PROC pr_BCDSMH
(
	@TUDAY		DATETIME,
	@DENNGAY	DATETIME
)
AS
BEGIN
	SELECT	mh.MSMH, 
			mh.TENMH, 
			mh.DONVITINH, 
			sum(ct.SOLUONG) as [Số lượng], 
			SUM(mh.DONGIA*ct.SOLUONG) as [Thành tiền]
	FROM	MATHANG mh, HOADON hd, CHITIET_HD ct
	WHERE	mh.MSMH = ct.MSMH and
			hd.MSHD = ct.MSHD and
			hd.NGAYHD Between @TUDAY and @DENNGAY
	GROUP BY mh.MSMH, mh.TENMH, mh.DONVITINH
END
GO
------5.Viết Stored Procedure tạo mã số hóa đơn
IF EXISTS(SELECT name FROM SYSOBJECTS WHERE NAME ='prTaomaHD')
	DROP PROC prTaomaHD
GO
CREATE PROC prTaomaHD
AS
BEGIN
	IF NOT EXISTS(SELECT MSHD FROM HOADON)
		SELECT	'HD'+	CAST(YEAR(GETDATE()) AS VARCHAR)+ 
						CAST(MONTH(GETDATE()) AS VARCHAR) + 
						CAST(DAY(GETDATE()) AS VARCHAR) + '001'
	ELSE
	BEGIN
		DECLARE @HD1	VARCHAR(15),
				@HD2	VARCHAR(15)
		SELECT	@HD1 = MAX(MSHD) FROM HOADON
		SET @HD2 = RIGHT(RTRIM(@HD1), 3) + 1
		IF LEN(@HD2)=1
			SELECT	'HD'+	CAST(YEAR(GETDATE()) AS VARCHAR)+ 
							CAST(MONTH(GETDATE()) AS VARCHAR) + 
							CAST(DAY(GETDATE()) AS VARCHAR) + '00' + @HD2
		ELSE
			IF LEN(@HD2)=2
				SELECT	'HD'+	CAST(YEAR(GETDATE()) AS VARCHAR)+ 
								CAST(MONTH(GETDATE()) AS VARCHAR) + 
								CAST(DAY(GETDATE()) AS VARCHAR) + '0' + @HD2
			ELSE
				IF LEN(@HD2)=3
				SELECT	'HD'+	CAST(YEAR(GETDATE()) AS VARCHAR)+ 
								CAST(MONTH(GETDATE()) AS VARCHAR) + 
								CAST(DAY(GETDATE()) AS VARCHAR) + @HD2
	END
END
GO
--EXECUTE prTaomaHD
---------------------------------------------------------------------------
------6.Viết Stored Procedure lập hóa đơn bán hàng
IF EXISTS(SELECT name FROM SYSOBJECTS WHERE NAME ='prLapHD')
	DROP PROC prLapHD
GO
CREATE PROC prLapHD
(
	--------------BẢNG HÓA ĐƠN
	@MSHD		CHAR(15), 
	@MANV		CHAR(10), 
	@MSKH		CHAR(10), 
	@NGAYHD		DATETIME, 
	@TONGTIEN	FLOAT,
	--------------BẢNG CHI TIẾT HD
	@MSMH		CHAR(10), 
	@SOLUONG	INT, 
	@THANHTIEN	FLOAT
)
AS
BEGIN
	DECLARE	@ERR1 INT,
			@ERR2 INT

	SET DATEFORMAT DMY
	BEGIN TRANSACTION BUOI
	IF NOT EXISTS(SELECT MSHD FROM HOADON WHERE MSHD = @MSHD)
	BEGIN
		INSERT INTO HOADON(MSHD, MANV, MSKH, NGAYHD, TONGTIEN)
			VALUES(@MSHD, @MANV, @MSKH, @NGAYHD, @TONGTIEN)
		SET @ERR1 = @@ERROR
	END
	INSERT INTO CHITIET_HD(MSHD, MSMH, SOLUONG, THANHTIEN)
		VALUES(@MSHD, @MSMH, @SOLUONG, @THANHTIEN)
	SET @ERR2 = @@ERROR

	IF @ERR1<>0 OR @ERR2<>0
	BEGIN
		ROLLBACK TRANSACTION BUOI
		RAISERROR(N'Lập hóa đơn không thành công!', 16, 1)
	END
	ELSE
	BEGIN
		COMMIT TRANSACTION BUOI
	END
END
GO
---------------------------------------------------------------------------
------7.Viết Stored Procedure IN hóa đơn bán hàng
IF EXISTS(SELECT name FROM SYSOBJECTS WHERE NAME ='prINHD')
	DROP PROC prINHD
GO
CREATE PROC prINHD
(
	@MSHD	char(15)
)
AS
BEGIN
	SELECT	nv.MANV, nv.TENNV, nv.DIACHI as DIACHInv, nv.DIENTHOAI as DIENTHOAInv,
			kh.MsKH, kh.TENKH, kh.DIENTHOAI as DIENTHOAIkh, kh.DIACHI as DIACHIkh,
			hd.MSHD, hd.NGAYHD, hd.TONGTIEN,
			ct.SOLUONG, ct.THANHTIEN,
			mh.MSMH, mh.TENMH, mh.DONVITINH, mh.DONGIA
	FROM	NHANVIEN nv, HOADON hd, KHACHHANG kh, MATHANG mh, CHITIET_HD ct
	WHERE	hd.MANV = nv.MANV	and
			hd.MSKH = kh.MsKH	and
			hd.MSHD = ct.MSHD	and
			ct.MSMH = mh.MSMH	and
			hd.MSHD = @MSHD
END
GO

---- 8.THÊM NHÂN VIÊN-------------
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME ='pr_ThemNV')
	DROP PROC pr_ThemNV
GO
CREATE PROC pr_ThemNV
(
	@MANV		    CHAR(10), 
	@TENNV  	    NVARCHAR(30),
	@TENDANGNHAP    NVARCHAR(256),
	@NGAYSINH	    DATETIME, 
	@PHAI	        NCHAR(10),
	@DIACHI         NVARCHAR(50),
	@DIENTHOAI      NVARCHAR(10),	
	@SO_HD_THUCHIEN INT,
	@NGAYDANGNHAP   DATETIME,	
	@SOLANDN        INT,
	@QUYENHAN       NVARCHAR(20)
)
AS
BEGIN
	DECLARE @MAMH  VARCHAR(10)
	SET @MAMH = RTRIM(@MANV)
	IF EXISTS(SELECT MANV  FROM NHANVIEN WHERE MANV = @MANV)
		RAISERROR(N'Mã nhân viên: %s này đã có trong bảng nhân viên!', 16, 1, @MAMH)
	ELSE
	BEGIN
		INSERT INTO NHANVIEN(MANV,TENNV,TENDANGNHAP,NGAYSINH,PHAI,DIACHI,DIENTHOAI,SO_HD_THUCHIEN,NGAYDANGNHAP,SOLANDN,QUYENHAN)
			VALUES(@MANV,@TENNV,@TENDANGNHAP,@NGAYSINH,@PHAI,@DIACHI,@DIENTHOAI,@SO_HD_THUCHIEN,@NGAYDANGNHAP,@SOLANDN,@QUYENHAN)
		RAISERROR(N'Thêm nhân viên: %s - %s mới thành công!', 16, 1,@MAMH, @TENNV)
	END
END
GO


SELECT * FROM NHANVIEN

----9.Viết Stored Procedure sửa thông tin nhân viên
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME ='pr_SuaNV')
	DROP PROC pr_SuaNV
GO
CREATE PROC pr_SuaNV
(
	@MANV		    CHAR(10), 
	@TENNV  	    NVARCHAR(30),
	@TENDANGNHAP    NVARCHAR(256),
	@NGAYSINH	    DATETIME, 
	@PHAI	        NCHAR(10),
	@DIACHI         NVARCHAR(50),
	@DIENTHOAI      NVARCHAR(10),	
	@SO_HD_THUCHIEN INT,
	@NGAYDANGNHAP   DATETIME,	
	@SOLANDN        INT,
	@QUYENHAN       NVARCHAR(20)
)
AS
BEGIN
	IF EXISTS(SELECT MANV FROM NHANVIEN WHERE MANV = @MANV)
	BEGIN
		UPDATE	NHANVIEN
		SET		TENNV = @TENNV,
				TENDANGNHAP =@TENDANGNHAP,
				PHAI  = @PHAI,
				DIACHI = @DIACHI,
				DIENTHOAI = @DIENTHOAI,
				SO_HD_THUCHIEN = @SO_HD_THUCHIEN,
				NGAYDANGNHAP = @NGAYDANGNHAP,
				SOLANDN = @SOLANDN,
				QUYENHAN = @QUYENHAN
		WHERE	MANV = @MANV
		RAISERROR(N'Sửa thông tin nhân viên thành công!', 16, 1)
	END
	ELSE
		RAISERROR(N'Nhân viên này không tồn tại!', 16, 1)
END
GO

SELECT * FROM NHANVIEN
---------------------------------------------------------------------

----10.Viết Stored Procedure xóa thông tin khách nhân viên
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME ='pr_XoaNV')
	DROP PROC pr_XoaNV
GO
CREATE PROC pr_XoaNV
(
	@MANV		CHAR(10)
)
AS
BEGIN
	---Trường hợp 1:
	IF NOT EXISTS(SELECT MANV FROM HOADON WHERE MSKH = @MANV)
		IF EXISTS(SELECT MANV FROM NHANVIEN WHERE MANV = @MANV)
		BEGIN
			DELETE NHANVIEN WHERE MANV = @MANV
			RAISERROR(N'Xóa nhân viên trong bảng nhân viên thành công!', 16, 1)
		END
	ELSE ---Trường hợp 2:
		IF EXISTS(SELECT * FROM HOADON hd, CHITIET_HD ct WHERE hd.MSHD = ct.MSHD and hd.MANV = @MANV)
		BEGIN
			DECLARE	@hd CHAR(10)
			SELECT @hd = MSHD FROM HOADON WHERE MANV = @MANV		--Lấy mã số hóa đơn theo mã nhân viên
			----------------------------------------------------
			DELETE CHITIET_HD	WHERE MSHD = @hd					--Xóa hóa đơn ở bảng chi tiết hóa đơn
			DELETE HOADON		WHERE MSHD = @hd AND MANV = @MANV	--Xóa hóa đơn của nhân viên ở bảng hóa đơn
			DELETE NHANVIEN	WHERE MANV = @MANV					    --Xóa khách hàng theo mã nhân viên
			RAISERROR(N'Đã xóa toàn bộ thông tin của Nhân viên này!', 16, 1)
		END
	
END
GO

SELECT * FROM NHANVIEN
---------------------------------------------------------------------------
---- 11.THÊM MẶT HÀNG-------------
------MSMH,TENMH,SL_TON,DONGIA,DONVITINH, HINHANH-------
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME ='pr_ThemMH')
	DROP PROC pr_ThemMH
GO
CREATE PROC pr_ThemMH
(
	@MSMH		    CHAR(10), 
	@TENMH  	    NVARCHAR(50), 
	@SL_TON         INT,
	@DONGIA 	    FLOAT, 
	@DONVITINH	    NCHAR(10),
	@HINHANH		NVARCHAR(30)
)
AS
BEGIN
	DECLARE @MAMH  VARCHAR(10)
	SET @MAMH = RTRIM(@MSMH)
	IF EXISTS(SELECT MSMH  FROM MATHANG WHERE MSMH = @MSMH)
		RAISERROR(N'Mã nhân viên: %s này đã có trong bảng nhân viên!', 16, 1, @MAMH)
	ELSE
	BEGIN
		INSERT INTO MATHANG(MSMH,TENMH,SL_TON,DONGIA,DONVITINH,HINHANH)
			VALUES(@MSMH,@TENMH,@SL_TON,@DONGIA,@DONVITINH,@HINHANH)
		RAISERROR(N'Thêm mặt hàng: %s - %s mới thành công!', 16, 1,@MAMH, @TENMH)
	END
END
GO

----12.Viết Stored Procedure sửa thông tin khách hàng
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME ='pr_SuaMH')
	DROP PROC pr_SuaMH
GO
CREATE PROC pr_SuaMH
(
	@MSMH		    CHAR(10), 
	@TENMH  	    NVARCHAR(50), 
	@SL_TON         INT,
	@DONGIA 	    FLOAT, 
	@DONVITINH	    NCHAR(10),
	@HINHANH		NVARCHAR(30)
)
AS
BEGIN
	IF EXISTS(SELECT MSMH FROM MATHANG WHERE MSMH = @MSMH)
	BEGIN
		UPDATE	MATHANG
		SET		TENMH = @TENMH,
				SL_TON  = @SL_TON,
				DONGIA = @DONGIA,
				DONVITINH = @DONVITINH,
				HINHANH = @HINHANH
		WHERE	MSMH = @MSMH
		RAISERROR(N'Sửa thông tin mặt hàng thành công!', 16, 1)
	END
	ELSE
		RAISERROR(N'Mặt hàng này không tồn tại!', 16, 1)
END
GO
---------------------------------------------------------------------
----13.Viết Stored Procedure xóa thông tin khách hàng
IF EXISTS(SELECT NAME FROM SYSOBJECTS WHERE NAME ='pr_XoaMH')
	DROP PROC pr_XoaMH
GO
CREATE PROC pr_XoaMH
(
	@MSMH		    CHAR(10)	
)
AS
BEGIN
	---Trường hợp 1:
	IF NOT EXISTS(SELECT MSMH FROM CHITIET_HD WHERE MSMH = @MSMH)
		IF EXISTS(SELECT MSMH FROM MATHANG WHERE MSMH = @MSMH)
		BEGIN
			DELETE MATHANG WHERE MSMH = @MSMH
			RAISERROR(N'Xóa mặt hàng trong bảng mặt hàng thành công!', 16, 1)
		END
	ELSE ---Trường hợp 2:
		IF EXISTS(SELECT * FROM HOADON hd, CHITIET_HD ct WHERE hd.MSHD = ct.MSHD and ct.MSMH = @MSMH)
		BEGIN
			DECLARE	@ct CHAR(10)
			SELECT @ct = MSHD FROM CHITIET_HD WHERE MSMH = @MSMH    --Lấy mã số chi tiết hóa đơn theo mã mặt hàng
			----------------------------------------------------
			DELETE CHITIET_HD	WHERE MSHD = @ct					--Xóa hóa đơn ở bảng chi tiết hóa đơn
			DELETE CHITIET_HD   WHERE MSHD = @ct AND MSMH = @MSMH	--Xóa hóa đơn của mặt hàng ở bảng chi tiết hóa đơn
			DELETE MATHANG	    WHERE MSMH = @MSMH					--Xóa khách hàng theo mã mặt hàng
			RAISERROR(N'Đã xóa toàn bộ thông tin của mặt hàng này!', 16, 1)
		END
	
END
GO
---------------------------------------------------------------------------
---14.Viết Stored Procedure báo cáo doanh số cho từng nhân viên [từ ngày - đến ngày]
IF EXISTS(SELECT name FROM SYSOBJECTS WHERE NAME ='pr_BCDSNV')
	DROP PROC pr_BCDSNV
GO
CREATE PROC pr_BCDSNV
(
	@TUDAY		DATETIME,
	@DENNGAY	DATETIME
)
AS
BEGIN
	SELECT	nv.MANV, 
			nv.TENNV, 
			nv.QUYENHAN, 
			count(ct.SOLUONG) as [Số lượng], 
			sum((ct.THANHTIEN)) as [Thành tiền]
	FROM	MATHANG mh, HOADON hd, CHITIET_HD ct, NHANVIEN nv
	WHERE	mh.MSMH = ct.MSMH and
			hd.MSHD = ct.MSHD and
			nv.MANV = hd.MANV and
			hd.NGAYHD Between @TUDAY and @DENNGAY
	GROUP BY nv.MANV, nv.TENNV, nv.QUYENHAN
END
GO

SELECT * FROM KHACHHANG
SELECT * FROM MATHANG
SELECT * FROM HOADON
SELECT * FROM CHITIET_HD


