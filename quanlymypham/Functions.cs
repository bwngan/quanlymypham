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
            connString = "Data Source=MSI\\NGAN;Initial Catalog=quanlymypham;Integrated Security=True;Encrypt=False";
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
        public static string ChuyenSoSangChu(string sNumber)
        {
            int mLen;
            decimal nDigit;
            string mTemp = "";
            string[] nNumText;
            // Xóa các dấu "." nếu có
            sNumber = sNumber.Replace(".", "");
            nNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
            mLen = sNumber.Length - 1; // trừ 1 vì vị trí đi từ 0
            for (int i = 0; i <= mLen; i++)
            {
                nDigit = Convert.ToDecimal(sNumber.Substring(i, 1));
                mTemp = mTemp + nNumText[(int)nDigit];
                if ((mLen - i) % 9 == 0 && (mLen - i) != 0)
                {
                    mTemp = mTemp + " tỷ";
                    if (sNumber.Substring(i + 1, 3) == "000")
                    {
                        i = i + 3;
                    }
                    if (sNumber.Substring(i + 1, 3) == "000")
                    {
                        i = i + 3;
                    }
                }
                else if ((mLen - i) % 6 == 0 && (mLen - i) != 0)
                {
                    mTemp = mTemp + " triệu";
                    if (sNumber.Substring(i + 1, 3) == "000")
                    {
                        i = i + 3;
                    }
                    if (sNumber.Substring(i + 1, 3) == "000")
                    {
                        i = i + 3;
                    }
                }
                else if ((mLen - i) % 3 == 0 && (mLen - i) != 0)
                {
                    mTemp = mTemp + " nghìn";
                    if (sNumber.Substring(i + 1, 3) == "000")
                    {
                        i = i + 3;
                    }
                }

                switch ((mLen - i) % 3)
                {
                    case 2:
                        mTemp = mTemp + " trăm";
                        break;
                    case 1:
                        mTemp = mTemp + " mươi";
                        break;
                }
            }

            // Loại bỏ trường hợp x00
            mTemp = mTemp.Replace("không mươi không", "");
            mTemp = mTemp.Replace("không mươi", "");
            // Loại bỏ trường hợp 0x0
            mTemp = mTemp.Replace("không trăm không", "");
            mTemp = mTemp.Replace("không trăm", "");
            // Loại bỏ trường hợp x0, x00
            mTemp = mTemp.Replace("mươi không", "mươi");
            mTemp = mTemp.Replace("mươi một", "mươi mốt");
            // Fix trường hợp x04, x05
            mTemp = mTemp.Replace("linh bốn", "linh tư");
            mTemp = mTemp.Replace("mươi bốn", "mươi tư");
            mTemp = mTemp.Replace("linh năm", "linh lăm");
            mTemp = mTemp.Replace("mươi năm", "mươi lăm");
            mTemp = mTemp.Replace("mươi một", "mươi mốt");
            // Bỏ ký tự space thừa
            mTemp = mTemp.Trim();
            // Viết hoa ký tự đầu tiên
            mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
            mTemp = System.Text.RegularExpressions.Regex.Replace(mTemp, @"\s+", " ");
            foreach (var u in new[] { "tỷ", "triệu", "nghìn", "trăm", "mươi", "đồng" })
            {
                mTemp = mTemp.Replace(u, u + " ");
            }
            mTemp = System.Text.RegularExpressions.Regex.Replace(mTemp.Trim(), @"\s+", " ");
            if (!mTemp.EndsWith("đồng", StringComparison.OrdinalIgnoreCase))
                mTemp += " đồng";

            return mTemp;
        }
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }


    }
}
  