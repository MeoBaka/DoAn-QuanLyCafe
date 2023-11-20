using QuanLyCafe.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCafe.GUI.CLDUI
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
            LoadData();
            btn_Exit.Visible = false;
            btn_acc_luu.Enabled = false;
            txt_acc_id.Enabled = false;
            txt_acc_ten.Enabled = false;
            txt_acc_mk.Enabled = false;
            txt_acc_role.Enabled = false;
            
        }
        TaiKhoan an;
        void LoadData()
        {
            DataTable tblmh;
            an = new TaiKhoan();

            if (an.Connect())
            {
                tblmh = an.GetDataTable();
                dgvTaiKhoan.DataSource = tblmh;
                an.DisConnect();
            }
            else
            {
                MessageBox.Show("ko có kết nối database", "Thông Báo");
            }
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, System.EventArgs e)
        {
            if(dgvTaiKhoan.SelectedRows.Count > 0)
            {
                DataGridViewRow data = dgvTaiKhoan.SelectedRows[0];
                object ID = data.Cells["ID"].Value;
                object Users = data.Cells["USERS"].Value;
                object Pass = data.Cells["PASSWORD"].Value;
                object Role = data.Cells["ROLE"].Value;
                if(ID != null)
                {
                    txt_acc_id.Text = ID.ToString();
                }
                if(Users != null)
                {
                    txt_acc_ten.Text = Users.ToString();
                }
                if (Pass != null)
                {
                    txt_acc_mk.Text = Pass.ToString();
                }
                if (Role != null)
                {
                    txt_acc_role.Text = Role.ToString();
                }
            }
        }
        private int Them(TaiKhoan an)
        {
            string sql = "INSERT INTO M3_ACCOUNT VALUES (@id, @ten, @pass, @role)";
            string[] param = { "@id", "@ten", "@pass", "@role" };
            object[] value = { int.Parse(txt_acc_id.Text), txt_acc_ten.Text, txt_acc_mk.Text, txt_acc_role.Text };
            return an.TaiKhoanExecuteNonQuery(sql, param, value, false);
        }
        private int Sua(TaiKhoan an)
        {
            string sql = "UPDATE M3_ACCOUNT SET USERS=@ten, PASSWORD=@pass, ROLE=@role WHERE ID=@id";
            string[] param = { "@id", "@ten", "@pass", "@role" };
            object[] value = { int.Parse(txt_acc_id.Text), txt_acc_ten.Text, txt_acc_mk.Text, txt_acc_role.Text };
            return an.TaiKhoanExecuteNonQuery(sql, param, value, false);
        }
        private int Xoa(TaiKhoan an)
        {
            string sql = "DELETE FROM M3_ACCOUNT WHERE ID=@id";
            string[] param = { "@id"};
            object[] value = { int.Parse(txt_acc_id.Text)};
            return an.TaiKhoanExecuteNonQuery(sql, param, value, false);
        }


        Boolean isadd = false;
        Boolean idfix = false;
        private void btn_acc_them_Click(object sender, System.EventArgs e)
        {
            isadd = true;
            txt_acc_id.Enabled = true;
            txt_acc_ten.Enabled = true;
            txt_acc_mk.Enabled = true;
            txt_acc_role.Enabled = true;

            txt_acc_id.Text = "";
            txt_acc_ten.Text = "";
            txt_acc_mk.Text = "";
            txt_acc_role.Text = "";

            btn_acc_them.Enabled = false;
            btn_acc_sua.Enabled = false;
            btn_acc_xoa.Enabled = false;
            btn_acc_luu.Enabled = true;
            btn_Exit.Visible = true;
            dgvTaiKhoan.Enabled = false;
        }

        private void btn_Exit_Click(object sender, System.EventArgs e)
        {
            isadd = false;
            idfix = false;
            btn_Exit.Visible = false;
            txt_acc_id.Enabled = false;
            txt_acc_ten.Enabled = false;
            txt_acc_mk.Enabled = false;
            txt_acc_role.Enabled = false;

            btn_acc_them.Enabled = true;
            btn_acc_sua.Enabled = true;
            btn_acc_xoa.Enabled = true;
            btn_acc_luu.Enabled = false;

            dgvTaiKhoan.Enabled = true;
        }

        private void btn_acc_xoa_Click(object sender, EventArgs e)
        {
            TaiKhoan atk = new TaiKhoan();
            if (atk.Connect())
            {
                int rec = Xoa(atk);
                MessageBox.Show($"Tài Khoản ID {txt_acc_id.Text} Đã được xoá","Thông Báo");
            }
            else
            {
                MessageBox.Show($"SQL DROPPED!", "Thông Báo");
            }
            LoadData();
        }

        private void btn_acc_sua_Click(object sender, EventArgs e)
        {
            idfix = true;
            txt_acc_id.Enabled = true;
            txt_acc_ten.Enabled = true;
            txt_acc_mk.Enabled = true;
            txt_acc_role.Enabled = true;

            btn_acc_them.Enabled = false;
            btn_acc_sua.Enabled = false;
            btn_acc_xoa.Enabled = false;
            btn_acc_luu.Enabled = true;
            btn_Exit.Visible = true;
            dgvTaiKhoan.Enabled = false;
        }

        private void btn_acc_luu_Click(object sender, EventArgs e)
        {
            if(isadd == true)
            {
                TaiKhoan atk = new TaiKhoan();
                if (atk.Connect())
                {
                    int rec = Them(atk);
                    MessageBox.Show($"Tài Khoản ID {txt_acc_id.Text} Đã được thêm", "Thông Báo");
                }
                else
                {
                    MessageBox.Show($"SQL DROPPED!", "Thông Báo");
                }
            }
            if(idfix == true)
            {
                TaiKhoan atk = new TaiKhoan();
                if (atk.Connect())
                {
                    int rec = Sua(atk);
                    MessageBox.Show($"Tài Khoản ID {txt_acc_id.Text} Đã được sửa", "Thông Báo");
                }
                else
                {
                    MessageBox.Show($"SQL DROPPED!", "Thông Báo");
                }
            }
            LoadData();
            isadd = false;
            idfix = false;
            btn_Exit.Visible = false;
            txt_acc_id.Enabled = false;
            txt_acc_ten.Enabled = false;
            txt_acc_mk.Enabled = false;
            txt_acc_role.Enabled = false;

            btn_acc_them.Enabled = true;
            btn_acc_sua.Enabled = true;
            btn_acc_xoa.Enabled = true;
            btn_acc_luu.Enabled = false;

            dgvTaiKhoan.Enabled = true;
        }
    }
}
