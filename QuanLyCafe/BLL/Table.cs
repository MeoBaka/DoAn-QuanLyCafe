using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QuanLyCafe.BLL
{
    internal class Table
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

        public DataTable GetDataTable()
        {
            string[] Param = { };
            string[] values = { };
            return provider.GetData("SELECT * FROM M3_TABLE", Param, values, false);
        }

        public DataTable GetlSVDon(string tenban)
        {
            DataTable table = new DataTable();
            string strsql = $"SELECT TENMON, DONGIA, SOLUONG, THANHTIEN FROM M3_LOGDON WHERE NAME = '{tenban}'";
            SqlCommand Cmd = new SqlCommand(strsql, Connection());
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            adapter.Fill(table);
            return table;
        }



        public int TableExecuteNonQuery(string sql, string[] param, object[] value, bool isStored)
        {
            return provider.ExecuteNonQuery(sql, param, value, isStored);
        }
        public int TableExecuteScalar(string data1, string[] data2, object[] data3)
        {
            return provider.ExecuteScalar(data1, data2, data3);
        }
    }
}
