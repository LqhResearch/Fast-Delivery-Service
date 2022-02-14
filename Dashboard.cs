using HeThongQLDVGiaoHangNhanh.personalInformation;
using HeThongQLDVGiaoHangNhanh.sqlQuery;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class Dashboard : Form
    {
        public Dashboard(string username, string displayName, string access)
        {
            InitializeComponent();
            Username = username;
            DisplayName = displayName;
            Access = access;
        }

        private string Username { get; set; }
        private string DisplayName { get; set; }
        private string Access { get; set; }

        #region Tải dữ liệu mặc định
        private void Dashboard_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtSearch, "Nhấn enter để tìm kiếm");
            GrantAccessToFunctions();
            if (DisplayName != "")
                lblUsernameAvatar.Text = DisplayName;
            else
                lblUsernameAvatar.Text = Username;
        }
        #endregion
        #region Phân quyền chức năng của hệ thống
        private void GrantAccessToFunctions()
        {
            đơnHàngĐảmNhậnToolStripMenuItem.Visible = false;
            if (Access == "Nhân viên")
            {
                hệThốngQuảnLýToolStripMenuItem.Visible = false;
                thốngKếToolStripMenuItem.Visible = false;
                đơnHàngĐảmNhậnToolStripMenuItem.Visible = true;
                inToolStripMenuItem.Visible = false;
            }
            else if (Access == "Khách")
            {
                hệThốngQuảnLýToolStripMenuItem.Visible = false;
                thốngKếToolStripMenuItem.Visible = false;
                thôngTinCáNhânToolStripMenuItem.Visible = false;
                inToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Text = "Thoát";
            }
        }
        #endregion
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
        #region Xử lý DataGridView
        private void DefaultRichTextBox()
        {
            rtxtKhachHangGui.Text = "Căn cước công dân: \nHọ tên: \nSố điện thoại: \nĐịa chỉ: ";
            rtxtKhachHangNhan.Text = "Căn cước công dân: \nHọ tên: \nSố điện thoại: \nĐịa chỉ: ";
            rtxtNhanVienGiaoHang.Text = "Căn cước công dân: \nHọ tên: \nGiới tính: \nSố điện thoại: \nĐịa chỉ: ";
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count == 1)
            {
                DataGridViewRow data = dgvDonHang.SelectedRows[0];
                DataRow khg = KhachHangGuiDAL.Instance.GetKhachHangGuiBySDT(data.Cells["Số điện thoại KH gửi"].Value.ToString()).Rows[0];
                rtxtKhachHangGui.Text = "Số điện thoại: " + khg[0].ToString() +
                                        "\nHọ tên: " + khg[1].ToString() +
                                        "\nĐịa chỉ: " + khg[2].ToString();

                DataRow khn = KhachHangNhanDAL.Instance.GetKhachHangNhanBySDT(data.Cells["Số điện thoại KH nhận"].Value.ToString()).Rows[0];
                rtxtKhachHangNhan.Text = "Số điện thoại: " + khn[0].ToString() +
                                        "\nHọ tên: " + khn[1].ToString() +
                                        "\nĐịa chỉ: " + khn[2].ToString();

                DataRow ghn = NV_GiaoHangDAL.Instance.GetNVGiaoHangByCCCD_NV(data.Cells["CCCD nhân viên giao hàng"].Value.ToString()).Rows[0];
                rtxtNhanVienGiaoHang.Text = "Căn cước công dân: " + ghn[0].ToString() +
                                        "\nHọ tên: " + ghn[1].ToString() +
                                        "\nGiới tính: " + ghn[2].ToString() +
                                        "\nSố điện thoại: " + ghn[3].ToString() +
                                        "\nĐịa chỉ: " + ghn[4].ToString();
            }
        }

        private void dgvDonHang_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvDonHang.RowCount + " đơn hàng";
        }
        #endregion
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvDonHang.DataSource = DonHangDAL.Instance.GetDonHangByMaVanDon(txtSearch.Text);
                if (dgvDonHang.Rows.Count == 0)
                    MessageBox.Show("Không tìm thấy đơn hàng có mã vận đơn là " + txtSearch.Text + " trong hệ thống", "Hệ thống quản lý dịch vụ giao hàng nhanh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThongTinSanPham_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count > 0)
            {
                DisplayProductInformation dpi = new DisplayProductInformation(dgvDonHang.SelectedRows[0].Cells[0].Value.ToString());
                this.Hide();
                dpi.ShowDialog();
                this.Show();
            }
        }
        #region Chức năng hệ thống quản lý
        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderManagement order = new OrderManagement();
            this.Hide();
            order.ShowDialog();
            this.Show();
        }

        private void nhânViênGiaoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShipperManagement shipper = new ShipperManagement();
            this.Hide();
            shipper.ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerManagement customer = new CustomerManagement("Khách hàng gửi");
            this.Hide();
            customer.ShowDialog();
            this.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountManagement account = new AccountManagement(Username);
            this.Hide();
            account.ShowDialog();
            this.Show();
        }
        #endregion
        #region Chức năng thống kê
        private void đơnHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderStatistics orderStatistics = new OrderStatistics();
            this.Hide();
            orderStatistics.ShowDialog();
            this.Show();
        }

        private void tổngDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalRevenueStatistics totalRevenue = new TotalRevenueStatistics();
            this.Hide();
            totalRevenue.ShowDialog();
            this.Show();
        }

        private void sốLượngĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsOfTheNumberOfOrders statistics = new StatisticsOfTheNumberOfOrders();
            this.Hide();
            statistics.ShowDialog();
            this.Show();
        }

        private void lươngNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SalaryOfEmployees salary = new SalaryOfEmployees();
            this.Hide();
            salary.ShowDialog();
            this.Show();
        }
        #endregion
        #region Chức năng In
        private void phiếuGiaoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDonHang donHang = new ShowDonHang();
            this.Hide();
            donHang.ShowDialog();
            this.Show();
        }
        #endregion
        #region Chức năng thay đổi thông tin cá nhân
        private void đổiTênHiểnThịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDisplayName displayName = new ChangeDisplayName(Username);
            this.Hide();
            displayName.ShowDialog();
            string tmp = TaiKhoanDAL.Instance.GetTenHienThiByTenDangNhap(Username);
            if (tmp != "")
                lblUsernameAvatar.Text = tmp;
            this.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword password = new ChangePassword(Username);
            this.Hide();
            password.ShowDialog();
            this.Show();
        }

        private void đơnHàngĐảmNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryOfPersonal salary = new SalaryOfPersonal(Username);
            this.Hide();
            salary.ShowDialog();
            this.Show();
        }
        #endregion
        #region Chức năng tìm kiếm
        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCustomersAndShippers search = new SearchCustomersAndShippers();
            this.Hide();
            search.ShowDialog();
            this.Show();
        }
        #endregion
        #region Chức năng đăng xuất
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
