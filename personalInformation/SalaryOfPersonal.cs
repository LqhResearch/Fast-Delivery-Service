using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class SalaryOfPersonal : Form
    {
        ToolTip toolTip = new ToolTip();

        public SalaryOfPersonal(string cccd)
        {
            InitializeComponent();
            CCCD_NV = cccd;
        }

        private string CCCD_NV { get; set; }
        private int Month { get; set; }
        private int Year { get; set; }

        private int DaysOfAD(int day, int month, int year)
        {
            if (month < 3)
            {
                year--;
                month += 12;
            }
            return 365 * year + year / 4 - year / 100 + year / 400 + (153 * month - 457) / 5 + day - 306;
        }

        private void Funcyion_SalaryOfPersonal()
        {
            fpnlCalendar.Controls.Clear();
            lblThangNamHT.Text = "Tháng " + Month + " năm " + Year;

            int firstMonth = DaysOfAD(1, Month, Year) % 7;
            DataTable dt = NV_GiaoHangDAL.Instance.LuongCaNhanNhanVienTheoThang(CCCD_NV);

            int day = 1;
            for (int i = 0; i < 42; i++)
            {
                if (firstMonth == 0)
                    day = i - firstMonth + 2 - 7;
                else
                    day = i - firstMonth + 2;
                Guna2Button button = new Guna2Button()
                {
                    Size = new Size(100, 100),
                    FillColor = Color.White,
                    ForeColor = Color.Black,
                    Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)))
                };

                if (day > 0 && day <= DateTime.DaysInMonth(Year, Month))
                {
                    button.Text = day.ToString();
                    if (Convert.ToInt32(dt.Rows[day - 1][3]) == 0)
                        button.FillColor = Color.White;
                    else if (Convert.ToInt32(dt.Rows[day - 1][1]) != 0)
                        button.FillColor = Color.Blue;
                    else
                        button.FillColor = Color.Red;

                    string tmp = "Ngày " + dt.Rows[day - 1][0] +
                                 "\nĐH đảm nhận là " + dt.Rows[day - 1][3] +
                                 "\nĐH giao thành công là " + dt.Rows[day - 1][1] +
                                 "\nĐH hoàn trả là " + dt.Rows[day - 1][2];
                    toolTip.SetToolTip(button, tmp);
                }
                fpnlCalendar.Controls.Add(button);
            }
        }

        private void SalaryOfPersonal_Load(object sender, EventArgs e)
        {
            Month = DateTime.Now.Month;
            Year = DateTime.Now.Year;
            Funcyion_SalaryOfPersonal();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (Month == 1)
            {
                Month = 12;
                Year--;
            }
            else Month--;
            Funcyion_SalaryOfPersonal();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Month == 12)
            {
                Month = 1;
                Year++;
            }
            else Month++;
            Funcyion_SalaryOfPersonal();
        }
    }
}
