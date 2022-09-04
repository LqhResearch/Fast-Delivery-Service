using SqlQuery;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh
{
    class KhachHangNhanDAL : ConnectionDB
    {
        #region Design Pattern Singleton
        private static KhachHangNhanDAL instance;
        public static KhachHangNhanDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangNhanDAL();
                return KhachHangNhanDAL.instance;
            }
            private set => instance = value;
        }
        private KhachHangNhanDAL()
        {
            DataProvider.Instance.connectionString = connectDB;
        }
        #endregion

        #region Lấy danh sách thông tin của khách hàng nhận
        public DataTable GetListKhachHangNhan()
        {
            return DataProvider.Instance.ExecuteQuery("select * from View_KHACHHANGNHAN");
        }

        public DataTable GetKhachHangNhanBySDT(string sdt)
        {
            return DataProvider.Instance.ExecuteQuery("SP_GetKhachHangNhanBySdtKHN @sdt", new object[] { sdt });
        }
        #endregion
        #region Kiểm tra khoá chính (Căn cước công dân)
        public bool IsCheckCCCDKhachHangNhan(string cccd)
        {
            return DataProvider.Instance.ExecuteScalar("SP_IsCheckCCCDKhachHangNhan @cccd", new object[] { cccd }) != null ? true : false;
        }
        #endregion
        #region Thêm, cập nhật và xoá thông tin khách hàng nhận
        public bool AddKhachHangNhan(string sdt, string hoTen, string diaChi)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_AddKhachHangNhan @sdtKHN, @hoTenKHN, @diaChiKHN", new object[] { sdt, hoTen, diaChi }) > 0;
        }

        public bool UpdateKhachHangNhan(string sdt, string hoTen, string diaChi)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_UpdateKhachHangNhan @sdtKHN, @hoTenKHN, @diaChiKHN", new object[] { sdt, hoTen, diaChi }) > 0;
        }

        public bool DeleteKhachHangNhan(string sdt)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_DeleteKhachHangNhan @sdtKHN", new object[] { sdt }) > 0;
        }
        #endregion
        #region Hỗ trợ cho thống kê
        public int CountNumDonHangByKhachHangNhan(string cccd)
        {
            return (int)DataProvider.Instance.ExecuteScalar("SP_CountNumDonHangByKhachHangNhan @cccd_KHG", new object[] { cccd });
        }
        #endregion
    }
}
