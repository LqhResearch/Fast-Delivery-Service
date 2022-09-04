using System;
using System.Data;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class SalaryOfEmployees : Form
    {
        public SalaryOfEmployees()
        {
            InitializeComponent();
        }

        private void SalaryOfEmployees_Load(object sender, EventArgs e)
        {
            chartLuongNhanVien.ChartAreas[0].AxisX.MajorGrid.Enabled = false; //Bỏ đường lưới dọc (đường lưới trên trục X)
            chartLuongNhanVien.ChartAreas[0].AxisX.Title = "Tên nhân viên";
            chartLuongNhanVien.ChartAreas[0].AxisY.Title = "Lương (đồng)";

            lblThangNamHT.Text = "Tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            DataTable dt = NV_GiaoHangDAL.Instance.LuongTatCaNhanVienTheoThang();
            foreach (DataRow row in dt.Rows)
                chartLuongNhanVien.Series[0].Points.AddXY(row[1].ToString(), Convert.ToInt32(row[2]));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
