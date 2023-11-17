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
    public partial class frmQLBanAn : Form
    {
        public frmQLBanAn()
        {
            InitializeComponent();
            LoadData();
            txt_soban.Enabled = false;
            btnLuu.Enabled = false;
        }
        QuanLyBanAn an;
        void LoadData()
        {
            DataTable tblmh;
            an = new QuanLyBanAn();

            if (an.Connect())
            {
                tblmh = an.GetDataBanAn();
                dgvThucAn.DataSource = tblmh;
                an.DisConnect();
            }
            else
            {
                MessageBox.Show("ko có kết nối database", "Thông Báo");
            }
        }

        private void dgvTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThucAn.SelectedRows.Count > 0)
            {
                DataGridViewRow data = dgvThucAn.SelectedRows[0];
                object idValue = data.Cells["SOBAN"].Value;
                object TenLoai = data.Cells["NAME"].Value;
                object STATUS = data.Cells["STATUS"].Value;
                if (idValue != null)
                {
                    txt_soban.Text = idValue.ToString();
                }
                if (TenLoai != null)
                {
                    txt_tenban.Text = TenLoai.ToString();
                }
                if (STATUS != null)
                {
                    cbStatus.Text = STATUS.ToString();
                }

            }
        }
        private int Them(QuanLyBanAn an)
        {
            string sql = "INSERT INTO M3_TABLE VALUES (@id, @tenloai, @status)";
            string[] param = { "@id", "@tenloai" , "@status" };
            object[] value = { int.Parse(txt_soban.Text), txt_tenban.Text, cbStatus.Text };
            return an.QuanLyBanAnExecuteNonQuery(sql, param, value, false);
        }
        private int Sua(QuanLyBanAn an)
        {
            string sql = "UPDATE M3_TABLE SET TENLOAI=@tenloai STATUS=@status WHERE SOBAN=@id";
            string[] param = { "@id", "@tenloai", "@status" };
            object[] value = { int.Parse(txt_soban.Text), txt_tenban.Text, cbStatus.Text };
            return an.QuanLyBanAnExecuteNonQuery(sql, param, value, false);
        }
        private int Xoa(QuanLyBanAn an)
        {
            string sql = "DELETE FROM M3_TABLE WHERE SOBAN=@id";
            string[] param = { "@id" };
            object[] value = { int.Parse(txt_soban.Text)};
            return an.QuanLyBanAnExecuteNonQuery(sql, param, value, false);
        }




        private Boolean isAdd = false;
        private Boolean isFix = false;

        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_soban.Text = "";
            txt_tenban.Text = "";
            txt_soban.Enabled = true;
            isAdd = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btn_Exit.Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isFix = true;
            txt_soban.Enabled = false;
            btn_Exit.Visible = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            an = new QuanLyBanAn();
            if (isAdd)
            {
                if (an.Connect())
                {
                    int rec = Them(an);
                    MessageBox.Show($"Đã thêm thành công {txt_tenban.Text}", "Thông Báo");
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
                    MessageBox.Show($"Đã Sửa thành công {txt_tenban.Text}", "Thông Báo");
                    isFix = false;
                }
                else
                {
                    MessageBox.Show($"SQL DROPPED!", "Thông Báo");
                }
            }
            LoadData();
            btn_Exit.Visible = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            btn_Exit.Visible = false;
            isFix = false;
            isAdd = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            dgvThucAn.Enabled = true;
            txt_tenban.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            an = new QuanLyBanAn();
            if (an.Connect())
            {
                int rec = Xoa(an);
                MessageBox.Show($"Đã Xoá thành công {txt_tenban.Text}", "Thông Báo");
            }
            else
            {
                MessageBox.Show($"SQL DROPPED!", "Thông Báo");
            }
            LoadData();
        }
    }
}
