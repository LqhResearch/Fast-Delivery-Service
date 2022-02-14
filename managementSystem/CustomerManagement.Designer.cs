
namespace HeThongQLDVGiaoHangNhanh
{
    partial class CustomerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManagement));
            this.txtSdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblLoaiKhachHang = new System.Windows.Forms.Label();
            this.cboLoaiKhachHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.grbLoaiKhachHang = new System.Windows.Forms.GroupBox();
            this.rdbKhachHangNhan = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbKhachHangGui = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.dgvKhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnNewAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grbLoaiKhachHang.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSdt
            // 
            this.txtSdt.BorderRadius = 3;
            this.txtSdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdt.DefaultText = "";
            this.txtSdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdt.DisabledState.Parent = this.txtSdt;
            this.txtSdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdt.FocusedState.Parent = this.txtSdt;
            this.txtSdt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdt.HoverState.Parent = this.txtSdt;
            this.txtSdt.Location = new System.Drawing.Point(621, 120);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.PasswordChar = '\0';
            this.txtSdt.PlaceholderText = "";
            this.txtSdt.SelectedText = "";
            this.txtSdt.ShadowDecoration.Parent = this.txtSdt;
            this.txtSdt.Size = new System.Drawing.Size(212, 36);
            this.txtSdt.TabIndex = 3;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.Location = new System.Drawing.Point(476, 130);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(92, 17);
            this.lblSdt.TabIndex = 3;
            this.lblSdt.Text = "Số điện thoại: ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderRadius = 3;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.Parent = this.txtHoTen;
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.FocusedState.Parent = this.txtHoTen;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.HoverState.Parent = this.txtHoTen;
            this.txtHoTen.Location = new System.Drawing.Point(621, 162);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.ShadowDecoration.Parent = this.txtHoTen;
            this.txtHoTen.Size = new System.Drawing.Size(212, 36);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderRadius = 3;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.Parent = this.txtDiaChi;
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.FocusedState.Parent = this.txtDiaChi;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.HoverState.Parent = this.txtDiaChi;
            this.txtDiaChi.Location = new System.Drawing.Point(621, 206);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.ShadowDecoration.Parent = this.txtDiaChi;
            this.txtDiaChi.Size = new System.Drawing.Size(212, 36);
            this.txtDiaChi.TabIndex = 4;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(476, 216);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(54, 17);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ: ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(476, 172);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(54, 17);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên: ";
            // 
            // lblLoaiKhachHang
            // 
            this.lblLoaiKhachHang.AutoSize = true;
            this.lblLoaiKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiKhachHang.Location = new System.Drawing.Point(476, 258);
            this.lblLoaiKhachHang.Name = "lblLoaiKhachHang";
            this.lblLoaiKhachHang.Size = new System.Drawing.Size(109, 17);
            this.lblLoaiKhachHang.TabIndex = 5;
            this.lblLoaiKhachHang.Text = "Loại khách hàng: ";
            // 
            // cboLoaiKhachHang
            // 
            this.cboLoaiKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.cboLoaiKhachHang.BorderRadius = 3;
            this.cboLoaiKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoaiKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKhachHang.FocusedColor = System.Drawing.Color.Empty;
            this.cboLoaiKhachHang.FocusedState.Parent = this.cboLoaiKhachHang;
            this.cboLoaiKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoaiKhachHang.FormattingEnabled = true;
            this.cboLoaiKhachHang.HoverState.Parent = this.cboLoaiKhachHang;
            this.cboLoaiKhachHang.ItemHeight = 30;
            this.cboLoaiKhachHang.Items.AddRange(new object[] {
            "Khách hàng gửi",
            "Khách hàng nhận"});
            this.cboLoaiKhachHang.ItemsAppearance.Parent = this.cboLoaiKhachHang;
            this.cboLoaiKhachHang.Location = new System.Drawing.Point(621, 248);
            this.cboLoaiKhachHang.Name = "cboLoaiKhachHang";
            this.cboLoaiKhachHang.ShadowDecoration.Parent = this.cboLoaiKhachHang;
            this.cboLoaiKhachHang.Size = new System.Drawing.Size(212, 36);
            this.cboLoaiKhachHang.TabIndex = 5;
            // 
            // grbLoaiKhachHang
            // 
            this.grbLoaiKhachHang.Controls.Add(this.rdbKhachHangNhan);
            this.grbLoaiKhachHang.Controls.Add(this.rdbKhachHangGui);
            this.grbLoaiKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLoaiKhachHang.Location = new System.Drawing.Point(12, 64);
            this.grbLoaiKhachHang.Name = "grbLoaiKhachHang";
            this.grbLoaiKhachHang.Size = new System.Drawing.Size(455, 49);
            this.grbLoaiKhachHang.TabIndex = 0;
            this.grbLoaiKhachHang.TabStop = false;
            this.grbLoaiKhachHang.Text = "Loại khách hàng";
            // 
            // rdbKhachHangNhan
            // 
            this.rdbKhachHangNhan.AutoSize = true;
            this.rdbKhachHangNhan.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbKhachHangNhan.CheckedState.BorderThickness = 0;
            this.rdbKhachHangNhan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbKhachHangNhan.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbKhachHangNhan.CheckedState.InnerOffset = -4;
            this.rdbKhachHangNhan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKhachHangNhan.Location = new System.Drawing.Point(268, 22);
            this.rdbKhachHangNhan.Name = "rdbKhachHangNhan";
            this.rdbKhachHangNhan.Size = new System.Drawing.Size(126, 21);
            this.rdbKhachHangNhan.TabIndex = 1;
            this.rdbKhachHangNhan.Text = "Khách hàng nhận";
            this.rdbKhachHangNhan.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbKhachHangNhan.UncheckedState.BorderThickness = 2;
            this.rdbKhachHangNhan.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbKhachHangNhan.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbKhachHangNhan.UseVisualStyleBackColor = true;
            this.rdbKhachHangNhan.CheckedChanged += new System.EventHandler(this.rdbKhachHangNhan_CheckedChanged);
            // 
            // rdbKhachHangGui
            // 
            this.rdbKhachHangGui.AutoSize = true;
            this.rdbKhachHangGui.Checked = true;
            this.rdbKhachHangGui.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbKhachHangGui.CheckedState.BorderThickness = 0;
            this.rdbKhachHangGui.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbKhachHangGui.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbKhachHangGui.CheckedState.InnerOffset = -4;
            this.rdbKhachHangGui.Location = new System.Drawing.Point(57, 22);
            this.rdbKhachHangGui.Name = "rdbKhachHangGui";
            this.rdbKhachHangGui.Size = new System.Drawing.Size(117, 21);
            this.rdbKhachHangGui.TabIndex = 0;
            this.rdbKhachHangGui.TabStop = true;
            this.rdbKhachHangGui.Text = "Khách hàng gửi";
            this.rdbKhachHangGui.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbKhachHangGui.UncheckedState.BorderThickness = 2;
            this.rdbKhachHangGui.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbKhachHangGui.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbKhachHangGui.UseVisualStyleBackColor = true;
            this.rdbKhachHangGui.CheckedChanged += new System.EventHandler(this.rdbKhachHangGui_CheckedChanged);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(182)))), ((int)(((byte)(152)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(845, 46);
            this.pnlTitle.TabIndex = 0;
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
            this.btnXoa.Location = new System.Drawing.Point(540, 442);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(117, 39);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnBack.Location = new System.Drawing.Point(663, 442);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(117, 39);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Trở về";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnCapNhat.Location = new System.Drawing.Point(663, 395);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ShadowDecoration.Parent = this.btnCapNhat;
            this.btnCapNhat.Size = new System.Drawing.Size(117, 39);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
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
            this.btnThem.Location = new System.Drawing.Point(540, 395);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(117, 39);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.Location = new System.Drawing.Point(12, 120);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(455, 339);
            this.dgvKhachHang.TabIndex = 10;
            this.dgvKhachHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvKhachHang.ThemeStyle.ReadOnly = true;
            this.dgvKhachHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhachHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhachHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKhachHang.ThemeStyle.RowsStyle.Height = 22;
            this.dgvKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKhachHang.DataSourceChanged += new System.EventHandler(this.dgvKhachHang_DataSourceChanged);
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pnlTitle;
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
            this.btnNewAdd.Location = new System.Drawing.Point(598, 348);
            this.btnNewAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewAdd.Name = "btnNewAdd";
            this.btnNewAdd.ShadowDecoration.Parent = this.btnNewAdd;
            this.btnNewAdd.Size = new System.Drawing.Size(117, 39);
            this.btnNewAdd.TabIndex = 33;
            this.btnNewAdd.Text = "Tạo mới";
            this.btnNewAdd.Click += new System.EventHandler(this.btnNewAdd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(329, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý khách hàng";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 463);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 13);
            this.lblStatus.TabIndex = 34;
            this.lblStatus.Text = "0 khách hàng";
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(845, 492);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnNewAdd);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.grbLoaiKhachHang);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboLoaiKhachHang);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.lblSdt);
            this.Controls.Add(this.lblLoaiKhachHang);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblHoTen);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            this.grbLoaiKhachHang.ResumeLayout(false);
            this.grbLoaiKhachHang.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtSdt;
        private System.Windows.Forms.Label lblSdt;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblLoaiKhachHang;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiKhachHang;
        private System.Windows.Forms.GroupBox grbLoaiKhachHang;
        private Guna.UI2.WinForms.Guna2RadioButton rdbKhachHangNhan;
        private Guna.UI2.WinForms.Guna2RadioButton rdbKhachHangGui;
        private System.Windows.Forms.Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhachHang;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Button btnNewAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;
    }
}