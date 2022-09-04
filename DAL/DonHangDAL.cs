using SqlQuery;
using System;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh
{
    class DonHangDAL : ConnectionDB
    {
        #region Design Pattern Singleton
        private static DonHangDAL instance;
        public static DonHangDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonHangDAL();
                return DonHangDAL.instance;
            }
            private set => instance = value;
        }
        private DonHangDAL()
        {
            DataProvider.Instance.connectionString = connectDB;
        }
        #endregion

        #region Lấy danh sách thông tin của đơn hàng
        public DataTable GetListDonHang()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM View_DONHANG ORDER BY CreatedAt DESC");
        }

        public DataTable GetDonHangByMaVanDon(string maVanDon)
        {
            return DataProvider.Instance.ExecuteQuery("SP_GetDonHangByMaVanDon @maVanDon", new object[] { maVanDon });
        }
        #endregion
        #region Thêm, cập nhật và xoá đơn hàng
        public bool AddDonHang(double tongDonHang, double phiVanChuyen, DateTime ngayNhapKho, DateTime? ngayGui, bool giaoThanhCong, bool hoanTra, string nguyenNhanHoanTra, string cccd_NV, string sdtKHG, string sdtKHN)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_AddDonHang @tongDonHang, @phiVanChuyen, @ngayNhapKho, @ngayGui, @giaoThanhCong, @hoanTra, @nguyenNhanHoanTra, @cccd_NV, @sdtKHG, @sdtKHN",
                        new object[] { tongDonHang, phiVanChuyen, ngayNhapKho, ngayGui, giaoThanhCong, hoanTra, nguyenNhanHoanTra, cccd_NV, sdtKHG, sdtKHN }) > 0;
        }

        public bool UpdateDonHang(string maVanDon, double tongDonHang, double phiVanChuyen, DateTime ngayNhapKho, DateTime? ngayGui, bool giaoThanhCong, bool hoanTra, string nguyenNhanHoanTra, string cccd_NV, string sdtKHG, string sdtKHN)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_UpdateDonHang @maVanDon, @tongDonHang, @phiVanChuyen, @ngayNhapKho, @ngayGui, @giaoThanhCong, @hoanTra, @nguyenNhanHoanTra, @cccd_NV, @sdtKHG, @sdtKHN",
                        new object[] { maVanDon, tongDonHang, phiVanChuyen, ngayNhapKho, ngayGui, giaoThanhCong, hoanTra, nguyenNhanHoanTra, cccd_NV, sdtKHG, sdtKHN }) > 1;
        }

        public bool DeleteDonHang(string maVanDon)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_DeleteDonHang @maVanDon", new object[] { maVanDon }) > 0;
        }
        #endregion
        #region Danh sách đơn hàng giao thành công, hoàn trả và tồn kho
        public DataTable DonHangGiaoThanhCong(int thang, int nam)
        {
            return DataProvider.Instance.ExecuteQuery("SP_DonHangGiaoThanhCong @thang, @nam", new object[] { thang, nam });
        }

        public DataTable DonHangHoanTra(int thang, int nam)
        {
            return DataProvider.Instance.ExecuteQuery("SP_DonHangHoanTra @thang, @nam", new object[] { thang, nam });
        }

        public DataTable DonHangTonKho(int thang, int nam)
        {
            return DataProvider.Instance.ExecuteQuery("SP_DonHangTonKho @thang, @nam", new object[] { thang, nam });
        }

        public DataTable ThongKeDonHangTheoNam(int nam)
        {
            return DataProvider.Instance.ExecuteQuery("SP_ThongKeDonHangTheoNam @year", new object[] { nam });
        }

        public DataTable DonHangTheoThang(int thang, int nam)
        {
            return DataProvider.Instance.ExecuteQuery("SP_DonHangTheoThang @thang, @nam", new object[] { thang, nam });
        }
        #endregion

        public DataTable PrinterDONHANG(string maVanDon) // In phiếu giao hàng nhanh
        {
            return DataProvider.Instance.ExecuteQuery("SP_PrinterDONHANG @maVanDon", new object[] { maVanDon });
        }
    }
}
