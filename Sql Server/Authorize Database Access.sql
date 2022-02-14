--Tạo user và cấp quyền:
EXEC SP_ADDLOGIN 'Quanly_admin', '123456'
EXEC SP_ADDLOGIN 'Nhanvien_user', '123456'
GO

CREATE USER QL_admin FOR LOGIN Quanly_admin
CREATE USER NV_user FOR LOGIN Nhanvien_user
GO

EXEC SP_GRANTDBACCESS 'Quanly_admin'  
GO 

EXEC SP_GRANTDBACCESS 'Nhanvien_user'
GO

--Cấp quyền cho quản lý:
GRANT SELECT, INSERT, UPDATE ON View_TAIKHOAN
	TO Quanly_admin
GO

GRANT SELECT, INSERT, UPDATE ON View_DONHANG
	TO Quanly_admin
GO

GRANT SELECT, INSERT, UPDATE ON View_KHACHHANGGUI
	TO Quanly_admin
GO

GRANT SELECT, INSERT, UPDATE ON View_KHACHHANGNHAN
	TO Quanly_admin
GO

GRANT SELECT, INSERT, UPDATE ON View_NV_GIAOHANG
	TO Quanly_admin
GO

GRANT EXECUTE ON SP_GetKhachHangGuiByCCCD_KHG TO Quanly_admin
GRANT EXECUTE ON SP_GetKhachHangNhanByCCCD_KHN TO Quanly_admin
GRANT EXECUTE ON SP_GetNVGiaoHangByCCCD_NV TO Quanly_admin
GRANT EXECUTE ON SP_GetDonHangByMaVanDon TO Quanly_admin
GRANT EXECUTE ON SP_GetListThongTinSanPhamByMaVanDon TO Quanly_admin
GRANT EXECUTE ON SP_UpdateTOngGiaTriDonHang TO Quanly_admin
GRANT EXECUTE ON SP_AddThongTinSanPhamDH TO Quanly_admin
GRANT EXECUTE ON SP_UpdateThongTinSanPhamDH TO Quanly_admin
GRANT EXECUTE ON SP_DeleteThongTinSanPhamDH TO Quanly_admin
GRANT EXECUTE ON SP_AddDonHang TO Quanly_admin
GRANT EXECUTE ON SP_UpdateDonHang TO Quanly_admin
GRANT EXECUTE ON SP_DeleteDonHang TO Quanly_admin
GRANT EXECUTE ON SP_IsCheckCCCDKhachHangGui TO Quanly_admin
GRANT EXECUTE ON SP_IsCheckCCCDKhachHangNhan TO Quanly_admin
GRANT EXECUTE ON SP_IsCheckCCCDKhachHangNhan TO Quanly_admin
GRANT EXECUTE ON SP_AddKhachHangGui TO Quanly_admin
GRANT EXECUTE ON SP_UpdateKhachHangGui TO Quanly_admin
GRANT EXECUTE ON SP_DeleteKhachHangGui TO Quanly_admin
GRANT EXECUTE ON SP_AddKhachHangNhan TO Quanly_admin
GRANT EXECUTE ON SP_UpdateKhachHangNhan TO Quanly_admin
GRANT EXECUTE ON SP_DeleteKhachHangNhan  TO Quanly_admin
GRANT EXECUTE ON SP_CountNumDonHangByKhachHangGui TO Quanly_admin
GRANT EXECUTE ON SP_CountNumDonHangByKhachHangNhan TO Quanly_admin
GRANT EXECUTE ON SP_CountNumDonHangByNVGiaoHang TO Quanly_admin
GRANT EXECUTE ON SP_IsCheckCCCDNV_GiaoHang TO Quanly_admin
GRANT EXECUTE ON SP_AddNV_GiaoHang TO Quanly_admin
GRANT EXECUTE ON SP_UpdateNV_GiaoHang TO Quanly_admin
GRANT EXECUTE ON SP_DeleteNV_GiaoHang TO Quanly_admin
GRANT EXECUTE ON SP_DonHangGiaoThanhCong TO Quanly_admin
GRANT EXECUTE ON SP_DonHangHoanTra TO Quanly_admin
GRANT EXECUTE ON SP_DonHangTOnKho TO Quanly_admin
GRANT EXECUTE ON SP_DonHangTheoThang TO Quanly_admin
GRANT EXECUTE ON SP_ThongTinTaiKhoan TO Quanly_admin
GRANT EXECUTE ON SP_GetKhachHangGuiBySDT TO Quanly_admin
GRANT EXECUTE ON SP_GetKhachHangNhanBySDT TO Quanly_admin
GRANT EXECUTE ON SP_GetNVGiaoHangBySDT TO Quanly_admin
GRANT EXECUTE ON SP_AddTaiKhoan TO Quanly_admin
GRANT EXECUTE ON SP_UpdateTaiKhoan TO Quanly_admin
GRANT EXECUTE ON SP_DeleteTaiKhoan TO Quanly_admin
GRANT EXECUTE ON SP_ThongKeDonHangTheoNam TO Quanly_admin
GRANT EXECUTE ON SP_LuongCaNhanNhanVienTheoThang TO Quanly_admin
GO

--Cấp quyền cho nhân viên:
GRANT SELECT, INSERT ON View_TAIKHOAN
	TO Nhanvien_user	
GRANT SELECT, INSERT ON View_DONHANG
	TO Nhanvien_user	
GRANT SELECT ON View_KHACHHANGGUI
	TO Nhanvien_user
GRANT SELECT ON View_KHACHHANGNHAN
	TO Nhanvien_user
GRANT SELECT ON View_NV_GIAOHANG
	TO Nhanvien_user
GO

GRANT EXECUTE ON SP_ThayDoiTenHienThi TO Nhanvien_user		
GRANT EXECUTE ON SP_ThayDoiMatKhau TO Nhanvien_user
GO