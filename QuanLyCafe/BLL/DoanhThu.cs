using System;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyCafe.BLL
{
    internal class DoanhThu
    {
        DAL.Provider provider = new DAL.Provider();

        public SqlConnection Connection()
        {
            return provider.connection;
        }

        public Boolean Connect()
        {
            return provider.Connect();
        }

        public void DisConnect()
        {
            provider.Disconnect();
        }
        public DataTable GetTen()
        {
            DataTable table = new DataTable();
            string strsql = "SELECT NAME FROM M3_TABLE";
            SqlCommand Cmd = new SqlCommand(strsql, Connection());
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            adapter.Fill(table);
            return table;
        }
        public DataTable GetDataDoanhThu()
        {
            string[] parameters = { };
            string[] values = { };
            return provider.GetData("select * from M3_DOANHTHU", parameters, values, false);
        }

        public DataTable GetDataDoanhThuTheoNgay(DateTime data1, DateTime data2, string data3)
        {
            string sql = "SELECT * FROM M3_DOANHTHU WHERE TIME BETWEEN @NgayBatDau AND @NgayKetThuc AND NAME = @TenBan";

            // Trừ đi 1 ngày từ ngày bắt đầu và ngày kết thúc
            DateTime ngayBatDau = data1.AddDays(0);
            DateTime ngayKetThuc = data2.AddDays(1);

            // Chuyển đổi thành chuỗi ngày tháng đúng định dạng
            string ngayBatDauStr = ngayBatDau.ToString("yyyy-MM-dd");
            string ngayKetThucStr = ngayKetThuc.ToString("yyyy-MM-dd");

            // Sử dụng chuỗi cho các tham số
            string[] parameters = { "@NgayBatDau", "@NgayKetThuc", "@TenBan" };
            string[] values = { ngayBatDauStr, ngayKetThucStr, data3 };

            return provider.GetData(sql, parameters, values, false);
        }



        public int MonHocExecuteNonQuery(string data1, string[] data2, object[] data3, bool isStored)
        {
            return provider.ExecuteNonQuery(data1, data2, data3, isStored);
        }
    }
}
