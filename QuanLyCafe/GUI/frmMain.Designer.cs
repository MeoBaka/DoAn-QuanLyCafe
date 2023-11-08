namespace QuanLyCafe.GUI
{
    partial class frmMain
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.drgLabelDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.drgPanel = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnMerge = new System.Windows.Forms.Panel();
            this.drgPnMerge = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnTop.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnMerge.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnTop.Controls.Add(this.pnMerge);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(891, 42);
            this.pnTop.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(19, 8);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(111, 22);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Quản Lý Bàn";
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnLeft.Controls.Add(this.btnLogOut);
            this.pnLeft.Controls.Add(this.btnThongTin);
            this.pnLeft.Controls.Add(this.btnAdmin);
            this.pnLeft.Controls.Add(this.btnTable);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 42);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(157, 476);
            this.pnLeft.TabIndex = 1;
            // 
            // btnTable
            // 
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.Location = new System.Drawing.Point(3, 6);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(151, 39);
            this.btnTable.TabIndex = 0;
            this.btnTable.Text = "Bàn";
            this.btnTable.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(3, 51);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(151, 39);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnThongTin
            // 
            this.btnThongTin.FlatAppearance.BorderSize = 0;
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.White;
            this.btnThongTin.Location = new System.Drawing.Point(3, 96);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(151, 39);
            this.btnThongTin.TabIndex = 0;
            this.btnThongTin.Text = "Thông Tin TK";
            this.btnThongTin.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Yellow;
            this.btnLogOut.Location = new System.Drawing.Point(3, 434);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(151, 39);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // drgLabelDrag
            // 
            this.drgLabelDrag.DockForm = true;
            this.drgLabelDrag.DockIndicatorTransparencyValue = 0.6D;
            this.drgLabelDrag.TargetControl = this.lbl_Title;
            this.drgLabelDrag.UseTransparentDrag = true;
            // 
            // drgPanel
            // 
            this.drgPanel.DockForm = true;
            this.drgPanel.DockIndicatorTransparencyValue = 0.6D;
            this.drgPanel.TargetControl = this.pnTop;
            this.drgPanel.UseTransparentDrag = true;
            // 
            // pnMerge
            // 
            this.pnMerge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(50)))), ((int)(((byte)(107)))));
            this.pnMerge.Controls.Add(this.lbl_Title);
            this.pnMerge.Location = new System.Drawing.Point(0, 0);
            this.pnMerge.Name = "pnMerge";
            this.pnMerge.Size = new System.Drawing.Size(157, 42);
            this.pnMerge.TabIndex = 2;
            // 
            // drgPnMerge
            // 
            this.drgPnMerge.DockForm = true;
            this.drgPnMerge.DockIndicatorTransparencyValue = 0.6D;
            this.drgPnMerge.TargetControl = this.pnMerge;
            this.drgPnMerge.UseTransparentDrag = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 518);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.pnTop.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnMerge.ResumeLayout(false);
            this.pnMerge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnAdmin;
        private Guna.UI2.WinForms.Guna2DragControl drgLabelDrag;
        private Guna.UI2.WinForms.Guna2DragControl drgPanel;
        private System.Windows.Forms.Panel pnMerge;
        private Guna.UI2.WinForms.Guna2DragControl drgPnMerge;
    }
}