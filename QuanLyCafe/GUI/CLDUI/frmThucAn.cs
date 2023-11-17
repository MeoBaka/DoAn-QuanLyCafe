using QuanLyCafe.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.GUI.CLDUI
{
    public partial class frmThucAn : Form
    {
        public frmThucAn()
        {
            InitializeComponent();
            LoadDataDon();
            btnLuu.Enabled = false;
            btn_Exit.Visible = false;
        }
        #region Thuc An
        void LoadDataDon()
        {
            DataTable tblmh;
            ThucAn ta = new ThucAn();

            if (ta.Connect())
            {
                tblmh = ta.GetDataThucAn();
                dgvThucAn.DataSource = tblmh;
                ta.DisConnect();
            }
            else
            {
                MessageBox.Show("ko có kết nối database", "Thông Báo");
            }

            dgvThucAn.Columns["ID"].HeaderText = "Số Thứ Tự";
            dgvThucAn.Columns["TENLOAI"].HeaderText = "Tên Loại";
            dgvThucAn.Columns["TENDON"].HeaderText = "Tên Đơn";
            dgvThucAn.Columns["MSIZE"].HeaderText = "Size";
            dgvThucAn.Columns["GIATIEN"].HeaderText = "Giá Tiền";
        }

        private void dgvThucAn_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvThucAn.SelectedRows.Count > 0)
            {
                // Lấy giá trị của cột có tên là "ID" từ hàng được chọn
                DataGridViewRow selectedRow = dgvThucAn.SelectedRows[0];
                object idValue = selectedRow.Cells["ID"].Value;
                object tenLoaiValue = selectedRow.Cells["TENLOAI"].Value;
                object tenDonValue = selectedRow.Cells["TENDON"].Value;
                object mSizeValue = selectedRow.Cells["MSIZE"].Value;
                object giaTienValue = selectedRow.Cells["GIATIEN"].Value;

                // Kiểm tra xem giá trị ID có tồn tại không và đưa vào TextBox tương ứng
                if (idValue != null)
                {
                    txt_id.Text = idValue.ToString();
                }
                if (tenLoaiValue != null)
                {
                    txt_loaimon.Text = tenLoaiValue.ToString();
                }
                if (tenDonValue != null)
                {
                    txt_tenmon.Text = tenDonValue.ToString();
                }
                if (mSizeValue != null)
                {
                    cbSize.Text = mSizeValue.ToString();
                }
                if (giaTienValue != null)
                {
                    txt_giatien.Text = giaTienValue.ToString();
                }
            }
        }
        private Boolean isAdd = false;
        private Boolean isFix = false;
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThucAn ta = new ThucAn();
            if (ta.Connect())
            {
                int rec = DeleteDon(ta);
                DialogResult kq = MessageBox.Show($"Bạn có muốn xoá {txt_id.Text} ?", $"Thông Báo", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    if (rec > 0)
                    {
                        MessageBox.Show("Đã xoá 1 dòng thành công", "Thông báo");
                        LoadDataDon();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra trong quá trình xoá dữ liệu", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("CSDL Dropped!", "Thông báo");
            }
        }

        private int DeleteDon(ThucAn TA)
        {
            string sqlDelete = "DELETE FROM M3_DON WHERE ID=@id";
            string[] param = { "@id" };
            object[] value = { txt_id.Text };
            return TA.ThucAnExecuteNonQuery(sqlDelete, param, value, false);
        }
        private int ThemDon(ThucAn TA)
        {
            string sql = "INSERT INTO M3_DON VALUES(@id, @tenloai, @tendon, @size, @giatien)";
            string[] param = { "@id", "@tenloai", "@tendon", "@size", "@giatien" };
            object[] value = { txt_id.Text, txt_loaimon.Text, txt_tenmon.Text, cbSize.Text, SqlMoney.Parse(txt_giatien.Text) };
            return TA.ThucAnExecuteNonQuery(sql, param, value, false);
        }
        private int SuaDon(ThucAn thucAn)
        {
            string sql = "UPDATE M3_DON SET TENLOAI=@tenloai, TENDON=@tendon, MSIZE=@size, GIATIEN=@giatien WHERE ID=@id";
            string[] param = { "@id", "@tenloai", "@tendon", "@size", "@giatien" };
            object[] value = { txt_id.Text, txt_tenmon.Text, txt_loaimon.Text, cbSize.Text, SqlMoney.Parse(txt_giatien.Text) };
            return thucAn.ThucAnExecuteNonQuery(sql, param, value, false);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThucAn ta = new ThucAn();
            if (isAdd == true)
            {
                if (ta.Connect())
                {
                    int rec = ThemDon(ta);
                    MessageBox.Show($"Đã thêm thành công {txt_tenmon.Text}", "Thông Báo");
                    isAdd = false;
                }
                else
                {
                    MessageBox.Show($"SQL DROPPED!", "Thông Báo");
                }
            }
            if (isFix == true)
            {
                if (ta.Connect())
                {
                    int rec = SuaDon(ta);
                    MessageBox.Show($"Đã sửa thành công {txt_tenmon.Text}", "Thông Báo");
                    isFix = false;
                }
                else
                {
                    MessageBox.Show($"SQL DROPPED!", "Thông Báo");
                }
            }
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            dgvThucAn.Enabled = true;
            LoadDataDon();
            txt_id.Enabled = false;
            txt_tenmon.Enabled = false;
            txt_loaimon.Enabled = false;
            cbSize.Enabled = false;
            txt_giatien.Enabled = false;
            btn_Exit.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            txt_id.Text = "";
            txt_tenmon.Text = "";
            txt_loaimon.Text = "";
            cbSize.Text = "";
            txt_giatien.Text = "";

            txt_id.Enabled = true;
            txt_tenmon.Enabled = true;
            txt_loaimon.Enabled = true;
            cbSize.Enabled = true;
            txt_giatien.Enabled = true;

            dgvThucAn.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btn_Exit.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isFix = true;
            btnLuu.Enabled = true;
            dgvThucAn.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txt_id.Enabled = false;
            txt_id.Enabled = true;
            txt_tenmon.Enabled = true;
            txt_loaimon.Enabled = true;
            cbSize.Enabled = true;
            txt_giatien.Enabled = true;
            btn_Exit.Visible = true;
        }

        #endregion

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
            txt_id.Enabled = false;
            txt_tenmon.Enabled = false;
            txt_loaimon.Enabled = false;
            cbSize.Enabled = false;
            txt_giatien.Enabled = false;
        }
    }
}
