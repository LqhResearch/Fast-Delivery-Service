using System;
using System.Windows.Forms;
using SqlQuery;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class AccountManagement : Form
    {
        public AccountManagement(string username)
        {
            InitializeComponent();
            Username = username;
        }

        public string Username { get; set; }

        #region Load dữ liệu mặc định
        private void AccountManagement_Load(object sender, EventArgs e)
        {
            dgvAccount.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM View_TAIKHOAN");
        }
        #endregion
        #region Xử lý DataGridView tài khoản
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccount.RowCount > 0)
            {
                DataGridViewRow row = dgvAccount.SelectedRows[0];
                txtUsername.Text = row.Cells[0].Value.ToString();
                txtDisplayName.Text = row.Cells[1].Value.ToString();
                cboAccess.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dgvAccount_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvAccount.RowCount + " tài khoản";
        }
        #endregion
        #region Thêm, cập nhật và xoá tài khoản
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TaiKhoanDAL.Instance.AddTaiKhoan(txtUsername.Text, txtDisplayName.Text, cboAccess.Text))
                MessageBox.Show("Thêm tài khoản mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm tài khoản mới thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AccountManagement_Load(null, null);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (TaiKhoanDAL.Instance.UpdateTaiKhoan(txtUsername.Text, txtDisplayName.Text, cboAccess.Text))
                MessageBox.Show("Cập nhật thông tin tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Cập nhật thông tin tài khoản thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AccountManagement_Load(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != Username)
            {
                if (TaiKhoanDAL.Instance.DeleteTaiKhoan(txtUsername.Text))
                    MessageBox.Show("Xoá tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xoá tài khoản thất bại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AccountManagement_Load(null, null);
            }
            else
                MessageBox.Show("Bạn không thể xoá tài khoản đang đăng nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
        #region Chuẩn bị thêm mới
        private void btnNewAdd_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtDisplayName.Clear();
            cboAccess.SelectedIndex = 0;
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
