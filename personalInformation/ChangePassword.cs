using System;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class ChangePassword : Form
    {
        public ChangePassword(string username)
        {
            InitializeComponent();
            Username = username;
        }

        public string Username { get; set; }

        #region Tải dữ liệu mặc định
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Username;
        }
        #endregion
        #region Lưu lại
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtEnterPass.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TaiKhoanDAL.Instance.ThayDoiMatKhau(txtUsername.Text, Encryption.MD5(txtPassword.Text), Encryption.MD5(txtNewPass.Text)))
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
