using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace quanlymypham
{
    class Functions
    {
        public static SqlConnection conn;
        public static string connString; 
        public static void Connect()
        {
            connString = @"Data Source=MSI\NGAN;Initial Catalog=quanlymypham;Integrated Security=True";
            conn = new SqlConnection();
            conn.ConnectionString = connString;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public static void Disconnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            
            Connect();

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            da.Fill(table);

            Disconnect();

            return table;

        }


        public static object GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma=reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
        public static void ExecuteSql(string sql, params SqlParameter[] pars)
        {
            try
            {
                Connect();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (pars != null)
                        cmd.Parameters.AddRange(pars);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
    
}
