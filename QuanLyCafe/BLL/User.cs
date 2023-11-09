using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QuanLyCafe.BLL
{
    internal class User
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

        public int CheckUser(string User, string Pass)
        {
            provider.Connect();
            string strsql = "select count(*) from M3_ACCOUNT where ((USERS=@TaiKhoan) and (PASSWORD=@MatkhauNguoiDung))";
            SqlCommand Cmd = new SqlCommand(strsql, Connection());

            SqlParameter para1 = new SqlParameter("@Taikhoan", User);
            SqlParameter para2 = new SqlParameter("@MatkhauNguoiDung", Pass);

            Cmd.Parameters.Add(para1);
            Cmd.Parameters.Add(para2);

            int kqsql = (int)Cmd.ExecuteScalar();
            return kqsql;
        }

        public int UserExecuteNonQuery(string data1, string[] data2, object[] data3, bool data4)
        {
            return provider.ExecuteNonQuery(data1, data2, data3, data4);
        }
        public int UserExecuteScalar(string data1, string[] data2, object[] data3)
        {
            return provider.ExecuteScalar(data1, data2, data3);
        }
    }
}
