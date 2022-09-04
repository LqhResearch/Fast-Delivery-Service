CREATE DATABASE HeThong_QLDV_GiaoHangNhanh
GO

USE HeThong_QLDV_GiaoHangNhanh
GO

CREATE TABLE TAIKHOAN
(
	TenDangNhap NVARCHAR(30) PRIMARY KEY NOT NULL, --Mã hoặc tên nhân viên
	TenHienThi NVARCHAR(30),
	MatKhau VARCHAR(40) NOT NULL, -- Mã hoá MD5
	QuyenTruyCap NVARCHAR(25) NOT NULL -- Quản trị viên, nhân viên
)
GO

CREATE TABLE NV_GIAOHANG
(
	CCCD_NV VARCHAR(12) PRIMARY KEY NOT NULL,
	HoTenNV NVARCHAR(30) NOT NULL,
	GioiTinhNV NVARCHAR(4) NOT NULL, -- Nam, nữ hoặc khác
	SdtNV VARCHAR(10) NOT NULL, -- 10 số
	DiaChiNV NVARCHAR(70) NOT NULL,
	NgaySinhNV DATE NOT NULL, -- >= 18 tuổi
	LuongNV FLOAT NOT NULL DEFAULT 0, -- Số đơn hàng giao thành công * 5000đ
	GhiChuNV NVARCHAR(100)
)
GO

CREATE TABLE KHACHHANGGUI
(
	SdtKHG VARCHAR(10) PRIMARY KEY NOT NULL, -- 10 số
	HoTenKHG NVARCHAR(30) NOT NULL,
	DiaChiKHG NVARCHAR(70) NOT NULL,
)
GO

CREATE TABLE KHACHHANGNHAN
(
	SdtKHN VARCHAR(10) PRIMARY KEY NOT NULL, -- 10 số
	HoTenKHN NVARCHAR(30) NOT NULL,
	DiaChiKHN NVARCHAR(70) NOT NULL,
)
GO

CREATE TABLE DONHANG
(
	MaVanDon VARCHAR(12) PRIMARY KEY NOT NULL, -- Random: 2 chữ cái ở đầu, 10 số ở cuối
	TongDonHang FLOAT NOT NULL DEFAULT 0, -- Đơn vị tính VND
	PhiVanChuyen FLOAT NOT NULL DEFAULT 30000, -- Đơn vị tính VND
	NgayNhapKho DATE NOT NULL, -- Ngày khách hàng đến gửi chi nhánh
	NgayGui DATE, -- Ngày nhân viên giao hàng gửi cho khách hàng nhận
	GiaoThanhCong BIT, -- 1. Thành công, 0. Chưa giao
	HoanTra BIT, -- 1. Hoàn trả, 0. Chưa giao
	NguyenNhanHoanTra NVARCHAR(100), --Chỉ khác null khi bị hoàn trả
	CCCD_NV VARCHAR(12) NOT NULL,
	SdtKHG VARCHAR(10) NOT NULL,
	SdtKHN VARCHAR(10) NOT NULL,
	CreatedAt DATETIME DEFAULT GETDATE()

	FOREIGN KEY (CCCD_NV) REFERENCES NV_GIAOHANG(CCCD_NV),
	FOREIGN KEY (SdtKHG) REFERENCES KHACHHANGGUI(SdtKHG),
	FOREIGN KEY (SdtKHN) REFERENCES KHACHHANGNHAN(SdtKHN)
)
GO

CREATE TABLE THONGTINSANPHAMDH
(
	MaSP NVARCHAR(8) PRIMARY KEY NOT NULL, -- SP + Random 6 số		VD: SP078946
	TenSP NVARCHAR(40) NOT NULL, 
	GiaSP FLOAT DEFAULT 0 NOT NULL, -- Đơn vị tính VND
	SoLuongSP INT DEFAULT 0 NOT NULL,
	ThanhTienSP FLOAT DEFAULT 0 NOT NULL, -- Thành tiền = Giá sản phẩm * Số lượng
	MaVanDon VARCHAR(12) NOT NULL

	FOREIGN KEY (MaVanDon) REFERENCES DONHANG(MaVanDon)
)
GO

INSERT INTO TAIKHOAN VALUES (N'Admin', N'Lý Quốc Hưng', '202cb962ac59075b964b07152d234b70', N'Quản trị viên')
INSERT INTO TAIKHOAN VALUES (N'079097165226', N'Nguyễn Thanh Sơn', '202cb962ac59075b964b07152d234b70', N'Nhân viên')
INSERT INTO TAIKHOAN VALUES (N'074099247261', N'Nguyễn Tấn Tài', '202cb962ac59075b964b07152d234b70', N'Nhân viên')
INSERT INTO TAIKHOAN VALUES (N'092098907783', N'Tạ Thành Giác', '202cb962ac59075b964b07152d234b70', N'Nhân viên')
INSERT INTO TAIKHOAN VALUES (N'075195016660', N'Trần Hoàng Anh', '202cb962ac59075b964b07152d234b70', N'Nhân viên')
INSERT INTO TAIKHOAN VALUES (N'079300903397', N'Nguyễn Vân Anh', '202cb962ac59075b964b07152d234b70', N'Nhân viên')
GO

