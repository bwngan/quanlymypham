using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlymypham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string user = txtDangnhap.Text.Trim();
            string pass = txtMatkhau.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                // Mở kết nối
                Functions.Connect();

                // Lấy mật khẩu từ DB
                string sql = @"
                    SELECT MatKhau 
                    FROM NhanVien 
                    WHERE TenDangNhap = @user";

                using (var cmd = new SqlCommand(sql, Functions.conn))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show(
                            "Tên đăng nhập không tồn tại.",
                            "Đăng nhập thất bại",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                    }

                    string storedPass = result.ToString();
                    if (storedPass == pass)
                    {
                        // Đăng nhập thành công → mở GD_Chinh
                        var mainForm = new Forms.GD_Chinh();
                        // Khi đóng GD_Chinh thì đóng luôn Form1
                        mainForm.FormClosed += (s, args) => this.Close();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Sai mật khẩu.",
                            "Đăng nhập thất bại",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        txtMatkhau.Clear();
                        txtMatkhau.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi kết nối hoặc truy vấn:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                // Đóng kết nối
                Functions.Disconnect();
            }
        }

        private void lDangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var registerForm = new Forms.Dangky();
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.Show();
        }
    }
}
