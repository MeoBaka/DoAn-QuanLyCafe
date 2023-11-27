namespace QuanLyCafe.GUI.CLDUI
{
    partial class frmDoanhThu
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
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.btn_LayThongKe = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btn_ThongTin = new System.Windows.Forms.Button();
            this.cbTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(6, 42);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu.Size = new System.Drawing.Size(982, 478);
            this.dgvDoanhThu.TabIndex = 16;
            // 
            // btn_LayThongKe
            // 
            this.btn_LayThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_LayThongKe.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_LayThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_LayThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_LayThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LayThongKe.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LayThongKe.ForeColor = System.Drawing.Color.Blue;
            this.btn_LayThongKe.Location = new System.Drawing.Point(207, 527);
            this.btn_LayThongKe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_LayThongKe.Name = "btn_LayThongKe";
            this.btn_LayThongKe.Size = new System.Drawing.Size(187, 36);
            this.btn_LayThongKe.TabIndex = 13;
            this.btn_LayThongKe.Text = "THỐNG KÊ";
            this.btn_LayThongKe.UseVisualStyleBackColor = true;
            this.btn_LayThongKe.Click += new System.EventHandler(this.btn_LayThongKe_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLamMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLamMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Blue;
            this.btnLamMoi.Location = new System.Drawing.Point(770, 527);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(218, 36);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btn_ThongTin
            // 
            this.btn_ThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ThongTin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_ThongTin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ThongTin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongTin.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTin.ForeColor = System.Drawing.Color.Blue;
            this.btn_ThongTin.Location = new System.Drawing.Point(13, 527);
            this.btn_ThongTin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_ThongTin.Name = "btn_ThongTin";
            this.btn_ThongTin.Size = new System.Drawing.Size(187, 36);
            this.btn_ThongTin.TabIndex = 15;
            this.btn_ThongTin.Text = "XEM THÔNG TIN";
            this.btn_ThongTin.UseVisualStyleBackColor = true;
            this.btn_ThongTin.Click += new System.EventHandler(this.btn_ThongTin_Click);
            // 
            // cbTable
            // 
            this.cbTable.BackColor = System.Drawing.Color.Transparent;
            this.cbTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTable.ItemHeight = 30;
            this.cbTable.Items.AddRange(new object[] {
            "Toàn Bộ"});
            this.cbTable.Location = new System.Drawing.Point(633, 0);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(355, 36);
            this.cbTable.TabIndex = 12;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(296, 5);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(83, 23);
            this.guna2HtmlLabel3.TabIndex = 9;
            this.guna2HtmlLabel3.Text = "Đến Ngày: ";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 3);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(72, 23);
            this.guna2HtmlLabel2.TabIndex = 10;
            this.guna2HtmlLabel2.Text = "Từ Ngày: ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(591, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(36, 23);
            this.guna2HtmlLabel1.TabIndex = 11;
            this.guna2HtmlLabel1.Text = "Bàn: ";
            // 
            // DenNgay
            // 
            this.DenNgay.Checked = true;
            this.DenNgay.FillColor = System.Drawing.Color.White;
            this.DenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DenNgay.Location = new System.Drawing.Point(385, 0);
            this.DenNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DenNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DenNgay.Name = "DenNgay";
            this.DenNgay.Size = new System.Drawing.Size(200, 36);
            this.DenNgay.TabIndex = 7;
            this.DenNgay.Value = new System.DateTime(2023, 11, 13, 12, 58, 47, 231);
            // 
            // TuNgay
            // 
            this.TuNgay.Checked = true;
            this.TuNgay.FillColor = System.Drawing.Color.White;
            this.TuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.TuNgay.Location = new System.Drawing.Point(90, 0);
            this.TuNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TuNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TuNgay.Name = "TuNgay";
            this.TuNgay.Size = new System.Drawing.Size(200, 36);
            this.TuNgay.TabIndex = 8;
            this.TuNgay.Value = new System.DateTime(2023, 11, 13, 12, 58, 47, 231);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 575);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.btn_LayThongKe);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btn_ThongTin);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.DenNgay);
            this.Controls.Add(this.TuNgay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoanhThu";
            this.Text = "frmDanhThu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            this.Click += new System.EventHandler(this.btn_ThongKe_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Button btn_LayThongKe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btn_ThongTin;
        private Guna.UI2.WinForms.Guna2ComboBox cbTable;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DenNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker TuNgay;
    }
}