INSERT INTO NV_GIAOHANG VALUES ('079097165226', N'Nguyễn Thanh Sơn', N'Nam', '0329138141', N'Hòa Hảo, Phường 5, Quận 10, TP.Hồ Chí Minh', '1997/12/06', 0, null)
INSERT INTO NV_GIAOHANG VALUES ('074099247261', N'Nguyễn Tấn Tài', N'Nam', '0335422423', N'Trần Văn Ơn,Phường Phú Hòa,TP.Thủ Dầu Một, Bình Dương', '1999-12-01', 0, null)
INSERT INTO NV_GIAOHANG VALUES ('092098907783', N'Tạ Thành Giác', N'Nam', '0938505623', N'Trần Hưng Đạo, Phường Lê Bình, Quận Cái Răng, TP.Cần Thơ', '1998-01-17', 0, null)
INSERT INTO NV_GIAOHANG VALUES ('075195016660', N'Trần Hoàng Anh', N'Nữ', '0986954591', N'Xã Tây Hòa, Huyện Trảng Bom, Đồng Nai', '1995-11-05', 0, N'Nghỉ việc')
INSERT INTO NV_GIAOHANG VALUES ('079300903397', N'Nguyễn Vân Anh', N'Nữ', '0918226870', N'Bửu Đình, Phường 5,Quận 6, TP.Hồ Chí Minh', '2000-12-07', 0, null)
GO

INSERT INTO KHACHHANGGUI VALUES ('0983552627', N'Trần Thị Thanh Huyền', N'31 Trần Phú, Phường 4, Quận 5, TP. Hồ Chí Minh')
INSERT INTO KHACHHANGGUI VALUES ('0386211769', N'Lâm Văn Khang', N'số 7, Phường Tân Thuận Đông, Quận 7, TP.Hồ Chí Minh')
INSERT INTO KHACHHANGGUI VALUES ('0399666855', N'Nguyễn Phúc Tuấn', N'Phường Quyết Thắng, Thành phố Biên Hòa, Đồng Nai')
INSERT INTO KHACHHANGGUI VALUES ('0322245083', N'Trần Trí Thương', N'105, Phường 7, Quận 3, TP.Hồ Chí Minh')
INSERT INTO KHACHHANGGUI VALUES ('0323246034', N'Trần Văn Nam', N'Phường Yên Hòa, Quận Cầu Giấy, Hà Nội')
GO

INSERT INTO KHACHHANGNHAN VALUES ('0860740042', N'Nguyễn Phùng Minh', N'2/55 Đường Ngô Quyền, Quận Ngô Quyền, TP. Hải Phòng')
INSERT INTO KHACHHANGNHAN VALUES ('0374177579', N'Đỗ Tiến Khoa', N'26 Quang Trung, Quận Hà Đông, Hà Nội')
INSERT INTO KHACHHANGNHAN VALUES ('0936019846', N'Bùi Đức Anh', N'42, Hàng Than, Phường Nguyễn Trung Trực, Quận Ba Đình, Hà Nội')
INSERT INTO KHACHHANGNHAN VALUES ('0978831357', N'Nguyễn Huỳnh Anh Thư', N'27, Nguyễn Bỉnh Khiêm, Phường Đa Kao, Quận 1, Hồ Chí Minh')
INSERT INTO KHACHHANGNHAN VALUES ('0335480188', N'Lê Thị Phương Anh', N'Phường 9, Quận Gò Vấp, TP.Hồ Chí Minh')
GO

INSERT INTO DONHANG VALUES ('Ag5539210714', 559000, 25000, '2021-05-20', '2021-05-21', 1, 0, N'', '079097165226', '0983552627', '0374177579', GETDATE())
INSERT INTO DONHANG VALUES ('BL9787366421', 350000, 30000, '2020-12-07', '2020-12-08', 0, 1, N'Sản phẩm bị lỗi', '074099247261', '0323246034', '0374177579', GETDATE())
INSERT INTO DONHANG VALUES ('Hb3199462633', 3789500, 34500, '2021-07-02', '2021-07-07', 1, 0, N'', '079097165226', '0983552627', '0335480188', GETDATE())
INSERT INTO DONHANG VALUES ('KG9907469541', 329000, 29000, '2021-01-18', '2021-01-20', 0, 1, N'Không đúng sản phẩm', '092098907783', '0323246034', '0335480188', GETDATE())
INSERT INTO DONHANG VALUES ('Rk3993948652', 95000, 15000, '2020-06-14', '2020-06-19', 1, 0, N'', '074099247261', '0399666855', '0860740042', GETDATE())
INSERT INTO DONHANG VALUES ('Qw3754072406', 128000, 29000, '2020-02-02', '2020-02-06', 1, 0, N'', '092098907783', '0399666855', '0860740042', GETDATE())
INSERT INTO DONHANG VALUES ('We2167974108', 156000, 33000, '2020-03-22', '2020-03-26', 1, 0, N'', '079097165226', '0323246034', '0936019846', GETDATE())
INSERT INTO DONHANG VALUES ('Ef5907030797', 57000, 31000, '2020-04-12', '2020-04-16', 1, 0, N'', '092098907783', '0399666855', '0335480188', GETDATE())
INSERT INTO DONHANG VALUES ('Ft2434023888', 183000, 21000, '2020-05-09', '2020-05-13', 1, 0, N'', '079097165226', '0983552627', '0860740042', GETDATE())
INSERT INTO DONHANG VALUES ('Tk1539289829', 980000, 30000, '2020-06-07', '2020-06-08', 0, 1, N'Sản phẩm bị lỗi', '092098907783', '0323246034', '0335480188', GETDATE())
INSERT INTO DONHANG VALUES ('Ky4460019464', 325000, 25000, '2020-07-14', '2020-07-20', 1, 0, N'', '075195016660', '0323246034', '0936019846', GETDATE())
INSERT INTO DONHANG VALUES ('Ac3450793233', 777000, 27000, '2020-09-09', '2020-09-15', 1, 0, N'', '075195016660', '0386211769', '0374177579', GETDATE())
INSERT INTO DONHANG VALUES ('Cq7596592556', 185000, 35000, '2020-10-11', '2020-10-15', 1, 0, N'', '079300903397', '0386211769', '0978831357', GETDATE())
INSERT INTO DONHANG VALUES ('Qx2695472829', 171000, 26000, '2020-11-20', '2020-11-23', 1, 0, N'', '079097165226', '0323246034', '0374177579', GETDATE())
INSERT INTO DONHANG VALUES ('Xd7144143845', 269000, 25000, '2020-12-10', '2020-12-14', 1, 0, N'', '079300903397', '0323246034', '0335480188', GETDATE())
INSERT INTO DONHANG VALUES ('Ds1787388888', 161000, 29000, '2021-01-14', '2021-01-17', 1, 0, N'', '079300903397', '0386211769', '0978831357', GETDATE())
GO

