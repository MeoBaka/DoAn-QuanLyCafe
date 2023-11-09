using QuanLyCafe.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace QuanLyCafe.GUI
{
    public partial class frmLogin : Form
    {

        User user;
        public frmLogin()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
            lbl_thongbao.AutoSize = false;
            lbl_thongbao.Height = 180;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private int DangNhap(User us)
        {
            string spName = "USP_CHECKLOGIN @tk, @mk";
            string[] Para = { "@tk", "@mk" };
            object[] values = { txt_User.Texts, txt_Pass.Texts };
            Console.WriteLine(txt_User.Texts); 
            Console.WriteLine(txt_Pass.Texts);
            return us.UserExecuteScalar(spName, Para, values);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            lbl_thongbao.ForeColor = Color.DarkGreen;
            lbl_thongbao.Text = "Đang Kiểm Tra Tài Khoản";
            user = new User();
            if (user.Connect())
            {
                //user.CheckUser(txt_User.Texts, txt_Pass.Texts);
                int dnstatus = DangNhap(user);
                Console.WriteLine(dnstatus.ToString());
                if (dnstatus > 0)
                {
                    frmMain frmMain = new frmMain();
                    this.Hide();
                    frmMain.Show();
                }
                else
                {
                    lbl_User.ForeColor = Color.Red;
                    lbl_Password.ForeColor = Color.Red;
                    lbl_thongbao.ForeColor = Color.Red;
                    lbl_thongbao.Text = "Sai Tên Đăng Nhập Hoặc Mật Khẩu";
                }
            }
            else
            {
                lbl_thongbao.ForeColor = Color.DarkRed;
                lbl_thongbao.Text = "Không Có Kết Nối Đến Database hoặc Rớt Mạng";
            }
        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_showpass.Checked)
            {
                txt_Pass.PasswordChar = false;
            }
            else
            {
                txt_Pass.PasswordChar = true;
            }
        }
    }
}
