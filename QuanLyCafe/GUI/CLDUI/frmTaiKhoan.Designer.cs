namespace QuanLyCafe.GUI.CLDUI
{
    partial class frmTaiKhoan
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
            this.txt_acc_role = new System.Windows.Forms.TextBox();
            this.txt_acc_ten = new System.Windows.Forms.TextBox();
            this.txt_acc_id = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btn_acc_luu = new System.Windows.Forms.Button();
            this.btn_acc_sua = new System.Windows.Forms.Button();
            this.btn_acc_xoa = new System.Windows.Forms.Button();
            this.btn_acc_them = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_acc_mk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_acc_role
            // 
            this.txt_acc_role.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_acc_role.Location = new System.Drawing.Point(162, 113);
            this.txt_acc_role.Name = "txt_acc_role";
            this.txt_acc_role.Size = new System.Drawing.Size(824, 29);
            this.txt_acc_role.TabIndex = 68;
            // 
            // txt_acc_ten
            // 
            this.txt_acc_ten.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_acc_ten.Location = new System.Drawing.Point(165, 43);
            this.txt_acc_ten.Name = "txt_acc_ten";
            this.txt_acc_ten.Size = new System.Drawing.Size(821, 29);
            this.txt_acc_ten.TabIndex = 69;
            // 
            // txt_acc_id
            // 
            this.txt_acc_id.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_acc_id.Location = new System.Drawing.Point(165, 6);
            this.txt_acc_id.Name = "txt_acc_id";
            this.txt_acc_id.Size = new System.Drawing.Size(824, 29);
            this.txt_acc_id.TabIndex = 70;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(11, 113);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(136, 23);
            this.guna2HtmlLabel9.TabIndex = 67;
            this.guna2HtmlLabel9.Text = "LOẠI TÀI KHOẢN";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(12, 49);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(129, 23);
            this.guna2HtmlLabel10.TabIndex = 66;
            this.guna2HtmlLabel10.Text = "TÊN TÀI KHOẢN";
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(24, 23);
            this.guna2HtmlLabel14.TabIndex = 65;
            this.guna2HtmlLabel14.Text = "ID: ";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(10, 148);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(979, 353);
            this.dgvTaiKhoan.TabIndex = 64;
            this.dgvTaiKhoan.SelectionChanged += new System.EventHandler(this.dgvTaiKhoan_SelectionChanged);
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
            this.btn_acc_luu.Location = new System.Drawing.Point(762, 508);
            this.btn_acc_luu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_acc_luu.Name = "btn_acc_luu";
            this.btn_acc_luu.Size = new System.Drawing.Size(139, 46);
            this.btn_acc_luu.TabIndex = 63;
            this.btn_acc_luu.Text = "Lưu";
            this.btn_acc_luu.UseVisualStyleBackColor = true;
            this.btn_acc_luu.Click += new System.EventHandler(this.btn_acc_luu_Click);
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
            this.btn_acc_sua.Location = new System.Drawing.Point(590, 508);
            this.btn_acc_sua.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_acc_sua.Name = "btn_acc_sua";
            this.btn_acc_sua.Size = new System.Drawing.Size(139, 46);
            this.btn_acc_sua.TabIndex = 62;
            this.btn_acc_sua.Text = "Sửa";
            this.btn_acc_sua.UseVisualStyleBackColor = true;
            this.btn_acc_sua.Click += new System.EventHandler(this.btn_acc_sua_Click);
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
            this.btn_acc_xoa.Location = new System.Drawing.Point(418, 508);
            this.btn_acc_xoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_acc_xoa.Name = "btn_acc_xoa";
            this.btn_acc_xoa.Size = new System.Drawing.Size(139, 46);
            this.btn_acc_xoa.TabIndex = 61;
            this.btn_acc_xoa.Text = "Xoá";
            this.btn_acc_xoa.UseVisualStyleBackColor = true;
            this.btn_acc_xoa.Click += new System.EventHandler(this.btn_acc_xoa_Click);
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
            this.btn_acc_them.Location = new System.Drawing.Point(247, 508);
            this.btn_acc_them.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_acc_them.Name = "btn_acc_them";
            this.btn_acc_them.Size = new System.Drawing.Size(139, 46);
            this.btn_acc_them.TabIndex = 60;
            this.btn_acc_them.Text = "Thêm";
            this.btn_acc_them.UseVisualStyleBackColor = true;
            this.btn_acc_them.Click += new System.EventHandler(this.btn_acc_them_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(417, 508);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(140, 46);
            this.btn_Exit.TabIndex = 71;
            this.btn_Exit.Text = "HUỶ";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 84);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(91, 23);
            this.guna2HtmlLabel1.TabIndex = 66;
            this.guna2HtmlLabel1.Text = "MẬT KHẨU";
            // 
            // txt_acc_mk
            // 
            this.txt_acc_mk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_acc_mk.Location = new System.Drawing.Point(165, 78);
            this.txt_acc_mk.Name = "txt_acc_mk";
            this.txt_acc_mk.Size = new System.Drawing.Size(821, 29);
            this.txt_acc_mk.TabIndex = 69;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 567);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_acc_role);
            this.Controls.Add(this.txt_acc_mk);
            this.Controls.Add(this.txt_acc_ten);
            this.Controls.Add(this.txt_acc_id);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.guna2HtmlLabel14);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.btn_acc_luu);
            this.Controls.Add(this.btn_acc_sua);
            this.Controls.Add(this.btn_acc_xoa);
            this.Controls.Add(this.btn_acc_them);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_acc_role;
        private System.Windows.Forms.TextBox txt_acc_ten;
        private System.Windows.Forms.TextBox txt_acc_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Button btn_acc_luu;
        private System.Windows.Forms.Button btn_acc_sua;
        private System.Windows.Forms.Button btn_acc_xoa;
        private System.Windows.Forms.Button btn_acc_them;
        private System.Windows.Forms.Button btn_Exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.TextBox txt_acc_mk;
    }
}