INSERT INTO THONGTINSANPHAMDH VALUES ('SP413712', N'Áo khoác len mỏng', 160000, 2, 320000, 'BL9787366421')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP310595', N'Đồng hồ thông minh Vikopa A1', 534000, 1, 534000, 'Ag5539210714')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP443710', N'Pin sạc dự phòng Hoco', 325000, 1, 325000, 'Hb3199462633')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP078932', N'Iphone 7 plus', 3430000, 1, 3430000, 'Hb3199462633')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP841318', N'Tai nghe thể thao không dây Bluetooth', 40000, 2, 80000, 'Rk3993948652')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP528423', N'Giày Thể Thao Nam', 300000, 1, 300000, 'KG9907469541')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP352501', N'Tai nghe bluetooth không dây', 99000, 1, 99000, 'Qw3754072406')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP855947', N'Bộ dụng cụ cắt kính Tuosen', 123000, 1, 123000, 'We2167974108')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP425219', N'Kìm đa năng', 13000, 2, 26000, 'Ef5907030797')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP425220', N'Ổ khóa chống cắt ', 54000, 3, 162000, 'Ft2434023888')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP308209', N' Máy phun sương', 950000, 1, 950000, 'Tk1539289829')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP974025', N'Khẩu trang y tế 4 lớp', 150000, 2, 300000, 'Ky4460019464')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP550226', N'Đồng hồ Thông minh Xiaomi Mi', 750000, 1, 750000, 'Ac3450793233')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP280900', N'Ổ Cắm Điện Remax', 37500, 4, 150000, 'Cq7596592556')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP481120', N'Thảm Lông Loang Trải Sàn', 72500, 2, 145000, 'Qx2695472829')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP392265', N'Kệ trang điểm mini', 244000, 1, 244000, 'Xd7144143845')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP356714', N'Cáp sạc siêu nhanh OWIRE 5A USB', 44000, 3, 132000, 'Ds1787388888')
GO

CREATE VIEW View_DONHANG
AS
	SELECT MaVanDon AS [Mã vận đơn], TongDonHang AS [Tổng đơn hàng], PhiVanChuyen AS [Phí vận chuyển], NgayNhapKho AS [Ngày nhập kho],
			NgayGui AS [Ngày giao hàng], GiaoThanhCong AS [Giao thành công], HoanTra AS [Bị hoàn trả], NguyenNhanHoanTra AS [Nguyên nhân bị hoàn trả],
			CCCD_NV AS [CCCD nhân viên giao hàng], SdtKHG AS [Số điện thoại KH gửi], SdtKHN AS [Số điện thoại KH nhận], CreatedAt
	FROM DONHANG
GO

CREATE VIEW View_KHACHHANGGUI
AS
	SELECT SdtKHG AS [Số điện thoại], HoTenKHG AS [Họ tên], DiaChiKHG AS [Địa chỉ]
	FROM KHACHHANGGUI
GO

CREATE VIEW View_KHACHHANGNHAN
AS
	SELECT SdtKHN AS [Số điện thoại], HoTenKHN AS [Họ tên], DiaChiKHN AS [Địa chỉ]
	FROM KHACHHANGNHAN
GO

CREATE VIEW View_NV_GIAOHANG
AS
	SELECT CCCD_NV AS [Căn cước công dân], HoTenNV AS [Họ tên], GioiTinhNV AS [Giới tính], SdtNV AS [Số điện thoại], 
			DiaChiNV AS [Địa chỉ], NgaySinhNV AS [Ngày sinh], GhiChuNV AS [Ghi chú]
	FROM NV_GIAOHANG
GO

CREATE VIEW View_TAIKHOAN
AS
	SELECT TenDangNhap AS [Tên đăng nhập], TenHienThi AS [Tên hiển thị], QuyenTruyCap AS [Quyền truy cập]
	FROM TAIKHOAN
GO

-- Lấy khách hàng gửi theo số điện thoại của khách hàng gửi
CREATE PROC SP_GetKhachHangGuiBySdtKHG
@sdtKHG VARCHAR(10)
AS
	SELECT * 
	FROM KHACHHANGGUI 
	WHERE SdtKHG = @sdtKHG
GO

-- Lấy khách hàng nhận theo số điện thoại của khách hàng nhận
CREATE PROC SP_GetKhachHangNhanBySdtKHN
@sdtKHN VARCHAR(10)
AS
	SELECT * 
	FROM KHACHHANGNHAN 
	WHERE SdtKHN = @sdtKHN
GO

-- Lấy nhân viên giao hàng theo căn cước công dân của nhân viên giao hàng
CREATE PROC SP_GetNVGiaoHangByCCCD_NV
@cccd_NV VARCHAR(12)
AS
	SELECT * 
	FROM NV_GIAOHANG 
	WHERE CCCD_NV = @cccd_NV
GO

