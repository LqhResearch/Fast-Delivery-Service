using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class ShowDonHang : Form
    {
        public ShowDonHang()
        {
            InitializeComponent();
        }

        private void ShowDonHang_Load(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = DonHangDAL.Instance.GetListDonHang();
            dgvDonHang.Columns[1].DefaultCellStyle.Format = "N0";
            dgvDonHang.Columns[2].DefaultCellStyle.Format = "N0";
            dgvDonHang.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDonHang.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDonHang.Columns[11].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss";
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnRefresh, "Tải lại danh sách đơn hàng");
            toolTip.SetToolTip(txtSearch, "Nhấn enter để tìm kiếm");
        }

        #region Event tạo chữ chìm trong textbox tìm kiếm
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Mã vận đơn";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Mã vận đơn")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = DonHangDAL.Instance.GetListDonHang();
        }

        private void btnInDH_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count == 1)
            {
                btnInDH.Visible = true;
                string maVanDon = dgvDonHang.SelectedRows[0].Cells[0].Value.ToString();
                DataTable dt = DonHangDAL.Instance.PrinterDONHANG(maVanDon);

                GoodsDeliveryPaperReport report = new GoodsDeliveryPaperReport();
                report.SetDataSource(dt);

                CrystalReportViewer viewer = new CrystalReportViewer();
                viewer.crvInBaoCao.ReportSource = report;
                viewer.ShowDialog();
            }
            else btnInDH.Visible = false;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dgvDonHang.DataSource = DonHangDAL.Instance.GetDonHangByMaVanDon(txtSearch.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
