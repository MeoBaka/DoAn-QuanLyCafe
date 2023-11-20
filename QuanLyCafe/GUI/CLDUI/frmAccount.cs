using QuanLyCafe.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.GUI.CLDUI
{
    public partial class frmAccount : Form
    {
        private string Users;
        public frmAccount(string User)
        {
            InitializeComponent();
            Users = User;
            PushData(Users);
        }
        void PushData(string userName)
        {
            TaiKhoan tk = new TaiKhoan();
            if (tk.Connect())
            {
                // Gọi hàm GetTK để lấy DataTable
                DataTable dataTable = tk.GetTK(userName);

                // Kiểm tra xem có dữ liệu trong DataTable không
                if (dataTable.Rows.Count > 0)
                {
                    // Lấy giá trị từ DataTable
                    string user = dataTable.Rows[0]["USERS"].ToString();
                    string role = dataTable.Rows[0]["ROLE"].ToString();

                    // Cập nhật Label
                    lbltk.Text = $"Tài Khoản: {user}";
                    lblrole.Text = $"Role: {role}";
                }
                else
                {
                    // Nếu không có dữ liệu, có thể xử lý theo ý của bạn (ví dụ: hiển thị thông báo)
                    MessageBox.Show("Không tìm thấy thông tin tài khoản.");
                }
            }
            else
            {
                // Xử lý kết nối không thành công (ví dụ: hiển thị thông báo)
                MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
            }
        }

        private void Showpass_CheckedChanged(object sender, EventArgs e)
        {
            if(Showpass.Checked == true)
            {
                txt_old_pass.UseSystemPasswordChar = false;
                txt_new_pass.UseSystemPasswordChar = false;
                txt_new_pass_repeat.UseSystemPasswordChar = false;
            }
            else
            {
                txt_old_pass.UseSystemPasswordChar = true;
                txt_new_pass.UseSystemPasswordChar = true;
                txt_new_pass_repeat.UseSystemPasswordChar = true;
            }
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_old_pass.Text)) 
            {
                CB.Text = "Mật khẩu không được trống";
                return;
            }
            if (string.IsNullOrEmpty(txt_new_pass.Text))
            {
                CB.Text = "Mật khẩu không được trống";
                return;
            }
            if (string.IsNullOrEmpty(txt_new_pass_repeat.Text))
            {
                CB.Text = "Mật khẩu không được trống";
                return;
            }
            if (txt_new_pass.Text != txt_new_pass_repeat.Text)
            {
                CB.Text = "Mật khẩu không giống nhau";
                return;
            }
            TaiKhoan tk = new TaiKhoan();
            if (tk.Connect())
            {
                int rec = tk.CheckPass(tk, Users, txt_old_pass.Text);
                Console.WriteLine("rec: "+rec);
                if (rec > 0)
                {
                    if (tk.Connect())
                    {
                        int dpass = tk.Doipass(tk, Users, txt_new_pass_repeat.Text);
                        Console.WriteLine("Dpass: " + dpass);
                        if (dpass > 0)
                        {
                            MessageBox.Show("Đổi Pass Thành Công", "Thông Báo");
                        }
                    }
                }
                else
                {
                    CB.Text = "Mật khẩu không đúng";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Mất kết nối đến sql", "Thông Báo");
            }

        }
    }
}
