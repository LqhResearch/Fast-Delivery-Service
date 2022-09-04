using System;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class ProductManagement : Form
    {
        public ProductManagement(string maVanDon)
        {
            InitializeComponent();
            MaVanDon = maVanDon;
        }

        public string MaVanDon { get; set; }
        #region Tải dữ liệu mặc định
        private void ProductManagement_Load(object sender, EventArgs e)
        {
            lblMaVanDon.Text = "Đơn hàng: " + MaVanDon;
            dgvThongTinSanPhamDH.DataSource = ThongTinSanPhamDHDAL.Instance.GetListThongTinSanPhamByMaVanDon(MaVanDon);
            dgvThongTinSanPhamDH.Columns[2].DefaultCellStyle.Format = "N0";
            dgvThongTinSanPhamDH.Columns[4].DefaultCellStyle.Format = "N0";
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtThanhTien, "Tính tự động không cần nhập vào");
        }
        #endregion
        #region Xử lý DataGridView
        private void dgvThongTinSanPhamDH_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvThongTinSanPhamDH.RowCount + " sản phẩm";
        }

        private void dgvThongTinSanPhamDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThongTinSanPhamDH.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvThongTinSanPhamDH.SelectedRows[0];
                txtMaSP.Text = row.Cells["Mã sản phẩm"].Value.ToString();
                txtTenSP.Text = row.Cells["Tên sản phẩm"].Value.ToString();
                numGiaSP.Value = Convert.ToInt32(row.Cells["Giá"].Value);
                numSoLuong.Value = Convert.ToInt32(row.Cells["Số lượng"].Value);
                txtThanhTien.Text = row.Cells["Thành tiền"].Value.ToString();
            }
        }
        #endregion
        #region Thêm, cập nhật và xoá thông tin sản phẩm của đơn hàng
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ThongTinSanPhamDHDAL.Instance.AddThongTinSanPhamDH(txtTenSP.Text, (double)numGiaSP.Value, (int)numSoLuong.Value, MaVanDon))
                MessageBox.Show("Thêm sản phẩm mới thành công", "Quản lý sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Thêm sản phẩm mới thất bại", "Quản lý sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProductManagement_Load(null, new EventArgs());
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ThongTinSanPhamDHDAL.Instance.UpdateThongTinSanPhamDH(txtMaSP.Text, txtTenSP.Text, (double)numGiaSP.Value, (int)numSoLuong.Value, MaVanDon))
                MessageBox.Show("Cập nhật sản phẩm mới thành công", "Quản lý sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Cập nhật sản phẩm mới thất bại", "Quản lý sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProductManagement_Load(null, new EventArgs());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ThongTinSanPhamDHDAL.Instance.DeleteThongTinSanPhamDH(txtMaSP.Text, MaVanDon))
                MessageBox.Show("Xoá sản phẩm mới thành công", "Quản lý sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Xoá sản phẩm mới thất bại", "Quản lý sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProductManagement_Load(null, new EventArgs());
        }
        #endregion
        #region Tính tiền tự động của đơn hàng
        private void numGiaSP_ValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (numGiaSP.Value * numSoLuong.Value).ToString();
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (numGiaSP.Value * numSoLuong.Value).ToString();
        }
        #endregion
        #region Chuẩn bị thêm mới
        private void btnNewAdd_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            numGiaSP.Value = 0;
            numSoLuong.Value = 1;
            txtThanhTien.Text = "0";
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
