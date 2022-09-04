using System;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class OrderStatistics : Form
    {
        public OrderStatistics()
        {
            InitializeComponent();
        }

        private void HeaderTextDonHang()
        {
            dgvDonHang.Columns[0].HeaderText = "Mã vận đơn";
            dgvDonHang.Columns[1].HeaderText = "Tổng đơn hàng";
            dgvDonHang.Columns[2].HeaderText = "Phí vận chuyển";
            dgvDonHang.Columns[3].HeaderText = "Ngày nhập kho";
            dgvDonHang.Columns[4].HeaderText = "Ngày giao hàng";
            dgvDonHang.Columns[5].HeaderText = "Giao thành công";
            dgvDonHang.Columns[6].HeaderText = "Bị hoàn trả";
            dgvDonHang.Columns[7].HeaderText = "Nguyên nhân bị hoàn trả";
            dgvDonHang.Columns[8].HeaderText = "CCCD nhân viên giao hàng";
            dgvDonHang.Columns[9].HeaderText = "CCCD khách hàng gửi";
            dgvDonHang.Columns[10].HeaderText = "CCCD khách hàng nhận";
            dgvDonHang.Columns[11].HeaderText = "Ngày mua hàng";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderStatistics_Load(object sender, EventArgs e)
        {
            cboThang.Text = DateTime.Now.Month.ToString();
            numNam.Value = DateTime.Now.Year;
            cboLoaiThongKe.SelectedIndex = 0;
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            if (cboLoaiThongKe.SelectedIndex == 0)
                dgvDonHang.DataSource = DonHangDAL.Instance.DonHangGiaoThanhCong(Convert.ToInt32(cboThang.Text), (int)numNam.Value);
            else if (cboLoaiThongKe.SelectedIndex == 1)
                dgvDonHang.DataSource = DonHangDAL.Instance.DonHangHoanTra(Convert.ToInt32(cboThang.Text), (int)numNam.Value);
            else
                dgvDonHang.DataSource = DonHangDAL.Instance.DonHangTonKho(Convert.ToInt32(cboThang.Text), (int)numNam.Value);
            dgvDonHang.Columns[1].DefaultCellStyle.Format = "N0";
            dgvDonHang.Columns[2].DefaultCellStyle.Format = "N0";
            dgvDonHang.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDonHang.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDonHang.Columns[11].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss";
            HeaderTextDonHang();
        }

        private void dgvDonHang_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvDonHang.RowCount + " đơn hàng";
        }
    }
}
