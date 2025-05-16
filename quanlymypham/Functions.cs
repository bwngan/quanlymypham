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
            connString = "Data Source=ADMIN-PC\\THU;Initial Catalog=quanlymypham;Integrated Security=True;Encrypt=False";
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
            var table = new DataTable();
            try
            {
                Connect();

                using (var da = new SqlDataAdapter(sql, conn))
                {
                    da.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
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

        public static string GetFieldValues(string sql)
        {
            Connect();
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Functions.conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
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
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }

    }
}
  