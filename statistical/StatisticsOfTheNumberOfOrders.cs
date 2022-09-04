using System;
using System.Data;
using System.Windows.Forms;
namespace HeThongQLDVGiaoHangNhanh
{
    public partial class StatisticsOfTheNumberOfOrders : Form
    {
        public StatisticsOfTheNumberOfOrders()
        {
            InitializeComponent();
        }

        private void StatisticsOfTheNumberOfOrders_Load(object sender, EventArgs e)
        {
            chartTheoNam.ChartAreas[0].AxisX.MajorGrid.Enabled = false; //Bỏ đường lưới dọc (đường lưới trên trục X)
            chartTheoNam.ChartAreas[0].AxisX.Maximum = 13;
            chartTheoNam.ChartAreas[0].AxisX.Title = "Tháng trong năm";
            chartTheoNam.ChartAreas[0].AxisY.Title = "Số lượng đơn hàng";
            numNam.Value = DateTime.Now.Year;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DataTable dt = DonHangDAL.Instance.ThongKeDonHangTheoNam((int)numNam.Value);
            chartTheoNam.Series["GiaoThanhCong"].Points.Clear();
            chartTheoNam.Series["BiHoanTra"].Points.Clear();
            chartTheoNam.Series["DamNhan"].Points.Clear();

            for (int i = 1; i <= 12; i++)
            {
                chartTheoNam.Series["GiaoThanhCong"].Points.AddXY(i, (int)dt.Rows[i - 1][1]);
                chartTheoNam.Series["GiaoThanhCong"].Points[i - 1].ToolTip = dt.Rows[i - 1][1] + " đơn hàng";
                chartTheoNam.Series["BiHoanTra"].Points.AddXY(i, (int)dt.Rows[i - 1][2]);
                chartTheoNam.Series["BiHoanTra"].Points[i - 1].ToolTip = dt.Rows[i - 1][2] + " đơn hàng";
                chartTheoNam.Series["DamNhan"].Points.AddXY(i, (int)dt.Rows[i - 1][3]);
                chartTheoNam.Series["DamNhan"].Points[i - 1].ToolTip = dt.Rows[i - 1][3] + " đơn hàng";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
