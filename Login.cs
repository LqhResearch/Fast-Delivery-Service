using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class Login : Form
    {
        ToolTip toolTip = new ToolTip();
        public Login()
        {
            InitializeComponent();
        }

        #region Tạo chữ chìm
        private void Login_Load(object sender, EventArgs e)
        {
            toolTip.SetToolTip(txtUsername, "Tên đăng nhập không phân biệt chữ hoa chữ thường");
            toolTip.SetToolTip(btnEyePass, "Hiển thị mật khẩu");
            toolTip.SetToolTip(btnEyeClosePass, "Ẩn mật khẩu");
            toolTip.SetToolTip(btnKhach, "Đăng nhập với tư cách là khách hàng (người xem) không cần tên đăng nhập và mật khẩu");
            txtUsername_Leave(null, new EventArgs());
            txtPassword_Leave(null, new EventArgs());
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Tên đăng nhập")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Tên đăng nhập";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mật khẩu")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Mật khẩu";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        #endregion
        #region Hiển thị / Ẩn mật khẩu
        private void btnEyePass_Click(object sender, EventArgs e)
        {
            btnEyeClosePass.BringToFront();
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnEyeClosePass_Click(object sender, EventArgs e)
        {
            btnEyePass.BringToFront();
            txtPassword.UseSystemPasswordChar = true;
        }
        #endregion
        #region Đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = TaiKhoanDAL.Instance.ThongTinTaiKhoan(txtUsername.Text, Encryption.MD5(txtPassword.Text));
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard dashboard = new Dashboard(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                this.Hide();
                dashboard.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Đăng nhập thất bại", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard("", "", "Khách");
            this.Hide();
            dashboard.ShowDialog();
            this.Show();
        }
        #endregion
        #region Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.Exit();
        }
        #endregion
    }
}
