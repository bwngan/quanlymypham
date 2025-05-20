using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace quanlymypham
{
    class Functions
    {
        public static SqlConnection conn;
        public static string connString;
        public static void Connect()
        {
            connString = @"Data Source=MSI\NGAN;Initial Catalog=quanlymypham;Integrated Security=True;Encrypt=False";
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
            Connect();
            using (var cmd = new SqlCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                    return reader[0]?.ToString() ?? "";
            }
            Disconnect();
            return "";

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
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            Functions.Connect();
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Functions.conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;

            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;

        }




        public static bool CheckKey(string sql)
        {
            Connect();
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Functions.conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void RunSql(string sql)
        {
            Connect();
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = Functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        public static void RunSqlDel(string sql)
        {
            Connect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }
        public static bool IsDate(string strDate)
        {
            DateTime tmp;
            return DateTime.TryParseExact(
                strDate,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out tmp
            );
        }
        public static string CreateKey(string tiento)
        {
            string key = tiento;
            DateTime dt = DateTime.Now;
            string datePart = dt.ToString("yyyyMMdd");
            string timePart = dt.ToString("HHmmss");
            key += datePart + timePart;
            return key;
        }

    }
}
  