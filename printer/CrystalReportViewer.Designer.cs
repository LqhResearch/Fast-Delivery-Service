
namespace HeThongQLDVGiaoHangNhanh
{
    partial class CrystalReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrystalReportViewer));
            this.crvInBaoCao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvInBaoCao
            // 
            this.crvInBaoCao.ActiveViewIndex = -1;
            this.crvInBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInBaoCao.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInBaoCao.Location = new System.Drawing.Point(0, 0);
            this.crvInBaoCao.Name = "crvInBaoCao";
            this.crvInBaoCao.Size = new System.Drawing.Size(684, 461);
            this.crvInBaoCao.TabIndex = 0;
            // 
            // CrystalReportViewerInBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.crvInBaoCao);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CrystalReportViewerInBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In phiếu giao hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvInBaoCao;
    }
}