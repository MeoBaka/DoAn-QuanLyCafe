using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QuanLyCafe.BLL
{
    internal class TaiKhoan
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
            return provider.GetData("SELECT * FROM M3_ACCOUNT", Param, values, false);
        }

        public DataTable GetTK(string name)
        {
            DataTable table = new DataTable();
            string strsql = $"SELECT USERS, ROLE FROM M3_ACCOUNT WHERE USERS='{name}'";
            SqlCommand Cmd = new SqlCommand(strsql, Connection());
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            adapter.Fill(table);
            return table;
        }

        public int CheckPass(TaiKhoan tk,string user, string pass)
        {
            string sql = $"SELECT COUNT(*) FROM M3_ACCOUNT WHERE USERS = @user AND PASSWORD = @pass";
            string[] param = { "@user" , "@pass" };
            object[] value = { user, pass};
            return tk.TaiKhoanExecuteScalar(sql, param, value);
        }
        public int Doipass(TaiKhoan tk,string user, string pass)
        {
            string sql = $"UPDATE M3_ACCOUNT SET PASSWORD=@pass WHERE USERS=@user";
            string[] param = { "@user", "@pass" };
            object[] value = { user, pass };
            return tk.TaiKhoanExecuteNonQuery(sql, param, value, false);
        }


        public DataTable GetlSVDon(string tenban)
        {
            DataTable table = new DataTable();
            string strsql = $"SELECT TENMON, DONGIA, SOLUONG, THANHTIEN, ID FROM M3_LOGDON WHERE NAME = '{tenban}'";
            SqlCommand Cmd = new SqlCommand(strsql, Connection());
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            adapter.Fill(table);
            return table;
        }



        public int TaiKhoanExecuteNonQuery(string sql, string[] param, object[] value, bool isStored)
        {
            return provider.ExecuteNonQuery(sql, param, value, isStored);
        }
        public int TaiKhoanExecuteScalar(string data1, string[] data2, object[] data3)
        {
            return provider.ExecuteScalar(data1, data2, data3);
        }
    }
}
