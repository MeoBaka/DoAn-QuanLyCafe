namespace QuanLyCafe.GUI.CLDUI
{
    partial class frmQuanLy
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
            this.tcQuanLy = new Guna.UI2.WinForms.Guna2TabControl();
            this.doanhthu = new System.Windows.Forms.TabPage();
            this.pnDoanhThu = new System.Windows.Forms.Panel();
            this.txt_TongDoanhThu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.thucan = new System.Windows.Forms.TabPage();
            this.pnThucAn = new System.Windows.Forms.Panel();
            this.danhmuc = new System.Windows.Forms.TabPage();
            this.pnDanhMuc = new System.Windows.Forms.Panel();
            this.banan = new System.Windows.Forms.TabPage();
            this.pnBanAn = new System.Windows.Forms.Panel();
            this.taikhoan = new System.Windows.Forms.TabPage();
            this.tcQuanLy.SuspendLayout();
            this.doanhthu.SuspendLayout();
            this.thucan.SuspendLayout();
            this.danhmuc.SuspendLayout();
            this.banan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQuanLy
            // 
            this.tcQuanLy.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcQuanLy.Controls.Add(this.doanhthu);
            this.tcQuanLy.Controls.Add(this.thucan);
            this.tcQuanLy.Controls.Add(this.danhmuc);
            this.tcQuanLy.Controls.Add(this.banan);
            this.tcQuanLy.Controls.Add(this.taikhoan);
            this.tcQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcQuanLy.ItemSize = new System.Drawing.Size(180, 40);
            this.tcQuanLy.Location = new System.Drawing.Point(0, 0);
            this.tcQuanLy.Name = "tcQuanLy";
            this.tcQuanLy.SelectedIndex = 0;
            this.tcQuanLy.Size = new System.Drawing.Size(1181, 574);
            this.tcQuanLy.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcQuanLy.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcQuanLy.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcQuanLy.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcQuanLy.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcQuanLy.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcQuanLy.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcQuanLy.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcQuanLy.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcQuanLy.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcQuanLy.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcQuanLy.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcQuanLy.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcQuanLy.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcQuanLy.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcQuanLy.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcQuanLy.TabIndex = 0;
            this.tcQuanLy.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcQuanLy.SelectedIndexChanged += new System.EventHandler(this.tcQuanLy_SelectedIndexChanged);
            // 
            // doanhthu
            // 
            this.doanhthu.Controls.Add(this.pnDoanhThu);
            this.doanhthu.Controls.Add(this.txt_TongDoanhThu);
            this.doanhthu.Location = new System.Drawing.Point(184, 4);
            this.doanhthu.Name = "doanhthu";
            this.doanhthu.Padding = new System.Windows.Forms.Padding(3);
            this.doanhthu.Size = new System.Drawing.Size(993, 566);
            this.doanhthu.TabIndex = 0;
            this.doanhthu.Text = "Doanh Thu";
            this.doanhthu.UseVisualStyleBackColor = true;
            // 
            // pnDoanhThu
            // 
            this.pnDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.pnDoanhThu.Name = "pnDoanhThu";
            this.pnDoanhThu.Size = new System.Drawing.Size(987, 560);
            this.pnDoanhThu.TabIndex = 3;
            // 
            // txt_TongDoanhThu
            // 
            this.txt_TongDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.txt_TongDoanhThu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongDoanhThu.Location = new System.Drawing.Point(6, 547);
            this.txt_TongDoanhThu.Name = "txt_TongDoanhThu";
            this.txt_TongDoanhThu.Size = new System.Drawing.Size(3, 2);
            this.txt_TongDoanhThu.TabIndex = 2;
            this.txt_TongDoanhThu.Text = null;
            // 
            // thucan
            // 
            this.thucan.Controls.Add(this.pnThucAn);
            this.thucan.Location = new System.Drawing.Point(184, 4);
            this.thucan.Name = "thucan";
            this.thucan.Size = new System.Drawing.Size(993, 566);
            this.thucan.TabIndex = 1;
            this.thucan.Text = "Thức Ăn";
            this.thucan.UseVisualStyleBackColor = true;
            // 
            // pnThucAn
            // 
            this.pnThucAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThucAn.Location = new System.Drawing.Point(0, 0);
            this.pnThucAn.Name = "pnThucAn";
            this.pnThucAn.Size = new System.Drawing.Size(993, 566);
            this.pnThucAn.TabIndex = 0;
            // 
            // danhmuc
            // 
            this.danhmuc.Controls.Add(this.pnDanhMuc);
            this.danhmuc.Location = new System.Drawing.Point(184, 4);
            this.danhmuc.Name = "danhmuc";
            this.danhmuc.Size = new System.Drawing.Size(993, 566);
            this.danhmuc.TabIndex = 2;
            this.danhmuc.Text = "Danh Mục";
            this.danhmuc.UseVisualStyleBackColor = true;
            // 
            // pnDanhMuc
            // 
            this.pnDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.pnDanhMuc.Name = "pnDanhMuc";
            this.pnDanhMuc.Size = new System.Drawing.Size(993, 566);
            this.pnDanhMuc.TabIndex = 0;
            // 
            // banan
            // 
            this.banan.Controls.Add(this.pnBanAn);
            this.banan.Location = new System.Drawing.Point(184, 4);
            this.banan.Name = "banan";
            this.banan.Size = new System.Drawing.Size(993, 566);
            this.banan.TabIndex = 3;
            this.banan.Text = "Bàn Ăn";
            this.banan.UseVisualStyleBackColor = true;
            // 
            // pnBanAn
            // 
            this.pnBanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBanAn.Location = new System.Drawing.Point(0, 0);
            this.pnBanAn.Name = "pnBanAn";
            this.pnBanAn.Size = new System.Drawing.Size(993, 566);
            this.pnBanAn.TabIndex = 0;
            // 
            // taikhoan
            // 
            this.taikhoan.Location = new System.Drawing.Point(184, 4);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(993, 566);
            this.taikhoan.TabIndex = 4;
            this.taikhoan.Text = "Tài khoản";
            this.taikhoan.UseVisualStyleBackColor = true;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 574);
            this.Controls.Add(this.tcQuanLy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLy";
            this.Text = "frmQuanLy";
            this.tcQuanLy.ResumeLayout(false);
            this.doanhthu.ResumeLayout(false);
            this.doanhthu.PerformLayout();
            this.thucan.ResumeLayout(false);
            this.danhmuc.ResumeLayout(false);
            this.banan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcQuanLy;
        private System.Windows.Forms.TabPage doanhthu;
        private System.Windows.Forms.TabPage thucan;
        private System.Windows.Forms.TabPage danhmuc;
        private System.Windows.Forms.TabPage banan;
        private System.Windows.Forms.TabPage taikhoan;
        private Guna.UI2.WinForms.Guna2HtmlLabel txt_TongDoanhThu;
        private System.Windows.Forms.Panel pnDoanhThu;
        private System.Windows.Forms.Panel pnThucAn;
        private System.Windows.Forms.Panel pnBanAn;
        private System.Windows.Forms.Panel pnDanhMuc;
    }
}