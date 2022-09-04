using System;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class ChangeDisplayName : Form
    {
        public ChangeDisplayName(string username)
        {
            InitializeComponent();
            Username = username;
        }

        public string Username { get; set; }

        #region Tải dữ liệu mặc định
        private void ChangeDisplayName_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Username;
        }
        #endregion
        #region Lưu lại
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (TaiKhoanDAL.Instance.ThayDoiTenHienThi(txtUsername.Text, txtDisplayName.Text, txtPassword.Text))
                MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Mật khẩu không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion
        #region Thoát
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
