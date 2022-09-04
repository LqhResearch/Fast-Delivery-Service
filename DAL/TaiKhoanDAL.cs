using SqlQuery;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh
{
    class TaiKhoanDAL : ConnectionDB
    {
        #region Design Pattern Singleton
        private static TaiKhoanDAL instance;
        public static TaiKhoanDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAL();
                return TaiKhoanDAL.instance;
            }
            private set => instance = value;
        }
        private TaiKhoanDAL()
        {
            DataProvider.Instance.connectionString = connectDB;
        }
        #endregion

        #region Lấy thông tin của tài khoản
        public DataTable GetListThongTinTaiKhoan()
        {
            return DataProvider.Instance.ExecuteQuery("select * from View_TAIKHOAN");
        }

        public DataTable ThongTinTaiKhoan(string user, string pass)
        {
            return DataProvider.Instance.ExecuteQuery("SP_ThongTinTaiKhoan @tenDangNhap, @matKhau", new object[] { user, pass });
        }

        public string GetTenHienThiByTenDangNhap(string user)
        {
            return DataProvider.Instance.ExecuteScalar("SP_GetTenHienThiByTenDangNhap @tenDangNhap", new object[] { user }).ToString();
        }
        #endregion
        #region Thay đổi thông tin của tài khoản
        public bool ThayDoiTenHienThi(string user, string displayName, string pass)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_ThayDoiTenHienThi @tenDangNhap, @tenHienThi, @matKhau", new object[] { user, displayName, pass }) > 0;
        }

        public bool ThayDoiMatKhau(string user, string pass, string newPass)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_ThayDoiMatKhau @tenDangNhap, @matKhau, @matKhauMoi", new object[] { user, pass, newPass }) > 0;
        }
        #endregion
        #region Thêm, cập nhật và xoá thông tin tài khoản
        public bool AddTaiKhoan(string user, string displayName, string access)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_AddTaiKhoan @tenDangNhap, @tenHienThi, @quyenTruyCap", new object[] { user, displayName, access }) > 0;
        }

        public bool UpdateTaiKhoan(string user, string displayName, string access)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_UpdateTaiKhoan @tenDangNhap, @tenHienThi, @quyenTruyCap", new object[] { user, displayName, access }) > 0;
        }

        public bool DeleteTaiKhoan(string user)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_DeleteTaiKhoan @tenDangNhap", new object[] { user }) > 0;
        }
        #endregion
    }
}
