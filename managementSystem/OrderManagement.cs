using System;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }

        #region Load dữ liệu hệ thống
        private void SetAllToolTip()
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(txtMaVanDon, "Mã vận đơn sẽ được tạo tự động khi thêm mới");
            tip.SetToolTip(txtTongDonHang, "Tổng đơn hàng sẽ được cập nhật tự dộng");
        }

        private void LoadComboxKHG_KHN_NV()
        {
            cboCCCD_KHG.DataSource = KhachHangGuiDAL.Instance.GetListKhachHangGui();
            cboCCCD_KHG.DisplayMember = "Số điện thoại";
            cboCCCD_KHN.DataSource = KhachHangNhanDAL.Instance.GetListKhachHangNhan();
            cboCCCD_KHN.DisplayMember = "Số điện thoại";
            cboCCCD_NV.DataSource = NV_GiaoHangDAL.Instance.GetListNVGiaoHang();
            cboCCCD_NV.DisplayMember = "Căn cước công dân";
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = DonHangDAL.Instance.GetListDonHang();
            dgvDonHang.Columns[1].DefaultCellStyle.Format = "N0";
            dgvDonHang.Columns[2].DefaultCellStyle.Format = "N0";
            dgvDonHang.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDonHang.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDonHang.Columns[11].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss";
            LoadComboxKHG_KHN_NV();
            SetAllToolTip();
        }
        #endregion
        #region Xử lý DataGridView
        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvDonHang.SelectedRows[0];
                txtMaVanDon.Text = row.Cells["Mã vận đơn"].Value.ToString();
                txtTongDonHang.Text = row.Cells["Tổng đơn hàng"].Value.ToString();
                numPhiVanChuyen.Value = Convert.ToInt32(row.Cells["Phí vận chuyển"].Value);
                dtpNgayNhapKho.Value = Convert.ToDateTime(row.Cells["Ngày nhập kho"].Value);

                rdbGiaoThanhCong.Checked = Convert.ToBoolean(row.Cells["Giao thành công"].Value);
                rdbHoanTra.Checked = Convert.ToBoolean(row.Cells["Bị hoàn trả"].Value);
                rtxtNguyenNhanHoanTra.Text = row.Cells["Nguyên nhân bị hoàn trả"].Value.ToString();

                if (!rdbGiaoThanhCong.Checked && !rdbHoanTra.Checked)
                {
                    rdbTonKho.Checked = true;
                    dtpNgayGui.Enabled = false;
                    rtxtNguyenNhanHoanTra.Enabled = false;
                }
                else
                {
                    dtpNgayGui.Enabled = true;
                    dtpNgayGui.Value = Convert.ToDateTime(row.Cells["Ngày giao hàng"].Value);
                }

                cboCCCD_KHG.Text = row.Cells["Số điện thoại KH gửi"].Value.ToString();
                cboCCCD_KHN.Text = row.Cells["Số điện thoại KH nhận"].Value.ToString();
                cboCCCD_NV.Text = row.Cells["CCCD nhân viên giao hàng"].Value.ToString();
            }
        }

        private void dgvDonHang_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvDonHang.RowCount + " đơn hàng";
        }
        #endregion
        private void btnTTDonHang_Click(object sender, EventArgs e)
        {
            ProductManagement product = new ProductManagement(dgvDonHang.SelectedRows[0].Cells[0].Value.ToString());
            this.Hide();
            product.ShowDialog();
            this.Show();
            OrderManagement_Load(null, new EventArgs());
        }
        #region Thêm, cập nhật, xoá đơn hàng
        private void btnThem_Click(object sender, EventArgs e)
        {
            string nguyenNhanHoanTra = (rdbHoanTra.Checked == true) ? rtxtNguyenNhanHoanTra.Text : "";
            if (DonHangDAL.Instance.AddDonHang((int)numPhiVanChuyen.Value, (int)numPhiVanChuyen.Value,
                dtpNgayNhapKho.Value, dtpNgayGui.Value, rdbGiaoThanhCong.Checked, rdbHoanTra.Checked,
                nguyenNhanHoanTra, cboCCCD_NV.Text, cboCCCD_KHG.Text, cboCCCD_KHN.Text))
            {
                MessageBox.Show("Thêm đơn hàng mới thành công", "Quản lý đơn hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrderManagement_Load(null, new EventArgs());
            }
            else
                MessageBox.Show("Thêm đơn hàng mới thất bại", "Quản lý đơn hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string nguyenNhanHoanTra = (rdbHoanTra.Checked == true) ? rtxtNguyenNhanHoanTra.Text : "";
            if (DonHangDAL.Instance.UpdateDonHang(txtMaVanDon.Text, (int)numPhiVanChuyen.Value, (int)numPhiVanChuyen.Value,
                dtpNgayNhapKho.Value, dtpNgayGui.Value, rdbGiaoThanhCong.Checked, rdbHoanTra.Checked,
                nguyenNhanHoanTra, cboCCCD_NV.Text, cboCCCD_KHG.Text, cboCCCD_KHN.Text))
            {
                MessageBox.Show("Sửa đơn hàng thành công", "Quản lý đơn hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrderManagement_Load(null, new EventArgs());
            }
            else
                MessageBox.Show("Sửa đơn hàng thất bại", "Quản lý đơn hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < dgvDonHang.SelectedRows.Count; i++)
            {
                string maVanDon = dgvDonHang.SelectedRows[i].Cells[0].Value.ToString();
                if (DonHangDAL.Instance.DeleteDonHang(maVanDon))
                    count++;
            }
            if (count > 0)
            {
                MessageBox.Show("Xoá thành công " + count + " đơn hàng", "Quản lý đơn hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrderManagement_Load(null, new EventArgs());
            }
        }
        #endregion
        #region Hoán đổi giữa table khách hàng gửi và khách hàng nhận
        private void rdbTonKho_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTonKho.Checked)
                dtpNgayGui.Enabled = false;
            else
                dtpNgayGui.Enabled = true;
        }

        private void rdbHoanTra_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHoanTra.Checked)
                rtxtNguyenNhanHoanTra.Enabled = true;
            else
                rtxtNguyenNhanHoanTra.Enabled = false;
        }
        #endregion
        #region Các button đăng ký khách hàng nhận, gửi và nhân viên giao hàng nhanh
        private void btnQLKHGui_Click(object sender, EventArgs e)
        {
            CustomerManagement customer = new CustomerManagement("Khách hàng gửi");
            customer.ShowDialog();
            LoadComboxKHG_KHN_NV();
        }

        private void btnQLKHNhan_Click(object sender, EventArgs e)
        {
            CustomerManagement customer = new CustomerManagement("Khách hàng nhận");
            customer.ShowDialog();
            LoadComboxKHG_KHN_NV();
        }

        private void btnQLNVGiaoHang_Click(object sender, EventArgs e)
        {
            ShipperManagement shipper = new ShipperManagement();
            shipper.ShowDialog();
            LoadComboxKHG_KHN_NV();
        }
        #endregion
        #region Chuẩn bị thêm mới
        private void btnNewAdd_Click(object sender, EventArgs e)
        {
            txtMaVanDon.Clear();
            txtTongDonHang.Text = "0";
            numPhiVanChuyen.Value = 30000;
            dtpNgayNhapKho.Value = DateTime.Now;
            rdbTonKho.Checked = true;
            rtxtNguyenNhanHoanTra.Clear();
            dtpNgayGui.Value = DateTime.Now;
            cboCCCD_KHG.SelectedIndex = 0;
            cboCCCD_KHN.SelectedIndex = 0;
            cboCCCD_NV.SelectedIndex = 0;
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
