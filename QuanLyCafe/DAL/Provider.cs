using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Configuration;

namespace QuanLyCafe.DAL
{
    internal class Provider
    {
        public SqlConnection connection;
        public bool Connect()
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["ConnectStr"].ConnectionString.ToString();
            connection = new SqlConnection(connectionStr);
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection.Open();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Disconnect()
        {
            connection.Close();
            connection.Dispose();
        }

        public SqlCommand Command(string data1, string[] data2, object[] data3, bool isStored)
        {
            SqlCommand cmd = new SqlCommand(data1, connection);
            if (isStored)
            {
                cmd.CommandText = data1;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
            }
            if (data2 != null)
            {
                for (int i = 0; i < data2.Length; i++)
                {
                    cmd.Parameters.AddWithValue(data2[i], data3[i]);
                }
            }
            return cmd;
        }

        public SqlDataReader sqlDataReader(string data1, string[] data2, object[] data3, bool isStored)
        {
            SqlDataReader reader = Command(data1, data2, data3, isStored).ExecuteReader();
            Disconnect();
            return reader;
        }

        public int ExecuteNonQuery(string data1, string[] data2, object[] data3, bool isStored)
        {
            int reader = Command(data1, data2, data3, isStored).ExecuteNonQuery();
            Disconnect();
            return reader;
        }

        public int ExecuteScalar(string data1, string[] data2, object[] data3)
        {
            int reader = (int)Command(data1, data2, data3, false).ExecuteScalar();
            Disconnect();
            return reader;
        }

        public DataTable GetData(string data1, string[] data2, object[] data3, bool isStored)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = Command(data1, data2, data3, false);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Disconnect();
            return dt;
        }
    }
}
