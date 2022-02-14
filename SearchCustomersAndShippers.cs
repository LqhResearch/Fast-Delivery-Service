using HeThongQLDVGiaoHangNhanh.sqlQuery;
using System;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class SearchCustomersAndShippers : Form
    {
        public SearchCustomersAndShippers()
        {
            InitializeComponent();
        }
        #region Danh sách các header
        private void HeaderTextKhachHang()
        {
            dgvTimKiem.Columns[0].HeaderText = "Căn cước công dân";
            dgvTimKiem.Columns[1].HeaderText = "Họ tên";
            dgvTimKiem.Columns[2].HeaderText = "Số điện thoại";
            dgvTimKiem.Columns[3].HeaderText = "Địa chỉ";
        }

        private void HeaderTextDonHang()
        {
            dgvTimKiem.Columns[0].HeaderText = "Mã vận đơn";
            dgvTimKiem.Columns[1].HeaderText = "Tổng đơn hàng";
            dgvTimKiem.Columns[2].HeaderText = "Phí vận chuyển";
            dgvTimKiem.Columns[3].HeaderText = "Ngày nhập kho";
            dgvTimKiem.Columns[4].HeaderText = "Ngày giao hàng";
            dgvTimKiem.Columns[5].HeaderText = "Giao thành công";
            dgvTimKiem.Columns[6].HeaderText = "Bị hoàn trả";
            dgvTimKiem.Columns[7].HeaderText = "Nguyên nhân bị hoàn trả";
            dgvTimKiem.Columns[8].HeaderText = "CCCD nhân viên giao hàng";
            dgvTimKiem.Columns[9].HeaderText = "CCCD khách hàng gửi";
            dgvTimKiem.Columns[10].HeaderText = "CCCD khách hàng nhận";
        }
        #endregion
        #region Tải dữ liệu mặc định
        private void SearchCustomersAndShippers_Load(object sender, EventArgs e)
        {
            cboLoaiTimKiem.SelectedIndex = 0;
            cboThuocTinh.SelectedIndex = 0;
        }
        #endregion
        #region Xử lý DataGridView
        private void dgvTimKiem_DataSourceChanged(object sender, EventArgs e)
        {
            if (cboLoaiTimKiem.SelectedIndex == 2)
                lblStatus.Text = dgvTimKiem.RowCount + " nhân viên";
            else
                lblStatus.Text = dgvTimKiem.RowCount + " khách hàng";
        }
        #endregion
        #region Tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboLoaiTimKiem.Text == "Khách hàng gửi")
                    dgvTimKiem.DataSource = KhachHangGuiDAL.Instance.GetKhachHangGuiBySDT(txtSearch.Text);
            else if (cboLoaiTimKiem.Text == "Khách hàng nhận")
                    dgvTimKiem.DataSource = KhachHangNhanDAL.Instance.GetKhachHangNhanBySDT(txtSearch.Text);
            else
            {
                if (cboThuocTinh.Text == "Căn cước công dân")
                    dgvTimKiem.DataSource = NV_GiaoHangDAL.Instance.GetNVGiaoHangByCCCD_NV(txtSearch.Text);
                else
                    dgvTimKiem.DataSource = NV_GiaoHangDAL.Instance.GetNVGiaoHangBySDT(txtSearch.Text);
            }
            if (dgvTimKiem.RowCount == 0)
                MessageBox.Show("Không tìm thấy kết quả nào phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
