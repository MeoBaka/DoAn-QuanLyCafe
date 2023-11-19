using System.Data.SqlClient;
using System.Data;
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
            if ((connection.State == ConnectionState.Closed) || (connection.State == ConnectionState.Broken))
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

        public SqlCommand Command(string query, string[] para, object[] Values, bool isStored)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            if (isStored)
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
            }
            if (para != null)
            {
                for (int i = 0; i < para.Length; i++)
                {
                    cmd.Parameters.AddWithValue(para[i], Values[i]);
                }
            }
            return cmd;
        }

        public SqlDataReader ExecuteReader(string query, string[] para, object[] Values, bool isStored)
        {
            SqlDataReader reader = Command(query, para, Values, isStored).ExecuteReader();
            Disconnect();
            return reader;
        }
        public int ExecuteNonQuery(string query, string[] para, object[] Values, bool isStored)
        {
            int rec = Command(query, para, Values, isStored).ExecuteNonQuery();
            Disconnect();
            return rec;
        }
        public int ExecuteScalar(string query, string[] para, object[] Values)
        {
            int scalar = (int)Command(query, para, Values, false).ExecuteScalar();
            Disconnect();
            return scalar;
        }
        public DataTable GetData(string query, string[] para, object[] Values, bool isStored)
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = Command(query, para, Values, isStored);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tbl);
            Disconnect();
            return tbl;
        }

    }
}
