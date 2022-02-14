
namespace HeThongQLDVGiaoHangNhanh
{
    partial class OrderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagement));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.dgvDonHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblMaVanDon = new System.Windows.Forms.Label();
            this.txtMaVanDon = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTongDonHang = new System.Windows.Forms.Label();
            this.lblPhiVanChuyen = new System.Windows.Forms.Label();
            this.numPhiVanChuyen = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.dtpNgayNhapKho = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayNhapKho = new System.Windows.Forms.Label();
            this.lblNgayGui = new System.Windows.Forms.Label();
            this.dtpNgayGui = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gbxTrangThaiDH = new System.Windows.Forms.GroupBox();
            this.rdbTonKho = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbHoanTra = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbGiaoThanhCong = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rtxtNguyenNhanHoanTra = new System.Windows.Forms.RichTextBox();
            this.lblNguyenNhanHoanTra = new System.Windows.Forms.Label();
            this.cboCCCD_KHG = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCCCD_KHG = new System.Windows.Forms.Label();
            this.lblCCCD_KHN = new System.Windows.Forms.Label();
            this.cboCCCD_KHN = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCCCD_NV = new System.Windows.Forms.Label();
            this.cboCCCD_NV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnQLNVGiaoHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLKHNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLKHGui = new Guna.UI2.WinForms.Guna2Button();
            this.txtTongDonHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnTTDonHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiVanChuyen)).BeginInit();
            this.gbxTrangThaiDH.SuspendLayout();
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
            this.pnlTitle.Size = new System.Drawing.Size(974, 46);
            this.pnlTitle.TabIndex = 0;
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDonHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDonHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDonHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDonHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonHang.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonHang.EnableHeadersVisualStyles = false;
            this.dgvDonHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonHang.Location = new System.Drawing.Point(23, 54);
            this.dgvDonHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.RowHeadersVisible = false;
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.Size = new System.Drawing.Size(591, 488);
            this.dgvDonHang.TabIndex = 17;
            this.dgvDonHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDonHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDonHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDonHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDonHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDonHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDonHang.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvDonHang.ThemeStyle.ReadOnly = true;
            this.dgvDonHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDonHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDonHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDonHang.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDonHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDonHang.DataSourceChanged += new System.EventHandler(this.dgvDonHang_DataSourceChanged);
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            // 
            // lblMaVanDon
            // 
            this.lblMaVanDon.AutoSize = true;
            this.lblMaVanDon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaVanDon.Location = new System.Drawing.Point(622, 61);
            this.lblMaVanDon.Name = "lblMaVanDon";
            this.lblMaVanDon.Size = new System.Drawing.Size(85, 17);
            this.lblMaVanDon.TabIndex = 2;
            this.lblMaVanDon.Text = "Mã vận đơn: ";
            // 
            // txtMaVanDon
            // 
            this.txtMaVanDon.BorderRadius = 3;
            this.txtMaVanDon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaVanDon.DefaultText = "";
            this.txtMaVanDon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaVanDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaVanDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaVanDon.DisabledState.Parent = this.txtMaVanDon;
            this.txtMaVanDon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaVanDon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaVanDon.FocusedState.Parent = this.txtMaVanDon;
            this.txtMaVanDon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVanDon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaVanDon.HoverState.Parent = this.txtMaVanDon;
            this.txtMaVanDon.Location = new System.Drawing.Point(747, 54);
            this.txtMaVanDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaVanDon.Name = "txtMaVanDon";
            this.txtMaVanDon.PasswordChar = '\0';
            this.txtMaVanDon.PlaceholderText = "";
            this.txtMaVanDon.ReadOnly = true;
            this.txtMaVanDon.SelectedText = "";
            this.txtMaVanDon.ShadowDecoration.Parent = this.txtMaVanDon;
            this.txtMaVanDon.Size = new System.Drawing.Size(215, 31);
            this.txtMaVanDon.TabIndex = 0;
            // 
            // lblTongDonHang
            // 
            this.lblTongDonHang.AutoSize = true;
            this.lblTongDonHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDonHang.Location = new System.Drawing.Point(622, 100);
            this.lblTongDonHang.Name = "lblTongDonHang";
            this.lblTongDonHang.Size = new System.Drawing.Size(105, 17);
            this.lblTongDonHang.TabIndex = 2;
            this.lblTongDonHang.Text = "Tổng đơn hàng: ";
            // 
            // lblPhiVanChuyen
            // 
            this.lblPhiVanChuyen.AutoSize = true;
            this.lblPhiVanChuyen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhiVanChuyen.Location = new System.Drawing.Point(622, 139);
            this.lblPhiVanChuyen.Name = "lblPhiVanChuyen";
            this.lblPhiVanChuyen.Size = new System.Drawing.Size(100, 17);
            this.lblPhiVanChuyen.TabIndex = 2;
            this.lblPhiVanChuyen.Text = "Phí vận chuyển: ";
            // 
            // numPhiVanChuyen
            // 
            this.numPhiVanChuyen.BackColor = System.Drawing.Color.Transparent;
            this.numPhiVanChuyen.BorderRadius = 3;
            this.numPhiVanChuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numPhiVanChuyen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numPhiVanChuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numPhiVanChuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numPhiVanChuyen.DisabledState.Parent = this.numPhiVanChuyen;
            this.numPhiVanChuyen.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numPhiVanChuyen.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numPhiVanChuyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numPhiVanChuyen.FocusedState.Parent = this.numPhiVanChuyen;
            this.numPhiVanChuyen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPhiVanChuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numPhiVanChuyen.Location = new System.Drawing.Point(747, 132);
            this.numPhiVanChuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPhiVanChuyen.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPhiVanChuyen.Name = "numPhiVanChuyen";
            this.numPhiVanChuyen.ShadowDecoration.Parent = this.numPhiVanChuyen;
            this.numPhiVanChuyen.Size = new System.Drawing.Size(215, 31);
            this.numPhiVanChuyen.TabIndex = 2;
            this.numPhiVanChuyen.ThousandsSeparator = true;
            this.numPhiVanChuyen.Value = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            // 
            // dtpNgayNhapKho
            // 
            this.dtpNgayNhapKho.BorderRadius = 3;
            this.dtpNgayNhapKho.CheckedState.Parent = this.dtpNgayNhapKho;
            this.dtpNgayNhapKho.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhapKho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtpNgayNhapKho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhapKho.ForeColor = System.Drawing.Color.White;
            this.dtpNgayNhapKho.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhapKho.HoverState.Parent = this.dtpNgayNhapKho;
            this.dtpNgayNhapKho.Location = new System.Drawing.Point(747, 171);
            this.dtpNgayNhapKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayNhapKho.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayNhapKho.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayNhapKho.Name = "dtpNgayNhapKho";
            this.dtpNgayNhapKho.ShadowDecoration.Parent = this.dtpNgayNhapKho;
            this.dtpNgayNhapKho.Size = new System.Drawing.Size(215, 31);
            this.dtpNgayNhapKho.TabIndex = 3;
            this.dtpNgayNhapKho.Value = new System.DateTime(2021, 5, 12, 0, 0, 0, 0);
            // 
            // lblNgayNhapKho
            // 
            this.lblNgayNhapKho.AutoSize = true;
            this.lblNgayNhapKho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhapKho.Location = new System.Drawing.Point(622, 178);
            this.lblNgayNhapKho.Name = "lblNgayNhapKho";
            this.lblNgayNhapKho.Size = new System.Drawing.Size(104, 17);
            this.lblNgayNhapKho.TabIndex = 2;
            this.lblNgayNhapKho.Text = "Ngày nhập kho: ";
            // 
            // lblNgayGui
            // 
            this.lblNgayGui.AutoSize = true;
            this.lblNgayGui.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayGui.Location = new System.Drawing.Point(622, 385);
            this.lblNgayGui.Name = "lblNgayGui";
            this.lblNgayGui.Size = new System.Drawing.Size(102, 17);
            this.lblNgayGui.TabIndex = 2;
            this.lblNgayGui.Text = "Ngày gửi hàng: ";
            // 
            // dtpNgayGui
            // 
            this.dtpNgayGui.BorderRadius = 3;
            this.dtpNgayGui.CheckedState.Parent = this.dtpNgayGui;
            this.dtpNgayGui.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayGui.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtpNgayGui.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayGui.ForeColor = System.Drawing.Color.White;
            this.dtpNgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGui.HoverState.Parent = this.dtpNgayGui;
            this.dtpNgayGui.Location = new System.Drawing.Point(747, 378);
            this.dtpNgayGui.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayGui.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayGui.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayGui.Name = "dtpNgayGui";
            this.dtpNgayGui.ShadowDecoration.Parent = this.dtpNgayGui;
            this.dtpNgayGui.Size = new System.Drawing.Size(215, 31);
            this.dtpNgayGui.TabIndex = 5;
            this.dtpNgayGui.Value = new System.DateTime(2021, 5, 12, 0, 0, 0, 0);
            // 
            // gbxTrangThaiDH
            // 
            this.gbxTrangThaiDH.Controls.Add(this.rdbTonKho);
            this.gbxTrangThaiDH.Controls.Add(this.rdbHoanTra);
            this.gbxTrangThaiDH.Controls.Add(this.rdbGiaoThanhCong);
            this.gbxTrangThaiDH.Controls.Add(this.rtxtNguyenNhanHoanTra);
            this.gbxTrangThaiDH.Controls.Add(this.lblNguyenNhanHoanTra);
            this.gbxTrangThaiDH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTrangThaiDH.Location = new System.Drawing.Point(623, 210);
            this.gbxTrangThaiDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTrangThaiDH.Name = "gbxTrangThaiDH";
            this.gbxTrangThaiDH.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTrangThaiDH.Size = new System.Drawing.Size(339, 160);
            this.gbxTrangThaiDH.TabIndex = 4;
            this.gbxTrangThaiDH.TabStop = false;
            this.gbxTrangThaiDH.Text = "Trạng thái đơn hàng";
            // 
            // rdbTonKho
            // 
            this.rdbTonKho.AutoSize = true;
            this.rdbTonKho.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbTonKho.CheckedState.BorderThickness = 0;
            this.rdbTonKho.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbTonKho.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbTonKho.CheckedState.InnerOffset = -4;
            this.rdbTonKho.Location = new System.Drawing.Point(10, 25);
            this.rdbTonKho.Name = "rdbTonKho";
            this.rdbTonKho.Size = new System.Drawing.Size(73, 21);
            this.rdbTonKho.TabIndex = 0;
            this.rdbTonKho.TabStop = true;
            this.rdbTonKho.Text = "Tồn kho";
            this.rdbTonKho.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbTonKho.UncheckedState.BorderThickness = 2;
            this.rdbTonKho.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbTonKho.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbTonKho.UseVisualStyleBackColor = true;
            this.rdbTonKho.CheckedChanged += new System.EventHandler(this.rdbTonKho_CheckedChanged);
            // 
            // rdbHoanTra
            // 
            this.rdbHoanTra.AutoSize = true;
            this.rdbHoanTra.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbHoanTra.CheckedState.BorderThickness = 0;
            this.rdbHoanTra.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbHoanTra.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbHoanTra.CheckedState.InnerOffset = -4;
            this.rdbHoanTra.Location = new System.Drawing.Point(256, 25);
            this.rdbHoanTra.Name = "rdbHoanTra";
            this.rdbHoanTra.Size = new System.Drawing.Size(77, 21);
            this.rdbHoanTra.TabIndex = 2;
            this.rdbHoanTra.TabStop = true;
            this.rdbHoanTra.Text = "Hoàn trả";
            this.rdbHoanTra.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbHoanTra.UncheckedState.BorderThickness = 2;
            this.rdbHoanTra.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbHoanTra.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbHoanTra.UseVisualStyleBackColor = true;
            this.rdbHoanTra.CheckedChanged += new System.EventHandler(this.rdbHoanTra_CheckedChanged);
            // 
            // rdbGiaoThanhCong
            // 
            this.rdbGiaoThanhCong.AutoSize = true;
            this.rdbGiaoThanhCong.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbGiaoThanhCong.CheckedState.BorderThickness = 0;
            this.rdbGiaoThanhCong.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbGiaoThanhCong.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbGiaoThanhCong.CheckedState.InnerOffset = -4;
            this.rdbGiaoThanhCong.Location = new System.Drawing.Point(115, 25);
            this.rdbGiaoThanhCong.Name = "rdbGiaoThanhCong";
            this.rdbGiaoThanhCong.Size = new System.Drawing.Size(122, 21);
            this.rdbGiaoThanhCong.TabIndex = 1;
            this.rdbGiaoThanhCong.TabStop = true;
            this.rdbGiaoThanhCong.Text = "Giao thành công";
            this.rdbGiaoThanhCong.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbGiaoThanhCong.UncheckedState.BorderThickness = 2;
            this.rdbGiaoThanhCong.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbGiaoThanhCong.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbGiaoThanhCong.UseVisualStyleBackColor = true;
            // 
            // rtxtNguyenNhanHoanTra
            // 
            this.rtxtNguyenNhanHoanTra.Location = new System.Drawing.Point(100, 67);
            this.rtxtNguyenNhanHoanTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtNguyenNhanHoanTra.Name = "rtxtNguyenNhanHoanTra";
            this.rtxtNguyenNhanHoanTra.Size = new System.Drawing.Size(233, 84);
            this.rtxtNguyenNhanHoanTra.TabIndex = 8;
            this.rtxtNguyenNhanHoanTra.Text = "";
            // 
            // lblNguyenNhanHoanTra
            // 
            this.lblNguyenNhanHoanTra.Location = new System.Drawing.Point(7, 67);
            this.lblNguyenNhanHoanTra.Name = "lblNguyenNhanHoanTra";
            this.lblNguyenNhanHoanTra.Size = new System.Drawing.Size(98, 35);
            this.lblNguyenNhanHoanTra.TabIndex = 7;
            this.lblNguyenNhanHoanTra.Text = "Nguyên nhân hoàn trả: ";
            // 
            // cboCCCD_KHG
            // 
            this.cboCCCD_KHG.BackColor = System.Drawing.Color.Transparent;
            this.cboCCCD_KHG.BorderRadius = 3;
            this.cboCCCD_KHG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCCCD_KHG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCCCD_KHG.FocusedColor = System.Drawing.Color.Empty;
            this.cboCCCD_KHG.FocusedState.Parent = this.cboCCCD_KHG;
            this.cboCCCD_KHG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCCCD_KHG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCCCD_KHG.FormattingEnabled = true;
            this.cboCCCD_KHG.HoverState.Parent = this.cboCCCD_KHG;
            this.cboCCCD_KHG.ItemHeight = 30;
            this.cboCCCD_KHG.ItemsAppearance.Parent = this.cboCCCD_KHG;
            this.cboCCCD_KHG.Location = new System.Drawing.Point(747, 417);
            this.cboCCCD_KHG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCCCD_KHG.Name = "cboCCCD_KHG";
            this.cboCCCD_KHG.ShadowDecoration.Parent = this.cboCCCD_KHG;
            this.cboCCCD_KHG.Size = new System.Drawing.Size(173, 36);
            this.cboCCCD_KHG.TabIndex = 6;
            // 
            // lblCCCD_KHG
            // 
            this.lblCCCD_KHG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD_KHG.Location = new System.Drawing.Point(622, 416);
            this.lblCCCD_KHG.Name = "lblCCCD_KHG";
            this.lblCCCD_KHG.Size = new System.Drawing.Size(113, 38);
            this.lblCCCD_KHG.TabIndex = 2;
            this.lblCCCD_KHG.Text = "Số điện thoại KH gửi: ";
            // 
            // lblCCCD_KHN
            // 
            this.lblCCCD_KHN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD_KHN.Location = new System.Drawing.Point(622, 460);
            this.lblCCCD_KHN.Name = "lblCCCD_KHN";
            this.lblCCCD_KHN.Size = new System.Drawing.Size(113, 38);
            this.lblCCCD_KHN.TabIndex = 2;
            this.lblCCCD_KHN.Text = "Số điện thoại KH nhận: ";
            // 
            // cboCCCD_KHN
            // 
            this.cboCCCD_KHN.BackColor = System.Drawing.Color.Transparent;
            this.cboCCCD_KHN.BorderRadius = 3;
            this.cboCCCD_KHN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCCCD_KHN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCCCD_KHN.FocusedColor = System.Drawing.Color.Empty;
            this.cboCCCD_KHN.FocusedState.Parent = this.cboCCCD_KHN;
            this.cboCCCD_KHN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCCCD_KHN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCCCD_KHN.FormattingEnabled = true;
            this.cboCCCD_KHN.HoverState.Parent = this.cboCCCD_KHN;
            this.cboCCCD_KHN.ItemHeight = 30;
            this.cboCCCD_KHN.ItemsAppearance.Parent = this.cboCCCD_KHN;
            this.cboCCCD_KHN.Location = new System.Drawing.Point(747, 461);
            this.cboCCCD_KHN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCCCD_KHN.Name = "cboCCCD_KHN";
            this.cboCCCD_KHN.ShadowDecoration.Parent = this.cboCCCD_KHN;
            this.cboCCCD_KHN.Size = new System.Drawing.Size(173, 36);
            this.cboCCCD_KHN.TabIndex = 8;
            // 
            // lblCCCD_NV
            // 
            this.lblCCCD_NV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD_NV.Location = new System.Drawing.Point(622, 504);
            this.lblCCCD_NV.Name = "lblCCCD_NV";
            this.lblCCCD_NV.Size = new System.Drawing.Size(113, 38);
            this.lblCCCD_NV.TabIndex = 2;
            this.lblCCCD_NV.Text = "CCCD nhân viên giao hàng: ";
            // 
            // cboCCCD_NV
            // 
            this.cboCCCD_NV.BackColor = System.Drawing.Color.Transparent;
            this.cboCCCD_NV.BorderRadius = 3;
            this.cboCCCD_NV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCCCD_NV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCCCD_NV.FocusedColor = System.Drawing.Color.Empty;
            this.cboCCCD_NV.FocusedState.Parent = this.cboCCCD_NV;
            this.cboCCCD_NV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCCCD_NV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboCCCD_NV.FormattingEnabled = true;
            this.cboCCCD_NV.HoverState.Parent = this.cboCCCD_NV;
            this.cboCCCD_NV.ItemHeight = 30;
            this.cboCCCD_NV.ItemsAppearance.Parent = this.cboCCCD_NV;
            this.cboCCCD_NV.Location = new System.Drawing.Point(747, 505);
            this.cboCCCD_NV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCCCD_NV.Name = "cboCCCD_NV";
            this.cboCCCD_NV.ShadowDecoration.Parent = this.cboCCCD_NV;
            this.cboCCCD_NV.Size = new System.Drawing.Size(173, 36);
            this.cboCCCD_NV.TabIndex = 10;
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pnlTitle;
            // 
            // btnQLNVGiaoHang
            // 
            this.btnQLNVGiaoHang.BorderRadius = 3;
            this.btnQLNVGiaoHang.CheckedState.Parent = this.btnQLNVGiaoHang;
            this.btnQLNVGiaoHang.CustomImages.Parent = this.btnQLNVGiaoHang;
            this.btnQLNVGiaoHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(182)))), ((int)(((byte)(152)))));
            this.btnQLNVGiaoHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNVGiaoHang.ForeColor = System.Drawing.Color.White;
            this.btnQLNVGiaoHang.HoverState.Parent = this.btnQLNVGiaoHang;
            this.btnQLNVGiaoHang.Location = new System.Drawing.Point(926, 505);
            this.btnQLNVGiaoHang.Name = "btnQLNVGiaoHang";
            this.btnQLNVGiaoHang.ShadowDecoration.Parent = this.btnQLNVGiaoHang;
            this.btnQLNVGiaoHang.Size = new System.Drawing.Size(36, 36);
            this.btnQLNVGiaoHang.TabIndex = 11;
            this.btnQLNVGiaoHang.Text = "...";
            this.btnQLNVGiaoHang.Click += new System.EventHandler(this.btnQLNVGiaoHang_Click);
            // 
            // btnQLKHNhan
            // 
            this.btnQLKHNhan.BorderRadius = 3;
            this.btnQLKHNhan.CheckedState.Parent = this.btnQLKHNhan;
            this.btnQLKHNhan.CustomImages.Parent = this.btnQLKHNhan;
            this.btnQLKHNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(182)))), ((int)(((byte)(152)))));
            this.btnQLKHNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKHNhan.ForeColor = System.Drawing.Color.White;
            this.btnQLKHNhan.HoverState.Parent = this.btnQLKHNhan;
            this.btnQLKHNhan.Location = new System.Drawing.Point(926, 461);
            this.btnQLKHNhan.Name = "btnQLKHNhan";
            this.btnQLKHNhan.ShadowDecoration.Parent = this.btnQLKHNhan;
            this.btnQLKHNhan.Size = new System.Drawing.Size(36, 36);
            this.btnQLKHNhan.TabIndex = 9;
            this.btnQLKHNhan.Text = "...";
            this.btnQLKHNhan.Click += new System.EventHandler(this.btnQLKHNhan_Click);
            // 
            // btnQLKHGui
            // 
            this.btnQLKHGui.BorderRadius = 3;
            this.btnQLKHGui.CheckedState.Parent = this.btnQLKHGui;
            this.btnQLKHGui.CustomImages.Parent = this.btnQLKHGui;
            this.btnQLKHGui.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(182)))), ((int)(((byte)(152)))));
            this.btnQLKHGui.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKHGui.ForeColor = System.Drawing.Color.White;
            this.btnQLKHGui.HoverState.Parent = this.btnQLKHGui;
            this.btnQLKHGui.Location = new System.Drawing.Point(926, 417);
            this.btnQLKHGui.Name = "btnQLKHGui";
            this.btnQLKHGui.ShadowDecoration.Parent = this.btnQLKHGui;
            this.btnQLKHGui.Size = new System.Drawing.Size(36, 36);
            this.btnQLKHGui.TabIndex = 7;
            this.btnQLKHGui.Text = "...";
            this.btnQLKHGui.Click += new System.EventHandler(this.btnQLKHGui_Click);
            // 
            // txtTongDonHang
            // 
            this.txtTongDonHang.BorderRadius = 3;
            this.txtTongDonHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongDonHang.DefaultText = "";
            this.txtTongDonHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongDonHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongDonHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongDonHang.DisabledState.Parent = this.txtTongDonHang;
            this.txtTongDonHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongDonHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongDonHang.FocusedState.Parent = this.txtTongDonHang;
            this.txtTongDonHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDonHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongDonHang.HoverState.Parent = this.txtTongDonHang;
            this.txtTongDonHang.Location = new System.Drawing.Point(747, 93);
            this.txtTongDonHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongDonHang.Name = "txtTongDonHang";
            this.txtTongDonHang.PasswordChar = '\0';
            this.txtTongDonHang.PlaceholderText = "";
            this.txtTongDonHang.ReadOnly = true;
            this.txtTongDonHang.SelectedText = "";
            this.txtTongDonHang.ShadowDecoration.Parent = this.txtTongDonHang;
            this.txtTongDonHang.Size = new System.Drawing.Size(215, 31);
            this.txtTongDonHang.TabIndex = 1;
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
            this.btnBack.Location = new System.Drawing.Point(845, 547);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(117, 39);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Trở về";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 3;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.Recycle_Bin;
            this.btnXoa.Location = new System.Drawing.Point(722, 547);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(117, 39);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BorderRadius = 3;
            this.btnCapNhat.CheckedState.Parent = this.btnCapNhat;
            this.btnCapNhat.CustomImages.Parent = this.btnCapNhat;
            this.btnCapNhat.FillColor = System.Drawing.Color.Lime;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.HoverState.Parent = this.btnCapNhat;
            this.btnCapNhat.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.Edit;
            this.btnCapNhat.Location = new System.Drawing.Point(599, 547);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ShadowDecoration.Parent = this.btnCapNhat;
            this.btnCapNhat.Size = new System.Drawing.Size(117, 39);
            this.btnCapNhat.TabIndex = 14;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTTDonHang
            // 
            this.btnTTDonHang.BorderRadius = 3;
            this.btnTTDonHang.CheckedState.Parent = this.btnTTDonHang;
            this.btnTTDonHang.CustomImages.Parent = this.btnTTDonHang;
            this.btnTTDonHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTTDonHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTDonHang.ForeColor = System.Drawing.Color.Black;
            this.btnTTDonHang.HoverState.Parent = this.btnTTDonHang;
            this.btnTTDonHang.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.List;
            this.btnTTDonHang.Location = new System.Drawing.Point(230, 547);
            this.btnTTDonHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTTDonHang.Name = "btnTTDonHang";
            this.btnTTDonHang.ShadowDecoration.Parent = this.btnTTDonHang;
            this.btnTTDonHang.Size = new System.Drawing.Size(117, 39);
            this.btnTTDonHang.TabIndex = 12;
            this.btnTTDonHang.Text = "Sản phẩm";
            this.btnTTDonHang.Click += new System.EventHandler(this.btnTTDonHang_Click);
            // 
            // btnNewAdd
            // 
            this.btnNewAdd.BorderRadius = 3;
            this.btnNewAdd.CheckedState.Parent = this.btnNewAdd;
            this.btnNewAdd.CustomImages.Parent = this.btnNewAdd;
            this.btnNewAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNewAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAdd.ForeColor = System.Drawing.Color.Black;
            this.btnNewAdd.HoverState.Parent = this.btnNewAdd;
            this.btnNewAdd.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.New_Add;
            this.btnNewAdd.Location = new System.Drawing.Point(353, 547);
            this.btnNewAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewAdd.Name = "btnNewAdd";
            this.btnNewAdd.ShadowDecoration.Parent = this.btnNewAdd;
            this.btnNewAdd.Size = new System.Drawing.Size(117, 39);
            this.btnNewAdd.TabIndex = 13;
            this.btnNewAdd.Text = "Tạo mới";
            this.btnNewAdd.Click += new System.EventHandler(this.btnNewAdd_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 3;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.Add;
            this.btnThem.Location = new System.Drawing.Point(476, 547);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(117, 39);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(402, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý đơn hàng";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 547);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 17);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "0 đơn hàng";
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(974, 599);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnQLKHGui);
            this.Controls.Add(this.btnQLKHNhan);
            this.Controls.Add(this.btnQLNVGiaoHang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTTDonHang);
            this.Controls.Add(this.btnNewAdd);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboCCCD_NV);
            this.Controls.Add(this.cboCCCD_KHN);
            this.Controls.Add(this.cboCCCD_KHG);
            this.Controls.Add(this.gbxTrangThaiDH);
            this.Controls.Add(this.dtpNgayGui);
            this.Controls.Add(this.lblCCCD_NV);
            this.Controls.Add(this.dtpNgayNhapKho);
            this.Controls.Add(this.lblCCCD_KHN);
            this.Controls.Add(this.numPhiVanChuyen);
            this.Controls.Add(this.lblCCCD_KHG);
            this.Controls.Add(this.lblNgayGui);
            this.Controls.Add(this.lblNgayNhapKho);
            this.Controls.Add(this.lblPhiVanChuyen);
            this.Controls.Add(this.lblTongDonHang);
            this.Controls.Add(this.txtTongDonHang);
            this.Controls.Add(this.txtMaVanDon);
            this.Controls.Add(this.lblMaVanDon);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đơn hàng";
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiVanChuyen)).EndInit();
            this.gbxTrangThaiDH.ResumeLayout(false);
            this.gbxTrangThaiDH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDonHang;
        private System.Windows.Forms.Label lblMaVanDon;
        private Guna.UI2.WinForms.Guna2TextBox txtMaVanDon;
        private System.Windows.Forms.Label lblTongDonHang;
        private System.Windows.Forms.Label lblPhiVanChuyen;
        private Guna.UI2.WinForms.Guna2NumericUpDown numPhiVanChuyen;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayNhapKho;
        private System.Windows.Forms.Label lblNgayNhapKho;
        private System.Windows.Forms.Label lblNgayGui;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayGui;
        private System.Windows.Forms.GroupBox gbxTrangThaiDH;
        private System.Windows.Forms.Label lblNguyenNhanHoanTra;
        private Guna.UI2.WinForms.Guna2ComboBox cboCCCD_KHG;
        private System.Windows.Forms.Label lblCCCD_KHG;
        private System.Windows.Forms.RichTextBox rtxtNguyenNhanHoanTra;
        private System.Windows.Forms.Label lblCCCD_KHN;
        private Guna.UI2.WinForms.Guna2ComboBox cboCCCD_KHN;
        private System.Windows.Forms.Label lblCCCD_NV;
        private Guna.UI2.WinForms.Guna2ComboBox cboCCCD_NV;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Button btnTTDonHang;
        private Guna.UI2.WinForms.Guna2RadioButton rdbHoanTra;
        private Guna.UI2.WinForms.Guna2RadioButton rdbGiaoThanhCong;
        private Guna.UI2.WinForms.Guna2RadioButton rdbTonKho;
        private Guna.UI2.WinForms.Guna2Button btnQLNVGiaoHang;
        private Guna.UI2.WinForms.Guna2Button btnQLKHNhan;
        private Guna.UI2.WinForms.Guna2Button btnQLKHGui;
        private Guna.UI2.WinForms.Guna2TextBox txtTongDonHang;
        private Guna.UI2.WinForms.Guna2Button btnNewAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;
    }
}