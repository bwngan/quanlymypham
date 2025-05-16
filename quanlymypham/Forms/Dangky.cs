using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quanlymypham.Forms
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }

        private void Dangky_Load(object sender, EventArgs e)
        {
            cboGioitinh.Items.AddRange(new[] { "Nam", "Nữ" });
            cboGioitinh.SelectedIndex = -1;
            string sql = @"
                            SELECT ''       AS MaCV,
                                   '-- Chọn công việc --' AS TenCV
                            UNION ALL
                            SELECT MaCV, TenCV
                              FROM CongViec
                            ORDER BY TenCV";    // ORDER BY bắt buộc nằm ở cuối, sẽ tự bỏ qua với giá trị ''

            DataTable dt = Functions.GetDataToTable(sql);
            cboCongviec.DataSource = dt;
            cboCongviec.ValueMember = "MaCV";
            cboCongviec.DisplayMember = "TenCV";
            cboCongviec.SelectedIndex = 0;
        }
        private void btnDangky_Click(object sender, EventArgs e)
        {
            // 1. Validate
            if (string.IsNullOrWhiteSpace(txtManv.Text) ||
                string.IsNullOrWhiteSpace(txtTennv.Text) ||
                cboGioitinh.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(txtDienthoai.Text) ||
                string.IsNullOrWhiteSpace(txtDiachi.Text) ||
                cboCongviec.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtTendangnhap.Text) ||
                string.IsNullOrWhiteSpace(txtMatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu thông tin",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Kiểm tra trùng MaNV bằng GetDataToTable
                var dt1 = Functions.GetDataToTable(
                    $"SELECT COUNT(*) AS cnt FROM NhanVien WHERE MaNV = '{txtManv.Text.Trim().Replace("'", "''")}'");
                int cnt = Convert.ToInt32(dt1.Rows[0]["cnt"]);
                if (cnt > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại.", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Kiểm tra trùng Username
                var dt2 = Functions.GetDataToTable(
                    $"SELECT COUNT(*) AS cnt FROM NhanVien WHERE TenDangNhap = '{txtTendangnhap.Text.Trim().Replace("'", "''")}'");
                int cntUser = Convert.ToInt32(dt2.Rows[0]["cnt"]);
                if (cntUser > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. Insert
                string sql = @"
            INSERT INTO NhanVien
              (MaNV, TenNV, GioiTinh, NgaySinh, DienThoai, DiaChi, MaCV, TenDangNhap, MatKhau)
            VALUES
              (@Ma, @Ten, @GT, @NS, @DT, @DC, @CV, @User, @Pass)";
                var pars = new[]
                {
            new SqlParameter("@Ma",  txtManv.Text.Trim()),
            new SqlParameter("@Ten", txtTennv.Text.Trim()),
            new SqlParameter("@GT",  cboGioitinh.Text),
            new SqlParameter("@NS",  dtpNgaysinh.Value.Date),
            new SqlParameter("@DT",  txtDienthoai.Text.Trim()),
            new SqlParameter("@DC",  txtDiachi.Text.Trim()),
            new SqlParameter("@CV",  cboCongviec.SelectedValue),
            new SqlParameter("@User",txtTendangnhap.Text.Trim()),
            new SqlParameter("@Pass",txtMatkhau.Text)
        };
                Functions.ExecuteSql(sql, pars);

                MessageBox.Show("Đăng ký thành công. Vui lòng đăng nhập lại.", "Thành công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Về lại Form1
                new Form1().Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký:\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            var Dangnhap = new Form1();
            Dangnhap.Show();
            this.Close();
        }
    }
}
