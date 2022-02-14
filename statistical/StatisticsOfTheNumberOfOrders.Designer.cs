
namespace HeThongQLDVGiaoHangNhanh
{
    partial class StatisticsOfTheNumberOfOrders
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsOfTheNumberOfOrders));
            this.chartTheoNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.numNam = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblNam = new System.Windows.Forms.Label();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTheoNam)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTheoNam
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTheoNam.ChartAreas.Add(chartArea1);
            this.chartTheoNam.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartTheoNam.Legends.Add(legend1);
            this.chartTheoNam.Location = new System.Drawing.Point(0, 100);
            this.chartTheoNam.Name = "chartTheoNam";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Số đơn hàng giao thành công";
            series1.Name = "GiaoThanhCong";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Số đơn hàng bị hoàn trả";
            series2.Name = "BiHoanTra";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.LegendText = "Số đơn hàng đảm nhận";
            series3.Name = "DamNhan";
            this.chartTheoNam.Series.Add(series1);
            this.chartTheoNam.Series.Add(series2);
            this.chartTheoNam.Series.Add(series3);
            this.chartTheoNam.Size = new System.Drawing.Size(1000, 500);
            this.chartTheoNam.TabIndex = 0;
            this.chartTheoNam.Text = "Thống kê đơn hàng theo năm";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(182)))), ((int)(((byte)(152)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1000, 46);
            this.pnlTitle.TabIndex = 1;
            // 
            // numNam
            // 
            this.numNam.BackColor = System.Drawing.Color.Transparent;
            this.numNam.BorderRadius = 3;
            this.numNam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numNam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numNam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numNam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numNam.DisabledState.Parent = this.numNam;
            this.numNam.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numNam.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numNam.FocusedState.Parent = this.numNam;
            this.numNam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numNam.Location = new System.Drawing.Point(776, 54);
            this.numNam.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numNam.Name = "numNam";
            this.numNam.ShadowDecoration.Parent = this.numNam;
            this.numNam.Size = new System.Drawing.Size(73, 36);
            this.numNam.TabIndex = 13;
            this.numNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.Location = new System.Drawing.Point(727, 64);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(43, 17);
            this.lblNam.TabIndex = 14;
            this.lblNam.Text = "Năm: ";
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pnlTitle;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BorderRadius = 3;
            this.btnThongKe.CheckedState.Parent = this.btnThongKe;
            this.btnThongKe.CustomImages.Parent = this.btnThongKe;
            this.btnThongKe.FillColor = System.Drawing.Color.Lime;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.HoverState.Parent = this.btnThongKe;
            this.btnThongKe.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.Search_Statistics;
            this.btnThongKe.Location = new System.Drawing.Point(871, 54);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.ShadowDecoration.Parent = this.btnThongKe;
            this.btnThongKe.Size = new System.Drawing.Size(117, 36);
            this.btnThongKe.TabIndex = 15;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
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
            this.btnBack.Location = new System.Drawing.Point(12, 54);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(117, 39);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Trở về";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(320, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thống kế số lượng đơn hàng theo năm";
            // 
            // StatisticsOfTheNumberOfOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.numNam);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.chartTheoNam);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StatisticsOfTheNumberOfOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kế số lượng đơn hàng";
            this.Load += new System.EventHandler(this.StatisticsOfTheNumberOfOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTheoNam)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTheoNam;
        private System.Windows.Forms.Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2NumericUpDown numNam;
        private System.Windows.Forms.Label lblNam;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.Label lblTitle;
    }
}