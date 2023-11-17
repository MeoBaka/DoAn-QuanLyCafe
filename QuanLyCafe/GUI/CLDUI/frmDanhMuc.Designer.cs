namespace QuanLyCafe.GUI.CLDUI
{
    partial class frmDanhMuc
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
            this.txt_table_id = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.btn_table_luu = new System.Windows.Forms.Button();
            this.btn_table_sua = new System.Windows.Forms.Button();
            this.btn_table_xoa = new System.Windows.Forms.Button();
            this.btn_table_them = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_table_id
            // 
            this.txt_table_id.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_table_id.Location = new System.Drawing.Point(136, 41);
            this.txt_table_id.Name = "txt_table_id";
            this.txt_table_id.Size = new System.Drawing.Size(853, 29);
            this.txt_table_id.TabIndex = 46;
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(12, 44);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(87, 23);
            this.guna2HtmlLabel13.TabIndex = 41;
            this.guna2HtmlLabel13.Text = "Danh Mục: ";
            // 
            // dgvTable
            // 
            this.dgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(12, 76);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(975, 394);
            this.dgvTable.TabIndex = 40;
            this.dgvTable.SelectionChanged += new System.EventHandler(this.dgvTable_SelectionChanged);
            // 
            // btn_table_luu
            // 
            this.btn_table_luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_table_luu.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_table_luu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_table_luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_table_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_table_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table_luu.ForeColor = System.Drawing.Color.Blue;
            this.btn_table_luu.Location = new System.Drawing.Point(691, 477);
            this.btn_table_luu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_table_luu.Name = "btn_table_luu";
            this.btn_table_luu.Size = new System.Drawing.Size(139, 46);
            this.btn_table_luu.TabIndex = 39;
            this.btn_table_luu.Text = "Lưu";
            this.btn_table_luu.UseVisualStyleBackColor = true;
            this.btn_table_luu.Click += new System.EventHandler(this.btn_table_luu_Click);
            // 
            // btn_table_sua
            // 
            this.btn_table_sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_table_sua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_table_sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_table_sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_table_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_table_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table_sua.ForeColor = System.Drawing.Color.Olive;
            this.btn_table_sua.Location = new System.Drawing.Point(519, 477);
            this.btn_table_sua.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_table_sua.Name = "btn_table_sua";
            this.btn_table_sua.Size = new System.Drawing.Size(139, 46);
            this.btn_table_sua.TabIndex = 38;
            this.btn_table_sua.Text = "Sửa";
            this.btn_table_sua.UseVisualStyleBackColor = true;
            this.btn_table_sua.Click += new System.EventHandler(this.btn_table_sua_Click);
            // 
            // btn_table_xoa
            // 
            this.btn_table_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_table_xoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_table_xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_table_xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_table_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_table_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_table_xoa.Location = new System.Drawing.Point(347, 477);
            this.btn_table_xoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_table_xoa.Name = "btn_table_xoa";
            this.btn_table_xoa.Size = new System.Drawing.Size(139, 46);
            this.btn_table_xoa.TabIndex = 37;
            this.btn_table_xoa.Text = "Xoá";
            this.btn_table_xoa.UseVisualStyleBackColor = true;
            this.btn_table_xoa.Click += new System.EventHandler(this.btn_table_xoa_Click);
            // 
            // btn_table_them
            // 
            this.btn_table_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_table_them.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_table_them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_table_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_table_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_table_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_table_them.ForeColor = System.Drawing.Color.Green;
            this.btn_table_them.Location = new System.Drawing.Point(176, 477);
            this.btn_table_them.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_table_them.Name = "btn_table_them";
            this.btn_table_them.Size = new System.Drawing.Size(139, 46);
            this.btn_table_them.TabIndex = 36;
            this.btn_table_them.Text = "Thêm";
            this.btn_table_them.UseVisualStyleBackColor = true;
            this.btn_table_them.Click += new System.EventHandler(this.btn_table_them_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(849, 477);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(140, 46);
            this.btn_Exit.TabIndex = 47;
            this.btn_Exit.Text = "HUỶ";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txt_id.Location = new System.Drawing.Point(136, 6);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(853, 29);
            this.txt_id.TabIndex = 49;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(24, 23);
            this.guna2HtmlLabel4.TabIndex = 48;
            this.guna2HtmlLabel4.Text = "ID: ";
            // 
            // frmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 536);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_table_id);
            this.Controls.Add(this.guna2HtmlLabel13);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.btn_table_luu);
            this.Controls.Add(this.btn_table_sua);
            this.Controls.Add(this.btn_table_xoa);
            this.Controls.Add(this.btn_table_them);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhMuc";
            this.Text = "frmQuanLyBanAn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_table_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btn_table_luu;
        private System.Windows.Forms.Button btn_table_sua;
        private System.Windows.Forms.Button btn_table_xoa;
        private System.Windows.Forms.Button btn_table_them;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}