CREATE PROC SP_GetDonHangByMaVanDon
@maVanDon VARCHAR(12)
AS
BEGIN
	SELECT MaVanDon AS [Mã vận đơn], TongDonHang AS [Tổng đơn hàng], PhiVanChuyen AS [Phí vận chuyển], NgayNhapKho AS [Ngày nhập kho],
			NgayGui AS [Ngày giao hàng], GiaoThanhCong AS [Giao thành công], HoanTra AS [Bị hoàn trả], NguyenNhanHoanTra AS [Nguyên nhân bị hoàn trả],
			CCCD_NV AS [CCCD nhân viên giao hàng], SdtKHG AS [Số điện thoại KH gửi], SdtKHN AS [Số điện thoại KH nhận]
	FROM DONHANG
	WHERE MaVanDon = @maVanDon
END
GO

CREATE PROC SP_GetListThongTinSanPhamByMaVanDon
@maVanDon VARCHAR(12)
AS
BEGIN
	SELECT MaSP AS [Mã sản phẩm], TenSP AS [Tên sản phẩm], GiaSP AS [Giá], SoLuongSP AS [Số lượng], ThanhTienSP AS [Thành tiền]
	FROM THONGTINSANPHAMDH
	WHERE MaVanDon = @maVanDon
END
GO

-- Tạo mã random
CREATE VIEW View_GetRandValue
AS
	SELECT RAND() AS Value
GO

CREATE FUNCTION Fn_RandomCodeWithAlphanumeric (@type VARCHAR(22))
RETURNS VARCHAR(100)
AS
BEGIN
	DECLARE @characters VARCHAR(52) = 'ABCDEFGHIJKLMNOPQRSTVUWXYZabcdefghijklmnopqrstvuwxyz'
	DECLARE @numbers VARCHAR(10) = '0123456789'
	DECLARE @len INT = LEN(@type)
	
	DECLARE @randomCode VARCHAR(100) = ''
	DECLARE @i INT = 0
	DECLARE @random INT

	WHILE (@i <= @len/2)
	BEGIN
		DECLARE @randType VARCHAR(1) = SUBSTRING(@type, @i*2-1, 1)
		DECLARE @times INT = SUBSTRING(@type, @i*2, 1)
		DECLARE @j INT = 0

		IF(@randType = 'C' OR @randType = 'c')
		BEGIN
			WHILE (@j < @times)
			BEGIN
				SET @random = CEILING((SELECT Value FROM View_GetRandValue)*52)
				SET @randomCode = CONCAT(@randomCode, SUBSTRING(@characters, @random, 1))
				SET @j = @j + 1
			END
		END

		IF(@randType = 'N' OR @randType = 'n')
		BEGIN
			WHILE (@j < @times)
			BEGIN
				SET @random = CEILING((SELECT Value FROM View_GetRandValue)*10)
				SET @randomCode = CONCAT(@randomCode, SUBSTRING(@numbers, @random, 1))
				SET @j = @j + 1
			END
		END
		SET @i = @i + 1
	END
	RETURN @randomCode
END
GO

-- Cập nhật tổng giá trị đơn hàng theo mã vận đơn
CREATE PROC SP_UpdateTongGiaTriDonHang
@maVanDon VARCHAR(12)
AS
BEGIN
	DECLARE @count INT = 0
	SELECT @count = COUNT(MaSP) 
	FROM THONGTINSANPHAMDH 
	WHERE MaVanDon = @maVanDon
	IF(@count <> 0)
	BEGIN
		DECLARE @tongThanhTienSP FLOAT
		SELECT @tongThanhTienSP = SUM(ThanhTienSP) 
		FROM THONGTINSANPHAMDH 
		WHERE MaVanDon = @maVanDon
		DECLARE @tongPhiVanChuyen FLOAT
		SELECT @tongPhiVanChuyen = PhiVanChuyen 
		FROM DONHANG 
		WHERE MaVanDon = @maVanDon
		UPDATE DONHANG 
		SET TongDonHang = @tongThanhTienSP + @tongPhiVanChuyen 
		WHERE MaVanDon = @maVanDon
	END
	ELSE
		UPDATE DONHANG 
		SET TongDonHang = 0, PhiVanChuyen = 0 
		WHERE MaVanDon = @maVanDon
END
GO

CREATE PROC SP_AddThongTinSanPhamDH
@tenSP NVARCHAR(40),
@giaSP FLOAT,
@soLuongSP INT,
@maVanDon VARCHAR(12)
AS
BEGIN
	-- Tạo mã sản phẩm mới
	DECLARE @maSP VARCHAR(8) = ''
	DECLARE @maTonTai BIT = 1
	WHILE (@maTonTai = 1)
	BEGIN
		SET @maSP = CONCAT('SP', dbo.Fn_RandomCodeWithAlphanumeric('N8'))
		DECLARE @tmp VARCHAR(8) = ''
		SELECT @tmp = MaSP 
		FROM THONGTINSANPHAMDH 
		WHERE MaSP = @maSP
		IF (@tmp = '')
			SET @maTonTai = 0
	END
	
	-- Thêm sản phẩm của đơn hàng mới
	INSERT INTO THONGTINSANPHAMDH 
	VALUES (@maSP, @tenSP, @giaSP, @soLuongSP, @giaSP * @soLuongSP, @maVanDon)

	EXEC SP_UpdateTongGiaTriDonHang @maVanDon
END
GO

