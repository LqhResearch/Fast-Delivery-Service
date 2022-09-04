using SqlQuery;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh
{
    class ThongTinSanPhamDHDAL : ConnectionDB
    {
        #region Design Pattern Singleton
        private static ThongTinSanPhamDHDAL instance;
        public static ThongTinSanPhamDHDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThongTinSanPhamDHDAL();
                return ThongTinSanPhamDHDAL.instance;
            }
            private set => instance = value;
        }
        private ThongTinSanPhamDHDAL()
        {
            DataProvider.Instance.connectionString = connectDB;
        }
        #endregion

        #region Lấy danh sách thông tin sản phẩm của đơn hàng
        public DataTable GetListThongTinSanPhamByMaVanDon(string maVanDon)
        {
            return DataProvider.Instance.ExecuteQuery("SP_GetListThongTinSanPhamByMaVanDon @maVanDon", new object[] { maVanDon });
        }
        #endregion
        #region Thêm, cập nhật và xoá thông tin sản phẩm của đơn hàng
        public bool AddThongTinSanPhamDH(string tenSP, double giaSP, int soLuong, string maVanSon)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_AddThongTinSanPhamDH @tenSP, @giaSP, @soLuongSP, @maVanDon", new object[] { tenSP, giaSP, soLuong, maVanSon }) > 0;
        }

        public bool UpdateThongTinSanPhamDH(string @maSP, string tenSP, double giaSP, int soLuong, string maVanSon)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_UpdateThongTinSanPhamDH @maSP, @tenSP, @giaSP, @soLuongSP, @maVanDon", new object[] { maSP, tenSP, giaSP, soLuong, maVanSon }) > 0;
        }

        public bool DeleteThongTinSanPhamDH(string @maSP, string maVanSon)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_DeleteThongTinSanPhamDH @maSP, @maVanDon", new object[] { maSP, maVanSon }) > 0;
        }
        #endregion
    }
}
