using QuanLyCafe.BLL;
using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyCafe.GUI.CLDUI
{
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
            LoadDataDoanhThu();
            LoadLoaiIDon();
        }
        #region DoanhThu
        BLL.DoanhThu mh;
        private void LoadDataDoanhThu()
        {
            DataTable tblmh;
            mh = new BLL.DoanhThu();

            if (mh.Connect())
            {
                tblmh = mh.GetDataDoanhThu();
                dgvDoanhThu.DataSource = tblmh;
                mh.DisConnect();
            }
            else
            {
                MessageBox.Show("ko có kết nối database", "Thông Báo");
            }

            dgvDoanhThu.Columns["ID"].HeaderText = "Số Thứ Tự";
            dgvDoanhThu.Columns["NAME"].HeaderText = "Tên Bàn";
            dgvDoanhThu.Columns["TENMON"].HeaderText = "Tên Đơn";
            dgvDoanhThu.Columns["DONGIA"].HeaderText = "Đơn Giá";
            dgvDoanhThu.Columns["SOLUONG"].HeaderText = "Số Lượng";
            dgvDoanhThu.Columns["THANHTIEN"].HeaderText = "Thành Tiền";
            dgvDoanhThu.Columns["TIME"].HeaderText = "Thời GIan";
        }

        void LoadLoaiIDon()
        {
            ComboBox cmb;
            mh = new DoanhThu();
            if (mh.Connect())
            {
                DataTable data = mh.GetTen();

                // Gán dữ liệu từ DataTable vào ComboBox
                cmb = new ComboBox();
                cmb.DataSource = data;
                cmb.DisplayMember = "NAME"; // Thay "TENLOAI" bằng tên cột bạn muốn hiển thị trong ComboBox
                cmb.ValueMember = "NAME"; // Thay "TENLOAI" bằng tên cột bạn muốn sử dụng làm giá trị.

                cbTable.DisplayMember = cmb.DisplayMember; // Gán tên cột hiển thị
                cbTable.ValueMember = cmb.ValueMember;     // Gán tên cột làm giá trị
                cbTable.DataSource = cmb.DataSource;        // Gán dữ liệu từ ComboBox gốc

                mh.DisConnect();
            }
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = TuNgay.Value;
            DateTime denNgay = DenNgay.Value;
            string tenTable = cbTable.Text;

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(tenTable))
            {
                MessageBox.Show("Vui lòng chọn tên từ ComboBox.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BLL.DoanhThu doanhThuBLL = new BLL.DoanhThu();

            if (doanhThuBLL.Connect())
            {
                DataTable doanhThuData = doanhThuBLL.GetDataDoanhThuTheoNgay(tuNgay, denNgay, tenTable);
                dgvDoanhThu.DataSource = doanhThuData;
                doanhThuBLL.DisConnect();
            }
            else
            {
                MessageBox.Show("Không có kết nối với cơ sở dữ liệu.", "Thông Báo");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDataDoanhThu();
        }

        private void btn_LayThongKe_Click(object sender, EventArgs e)
        {
            if (dgvDoanhThu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất ra Excel.", "Thông Báo");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Chọn vị trí lưu tệp Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string excelFilePath = saveFileDialog.FileName;

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.Worksheets.Add();

                // Tiêu đề
                worksheet.Cells[1, 1] = "THỐNG KÊ BÁN HÀNG";
                worksheet.Cells[2, 1] = "Ngày thống kê: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                // Tạo tiêu đề từ DataGridView
                for (int i = 0; i < dgvDoanhThu.Columns.Count; i++)
                {
                    worksheet.Cells[4, i + 1] = dgvDoanhThu.Columns[i].HeaderText;
                }

                // Thêm dữ liệu từ DataGridView
                for (int row = 0; row < dgvDoanhThu.Rows.Count; row++)
                {
                    for (int cell = 0; cell < dgvDoanhThu.Columns.Count; cell++)
                    {
                        object cellValue = dgvDoanhThu.Rows[row].Cells[cell].Value;
                        if (cellValue != null)
                        {
                            worksheet.Cells[row + 5, cell + 1] = cellValue.ToString();
                        }
                        else
                        {
                            worksheet.Cells[row + 5, cell + 1] = string.Empty;
                        }
                    }
                }

                // Tổng thành tiền
                double tongThanhTien = 0;
                for (int row = 0; row < dgvDoanhThu.Rows.Count; row++)
                {
                    object cellValue = dgvDoanhThu.Rows[row].Cells["THANHTIEN"].Value;
                    if (cellValue != null && cellValue != DBNull.Value)
                    {
                        double thanhTien;
                        if (double.TryParse(cellValue.ToString(), out thanhTien))
                        {
                            tongThanhTien += thanhTien;
                        }
                    }
                }

                worksheet.Cells[dgvDoanhThu.Rows.Count + 6, 1] = "Tổng thành tiền:";
                worksheet.Cells[dgvDoanhThu.Rows.Count + 6, 2] = tongThanhTien;

                workbook.SaveAs(excelFilePath);
                excelApp.Quit();

                MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel.", "Thông Báo");
            }
        }

        #endregion
    }
}