CREATE PROC SP_UpdateThongTinSanPhamDH
@maSP VARCHAR(8),
@tenSP NVARCHAR(40),
@giaSP FLOAT,
@soLuongSP INT,
@maVanDon VARCHAR(12)
AS
BEGIN
	UPDATE THONGTINSANPHAMDH
	SET TenSP = @tenSP, GiaSP = @giaSP, SoLuongSP = @soLuongSP, ThanhTienSP = @giaSP * @soLuongSP
	WHERE MaSP = @maSP

	EXEC SP_UpdateTongGiaTriDonHang @maVanDon
END
GO

CREATE PROC SP_DeleteThongTinSanPhamDH
@maSP VARCHAR(8),
@maVanDon VARCHAR(12)
AS
BEGIN
	DELETE THONGTINSANPHAMDH
	WHERE MaSP = @maSP

	EXEC SP_UpdateTongGiaTriDonHang @maVanDon
END
GO

CREATE PROC SP_AddDonHang
@tongDonHang FLOAT,
@phiVanChuyen FLOAT,
@ngayNhapKho DATE,
@ngayGui DATE,
@giaoThanhCong BIT,
@hoanTra BIT,
@nguyenNhanHoanTra NVARCHAR(100),
@cccd_NV VARCHAR(12),
@cccd_KHG VARCHAR(12),
@cccd_KHN VARCHAR(12)
AS
BEGIN
	-- Tạo mã vận đơn mới
	DECLARE @maVanDon VARCHAR(12) = ''
	DECLARE @maTonTai BIT = 1
	WHILE (@maTonTai = 1)
	BEGIN
		SET @maVanDon = dbo.Fn_RandomCodeWithAlphanumeric('C2N9N1')
		DECLARE @tmp VARCHAR(12) = ''
		SELECT @tmp = MaVanDon 
		FROM DONHANG 
		WHERE MaVanDon = @maVanDon
		IF (@tmp = '')
			SET @maTonTai = 0
	END

	-- Kiểm tra hàng đã gửi đi chưa
	IF (@giaoThanhCong = 0 AND @hoanTra = 0)
		SET @ngayGui = null;

	IF (@ngayNhapKho <= @ngayGui OR (@giaoThanhCong = 0 AND @hoanTra = 0)) -- Kiểm tra ngày giao và nhận hàng
	BEGIN
		-- Thêm đơn hàng mới
		INSERT INTO DONHANG 
		VALUES (@maVanDon, @tongDonHang, @phiVanChuyen, @ngayNhapKho, @ngayGui, @giaoThanhCong, @hoanTra, @nguyenNhanHoanTra, @cccd_NV, @cccd_KHG, @cccd_KHN, GETDATE())
	END
END
GO

CREATE PROC SP_UpdateDonHang
@maVanDon VARCHAR(12),
@tongDonHang FLOAT,
@phiVanChuyen FLOAT,
@ngayNhapKho DATE,
@ngayGui DATE,
@giaoThanhCong BIT,
@hoanTra BIT,
@nguyenNhanHoanTra NVARCHAR(100),
@cccd_NV VARCHAR(12),
@sdt_KHG VARCHAR(10),
@sdt_KHN VARCHAR(10)
AS
BEGIN
	-- Kiểm tra hàng đã gửi đi chưa
	IF (@giaoThanhCong = 0 AND @hoanTra = 0)
		SET @ngayGui = null;
	
	-- Kiểm tra ngày giao và nhận hàng
	IF (@ngayNhapKho <= @ngayGui OR (@giaoThanhCong = 0 AND @hoanTra = 0))
	BEGIN
		UPDATE DONHANG
		SET TongDonHang = @tongDonHang, PhiVanChuyen = @phiVanChuyen, NgayNhapKho = @ngayNhapKho, NgayGui = @ngayGui,
			GiaoThanhCong = @giaoThanhCong, HoanTra = @hoanTra, NguyenNhanHoanTra = @nguyenNhanHoanTra,
			CCCD_NV = @cccd_NV, SdtKHG = @sdt_KHG, SdtKHN = @sdt_KHN
		WHERE MaVanDon = @maVanDon
	END

	EXEC SP_UpdateTongGiaTriDonHang @maVanDon
END
GO

CREATE PROC SP_DeleteDonHang
@maVanDon VARCHAR(12)
AS
BEGIN
	-- Xoá các sản phẩm trong đơn hàng
	DELETE THONGTINSANPHAMDH
	WHERE MaVanDon = @maVanDon

	-- Xoá đơn hàng
	DELETE DONHANG
	WHERE MaVanDon = @maVanDon
END
GO

CREATE PROC SP_IsCheckCCCDKhachHangGui
@sdtKHG VARCHAR(10)
AS
BEGIN
	SELECT SdtKHG
	FROM KHACHHANGGUI
	WHERE SdtKHG = @sdtKHG
END
GO

CREATE PROC SP_IsCheckCCCDKhachHangNhan
@sdtKHN VARCHAR(10)
AS
BEGIN
	SELECT SdtKHN
	FROM KHACHHANGNHAN
	WHERE SdtKHN = @sdtKHN
END
GO

CREATE PROC SP_AddKhachHangGui
@sdtKHG VARCHAR(10),
@hoTenKHG NVARCHAR(30),
@diaChiKHG NVARCHAR(70)
AS
BEGIN
	INSERT INTO KHACHHANGGUI
	VALUES (@sdtKHG, @hoTenKHG, @diaChiKHG)
END
GO

CREATE PROC SP_AddKhachHangNhan
@sdtKHN VARCHAR(10),
@hoTenKHN NVARCHAR(30),
@diaChiKHN NVARCHAR(70)
AS
BEGIN
	INSERT INTO KHACHHANGNHAN
	VALUES (@sdtKHN, @hoTenKHN, @diaChiKHN)
END
GO

