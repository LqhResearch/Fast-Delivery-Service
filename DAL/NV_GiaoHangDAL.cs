using SqlQuery;
using System;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh
{
    class NV_GiaoHangDAL : ConnectionDB
    {
        #region Design Pattern Singleton
        private static NV_GiaoHangDAL instance;
        public static NV_GiaoHangDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NV_GiaoHangDAL();
                return NV_GiaoHangDAL.instance;
            }
            private set => instance = value;
        }
        private NV_GiaoHangDAL()
        {
            DataProvider.Instance.connectionString = connectDB;
        }
        #endregion

        #region Lấy danh sách thông tin của nhân viên giao hàng
        public DataTable GetListNVGiaoHang()
        {
            return DataProvider.Instance.ExecuteQuery("select * from View_NV_GIAOHANG");
        }

        public DataTable GetNVGiaoHangByCCCD_NV(string cccd_NV)
        {
            return DataProvider.Instance.ExecuteQuery("SP_GetNVGiaoHangByCCCD_NV @cccd_NV", new object[] { cccd_NV });
        }

        public DataTable GetNVGiaoHangBySDT(string sdt)
        {
            return DataProvider.Instance.ExecuteQuery("SP_GetNVGiaoHangBySDT @sdt", new object[] { sdt });
        }

        public DataTable LuongTatCaNhanVienTheoThang()
        {
            return DataProvider.Instance.ExecuteQuery("SP_LuongTatCaNhanVienTheoThang");
        }

        public DataTable LuongCaNhanNhanVienTheoThang(string cccd)
        {
            return DataProvider.Instance.ExecuteQuery("SP_LuongCaNhanNhanVienTheoThang @cccd_NV", new object[] { cccd });
        }
        #endregion
        #region Kiểm tra khoá chính (Căn cước công dân)
        public bool IsCheckCCCDNV_GiaoHang(string cccd_NV)
        {
            return DataProvider.Instance.ExecuteScalar("SP_IsCheckCCCDNV_GiaoHang @cccd_NV", new object[] { cccd_NV }) != null ? true : false;
        }
        #endregion
        #region Thêm, cập nhật và xoá thông tin nhân viên giao hàng
        public bool AddNV_GiaoHang(string cccd_NV, string hoTen, string gioiTinh, string sdt, string diaChi, DateTime ngaySinh, string ghiChu)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_AddNV_GiaoHang @cccd_NV, @hoTenNV, @gioiTinhNV, @sdtNV, @diaChiNV, @ngaySinhNV, @ghiChuNV", new object[] { cccd_NV, hoTen, gioiTinh, sdt, diaChi, ngaySinh, ghiChu }) > 0;
        }

        public bool UpdateNV_GiaoHang(string cccd_NV, string hoTen, string gioiTinh, string sdt, string diaChi, DateTime ngaySinh, string ghiChu)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_UpdateNV_GiaoHang @cccd_NV, @hoTenNV, @gioiTinhNV, @sdtNV, @diaChiNV, @ngaySinhNV, @ghiChuNV", new object[] { cccd_NV, hoTen, gioiTinh, sdt, diaChi, ngaySinh, ghiChu }) > 0;
        }

        public bool DeleteNV_GiaoHang(string cccd_NV)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_DeleteNV_GiaoHang @cccd_NV", new object[] { cccd_NV }) > 0;
        }
        #endregion
        #region Hỗ trợ thống kê
        public int CountNumDonHangByNVGiaoHang(string cccd_NV)
        {
            return (int)DataProvider.Instance.ExecuteScalar("SP_CountNumDonHangByNVGiaoHang @cccd_NV", new object[] { cccd_NV });
        }
        #endregion
    }
}
