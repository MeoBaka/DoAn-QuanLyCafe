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
            this.banan = new System.Windows.Forms.TabPage();
            this.taikhoan = new System.Windows.Forms.TabPage();
            this.txt_acc_loai = new System.Windows.Forms.TextBox();
            this.txt_acc_ten = new System.Windows.Forms.TextBox();
            this.txt_acc_id = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btn_acc_luu = new System.Windows.Forms.Button();
            this.btn_acc_sua = new System.Windows.Forms.Button();
            this.btn_acc_xoa = new System.Windows.Forms.Button();
            this.btn_Doipass = new System.Windows.Forms.Button();
            this.btn_acc_them = new System.Windows.Forms.Button();
            this.pnBanAn = new System.Windows.Forms.Panel();
            this.pnDanhMuc = new System.Windows.Forms.Panel();
            this.tcQuanLy.SuspendLayout();
            this.doanhthu.SuspendLayout();
            this.thucan.SuspendLayout();
            this.danhmuc.SuspendLayout();
            this.banan.SuspendLayout();
            this.taikhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
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
            // taikhoan
            // 
            this.taikhoan.Controls.Add(this.txt_acc_loai);
            this.taikhoan.Controls.Add(this.txt_acc_ten);
            this.taikhoan.Controls.Add(this.txt_acc_id);
            this.taikhoan.Controls.Add(this.guna2HtmlLabel9);
            this.taikhoan.Controls.Add(this.guna2HtmlLabel10);
            this.taikhoan.Controls.Add(this.guna2HtmlLabel14);
            this.taikhoan.Controls.Add(this.dgvTaiKhoan);
            this.taikhoan.Controls.Add(this.btn_acc_luu);
            this.taikhoan.Controls.Add(this.btn_acc_sua);
            this.taikhoan.Controls.Add(this.btn_acc_xoa);
            this.taikhoan.Controls.Add(this.btn_Doipass);
            this.taikhoan.Controls.Add(this.btn_acc_them);
            this.taikhoan.Location = new System.Drawing.Point(184, 4);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(993, 566);
            this.taikhoan.TabIndex = 4;
            this.taikhoan.Text = "Tài khoản";
            this.taikhoan.UseVisualStyleBackColor = true;
            // 
            // txt_acc_loai
            // 
            this.txt_acc_loai.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_acc_loai.Location = new System.Drawing.Point(162, 85);
            this.txt_acc_loai.Name = "txt_acc_loai";
            this.txt_acc_loai.Size = new System.Drawing.Size(821, 29);
            this.txt_acc_loai.TabIndex = 44;
            // 
            // txt_acc_ten
            // 
            this.txt_acc_ten.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_acc_ten.Location = new System.Drawing.Point(161, 45);
            this.txt_acc_ten.Name = "txt_acc_ten";
            this.txt_acc_ten.Size = new System.Drawing.Size(821, 29);
            this.txt_acc_ten.TabIndex = 45;
            // 
            // txt_acc_id
            // 
            this.txt_acc_id.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_acc_id.Location = new System.Drawing.Point(161, 8);
            this.txt_acc_id.Name = "txt_acc_id";
            this.txt_acc_id.Size = new System.Drawing.Size(824, 29);
            this.txt_acc_id.TabIndex = 46;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(8, 85);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(136, 23);
            this.guna2HtmlLabel9.TabIndex = 43;
            this.guna2HtmlLabel9.Text = "LOẠI TÀI KHOẢN";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(8, 51);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(129, 23);
            this.guna2HtmlLabel10.TabIndex = 42;
            this.guna2HtmlLabel10.Text = "TÊN TÀI KHOẢN";
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(8, 14);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(24, 23);
            this.guna2HtmlLabel14.TabIndex = 41;
            this.guna2HtmlLabel14.Text = "ID: ";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(6, 136);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(982, 406);
            this.dgvTaiKhoan.TabIndex = 40;
            // 
            // btn_acc_luu
            // 
            this.btn_acc_luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_acc_luu.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_acc_luu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_acc_luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_acc_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acc_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acc_luu.ForeColor = System.Drawing.Color.Blue;
            this.btn_acc_luu.Location = new System.Drawing.Point(758, 549);
            this.btn_acc_luu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_acc_luu.Name = "btn_acc_luu";
            this.btn_acc_luu.Size = new System.Drawing.Size(139, 46);
            this.btn_acc_luu.TabIndex = 39;
            this.btn_acc_luu.Text = "Lưu";
            this.btn_acc_luu.UseVisualStyleBackColor = true;
            // 
            // btn_acc_sua
            // 
            this.btn_acc_sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_acc_sua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_acc_sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_acc_sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_acc_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acc_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acc_sua.ForeColor = System.Drawing.Color.Olive;
            this.btn_acc_sua.Location = new System.Drawing.Point(586, 549);
            this.btn_acc_sua.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_acc_sua.Name = "btn_acc_sua";
            this.btn_acc_sua.Size = new System.Drawing.Size(139, 46);
            this.btn_acc_sua.TabIndex = 38;
            this.btn_acc_sua.Text = "Sửa";
            this.btn_acc_sua.UseVisualStyleBackColor = true;
            // 
            // btn_acc_xoa
            // 
            this.btn_acc_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_acc_xoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_acc_xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_acc_xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_acc_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acc_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acc_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_acc_xoa.Location = new System.Drawing.Point(414, 549);
            this.btn_acc_xoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_acc_xoa.Name = "btn_acc_xoa";
            this.btn_acc_xoa.Size = new System.Drawing.Size(139, 46);
            this.btn_acc_xoa.TabIndex = 37;
            this.btn_acc_xoa.Text = "Xoá";
            this.btn_acc_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Doipass
            // 
            this.btn_Doipass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Doipass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Doipass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_Doipass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Doipass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Doipass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Doipass.ForeColor = System.Drawing.Color.Green;
            this.btn_Doipass.Location = new System.Drawing.Point(94, 549);
            this.btn_Doipass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Doipass.Name = "btn_Doipass";
            this.btn_Doipass.Size = new System.Drawing.Size(139, 46);
            this.btn_Doipass.TabIndex = 36;
            this.btn_Doipass.Text = "Đổi Mật Khẩu";
            this.btn_Doipass.UseVisualStyleBackColor = true;
            // 
            // btn_acc_them
            // 
            this.btn_acc_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_acc_them.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_acc_them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_acc_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_acc_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acc_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acc_them.ForeColor = System.Drawing.Color.Green;
            this.btn_acc_them.Location = new System.Drawing.Point(243, 549);
            this.btn_acc_them.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_acc_them.Name = "btn_acc_them";
            this.btn_acc_them.Size = new System.Drawing.Size(139, 46);
            this.btn_acc_them.TabIndex = 36;
            this.btn_acc_them.Text = "Thêm";
            this.btn_acc_them.UseVisualStyleBackColor = true;
            // 
            // pnBanAn
            // 
            this.pnBanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBanAn.Location = new System.Drawing.Point(0, 0);
            this.pnBanAn.Name = "pnBanAn";
            this.pnBanAn.Size = new System.Drawing.Size(993, 566);
            this.pnBanAn.TabIndex = 0;
            // 
            // pnDanhMuc
            // 
            this.pnDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.pnDanhMuc.Name = "pnDanhMuc";
            this.pnDanhMuc.Size = new System.Drawing.Size(993, 566);
            this.pnDanhMuc.TabIndex = 0;
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
            this.taikhoan.ResumeLayout(false);
            this.taikhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcQuanLy;
        private System.Windows.Forms.TabPage doanhthu;
        private System.Windows.Forms.TabPage thucan;
        private System.Windows.Forms.TabPage danhmuc;
        private System.Windows.Forms.TabPage banan;
        private System.Windows.Forms.TabPage taikhoan;
        private System.Windows.Forms.TextBox txt_acc_loai;
        private System.Windows.Forms.TextBox txt_acc_ten;
        private System.Windows.Forms.TextBox txt_acc_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Button btn_acc_luu;
        private System.Windows.Forms.Button btn_acc_sua;
        private System.Windows.Forms.Button btn_acc_xoa;
        private System.Windows.Forms.Button btn_Doipass;
        private System.Windows.Forms.Button btn_acc_them;
        private Guna.UI2.WinForms.Guna2HtmlLabel txt_TongDoanhThu;
        private System.Windows.Forms.Panel pnDoanhThu;
        private System.Windows.Forms.Panel pnThucAn;
        private System.Windows.Forms.Panel pnBanAn;
        private System.Windows.Forms.Panel pnDanhMuc;
    }
}