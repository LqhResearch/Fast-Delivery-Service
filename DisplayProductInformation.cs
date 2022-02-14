using System;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh.sqlQuery
{
    public partial class DisplayProductInformation : Form
    {
        public DisplayProductInformation(string maVanDon)
        {
            InitializeComponent();
            MaVanDon = maVanDon;
        }

        private string MaVanDon { get; set; }
        #region Tải dữ liệu mặc định
        private void DisplayProductInformation_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin sản phẩm của đơn hàng";
            lblMaVanDon.Text = "Đơn hàng: " + MaVanDon;
            dgvThongTinSanPham.DataSource = ThongTinSanPhamDHDAL.Instance.GetListThongTinSanPhamByMaVanDon(MaVanDon);
        }

        private void dgvThongTinSanPham_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvThongTinSanPham.RowCount + " sản phẩm";
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
