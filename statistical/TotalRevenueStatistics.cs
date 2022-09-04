using System;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class TotalRevenueStatistics : Form
    {
        public TotalRevenueStatistics()
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

        private void TotalRevenueStatistics_Load(object sender, EventArgs e)
        {
            cboThang.SelectedIndex = 0;
            cboThang.Text = DateTime.Now.Month.ToString();
            numNam.Value = DateTime.Now.Year;
        }

        private void dgvDonHang_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvDonHang.RowCount + " đơn hàng";
        }

        private int TongDHTonKho()
        {
            int count = 0;
            for (int i = 0; i < dgvDonHang.RowCount; i++)
                if (dgvDonHang.Rows[i].Cells["NgayGui"].Value.ToString() == "")
                    count++;
            return count;
        }

        private int TongDHGiaoThanhCong()
        {
            int count = 0;
            for (int i = 0; i < dgvDonHang.RowCount; i++)
                if (Convert.ToBoolean(dgvDonHang.Rows[i].Cells["GiaoThanhCong"].Value))
                    count++;
            return count;
        }

        private int TongDHHoanTra()
        {
            int count = 0;
            for (int i = 0; i < dgvDonHang.RowCount; i++)
                if (Convert.ToBoolean(dgvDonHang.Rows[i].Cells["HoanTra"].Value))
                    count++;
            return count;
        }

        private int TongDoanhThuTrongThang()
        {
            int money = 0;
            for (int i = 0; i < dgvDonHang.RowCount; i++)
                if (Convert.ToBoolean(dgvDonHang.Rows[i].Cells["GiaoThanhCong"].Value))
                    money += Convert.ToInt32(dgvDonHang.Rows[i].Cells["PhiVanChuyen"].Value);
            return money;
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = DonHangDAL.Instance.DonHangTheoThang(Convert.ToInt32(cboThang.Text), (int)numNam.Value);
            dgvDonHang.Columns[1].DefaultCellStyle.Format = "N0";
            dgvDonHang.Columns[2].DefaultCellStyle.Format = "N0";
            dgvDonHang.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDonHang.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDonHang.Columns[11].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss";

            HeaderTextDonHang();
            lblTongDHTonKho.Text = "Tổng đơn hàng tồn kho: "+ TongDHTonKho() + " đơn hàng";
            lblSoDHGiaoThanhCong.Text = "Tổng đơn hàng giao thành công: "+ TongDHGiaoThanhCong() + " đơn hàng";
            lblTongDHHoanTra.Text = "Tổng đơn hàng bị hoàn trả: "+ TongDHHoanTra() + " đơn hàng";
            lblTongDoanhThu.Text = "Tổng doanh thu: " + TongDoanhThuTrongThang() + " đồng";
        }
    }
}
