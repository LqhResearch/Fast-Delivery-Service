using SqlQuery;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh
{
    class KhachHangGuiDAL : ConnectionDB
    {
        #region Design Pattern Singleton
        private static KhachHangGuiDAL instance;
        public static KhachHangGuiDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangGuiDAL();
                return KhachHangGuiDAL.instance;
            }
            private set => instance = value;
        }
        private KhachHangGuiDAL()
        {
            DataProvider.Instance.connectionString = connectDB;
        }
        #endregion

        #region Lấy danh sách thông tin khách hàng gửi
        public DataTable GetListKhachHangGui()
        {
            return DataProvider.Instance.ExecuteQuery("select * from View_KHACHHANGGUI");
        }

        public DataTable GetKhachHangGuiBySDT(string sdt)
        {
            return DataProvider.Instance.ExecuteQuery("SP_GetKhachHangGuiBySdtKHG @sdt", new object[] { sdt });
        }
        #endregion
        #region Kiểm tra khoá chính (Căn cước công dân)
        public bool IsCheckCCCDKhachHangGui(string cccd)
        {
            return DataProvider.Instance.ExecuteScalar("SP_IsCheckCCCDKhachHangGui @cccd", new object[] { cccd }) != null ? true : false;
        }
        #endregion
        #region Thêm, cập nhật và xoá thông tin của khách hàng gửi
        public bool AddKhachHangGui(string sdt, string hoTen, string diaChi)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_AddKhachHangGui @sdtKHG, @hoTenKHG, @diaChiKHG", new object[] { sdt, hoTen, diaChi }) > 0;
        }

        public bool UpdateKhachHangGui(string sdt, string hoTen, string diaChi)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_UpdateKhachHangGui @sdtKHG, @hoTenKHG, @diaChiKHG", new object[] { sdt, hoTen, diaChi }) > 0;
        }

        public bool DeleteKhachHangGui(string sdt)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_DeleteKhachHangGui @sdtKHG", new object[] { sdt }) > 0;
        }
        #endregion
        #region Hỗ trợ cho thống kê
        public int CountNumDonHangByKhachHangGui(string cccd)
        {
            return (int)DataProvider.Instance.ExecuteScalar("SP_CountNumDonHangByKhachHangGui @cccd_KHG", new object[] { cccd });
        }
        #endregion
    }
}
