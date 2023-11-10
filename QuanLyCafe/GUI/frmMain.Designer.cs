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
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnTop = new System.Windows.Forms.Panel();
            this.btn_CloseButton = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.btn_MaxSize = new System.Windows.Forms.Label();
            this.btn_MinSize = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.pnMerge = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.drgLabelDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.drgPanel = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.drgPnMerge = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.rzForm = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.pnTakeForm = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.pnMerge.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnTop.Controls.Add(this.btn_CloseButton);
            this.pnTop.Controls.Add(this.btn_MaxSize);
            this.pnTop.Controls.Add(this.btn_MinSize);
            this.pnTop.Controls.Add(this.btnClose);
            this.pnTop.Controls.Add(this.pnMerge);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1584, 40);
            this.pnTop.TabIndex = 0;
            this.pnTop.DoubleClick += new System.EventHandler(this.btn_MaxSize_Click);
            // 
            // btn_CloseButton
            // 
            this.btn_CloseButton.AllowAnimations = true;
            this.btn_CloseButton.AllowBorderColorChanges = true;
            this.btn_CloseButton.AllowDefaults = true;
            this.btn_CloseButton.AllowMouseEffects = true;
            this.btn_CloseButton.AnimationSpeed = 200;
            this.btn_CloseButton.AutoSizeCaptions = true;
            this.btn_CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.btn_CloseButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_CloseButton.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_CloseButton.BackPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_CloseButton.BorderColor = System.Drawing.Color.Empty;
            this.btn_CloseButton.BorderHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_CloseButton.BorderPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_CloseButton.BorderRadius = 1;
            this.btn_CloseButton.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.btn_CloseButton.BorderThickness = 1;
            this.btn_CloseButton.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Minimize;
            this.btn_CloseButton.ColorContrastOnClick = 30;
            this.btn_CloseButton.ColorContrastOnHover = 30;
            this.btn_CloseButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_CloseButton.CustomizableEdges = borderEdges1;
            this.btn_CloseButton.DefaultBorderColor = System.Drawing.Color.Empty;
            this.btn_CloseButton.DefaultColor = System.Drawing.Color.RoyalBlue;
            this.btn_CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_CloseButton.IconColor = System.Drawing.Color.Black;
            this.btn_CloseButton.IconHoverColor = System.Drawing.Color.Black;
            this.btn_CloseButton.IconPressedColor = System.Drawing.Color.Black;
            this.btn_CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("btn_CloseButton.Image")));
            this.btn_CloseButton.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.btn_CloseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_CloseButton.Location = new System.Drawing.Point(157, 0);
            this.btn_CloseButton.Name = "btn_CloseButton";
            this.btn_CloseButton.ShowBorders = true;
            this.btn_CloseButton.Size = new System.Drawing.Size(58, 42);
            this.btn_CloseButton.TabIndex = 1;
            this.btn_CloseButton.Visible = false;
            this.btn_CloseButton.Click += new System.EventHandler(this.btn_CloseButton_Click);
            // 
            // btn_MaxSize
            // 
            this.btn_MaxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MaxSize.AutoSize = true;
            this.btn_MaxSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_MaxSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MaxSize.Location = new System.Drawing.Point(1512, 13);
            this.btn_MaxSize.Name = "btn_MaxSize";
            this.btn_MaxSize.Size = new System.Drawing.Size(27, 17);
            this.btn_MaxSize.TabIndex = 4;
            this.btn_MaxSize.Text = "🔲";
            this.btn_MaxSize.Click += new System.EventHandler(this.btn_MaxSize_Click);
            // 
            // btn_MinSize
            // 
            this.btn_MinSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MinSize.AutoSize = true;
            this.btn_MinSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_MinSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MinSize.Location = new System.Drawing.Point(1479, 13);
            this.btn_MinSize.Name = "btn_MinSize";
            this.btn_MinSize.Size = new System.Drawing.Size(18, 17);
            this.btn_MinSize.TabIndex = 3;
            this.btn_MinSize.Text = "__";
            this.btn_MinSize.Click += new System.EventHandler(this.btn_MinSize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(1545, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 17);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "❌";
            this.btnClose.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnMerge
            // 
            this.pnMerge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(50)))), ((int)(((byte)(107)))));
            this.pnMerge.Controls.Add(this.lbl_Title);
            this.pnMerge.Location = new System.Drawing.Point(0, 0);
            this.pnMerge.Name = "pnMerge";
            this.pnMerge.Size = new System.Drawing.Size(150, 40);
            this.pnMerge.TabIndex = 2;
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
            this.pnLeft.Location = new System.Drawing.Point(0, 40);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(150, 560);
            this.pnLeft.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Yellow;
            this.btnLogOut.Location = new System.Drawing.Point(3, 518);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(151, 39);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
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
            // drgPnMerge
            // 
            this.drgPnMerge.DockForm = true;
            this.drgPnMerge.DockIndicatorTransparencyValue = 0.6D;
            this.drgPnMerge.TargetControl = this.pnMerge;
            this.drgPnMerge.UseTransparentDrag = true;
            // 
            // rzForm
            // 
            this.rzForm.TargetForm = this;
            // 
            // pnTakeForm
            // 
            this.pnTakeForm.BackColor = System.Drawing.Color.White;
            this.pnTakeForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTakeForm.Location = new System.Drawing.Point(150, 40);
            this.pnTakeForm.Name = "pnTakeForm";
            this.pnTakeForm.Size = new System.Drawing.Size(1434, 560);
            this.pnTakeForm.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 600);
            this.Controls.Add(this.pnTakeForm);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnMerge.ResumeLayout(false);
            this.pnMerge.PerformLayout();
            this.pnLeft.ResumeLayout(false);
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
        private System.Windows.Forms.Label btn_MaxSize;
        private System.Windows.Forms.Label btn_MinSize;
        private System.Windows.Forms.Label btnClose;
        private Guna.UI2.WinForms.Guna2ResizeForm rzForm;
        private System.Windows.Forms.Panel pnTakeForm;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton btn_CloseButton;
    }
}