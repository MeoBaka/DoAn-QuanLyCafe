namespace QuanLyCafe.GUI
{
    partial class frmLogin
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
            this.PnHead = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.drgControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.drgLabelControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.rad_showpass = new System.Windows.Forms.RadioButton();
            this.lbl_thongbao = new System.Windows.Forms.Label();
            this.txt_User = new CustomControls.RJControls.RJTextBox();
            this.txt_Pass = new CustomControls.RJControls.RJTextBox();
            this.PnHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnHead
            // 
            this.PnHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PnHead.Controls.Add(this.lbl_Title);
            this.PnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHead.Location = new System.Drawing.Point(0, 0);
            this.PnHead.Name = "PnHead";
            this.PnHead.Size = new System.Drawing.Size(336, 40);
            this.PnHead.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(108, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(120, 22);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "System Login";
            // 
            // drgControl
            // 
            this.drgControl.DockForm = true;
            this.drgControl.DockIndicatorTransparencyValue = 0.6D;
            this.drgControl.TargetControl = this.PnHead;
            this.drgControl.UseTransparentDrag = true;
            // 
            // drgLabelControl
            // 
            this.drgLabelControl.DockForm = true;
            this.drgLabelControl.DockIndicatorTransparencyValue = 0.6D;
            this.drgLabelControl.TargetControl = this.lbl_Title;
            this.drgLabelControl.UseTransparentDrag = true;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(43, 78);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(91, 21);
            this.lbl_User.TabIndex = 1;
            this.lbl_User.Text = "UserName: ";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(43, 146);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(84, 21);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password: ";
            // 
            // btn_Login
            // 
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.Blue;
            this.btn_Login.Location = new System.Drawing.Point(43, 249);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(120, 37);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "ĐĂNG NHẬP";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(173, 249);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(120, 37);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "THOÁT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // rad_showpass
            // 
            this.rad_showpass.AutoSize = true;
            this.rad_showpass.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_showpass.Location = new System.Drawing.Point(47, 209);
            this.rad_showpass.Name = "rad_showpass";
            this.rad_showpass.Size = new System.Drawing.Size(135, 20);
            this.rad_showpass.TabIndex = 5;
            this.rad_showpass.TabStop = true;
            this.rad_showpass.Text = "Hiển Thị Mật Khẩu";
            this.rad_showpass.UseVisualStyleBackColor = true;
            // 
            // lbl_thongbao
            // 
            this.lbl_thongbao.AutoSize = true;
            this.lbl_thongbao.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thongbao.Location = new System.Drawing.Point(43, 317);
            this.lbl_thongbao.Name = "lbl_thongbao";
            this.lbl_thongbao.Size = new System.Drawing.Size(146, 21);
            this.lbl_thongbao.TabIndex = 1;
            this.lbl_thongbao.Text = "                                  ";
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.SystemColors.Window;
            this.txt_User.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_User.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_User.BorderSize = 2;
            this.txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.ForeColor = System.Drawing.Color.DimGray;
            this.txt_User.Location = new System.Drawing.Point(43, 103);
            this.txt_User.Margin = new System.Windows.Forms.Padding(4);
            this.txt_User.Multiline = false;
            this.txt_User.Name = "txt_User";
            this.txt_User.Padding = new System.Windows.Forms.Padding(7);
            this.txt_User.PasswordChar = false;
            this.txt_User.Size = new System.Drawing.Size(250, 31);
            this.txt_User.TabIndex = 2;
            this.txt_User.Texts = "";
            this.txt_User.UnderlinedStyle = true;
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Pass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Pass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Pass.BorderSize = 2;
            this.txt_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Pass.Location = new System.Drawing.Point(43, 171);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Pass.Multiline = false;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Pass.PasswordChar = true;
            this.txt_Pass.Size = new System.Drawing.Size(250, 31);
            this.txt_Pass.TabIndex = 3;
            this.txt_Pass.Texts = "";
            this.txt_Pass.UnderlinedStyle = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 389);
            this.Controls.Add(this.rad_showpass);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.lbl_thongbao);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.PnHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.PnHead.ResumeLayout(false);
            this.PnHead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnHead;
        private System.Windows.Forms.Label lbl_Title;
        private Guna.UI2.WinForms.Guna2DragControl drgControl;
        private Guna.UI2.WinForms.Guna2DragControl drgLabelControl;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Password;
        private CustomControls.RJControls.RJTextBox txt_Pass;
        private CustomControls.RJControls.RJTextBox txt_User;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.RadioButton rad_showpass;
        private System.Windows.Forms.Label lbl_thongbao;
    }
}