CREATE PROC SP_UpdateKhachHangGui
@sdtKHG VARCHAR(10),
@hoTenKHG NVARCHAR(30),
@diaChiKHG NVARCHAR(70)
AS
BEGIN
	UPDATE KHACHHANGGUI
	SET HoTenKHG = @hoTenKHG, DiaChiKHG = @diaChiKHG
	WHERE SdtKHG = @sdtKHG
END
GO

CREATE PROC SP_UpdateKhachHangNhan
@sdtKHN VARCHAR(10),
@hoTenKHN NVARCHAR(30),
@diaChiKHN NVARCHAR(70)
AS
BEGIN
	UPDATE KHACHHANGNHAN
	SET HoTenKHN = @hoTenKHN, DiaChiKHN = @diaChiKHN
	WHERE SdtKHN = @sdtKHN
END
GO

CREATE PROC SP_CountNumDonHangByKhachHangGui
@sdtKHG VARCHAR(10)
AS
BEGIN
	SELECT COUNT(SdtKHG)
	FROM DONHANG
	WHERE SdtKHG = @sdtKHG
END
GO

CREATE PROC SP_CountNumDonHangByKhachHangNhan
@sdtKHN VARCHAR(10)
AS
BEGIN
	SELECT COUNT(SdtKHG)
	FROM DONHANG
	WHERE SdtKHG = @sdtKHN
END
GO

CREATE PROC SP_CountNumDonHangByNVGiaoHang
@cccd_NV VARCHAR(12)
AS
BEGIN
	SELECT COUNT(CCCD_NV)
	FROM DONHANG
	WHERE CCCD_NV = @cccd_NV
END
GO

CREATE PROC SP_DeleteKhachHangGui
@sdtKHG VARCHAR(10)
AS
BEGIN
	-- Xoá tất cả các sản phẩm trong đơn hàng của khách hàng
	DELETE FROM THONGTINSANPHAMDH
	WHERE MaSP IN  
	(
		SELECT MaSP
		FROM DONHANG, THONGTINSANPHAMDH 
		WHERE DONHANG.MaVanDon = THONGTINSANPHAMDH.MaVanDon 
		AND SdtKHG = @sdtKHG
	)

	-- Xoá các đơn hàng của khách hàng gửi có căn cước này
	DELETE DONHANG
	WHERE SdtKHG = @sdtKHG

	-- Xoá khách hàng gửi
	DELETE KHACHHANGGUI
	WHERE SdtKHG = @sdtKHG
END
GO

CREATE PROC SP_DeleteKhachHangNhan
@sdtKHN VARCHAR(10)
AS
BEGIN
	-- Xoá tất cả các sản phẩm trong đơn hàng của khách hàng nhận
	DELETE FROM THONGTINSANPHAMDH
	WHERE MaSP IN  
	(
		SELECT MaSP
		FROM DONHANG, THONGTINSANPHAMDH 
		WHERE DONHANG.MaVanDon = THONGTINSANPHAMDH.MaVanDon 
		AND SdtKHN = @sdtKHN
	)

	-- Xoá các đơn hàng của khách hàng nhận có căn cước này
	DELETE DONHANG
	WHERE SdtKHN = @sdtKHN

	-- Xoá khách hàng nhận
	DELETE KHACHHANGNHAN
	WHERE SdtKHN = @sdtKHN
END
GO

CREATE PROC SP_IsCheckCCCDNV_GiaoHang
@cccd VARCHAR(12)
AS
BEGIN
	SELECT CCCD_NV
	FROM NV_GIAOHANG
	WHERE CCCD_NV = @cccd
END
GO

CREATE PROC SP_AddNV_GiaoHang
@cccd_NV VARCHAR(12),
@hoTenNV NVARCHAR(30),
@gioiTinhNV NVARCHAR(4),
@sdtNV VARCHAR(10),
@diaChiNV NVARCHAR(70),
@ngaySinhNV DATE,
@ghiChuNV NVARCHAR(100)
AS
BEGIN
	DECLARE @check INT = 0
	SELECT @check = COUNT(*) FROM NV_GIAOHANG WHERE CCCD_NV = @cccd_NV

	IF (@check = 0)
		INSERT INTO NV_GIAOHANG
		VALUES (@cccd_NV, @hoTenNV, @gioiTinhNV, @sdtNV, @diaChiNV, @ngaySinhNV, 0, @ghiChuNV)
	ELSE
		PRINT N'Khoá chính này đã tồn tại'
END
GO

CREATE PROC SP_UpdateNV_GiaoHang
@cccd_NV VARCHAR(12),
@hoTenNV NVARCHAR(30),
@gioiTinhNV NVARCHAR(4),
@sdtNV VARCHAR(10),
@diaChiNV NVARCHAR(70),
@ngaySinhNV DATE,
@ghiChuNV NVARCHAR(100)
AS
BEGIN
	-- Tính lương của nhân viên
	DECLARE @luongNV FLOAT = 0
	SELECT @luongNV = COUNT(MaVanDon)
	FROM DONHANG
	WHERE GiaoThanhCong = 1
	AND CCCD_NV = @cccd_NV
	AND MONTH(GETDATE()) = MONTH(NgayGui)

	UPDATE NV_GIAOHANG
	SET HoTenNV = @hoTenNV, GioiTinhNV = @gioiTinhNV, SdtNV = @sdtNV, DiaChiNV = @diaChiNV, NgaySinhNV = @ngaySinhNV, LuongNV = @luongNV, GhiChuNV = @ghiChuNV
	WHERE CCCD_NV = @cccd_NV
END
GO

