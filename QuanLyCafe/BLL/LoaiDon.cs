using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.BLL
{
    internal class LoaiDon
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

        public DataTable GetDataLoaiDon()
        {
            string[] Param = { };
            string[] values = { };
            return provider.GetData("SELECT * FROM TABLE", Param, values, false);
        }

        public DataTable GetDon()
        {
            DataTable table = new DataTable();
            string strsql = "SELECT TENLOAI FROM M3_LOAI";
            SqlCommand Cmd = new SqlCommand(strsql, Connection());
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            adapter.Fill(table);
            return table;
        }
        public DataTable NhanCDDon(string loai)
        {
            DataTable table = new DataTable();
            string strsql = $"SELECT * FROM M3_DON WHERE TENLOAI = '{loai}'";
            SqlCommand Cmd = new SqlCommand(strsql, Connection());
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            adapter.Fill(table);
            return table;
        }


        public int LoaiDonExecuteNonQuery(string sql, string[] param, object[] value, bool isStored)
        {
            return provider.ExecuteNonQuery(sql, param, value, isStored);
        }
        public int LoaiDonExecuteScalar(string data1, string[] data2, object[] data3)
        {
            return provider.ExecuteScalar(data1, data2, data3);
        }
    }
}
