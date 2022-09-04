using System;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class ShipperManagement : Form
    {
        public ShipperManagement()
        {
            InitializeComponent();
        }

        #region Tải dữ liệu mặc định lên
        private void ShipperManagement_Load(object sender, EventArgs e)
        {
            dgvNVGiaoHang.DataSource = NV_GiaoHangDAL.Instance.GetListNVGiaoHang();
            dgvNVGiaoHang.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        #endregion
        #region Xử lý DataGridView
        private void dgvNVGiaoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNVGiaoHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvNVGiaoHang.SelectedRows[0];
                txtCCCD.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                cboGioiTinh.Text = row.Cells[2].Value.ToString();
                txtSdt.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells[5].Value);
                txtGhiChu.Text = row.Cells[6].Value.ToString();
            }
        }

        private void dgvNVGiaoHang_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvNVGiaoHang.RowCount + " nhân viên";
        }
        #endregion
        #region Thêm, cập nhật và xoá nhân viên giao hàng
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

        private bool CheckCitizenshipIdentity(string code)
        {
            if (code.Length != 12)
            {
                MessageBox.Show("Căn cước công dân có 12 chữ số", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            for (int i = 0; i < code.Length; i++)
                if (code[i] < '0' || code[i] > '9')
                {
                    MessageBox.Show("Căn cước công dân không hợp lệ\nVì có kí tự khác chữ số", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!CheckCitizenshipIdentity(txtCCCD.Text) || !CheckPhoneNumber(txtSdt.Text))
                return;

            if (!NV_GiaoHangDAL.Instance.IsCheckCCCDNV_GiaoHang(txtCCCD.Text))
            {
                int age = DateTime.Now.Year - dtpNgaySinh.Value.Year;
                if (age >= 18 && age <= 50)
                {
                    if (NV_GiaoHangDAL.Instance.AddNV_GiaoHang(txtCCCD.Text, txtHoTen.Text, cboGioiTinh.Text, txtSdt.Text, txtDiaChi.Text, dtpNgaySinh.Value, txtGhiChu.Text))
                    {
                        ShipperManagement_Load(null, new EventArgs());
                        MessageBox.Show("Thêm nhân viên giao hàng mới thành công", "Quản lý nhân viên giao hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else MessageBox.Show("Tuổi nhân viên từ 18 - 50", "Quản lý nhân viên giao hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Căn cước công dân này đã đăng ký rồi", "Quản lý nhân viên giao hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!CheckCitizenshipIdentity(txtCCCD.Text) || !CheckPhoneNumber(txtSdt.Text))
                return;

            if (NV_GiaoHangDAL.Instance.IsCheckCCCDNV_GiaoHang(txtCCCD.Text))
            {
                int age = DateTime.Now.Year - dtpNgaySinh.Value.Year;
                if (age >= 18 && age <= 50)
                {
                    if (NV_GiaoHangDAL.Instance.UpdateNV_GiaoHang(txtCCCD.Text, txtHoTen.Text, cboGioiTinh.Text, txtSdt.Text, txtDiaChi.Text, dtpNgaySinh.Value, txtGhiChu.Text))
                    {
                        ShipperManagement_Load(null, new EventArgs());
                        MessageBox.Show("Cập nhật nhân viên giao hàng thành công", "Quản lý nhân viên giao hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else MessageBox.Show("Tuổi nhân viên từ 18 - 50", "Quản lý nhân viên giao hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Căn cước công dân này chưa tồn tại rồi", "Quản lý nhân viên giao hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (NV_GiaoHangDAL.Instance.CountNumDonHangByNVGiaoHang(txtCCCD.Text) > 0)
            {
                DialogResult result = MessageBox.Show("Bạn xoá nhân viên giao hàng này, thì tất cả đơn hàng liên quan đến khách hàng gửi này sẽ bị xoá theo. \nBạn có muốn tiếp tục xoá không?", "Quản lý nhân viên giao hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
            }
            if (NV_GiaoHangDAL.Instance.DeleteNV_GiaoHang(txtCCCD.Text))
            {
                ShipperManagement_Load(null, new EventArgs());
                MessageBox.Show("Xoá nhân viên giao hàng thành công", "Quản lý nhân viên giao hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Chuẩn bị thêm mới
        private void btnNewAdd_Click(object sender, EventArgs e)
        {
            txtCCCD.Clear();
            txtHoTen.Clear();
            cboGioiTinh.SelectedIndex = 0;
            txtSdt.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = new DateTime(DateTime.Now.Year - 18, 1, 1);
            txtGhiChu.Clear();
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
