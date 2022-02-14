
namespace HeThongQLDVGiaoHangNhanh
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEyePass = new Guna.UI2.WinForms.Guna2Button();
            this.btnEyeClosePass = new Guna.UI2.WinForms.Guna2Button();
            this.picPassword = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picUsername = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnKhach = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 3;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(39, 3);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(321, 36);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 3;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(39, 46);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(321, 36);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pnlLogin
            // 
            this.pnlLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.btnEyePass);
            this.pnlLogin.Controls.Add(this.btnEyeClosePass);
            this.pnlLogin.Controls.Add(this.picPassword);
            this.pnlLogin.Controls.Add(this.picUsername);
            this.pnlLogin.Controls.Add(this.btnExit);
            this.pnlLogin.Controls.Add(this.btnKhach);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Location = new System.Drawing.Point(82, 47);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.ShadowDecoration.Parent = this.pnlLogin;
            this.pnlLogin.Size = new System.Drawing.Size(368, 141);
            this.pnlLogin.TabIndex = 0;
            // 
            // btnEyePass
            // 
            this.btnEyePass.BackColor = System.Drawing.Color.Transparent;
            this.btnEyePass.CheckedState.Parent = this.btnEyePass;
            this.btnEyePass.CustomImages.Parent = this.btnEyePass;
            this.btnEyePass.FillColor = System.Drawing.Color.White;
            this.btnEyePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEyePass.ForeColor = System.Drawing.Color.White;
            this.btnEyePass.HoverState.Parent = this.btnEyePass;
            this.btnEyePass.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.eye_close;
            this.btnEyePass.Location = new System.Drawing.Point(325, 47);
            this.btnEyePass.Name = "btnEyePass";
            this.btnEyePass.ShadowDecoration.Parent = this.btnEyePass;
            this.btnEyePass.Size = new System.Drawing.Size(34, 34);
            this.btnEyePass.TabIndex = 2;
            this.btnEyePass.Click += new System.EventHandler(this.btnEyePass_Click);
            // 
            // btnEyeClosePass
            // 
            this.btnEyeClosePass.BackColor = System.Drawing.Color.Transparent;
            this.btnEyeClosePass.CheckedState.Parent = this.btnEyeClosePass;
            this.btnEyeClosePass.CustomImages.Parent = this.btnEyeClosePass;
            this.btnEyeClosePass.FillColor = System.Drawing.Color.White;
            this.btnEyeClosePass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEyeClosePass.ForeColor = System.Drawing.Color.White;
            this.btnEyeClosePass.HoverState.Parent = this.btnEyeClosePass;
            this.btnEyeClosePass.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.eye;
            this.btnEyeClosePass.Location = new System.Drawing.Point(325, 47);
            this.btnEyeClosePass.Name = "btnEyeClosePass";
            this.btnEyeClosePass.ShadowDecoration.Parent = this.btnEyeClosePass;
            this.btnEyeClosePass.Size = new System.Drawing.Size(34, 34);
            this.btnEyeClosePass.TabIndex = 2;
            this.btnEyeClosePass.Click += new System.EventHandler(this.btnEyeClosePass_Click);
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.Transparent;
            this.picPassword.Image = ((System.Drawing.Image)(resources.GetObject("picPassword.Image")));
            this.picPassword.ImageLocation = "";
            this.picPassword.Location = new System.Drawing.Point(3, 46);
            this.picPassword.Name = "picPassword";
            this.picPassword.ShadowDecoration.Parent = this.picPassword;
            this.picPassword.Size = new System.Drawing.Size(36, 36);
            this.picPassword.TabIndex = 7;
            this.picPassword.TabStop = false;
            // 
            // picUsername
            // 
            this.picUsername.BackColor = System.Drawing.Color.Transparent;
            this.picUsername.Image = ((System.Drawing.Image)(resources.GetObject("picUsername.Image")));
            this.picUsername.Location = new System.Drawing.Point(3, 3);
            this.picUsername.Name = "picUsername";
            this.picUsername.ShadowDecoration.Parent = this.picUsername;
            this.picUsername.Size = new System.Drawing.Size(36, 36);
            this.picUsername.TabIndex = 7;
            this.picUsername.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BorderRadius = 3;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(245, 89);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(115, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnKhach
            // 
            this.btnKhach.BorderRadius = 3;
            this.btnKhach.CheckedState.Parent = this.btnKhach;
            this.btnKhach.CustomImages.Parent = this.btnKhach;
            this.btnKhach.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKhach.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhach.ForeColor = System.Drawing.Color.White;
            this.btnKhach.HoverState.Parent = this.btnKhach;
            this.btnKhach.Location = new System.Drawing.Point(124, 89);
            this.btnKhach.Name = "btnKhach";
            this.btnKhach.ShadowDecoration.Parent = this.btnKhach;
            this.btnKhach.Size = new System.Drawing.Size(115, 45);
            this.btnKhach.TabIndex = 3;
            this.btnKhach.Text = "K.Hàng";
            this.btnKhach.Click += new System.EventHandler(this.btnKhach_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 3;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(3, 89);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(115, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(100, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(342, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Hệ thống quản lý dịch vụ giao hàng nhanh";
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.GiaoHangNhanh_Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlLogin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập giao hàng nhanh";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Panel pnlLogin;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox picUsername;
        private Guna.UI2.WinForms.Guna2PictureBox picPassword;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnKhach;
        private Guna.UI2.WinForms.Guna2Button btnEyePass;
        private Guna.UI2.WinForms.Guna2Button btnEyeClosePass;
        private Guna.UI2.WinForms.Guna2GradientButton btnExit;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}