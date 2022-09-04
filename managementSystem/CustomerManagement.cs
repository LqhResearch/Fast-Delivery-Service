using System;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class CustomerManagement : Form
    {
        public CustomerManagement(string customer)
        {
            InitializeComponent();
            TypeCustomer = customer;
        }

        public string TypeCustomer { get; set; }
        #region Tải dữ liệu mặc định
        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            if (TypeCustomer == "Khách hàng gửi")
            {
                rdbKhachHangGui.Checked = true;
                rdbKhachHangGui_CheckedChanged(null, new EventArgs());
            }
            else
            {
                rdbKhachHangNhan.Checked = true;
                rdbKhachHangNhan_CheckedChanged(null, new EventArgs());
            }
        }
        #endregion
        #region Tải dữ liệu khách hàng
        private void rdbKhachHangGui_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKhachHangGui.Checked)
                dgvKhachHang.DataSource = KhachHangGuiDAL.Instance.GetListKhachHangGui();
        }

        private void rdbKhachHangNhan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKhachHangNhan.Checked)
                dgvKhachHang.DataSource = KhachHangNhanDAL.Instance.GetListKhachHangNhan();
        }
        #endregion
        #region Xử lý DataGridView
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvKhachHang.SelectedRows[0];
                txtSdt.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                cboLoaiKhachHang.Text = (rdbKhachHangGui.Checked) ? rdbKhachHangGui.Text : rdbKhachHangNhan.Text;
            }
        }

        private void dgvKhachHang_DataSourceChanged(object sender, EventArgs e)
        {
            if (rdbKhachHangGui.Checked)
                lblStatus.Text = dgvKhachHang.RowCount + " khách hàng gửi";
            else lblStatus.Text = dgvKhachHang.RowCount + " khách hàng nhận";
        }
        #endregion
        #region Thêm, cập nhật và xoá khách hàng
        private bool CheckPhoneNumber(string phone)
        {
            if (phone.Length != 10)
            {
                MessageBox.Show("Số điện thoại có 10 chữ số", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            for (int i = 0; i < phone.Length; i++)
                if (phone[i] < '0' || phone[i] > '9')
                {
                    MessageBox.Show("Số điện thoại không hợp lệ\nVì có kí tự khác chữ số", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckPhoneNumber(txtSdt.Text))
                return;

            if (rdbKhachHangGui.Checked)
            {
                if (!KhachHangGuiDAL.Instance.IsCheckCCCDKhachHangGui(txtSdt.Text))
                {
                    if (KhachHangGuiDAL.Instance.AddKhachHangGui(txtSdt.Text, txtHoTen.Text, txtDiaChi.Text))
                        MessageBox.Show("Thêm khách hàng gửi mới thành công", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Căn cước công dân này đã đăng ký rồi", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!KhachHangNhanDAL.Instance.IsCheckCCCDKhachHangNhan(txtSdt.Text))
                {
                    if (KhachHangNhanDAL.Instance.AddKhachHangNhan(txtSdt.Text, txtHoTen.Text, txtDiaChi.Text))
                        MessageBox.Show("Thêm khách hàng nhận mới thành công", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Căn cước công dân này đã đăng ký rồi", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CustomerManagement_Load(null, new EventArgs());
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!CheckPhoneNumber(txtSdt.Text))
                return;

            if (rdbKhachHangGui.Checked)
            {
                if (KhachHangGuiDAL.Instance.IsCheckCCCDKhachHangGui(txtSdt.Text))
                {
                    if (KhachHangGuiDAL.Instance.UpdateKhachHangGui(txtSdt.Text, txtHoTen.Text, txtDiaChi.Text))
                        MessageBox.Show("Cập nhật khách hàng gửi thành công", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Căn cước công dân này chưa sử dụng", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (KhachHangNhanDAL.Instance.IsCheckCCCDKhachHangNhan(txtSdt.Text))
                {
                    if (KhachHangNhanDAL.Instance.UpdateKhachHangNhan(txtSdt.Text, txtHoTen.Text, txtDiaChi.Text))
                        MessageBox.Show("Cập nhật khách hàng nhận thành công", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Căn cước công dân này chưa sử dụng", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CustomerManagement_Load(null, new EventArgs());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (rdbKhachHangGui.Checked)
            {
                if (KhachHangGuiDAL.Instance.CountNumDonHangByKhachHangGui(txtSdt.Text) > 0)
                    if (MessageBox.Show("Bạn xoá khách hàng gửi này, thì tất cả đơn hàng liên quan đến khách hàng gửi này sẽ bị xoá theo. \nBạn có muốn tiếp tục xoá không?", "Quản lý khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                if (KhachHangGuiDAL.Instance.DeleteKhachHangGui(txtSdt.Text))
                    MessageBox.Show("Xoá khách hàng gửi thành công", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (KhachHangNhanDAL.Instance.CountNumDonHangByKhachHangNhan(txtSdt.Text) > 0)
                    if (MessageBox.Show("Bạn xoá khách hàng nhận này, thì tất cả đơn hàng liên quan đến khách hàng nhận này sẽ bị xoá theo. \nBạn có muốn tiếp tục xoá không?", "Quản lý khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                if (KhachHangNhanDAL.Instance.DeleteKhachHangNhan(txtSdt.Text))
                    MessageBox.Show("Xoá khách hàng nhận thành công", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CustomerManagement_Load(null, new EventArgs());
        }
        #endregion
        #region Chuẩn bị thêm mới
        private void btnNewAdd_Click(object sender, EventArgs e)
        {
            txtSdt.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            cboLoaiKhachHang.SelectedIndex = (rdbKhachHangGui.Checked) ? 0 : 1;
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