CREATE PROC SP_DeleteNV_GiaoHang
@cccd_NV VARCHAR(12)
AS
BEGIN
	-- Xoá tất cả các sản phẩm trong đơn hàng của nhân viên giao hàng
	DELETE FROM THONGTINSANPHAMDH
	WHERE MaSP IN  
	(
		SELECT MaSP
		FROM DONHANG, THONGTINSANPHAMDH 
		WHERE DONHANG.MaVanDon = THONGTINSANPHAMDH.MaVanDon 
		AND CCCD_NV = @cccd_NV
	)

	-- Xoá các đơn hàng của hân viên giao hàng có căn cước này
	DELETE DONHANG
	WHERE CCCD_NV = @cccd_NV

	-- Xoá nhân viên giao hàng
	DELETE NV_GIAOHANG
	WHERE CCCD_NV = @cccd_NV
END
GO

CREATE PROC SP_DonHangGiaoThanhCong
@month INT,
@year INT
AS
BEGIN
	SELECT *
	FROM DONHANG
	WHERE GiaoThanhCong = 1
	AND MONTH(NgayGui) = @month AND YEAR(NgayGui) = @year
END
GO

CREATE PROC SP_DonHangHoanTra
@month INT,
@year INT
AS
BEGIN
	SELECT *
	FROM DONHANG
	WHERE HoanTra = 1
	AND MONTH(NgayGui) = @month AND YEAR(NgayGui) = @year
END
GO

CREATE PROC SP_DonHangTonKho
@month INT,
@year INT
AS
BEGIN
	SELECT *
	FROM DONHANG
	WHERE GiaoThanhCong = 0 AND HoanTra = 0
	AND MONTH(NgayNhapKho) = @month AND YEAR(NgayNhapKho) = @year
END
GO

CREATE PROC SP_DonHangTheoThang
@month INT,
@year INT
AS
BEGIN
	SELECT *
	FROM DONHANG
	WHERE MONTH(NgayNhapKho) = @month AND YEAR(NgayNhapKho) = @year
END
GO

CREATE PROC SP_ThongTinTaiKhoan
@tenDangNhap NVARCHAR(30),
@matKhau VARCHAR(40)
AS
BEGIN
	SELECT TenDangNhap, TenHienThi, QuyenTruyCap
	FROM TAIKHOAN
	WHERE TenDangNhap = @tenDangNhap AND MatKhau = @matKhau
END
GO

CREATE PROC SP_GetNVGiaoHangBySDT
@sdtNV VARCHAR(10)
AS
	SELECT * 
	FROM NV_GIAOHANG 
	WHERE SdtNV = @sdtNV
GO

CREATE PROC SP_ThayDoiTenHienThi
@tenDangNhap NVARCHAR(30),
@tenHienThi NVARCHAR(30),
@matKhau VARCHAR(40)
AS
BEGIN
	DECLARE @tmp NVARCHAR(30) = ''
	SELECT @tmp = TenDangNhap 
	FROM TAIKHOAN 
	WHERE TenDangNhap = @tenDangNhap AND MatKhau = @matKhau
	IF(@tmp <> '')
		UPDATE TAIKHOAN 
		SET TenHienThi = @tenHienThi 
		WHERE TenDangNhap = @tenDangNhap AND MatKhau = @matKhau
END
GO

CREATE PROC SP_GetTenHienThiByTenDangNhap
@tenDangNhap NVARCHAR(30)
AS
BEGIN
	SELECT TenHienThi 
	FROM TAIKHOAN 
	WHERE TenDangNhap = @tenDangNhap
END
GO

CREATE PROC SP_ThayDoiMatKhau
@tenDangNhap NVARCHAR(30),
@matKhau VARCHAR(40),
@matKhauMoi VARCHAR(40)
AS
BEGIN
	DECLARE @tmp NVARCHAR(30) = ''
	SELECT @tmp = TenDangNhap 
	FROM TAIKHOAN 
	WHERE TenDangNhap = @tenDangNhap AND (MatKhau = @matKhau OR MatKhau = '')
	IF(@tmp <> '')
		UPDATE TAIKHOAN 
		SET MatKhau = @matKhauMoi 
		WHERE TenDangNhap = @tenDangNhap
END
GO

CREATE PROC SP_AddTaiKhoan
@tenDangNhap NVARCHAR(30),
@tenHienThi NVARCHAR(30),
@quyenTruyCap NVARCHAR(25)
AS
BEGIN
	DECLARE @check NVARCHAR(30) = ''
	SELECT @check = TenDangNhap FROM TAIKHOAN WHERE TenDangNhap = @tenDangNhap
	IF (@check = '')
		INSERT INTO TAIKHOAN 
		VALUES (@tenDangNhap, @tenHienThi, '', @quyenTruyCap)
END
GO

CREATE PROC SP_UpdateTaiKhoan
@tenDangNhap NVARCHAR(30),
@tenHienThi NVARCHAR(30),
@quyenTruyCap NVARCHAR(25)
AS
BEGIN
	DECLARE @check NVARCHAR(30) = ''
	SELECT @check = TenDangNhap 
	FROM TAIKHOAN 
	WHERE TenDangNhap = @tenDangNhap
	IF (@check <> '')
		UPDATE TAIKHOAN
		SET TenHienThi = @tenHienThi, QuyenTruyCap = @quyenTruyCap 
		WHERE TenDangNhap = @tenDangNhap
END
GO

CREATE PROC SP_DeleteTaiKhoan
@tenDangNhap NVARCHAR(30)
AS
BEGIN
	DELETE TAIKHOAN
	WHERE TenDangNhap = @tenDangNhap
END
GO

