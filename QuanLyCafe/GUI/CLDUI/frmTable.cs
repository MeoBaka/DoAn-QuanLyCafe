using DGVPrinterHelper;
using QuanLyCafe.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace QuanLyCafe.GUI.CLDUI
{
    public partial class frmTable : Form
    {
        LoaiDon loaidon;
        public frmTable()
        {
            InitializeComponent();
            LoadTablesFromDatabase();
        }
        public void LoadTablesFromDatabase()
        {
            Table table = new Table();
            table.Connect(); // Thiết lập kết nối

            DataTable tableData = table.GetDataTable(); // Lấy dữ liệu từ cơ sở dữ liệu

            foreach (DataRow row in tableData.Rows)
            {
                string tableName = row["NAME"].ToString(); // Lấy tên bàn từ cột NAME
                string status = row["STATUS"].ToString(); // Lấy trạng thái từ cột STATUS

                AddTable(tableName, status); // Gọi lại hàm AddTable với thông tin từ cơ sở dữ liệu
            }
            table.DisConnect(); // Đảm bảo đóng kết nối sau khi hoàn thành công việc
        }

        public void ReloadFlpTable()
        {
            Table table = new Table();
            table.Connect(); // Thiết lập kết nối

            DataTable tableData = table.GetDataTable(); // Lấy dữ liệu từ cơ sở dữ liệu

            // Xoá toàn bộ button trên flpTable
            flpTable.Controls.Clear();

            foreach (DataRow row in tableData.Rows)
            {
                string tableName = row["NAME"].ToString(); // Lấy tên bàn từ cột NAME
                string status = row["STATUS"].ToString(); // Lấy trạng thái từ cột STATUS

                AddTable(tableName, status); // Gọi lại hàm AddTable với thông tin từ cơ sở dữ liệu
                string tenBan = selectedButton.Text;
                int index = tenBan.IndexOf("\n");
                tenBan = tenBan.Substring(0, index);
                lbl_Select.Text = "Đang Chọn: "+tenBan;
            }
            table.DisConnect(); // Đảm bảo đóng kết nối sau khi hoàn thành công việc
        }


        Button selectedButton = null;
        string selectedButtonStatus = "";
        void AddTable(string tableName, string status)
        {
            Button newButton = new Button();
            newButton.Text = tableName + (status.ToLower() == "trống" ? "\nTrống" : "\nĐang Dùng"); // Sử dụng tên bàn và trạng thái được truyền vào
            newButton.Size = new Size(90, 90);
            newButton.FlatStyle = FlatStyle.Flat;

            if (status.ToLower() == "trống")
            {
                newButton.BackColor = Color.Aqua;
            }
            else
            {
                newButton.BackColor = Color.OrangeRed;
            }

            newButton.Click += (sender, e) =>
            {
                // Kiểm tra nếu đã có một nút khác đang chọn
                if (selectedButton != null)
                {
                    // Reset nền của nút trước đó về màu mặc định
                    selectedButton.BackColor = selectedButtonStatus.ToLower() == "trống" ? Color.Aqua : Color.OrangeRed;

                    // Bỏ phần " (Đang Chọn)" khỏi tên nút trước đó nếu có
                    selectedButton.Text = selectedButton.Text.Replace(" (Đang Chọn)", "");
                }

                // Cập nhật thông tin của nút đang chọn
                selectedButton = newButton;
                selectedButtonStatus = status;

                // Đặt nền của nút đang chọn thành màu vàng
                selectedButton.BackColor = Color.Yellow;

                // Thêm " (Đang Chọn)" vào tên nút đang chọn
                selectedButton.Text += " (Đang Chọn)";
                string tenBan = selectedButton.Text;
                int index = tenBan.IndexOf("\n");
                tenBan = tenBan.Substring(0, index);
                lbl_Select.Text = "Đang Chọn: " + tenBan;
                UpdateListView(); 
                CalculateTotalBill();
            };

            flpTable.Controls.Add(newButton);
            
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (selectedButton == null)
            {
                MessageBox.Show("Vui lòng chọn một bàn trước.", "Thông báo");
                return;
            }

            ListViewItem existingItem = null;
            foreach (ListViewItem item in lsvBill2.Items)
            {
                existingItem = item;
                break;
            }
            if (existingItem == null)
            {
                MessageBox.Show("Bàn Này đang trống", "Thông Báo");
                return;
            }


            // Lấy thông tin từ ListView và tổng tiền
            StringBuilder sb = new StringBuilder();
            decimal tongTien = 0;
            string tenBan = selectedButton.Text;
            int index = tenBan.IndexOf("\n");
            tenBan = tenBan.Substring(0, index);
            BILL bILL = new BILL();
            string getthanhTien = "";
            foreach (ListViewItem item in lsvBill2.Items)
            {
                string tenMon = item.SubItems[0].Text;
                int soLuong = int.Parse(item.SubItems[1].Text);
                decimal donGia = decimal.Parse(item.SubItems[2].Text.Replace(",", "").Replace("vnđ", "")); // Loại bỏ dấu phẩy và "vnđ"
                decimal thanhTien = decimal.Parse(item.SubItems[3].Text.Replace(",", "").Replace("vnđ", "")); // Loại bỏ dấu phẩy và "vnđ"

                sb.AppendLine($"Tên món: {tenMon}, Số lượng: {soLuong}, Đơn giá: {donGia:#,##0} vnđ, Thành tiền: {thanhTien:#,##0} vnđ");
                getthanhTien = $"{thanhTien:#,##0}";

                tongTien += thanhTien;
                if (bILL.Connect())
                {
                    int rec = UpdateDoanhThu(bILL, tenBan, tenMon, soLuong, thanhTien, donGia.ToString());
                }
            }

            // Hiển thị MessageBox
            string thongTinBill = sb.ToString();
            string thongBao = $"Thông tin bàn: Bàn 1\n\n{thongTinBill}\n\nTổng tiền: {tongTien:#,##0} vnđ";
            MessageBox.Show(thongBao, "Hóa đơn thanh toán");

            // Xoá toàn bộ dữ liệu trong ListView và cập nhật txt_ThanhToan
            

            DGVPrinter printer = new DGVPrinter();

            printer.Title = "HOÁ ĐƠN THANH TOÁN";
            printer.SubTitle = $"Vị Trí: {tenBan} | \tThời Gian: {DateTime.Now}";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = $"Thành Tiền: {getthanhTien:#,##0}\r\n Cảm Ơn Đã Sử Dụng Dịch Vụ";
            DataTable dt = new DataTable();
            foreach (ColumnHeader column in lsvBill2.Columns)
            {
                dt.Columns.Add(column.Text);
            }
            foreach (ListViewItem item in lsvBill2.Items)
            {
                DataRow row = dt.NewRow();
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    if (!string.IsNullOrEmpty(item.SubItems[i].Text) && i < dt.Columns.Count)
                    {
                        row[i] = item.SubItems[i].Text;
                    }
                }
                dt.Rows.Add(row);
            }
            printbill.DataSource = dt;
            printer.PrintDataGridView(printbill);


            if (bILL.Connect())
            {
                int rec = UpdateBill(bILL, tenBan);
            }
            Table table = new Table(); ;
            if (table.Connect())
            {
                int rec = UpdateTable(table, "Trống", tenBan);
            }
            
            txt_ThanhToan.Text = "0"; // Đặt lại giá trị tổng tiền thành 0
            lsvBill2.Items.Clear();

            ReloadFlpTable();
            lbl_Select.Text = "Vừa Chọn: "+tenBan;
            selectedButton = null;
        }
        private int UpdateBill(BILL bll,string tenban)
        {
            string sql = "DELETE FROM M3_LOGDON WHERE NAME=@tenban";
            string[] param = { "@tenban" };
            object[] value = { tenban };
            return bll.TableExecuteNonQuery(sql,param,value,false);
        }
        private void frmTable_Load(object sender, EventArgs e)
        {
            LoadLoaiIDon();
        }
        void LoadLoaiIDon()
        {
            ComboBox cmb;
            loaidon = new LoaiDon();
            if (loaidon.Connect())
            {
                DataTable data = loaidon.GetDon();

                // Gán dữ liệu từ DataTable vào ComboBox
                cmb = new ComboBox();
                cmb.DataSource = data;
                cmb.DisplayMember = "TENLOAI"; // Thay "TENLOAI" bằng tên cột bạn muốn hiển thị trong ComboBox
                cmb.ValueMember = "TENLOAI"; // Thay "TENLOAI" bằng tên cột bạn muốn sử dụng làm giá trị.

                cbLoai.DisplayMember = cmb.DisplayMember; // Gán tên cột hiển thị 
                cbLoai.ValueMember = cmb.ValueMember;     // Gán tên cột làm giá trị
                cbLoai.DataSource = cmb.DataSource;        // Gán dữ liệu từ ComboBox gốc

                loaidon.DisConnect();
            }
        }
        private void LoadDon(string loaiDuocChon)
        {
            loaidon = new LoaiDon();
            if (loaidon.Connect())
            {
                DataTable data = loaidon.NhanCDDon(loaiDuocChon);

                // Tạo danh sách các mục định dạng theo yêu cầu
                List<string> donItems = new List<string>();

                foreach (DataRow row in data.Rows)
                {
                    string giatri = row["GIATIEN"].ToString();
                    string size = row["MSIZE"].ToString();
                    string ten = row["TENDON"].ToString();
                    string donItem = $"{giatri,-7}| {size,-6}| {ten}";
                    donItems.Add(donItem);
                }
                
                // Gán danh sách các mục định dạng cho ComboBox cbDon
                cbDon.DataSource = donItems;

                loaidon.DisConnect();
            }
        }
        // Gọi hàm LoadDon khi có sự kiện thay đổi trong ComboBox cbLoai
        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loaiDuocChon = cbLoai.Text; // Lấy giá trị đã chọn
            LoadDon(loaiDuocChon);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value < 1)
            {
                MessageBox.Show("Số Lượng không được nhỏ hơn 1","Thông Báo");
                numericUpDown1.Value = 1;
            }
        }
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn bàn chưa
            if (selectedButton == null)
            {
                MessageBox.Show("Vui lòng chọn một bàn trước.", "Thông báo");
                return;
            }

            // Kiểm tra xem đã chọn đơn ở cbDon chưa
            if (cbDon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một đơn trước.", "Thông báo");
                return;
            }

            string cbDonText = cbDon.Text; // Lấy nội dung từ ComboBox

            string[] parts = cbDonText.Split('|'); // Tách chuỗi thành mảng các phần

            if (parts.Length == 3)
            {
                string giatri = parts[0].Trim(); // Lấy giá trị và loại bỏ khoảng trắng
                string size = parts[1].Trim();   // Lấy size và loại bỏ khoảng trắng
                string ten = parts[2].Trim();    // Lấy tên và loại bỏ khoảng trắng

                decimal donGia = decimal.Parse(giatri); // Chuyển đổi giatri thành số thực
                int soLuong = (int)numericUpDown1.Value; // Lấy số lượng

                decimal thanhTien = donGia * soLuong; // Tính thành tiền

                // Đoạn code sau đây làm việc với cơ sở dữ liệu
                // Bạn cần điều chỉnh kết nối cơ sở dữ liệu của bạn ở đây để thêm thông tin vào bảng M3_LOGDON

                // Tên bàn đã chọn
                string tenBan = selectedButton.Text;
                int index = tenBan.IndexOf("\n");
                tenBan = tenBan.Substring(0, index);

                // Đặt status bàn là 'Đang Dùng' trong cơ sở dữ liệu
                // Code của bạn để thay đổi trạng thái bàn trong bảng M3_TABLE ở đây
                // Ví dụ:
                // string queryUpdateTableStatus = $"UPDATE M3_TABLE SET STATUS = 'Đang Dùng' WHERE NAME = '{tenBan}'";
                // provider.ExecuteQuery(queryUpdateTableStatus, null, null, false);

                // Đoạn code sau đây thêm thông tin vào bảng M3_LOGDON

                // Code của bạn để thêm thông tin vào bảng M3_LOGDON ở đây
                // Ví dụ:
                BILL bILL = new BILL();
                if (bILL.Connect())
                {
                    int rec = UpdateBill(bILL, tenBan, ten, soLuong, thanhTien, giatri);
                }
                
                Table table = new Table(); ;
                if (table.Connect())
                {
                    int rec = UpdateTable(table, "Đang Dùng", tenBan);
                }

                ListViewItem existingItem = null;
                foreach (ListViewItem item in lsvBill2.Items)
                {
                    if (item.SubItems[0].Text == ten && item.SubItems[1].Text == giatri)
                    {
                        existingItem = item;
                        break;
                    }
                }
                if (existingItem != null)
                {
                    // Nếu món đã tồn tại, cộng dồn số lượng và tính lại thành tiền
                    int existingQuantity = int.Parse(existingItem.SubItems[2].Text);
                    existingItem.SubItems[2].Text = (existingQuantity + soLuong).ToString();
                    decimal existingTotal = decimal.Parse(existingItem.SubItems[3].Text);
                    existingItem.SubItems[3].Text = (existingTotal + thanhTien).ToString("N2");
                }
                else
                {
                    // Nếu món chưa tồn tại, thêm mới vào ListView
                    ListViewItem newItem = new ListViewItem(new string[] { ten, giatri, soLuong.ToString(), thanhTien.ToString("N2") });
                    lsvBill2.Items.Add(newItem);
                }

                // Cập nhật ListView và TextBox
                UpdateListView();
                CalculateTotalBill();
                ReloadFlpTable();
            }
        }
        private int UpdateTable(Table table, string status, string tenban)
        {
            string queryupdatelogdon = "UPDATE M3_TABLE SET STATUS=@status WHERE NAME=@tenban";
            string[] param = { "@status", "@tenban" };
            object[] value = { status, tenban };
            return table.TableExecuteNonQuery(queryupdatelogdon, param, value, false);
        }
        private int UpdateBill(BILL bll,string tenBan,string ten, int soLuong, decimal thanhTien, string giatri)
        {
            string queryInsertLogDon = "INSERT INTO M3_LOGDON (NAME, TENMON, DONGIA, SOLUONG, THANHTIEN, TIME) VALUES (@TenBan, @TenMon, @dongia, @SoLuong, @ThanhTien, @thoigian)";
            string[] para = { "@TenBan", "@TenMon", "@dongia", "@SoLuong", "@ThanhTien", "@thoigian" };
            object[] values = { tenBan, ten, giatri, soLuong, thanhTien, DateTime.Now };
            return bll.TableExecuteNonQuery(queryInsertLogDon, para, values, false);
        }
        private int UpdateDoanhThu(BILL bll,string tenBan,string ten, int soLuong, decimal thanhTien, string giatri)
        {
            string queryInsertLogDon = "INSERT INTO M3_DOANHTHU (NAME, TENMON, DONGIA, SOLUONG, THANHTIEN, TIME) VALUES (@TenBan, @TenMon, @dongia, @SoLuong, @ThanhTien, @thoigian)";
            string[] para = { "@TenBan", "@TenMon", "@dongia", "@SoLuong", "@ThanhTien", "@thoigian" };
            object[] values = { tenBan, ten, giatri, soLuong, thanhTien, DateTime.Now };
            return bll.TableExecuteNonQuery(queryInsertLogDon, para, values, false);
        }

        private void UpdateListView()
        {
            // Kiểm tra xem đã chọn bàn chưa
            if (selectedButton == null)
            {
                return;
            }

            string tenBan = selectedButton.Text; // Lấy tên bàn đã chọn
            int index = tenBan.IndexOf("\n");
            tenBan = tenBan.Substring(0, index);

            // Đoạn code sau đây làm việc với cơ sở dữ liệu để cập nhật trạng thái bàn

            // Code của bạn để cập nhật trạng thái bàn trong bảng M3_TABLE ở đây
            // Ví dụ:
            // string queryUpdateTableStatus = $"UPDATE M3_TABLE SET STATUS = 'Đang Dùng' WHERE NAME = '{tenBan}'";
            // provider.ExecuteQuery(queryUpdateTableStatus, null, null, false);

            // Đoạn code sau đây truy vấn cơ sở dữ liệu để lấy thông tin từ bảng M3_LOGDON

            // Code của bạn để truy vấn cơ sở dữ liệu và lấy thông tin từ bảng M3_LOGDON ở đây
            // Ví dụ:
            Table table = new Table();
            if (table.Connect())
            {
                DataTable data = table.GetlSVDon(tenBan);

                // Tạo danh sách các mục định dạng theo yêu cầu
                List<string> donItems = new List<string>();

                lsvBill2.Items.Clear(); // Xóa tất cả các mục trong ListView trước khi cập nhật 

                foreach (DataRow row in data.Rows)
                {
                    string tenMon = row["TENMON"].ToString();
                    decimal donGia = decimal.Parse(row["DONGIA"].ToString());
                    int soLuong = (int)row["SOLUONG"];
                    decimal thanhTien = decimal.Parse(row["THANHTIEN"].ToString());
                    int id = int.Parse(row["ID"].ToString());

                    // Thêm thông tin món vào ListView
                    ListViewItem item = new ListViewItem(tenMon);
                    item.SubItems.Add(soLuong.ToString());
                    item.SubItems.Add(donGia.ToString("#,###vnđ"));
                    item.SubItems.Add(thanhTien.ToString("#,###vnđ"));
                    item.SubItems.Add(id.ToString());
                    lsvBill2.Items.Add(item);

                    // Cộng dồn vào tổng thành tiền
                    //totalBill += thanhTien;
                }

                // Hiển thị tổng thành tiền của bàn đang chọn
                //txt_ThanhToan.Text = totalBill.ToString("#,###vnđ");
            }
            // Duyệt qua các dòng dữ liệu từ bảng M3_LOGDON và thêm vào ListView và tính tổng thành tiền

        }
        private void CalculateTotalBill()
        {
            decimal totalBill = 0;

            foreach (ListViewItem item in lsvBill2.Items)
            {
                int soLuong = int.Parse(item.SubItems[1].Text); // Lấy số lượng từ ListView
                decimal donGia = decimal.Parse(item.SubItems[2].Text.Replace("vnđ", "").Replace(",", "")); // Lấy đơn giá từ ListView

                decimal thanhTien = soLuong * donGia; // Tính thành tiền

                item.SubItems[3].Text = thanhTien.ToString("#,###vnđ"); // Cập nhật giá trị thành tiền trong ListView

                totalBill += thanhTien; // Cộng dồn vào tổng thành tiền
            }

            // Hiển thị tổng thành tiền trong txt_ThanhToan
            txt_ThanhToan.Text = totalBill.ToString("#,###vnđ");
        }
        private int XoaDonHang(Table tl, int id)
        {
            string sql = "DELETE FROM M3_LOGDON WHERE ID=@id";
            string[] param = { "@id"};
            object[] value = { id };
            return tl.TableExecuteNonQuery(sql, param, value, false);
        }
        private void btnHuyBill_Click(object sender, EventArgs e)
        {
            if(selectedButton == null)
            {
                MessageBox.Show("Vui lòng chọn 1 đơn để huỷ","Thông báo");
                return;
            }
            Table table = new Table();
            string tenBan = selectedButton.Text;
            int index = tenBan.IndexOf("\n");
            tenBan = tenBan.Substring(0, index);

            

            if (lsvBill2.SelectedItems.Count > 0)
            {
                // Lấy ListViewItem đang được chọn
                ListViewItem selectedItem = lsvBill2.SelectedItems[0];

                // Lấy thông tin từ cột được chọn
                string col1 = selectedItem.SubItems[0].Text;
                string col2 = selectedItem.SubItems[1].Text;
                string col3 = selectedItem.SubItems[2].Text;
                string col4 = selectedItem.SubItems[3].Text;
                string col5 = selectedItem.SubItems[4].Text;

                // Loại bỏ dấu phẩy và chuyển đổi thành số thực
                decimal col3Value = decimal.Parse(col3.Replace(",", "").Replace("vnđ", ""));
                decimal col4Value = decimal.Parse(col4.Replace(",", "").Replace("vnđ", ""));

                // Định dạng lại giá trị thành chuỗi với số lẻ là hai chữ số
                Console.WriteLine(tenBan + col1 + col2 + col3Value + col4Value);
                // formattedCol2 sẽ chứa giá trị "29000.00"
                DialogResult kq = MessageBox.Show($"Bạn có muốn huỷ đơn {col1} từ {tenBan} không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    // Hiển thị thông tin cột được chọn trong MessageBox
                    if (table.Connect())
                    {
                        int rec = XoaDonHang(table, int.Parse(col5));
                        Console.WriteLine(rec);
                        if (rec > 0)
                        {
                            MessageBox.Show("Đã Xoá Thành Công", "Thông Báo");
                            UpdateListView();
                            CalculateTotalBill();
                        }
                    }
                }
            }

            Console.WriteLine(lsvBill2.Items.Count);
            if (lsvBill2.Items.Count == 0)
            {
                // If lsvBill2 is empty, update the table status to "Trống"
                if (table.Connect())
                {
                    int rec = UpdateTable(table, "Trống", tenBan);
                    if (rec > 0)
                    {
                        ReloadFlpTable();
                    }
                }
            }
        }
    }
}
