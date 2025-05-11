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
            DataTable table = new DataTable();
            try
            {
                // 1) Mở kết nối
                Connect();

                // 2) Tạo adapter với command có kết nối
                using (var cmd = new SqlCommand(sql, conn))
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu: " + ex.Message);
            }
            finally
            {
                // 3) Đóng kết nối trong mọi trường hợp
                Disconnect();
            }
            return table;
        }
        public static object GetFieldValues(string sql, params SqlParameter[] pars)
        {
            object value = null;
            try
            {
                Connect();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (pars != null && pars.Length > 0)
                        cmd.Parameters.AddRange(pars);
                    value = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
            return value;
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