CREATE PROC SP_ThongKeDonHangTheoNam
@year INT
AS
BEGIN
	CREATE TABLE THONGKEDONHANGTHEONAM
	(
		Thang INT NOT NULL PRIMARY KEY,
		SL_DH_GiaoThanhCong INT NOT NULL,
		SL_DH_BiHoanTra INT NOT NULL,
		SL_DH_DamNhan INT NOT NULL,
	)

	DECLARE @i INT = 1
	WHILE (@i <= 12)
	BEGIN
		DECLARE @DHGiaoThanhCongTrongThang INT = 0
		SELECT @DHGiaoThanhCongTrongThang = COUNT(MaVanDon) 
		FROM DONHANG 
		WHERE GiaoThanhCong = 1 AND MONTH(NgayGui) = @i AND YEAR(NgayGui) = @year

		DECLARE @DHBiHoanTraTrongThang INT = 0
		SELECT @DHBiHoanTraTrongThang = COUNT(MaVanDon) 
		FROM DONHANG 
		WHERE HoanTra = 1 AND MONTH(NgayGui) = @i AND YEAR(NgayGui) = @year

		DECLARE @DHDamNhanTrongThang INT = @DHGiaoThanhCongTrongThang + @DHBiHoanTraTrongThang

		INSERT INTO THONGKEDONHANGTHEONAM VALUES (@i, @DHGiaoThanhCongTrongThang, @DHBiHoanTraTrongThang, @DHDamNhanTrongThang)
		SET @i = @i + 1
	END

	SELECT * FROM THONGKEDONHANGTHEONAM
	
	DROP TABLE THONGKEDONHANGTHEONAM
END
GO

CREATE VIEW View_BangLuongNhanVien
AS
	SELECT CCCD_NV AS [Căn cước công dân], HoTenNV AS [Họ tên], LuongNV AS [Lương]
	FROM NV_GIAOHANG
GO

CREATE FUNCTION DaysOfMonth (@month INT, @year INT)
RETURNS INT
BEGIN
	DECLARE @day INT = 0
	IF (@month = 2)
	BEGIN
		IF ((@year % 4 = 0 AND @year % 100 <> 0) OR @year % 400 = 0)
			SET @day = 29
		ELSE
			SET @day = 28
	END
	ELSE IF (@month = 4 OR @month = 6 OR @month = 9 OR @month = 11)
		SET @day = 30
	ELSE
		SET @day = 31
	RETURN @day
END
GO

CREATE PROC SP_LuongCaNhanNhanVienTheoThang
@CCCD_NV VARCHAR(12)
AS
BEGIN
	CREATE TABLE LUONGCANHANNHANVIENTHEOTHANG
	(
		Ngay INT NOT NULL PRIMARY KEY,
		SL_DH_GiaoThanhCong INT NOT NULL,
		SL_DH_BiHoanTra INT NOT NULL,
		SL_DH_DamNhan INT NOT NULL,
	)

	DECLARE @i INT = 1
	DECLARE @maxDays INT = dbo.DaysOfMonth (MONTH(GETDATE()), YEAR(GETDATE()))
	WHILE (@i <= @maxDays)
	BEGIN
		DECLARE @DHGiaoThanhCongTrongThang INT = 0
		SELECT @DHGiaoThanhCongTrongThang = COUNT(MaVanDon) 
		FROM DONHANG 
		WHERE GiaoThanhCong = 1 AND CCCD_NV = @CCCD_NV AND
		DAY(NgayGui) = @i AND MONTH(NgayGui) = MONTH(GETDATE()) AND YEAR(NgayGui) = YEAR(GETDATE())

		DECLARE @DHBiHoanTraTrongThang INT = 0
		SELECT @DHBiHoanTraTrongThang = COUNT(MaVanDon) 
		FROM DONHANG 
		WHERE HoanTra = 1 AND CCCD_NV = @CCCD_NV AND 
		DAY(NgayGui) = @i AND MONTH(NgayGui) = MONTH(GETDATE()) AND YEAR(NgayGui) = YEAR(GETDATE())

		DECLARE @DHDamNhanTrongThang INT = @DHGiaoThanhCongTrongThang + @DHBiHoanTraTrongThang

		INSERT INTO LUONGCANHANNHANVIENTHEOTHANG VALUES (@i, @DHGiaoThanhCongTrongThang, @DHBiHoanTraTrongThang, @DHDamNhanTrongThang)
		SET @i = @i + 1
	END

	SELECT * FROM LUONGCANHANNHANVIENTHEOTHANG
	
	DROP TABLE LUONGCANHANNHANVIENTHEOTHANG
END
GO

CREATE PROC SP_PrinterDONHANG
@maVanDon VARCHAR(12)
AS
BEGIN
	SELECT *
	FROM DONHANG dh, NV_GIAOHANG nv, KHACHHANGGUI khg, KHACHHANGNHAN khn, THONGTINSANPHAMDH sp
	WHERE dh.CCCD_NV = nv.CCCD_NV
	AND dh.SdtKHG = khg.SdtKHG
	AND dh.SdtKHN = khn.SdtKHN
	AND dh.MaVanDon = sp.MaVanDon
	AND dh.MaVanDon = @maVanDon
END
GO

CREATE PROC SP_LuongTatCaNhanVienTheoThang
AS
BEGIN
	UPDATE NV_GIAOHANG 
	SET LuongNV = 
	(
		SELECT COUNT(*) * 5000 
		FROM DONHANG 
		WHERE GiaoThanhCong = 1 
		AND MONTH(NgayGui) = MONTH(GETDATE()) AND YEAR(NgayGui) = YEAR(GETDATE())
		AND DonHang.CCCD_NV = NV_GIAOHANG.CCCD_NV
	)
	SELECT * FROM View_BangLuongNhanVien
END
GO