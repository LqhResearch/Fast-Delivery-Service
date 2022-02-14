
namespace HeThongQLDVGiaoHangNhanh
{
    partial class SearchCustomersAndShippers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomersAndShippers));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTimKiem = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblLoaiTimKiem = new System.Windows.Forms.Label();
            this.cboLoaiTimKiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblThuocTinh = new System.Windows.Forms.Label();
            this.cboThuocTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(182)))), ((int)(((byte)(152)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(867, 46);
            this.pnlTitle.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderRadius = 3;
            this.btnTimKiem.CheckedState.Parent = this.btnTimKiem;
            this.btnTimKiem.CustomImages.Parent = this.btnTimKiem;
            this.btnTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.HoverState.Parent = this.btnTimKiem;
            this.btnTimKiem.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.search;
            this.btnTimKiem.Location = new System.Drawing.Point(738, 67);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShadowDecoration.Parent = this.btnTimKiem;
            this.btnTimKiem.Size = new System.Drawing.Size(117, 36);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 3;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FillColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.Home;
            this.btnBack.Location = new System.Drawing.Point(12, 67);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(117, 36);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Trở về";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTimKiem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTimKiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTimKiem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTimKiem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimKiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTimKiem.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimKiem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTimKiem.EnableHeadersVisualStyles = false;
            this.dgvTimKiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTimKiem.Location = new System.Drawing.Point(12, 162);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.ReadOnly = true;
            this.dgvTimKiem.RowHeadersVisible = false;
            this.dgvTimKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimKiem.Size = new System.Drawing.Size(843, 331);
            this.dgvTimKiem.TabIndex = 5;
            this.dgvTimKiem.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvTimKiem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTimKiem.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTimKiem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTimKiem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTimKiem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTimKiem.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTimKiem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTimKiem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTimKiem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTimKiem.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTimKiem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTimKiem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTimKiem.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvTimKiem.ThemeStyle.ReadOnly = true;
            this.dgvTimKiem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTimKiem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTimKiem.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTimKiem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTimKiem.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTimKiem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTimKiem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTimKiem.DataSourceChanged += new System.EventHandler(this.dgvTimKiem_DataSourceChanged);
            // 
            // lblLoaiTimKiem
            // 
            this.lblLoaiTimKiem.AutoSize = true;
            this.lblLoaiTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiTimKiem.Location = new System.Drawing.Point(212, 77);
            this.lblLoaiTimKiem.Name = "lblLoaiTimKiem";
            this.lblLoaiTimKiem.Size = new System.Drawing.Size(92, 16);
            this.lblLoaiTimKiem.TabIndex = 1;
            this.lblLoaiTimKiem.Text = "Loại tìm kiếm: ";
            // 
            // cboLoaiTimKiem
            // 
            this.cboLoaiTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiTimKiem.BorderRadius = 3;
            this.cboLoaiTimKiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiTimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.cboLoaiTimKiem.FocusedState.Parent = this.cboLoaiTimKiem;
            this.cboLoaiTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoaiTimKiem.FormattingEnabled = true;
            this.cboLoaiTimKiem.HoverState.Parent = this.cboLoaiTimKiem;
            this.cboLoaiTimKiem.ItemHeight = 30;
            this.cboLoaiTimKiem.Items.AddRange(new object[] {
            "Khách hàng gửi",
            "Khách hàng nhận",
            "Nhân viên giao hàng"});
            this.cboLoaiTimKiem.ItemsAppearance.Parent = this.cboLoaiTimKiem;
            this.cboLoaiTimKiem.Location = new System.Drawing.Point(310, 67);
            this.cboLoaiTimKiem.Name = "cboLoaiTimKiem";
            this.cboLoaiTimKiem.ShadowDecoration.Parent = this.cboLoaiTimKiem;
            this.cboLoaiTimKiem.Size = new System.Drawing.Size(169, 36);
            this.cboLoaiTimKiem.TabIndex = 1;
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pnlTitle;
            // 
            // lblThuocTinh
            // 
            this.lblThuocTinh.AutoSize = true;
            this.lblThuocTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuocTinh.Location = new System.Drawing.Point(485, 77);
            this.lblThuocTinh.Name = "lblThuocTinh";
            this.lblThuocTinh.Size = new System.Drawing.Size(75, 16);
            this.lblThuocTinh.TabIndex = 2;
            this.lblThuocTinh.Text = "Thuộc tính: ";
            // 
            // cboThuocTinh
            // 
            this.cboThuocTinh.BackColor = System.Drawing.Color.Transparent;
            this.cboThuocTinh.BorderRadius = 3;
            this.cboThuocTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThuocTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuocTinh.FocusedColor = System.Drawing.Color.Empty;
            this.cboThuocTinh.FocusedState.Parent = this.cboThuocTinh;
            this.cboThuocTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThuocTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboThuocTinh.FormattingEnabled = true;
            this.cboThuocTinh.HoverState.Parent = this.cboThuocTinh;
            this.cboThuocTinh.ItemHeight = 30;
            this.cboThuocTinh.Items.AddRange(new object[] {
            "Căn cước công dân",
            "Số điện thoại"});
            this.cboThuocTinh.ItemsAppearance.Parent = this.cboThuocTinh;
            this.cboThuocTinh.Location = new System.Drawing.Point(566, 67);
            this.cboThuocTinh.Name = "cboThuocTinh";
            this.cboThuocTinh.ShadowDecoration.Parent = this.cboThuocTinh;
            this.cboThuocTinh.Size = new System.Drawing.Size(166, 36);
            this.cboThuocTinh.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(182)))), ((int)(((byte)(152)))));
            this.txtSearch.BorderRadius = 3;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.Location = new System.Drawing.Point(215, 110);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(398, 45);
            this.txtSearch.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(228, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(411, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tìm kiếm nhân viên giao hàng và khách hàng";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 496);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "0 đơn hàng";
            // 
            // SearchCustomersAndShippers
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(867, 520);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cboThuocTinh);
            this.Controls.Add(this.cboLoaiTimKiem);
            this.Controls.Add(this.lblThuocTinh);
            this.Controls.Add(this.dgvTimKiem);
            this.Controls.Add(this.lblLoaiTimKiem);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchCustomersAndShippers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.SearchCustomersAndShippers_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTimKiem;
        private System.Windows.Forms.Label lblLoaiTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiTimKiem;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.Label lblThuocTinh;
        private Guna.UI2.WinForms.Guna2ComboBox cboThuocTinh;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;
    }
}