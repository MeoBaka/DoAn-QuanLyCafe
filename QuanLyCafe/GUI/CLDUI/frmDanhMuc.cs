using QuanLyCafe.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCafe.GUI.CLDUI
{
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
            LoadData();
            btn_table_luu.Enabled = false;
            btn_Exit.Visible = false;
        }
        QuanLyBanAn an;
        void LoadData()
        {
            DataTable tblmh;
            an = new QuanLyBanAn();

            if (an.Connect())
            {
                tblmh = an.GetDataTable();
                dgvTable.DataSource = tblmh;
                an.DisConnect();
            }
            else
            {
                MessageBox.Show("ko có kết nối database", "Thông Báo");
            }
        }

        private void dgvTable_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvTable.SelectedRows.Count > 0)
            {
                DataGridViewRow data = dgvTable.SelectedRows[0];
                object idValue = data.Cells["ID"].Value;
                object TenLoai = data.Cells["TENLOAI"].Value;
                if (idValue != null)
                {
                    txt_id.Text = idValue.ToString();
                }
                if (TenLoai != null)
                {
                    txt_table_id.Text = TenLoai.ToString();
                }
            }
        }
        private int Them(QuanLyBanAn an)
        {
            string sql = "INSERT INTO M3_LOAI VALUES (@id, @tenloai)";
            string[] param = { "@id", "@tenloai" };
            object[] value = { int.Parse(txt_id.Text), txt_table_id.Text };
            return an.QuanLyBanAnExecuteNonQuery(sql, param, value, false);
        }
        private int Sua(QuanLyBanAn an)
        {
            string sql = "UPDATE M3_LOAI SET TENLOAI=@tenloai WHERE ID=@id";
            string[] param = { "@id", "@tenloai" };
            object[] value = { int.Parse(txt_id.Text), txt_table_id.Text };
            return an.QuanLyBanAnExecuteNonQuery(sql, param, value, false);
        }
        private int Xoa(QuanLyBanAn an)
        {
            string sql = "DELETE FROM M3_LOAI WHERE ID=@id";
            string[] param = { "@id"};
            object[] value = { int.Parse(txt_id.Text), txt_table_id.Text };
            return an.QuanLyBanAnExecuteNonQuery(sql, param, value, false);
        }




        private Boolean isAdd = false;
        private Boolean isFix = false;

        private void btn_table_them_Click(object sender, EventArgs e)
        {
            txt_table_id.Text = "";
            txt_id.Text = "" ;
            txt_id.Enabled = true;
            isAdd = true;

            btn_table_them.Enabled = false;
            btn_table_sua.Enabled = false;
            btn_table_xoa.Enabled = false;
            btn_table_luu.Enabled = true;
            btn_Exit.Visible = false;
        }

        private void btn_table_sua_Click(object sender, EventArgs e)
        {
            isFix = true;
            txt_id.Enabled = false;
            btn_Exit.Visible = true;
            btn_table_them.Enabled = false;
            btn_table_sua.Enabled = false;
            btn_table_xoa.Enabled = false;
            btn_table_luu.Enabled = true;
        }

        private void btn_table_luu_Click(object sender, EventArgs e)
        {
            an = new QuanLyBanAn();
            if (isAdd)
            {
                if (an.Connect())
                {
                    int rec = Them(an);
                    MessageBox.Show($"Đã thêm thành công {txt_table_id.Text}", "Thông Báo");
                    isAdd = false;
                }
                else
                {
                    MessageBox.Show($"SQL DROPPED!", "Thông Báo");
                }
            }
            if (isFix)
            {
                if (an.Connect())
                {
                    int rec = Sua(an);
                    MessageBox.Show($"Đã Sửa thành công {txt_table_id.Text}", "Thông Báo");
                    isFix = false;
                }
                else
                {
                    MessageBox.Show($"SQL DROPPED!", "Thông Báo");
                }
            }
            LoadData();
            btn_Exit.Visible = false;
            btn_table_them.Enabled = true;
            btn_table_sua.Enabled = true;
            btn_table_xoa.Enabled = true;
            btn_table_luu.Enabled = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            btn_Exit.Visible = false;
            isFix = false;
            isAdd = false;
            btn_table_them.Enabled = true;
            btn_table_xoa.Enabled = true;
            btn_table_sua.Enabled = true;
            btn_table_luu.Enabled = false;
            dgvTable.Enabled = true;
            txt_table_id.Enabled = false;
        }

        private void btn_table_xoa_Click(object sender, EventArgs e)
        {
            an = new QuanLyBanAn();
            if (an.Connect())
            {
                int rec = Xoa(an);
                MessageBox.Show($"Đã Xoá thành công {txt_table_id.Text}", "Thông Báo");
            }
            else
            {
                MessageBox.Show($"SQL DROPPED!", "Thông Báo");
            }
            LoadData();
        }
    }
}
