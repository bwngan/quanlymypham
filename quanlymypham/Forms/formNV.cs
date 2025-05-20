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

namespace quanlymypham.Forms
{
    public partial class formNV : Form
    {
        public formNV()
        {
            InitializeComponent();
        }
        DataTable tblNV;

        private void formNV_Load(object sender, EventArgs e)
        {
            txtManv.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_dataGridViewNV();
            Functions.FillCombo("SELECT MaCV, TenCV FROM CongViec", cboMacv, "MaCV", "TenCV");
            cboMacv.SelectedIndex = -1;
            ResetValues();

        }
        private void ResetValues()
        {
            txtManv.Text = "";
            txtTennv.Text = "";
            cboMacv.Text = "";
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
            mskNgaysinh.Text = "";
            cbNam.Checked = false;
            cbNu.Checked = false;


        }
        private void Load_dataGridViewNV()
        {

            dataGridViewNV.AutoGenerateColumns = true;
            string sql;
            sql = "SELECT NhanVien.MaNV, NhanVien.TenNV,NhanVien.GioiTinh,NhanVien.NgaySinh,NhanVien.DienThoai,NhanVien.DiaChi,CongViec.TenCV FROM NhanVien JOIN CongViec ON NhanVien.MaCV=CongViec.MaCV";
            tblNV = Functions.GetDataToTable(sql);
            dataGridViewNV.DataSource = tblNV;
            dataGridViewNV.Columns[0].HeaderText = "Mã nhân viên";
            dataGridViewNV.Columns[1].HeaderText = "Tên nhân viên";            
            dataGridViewNV.Columns[2].HeaderText = "Giới Tính";
            dataGridViewNV.Columns[3].HeaderText = "Ngày Sinh";
            dataGridViewNV.Columns[4].HeaderText = "Điện Thoại";
            dataGridViewNV.Columns[5].HeaderText = "Địa Chỉ";
            dataGridViewNV.Columns[6].HeaderText = "Chức Vụ ";
            dataGridViewNV.AllowUserToAddRows = false;
            dataGridViewNV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridViewNV_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManv.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtManv.Text = dataGridViewNV.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTennv.Text = dataGridViewNV.CurrentRow.Cells["TenNV"].Value.ToString();
            mskDienthoai.Text = dataGridViewNV.CurrentRow.Cells["DienThoai"].Value.ToString();
            mskNgaysinh.Text = dataGridViewNV.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txtDiachi.Text = dataGridViewNV.CurrentRow.Cells["DiaChi"].Value.ToString();
            string Gioitinh = dataGridViewNV.CurrentRow.Cells["GioiTinh"].Value.ToString();
            if (Gioitinh == "Nam")
                cbNam.Checked = true;
            else
                cbNu.Checked = true;
            ma = dataGridViewNV.CurrentRow.Cells["TenCV"].Value.ToString();
            cboMacv.Text = Functions.GetFieldValues("SELECT TenCV FROM CongViec WHERE TenCV = N'" + ma + "'").ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtManv.Enabled = true;
            txtManv.Focus();            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtManv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManv.Focus();
                return;
            }
            if (txtTennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennv.Focus();
                return;
            }
            if (cboMacv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMacv.Focus();
                return;
            }
            if (mskNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            if (mskDienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (cbNam.Checked == false && cbNu.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbNam.Focus();
                return;
            }
            var dt = DateTime.ParseExact(mskNgaysinh.Text, "dd/MM/yyyy", null);
            string sIso = dt.ToString("yyyy-MM-dd");
            string gioitinh = cbNam.Checked ? "Nam" : "Nữ";
            sql = @"
                      INSERT INTO NhanVien
                        (MaNV, TenNV, GioiTinh, MaCV, NgaySinh, DienThoai, DiaChi)
                      VALUES
                        (@MaNV, @TenNV, @GioiTinh, @MaCV, @NgaySinh, @DienThoai, @DiaChi)
                    ";

            using (var cmd = new SqlCommand(sql, Functions.conn))
            {
                cmd.Parameters.AddWithValue("@MaNV", txtManv.Text.Trim());
                cmd.Parameters.AddWithValue("@TenNV", txtTennv.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
                cmd.Parameters.AddWithValue("@MaCV", cboMacv.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@NgaySinh", DateTime.ParseExact(mskNgaysinh.Text, "dd/MM/yyyy", null));
                cmd.Parameters.AddWithValue("@DienThoai", mskDienthoai.Text.Trim());
                cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text.Trim());

                cmd.ExecuteNonQuery();
            }
            Functions.RunSql(sql);
            Load_dataGridViewNV();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManv.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManv.Focus();
                return;
            }
            if (txtTennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennv.Focus();
                return;
            }
            if (cboMacv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMacv.Focus();
                return;
            }
            if (mskNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            if (mskDienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (cbNam.Checked == false && cbNu.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbNam.Focus();
                return;
            }
            var dt = DateTime.ParseExact(mskNgaysinh.Text, "dd/MM/yyyy", null);
            string sIso = dt.ToString("yyyy-MM-dd");
            string gioitinh = cbNam.Checked ? "Nam" : "Nữ";
            sql = "UPDATE NhanVien" +
                " SET TenNV=N'" + txtTennv.Text.Trim() + "',GioiTinh=N'" + gioitinh + "',MaCV='" + cboMacv.SelectedValue.ToString()+"',NgaySinh='" + sIso + "',DienThoai='" + mskDienthoai.Text.Trim() + "',DiaChi=N'" + txtDiachi.Text.Trim() + "' WHERE MaNV=N'" + txtManv.Text.Trim() + "'";
            Functions.RunSql(sql);
            Load_dataGridViewNV();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManv.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE NhanVien WHERE MaNV=N'" + txtManv.Text.Trim() + "'";
                Functions.RunSqlDel(sql);
                Load_dataGridViewNV();
                ResetValues();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtManv.Text == "")
                && (txtTennv.Text == "")
                && (cboMacv.Text == "")
                && (!cbNam.Checked)
                && (!cbNu.Checked)
                && (mskNgaysinh.Text == "")
                && (mskDienthoai.Text == "")
                && (txtDiachi.Text == "")
                )
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT Nhanvien.MaNV, Nhanvien.TenNV,Nhanvien.GioiTinh,Nhanvien.NgaySinh,Nhanvien.DienThoai,Nhanvien.DiaChi,CongViec.TenCV " +
                "FROM NhanVien JOIN CongViec ON NhanVien.MaCV=CongViec.MaCV WHERE 1=1";
            if (txtManv.Text != "")
                sql = sql + " AND NhanVien.MaNV Like N'%" + txtManv.Text + "%'";
            if (txtTennv.Text != "")
                sql = sql + " AND NhanVien.TenNV Like N'%" + txtTennv.Text + "%'";
            if (cboMacv.Text != "")
                sql = sql + " AND CongViec.TenCV Like N'%" + cboMacv.SelectedValue + "'";
            if (cbNam.Checked == true)
                sql = sql + " AND NhanVien.GioiTinh Like N'%" + "Nam" + "%'";
            if (cbNu.Checked == true)
                sql = sql + " AND NhanVien.GioiTinh Like N'%" + "Nữ" + "%'";
            if (mskNgaysinh.Text != "  /  /")
                sql = sql + " AND NhanVien.NgaySinh Like N'%" + mskNgaysinh.Text + "%'";
            if (mskDienthoai.Text.Trim().Length != 0)
                sql = sql + " AND NhanVien.DienThoai Like N'%" + mskDienthoai.Text + "%'";
            if (txtDiachi.Text != "")
                sql = sql + " AND NhanVien.DiaChi Like N'%" + txtDiachi.Text + "%'";
            tblNV = Functions.GetDataToTable(sql);
            if (tblNV.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblNV.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dataGridViewNV.DataSource = tblNV;
            ResetValues();
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            Load_dataGridViewNV();
            ResetValues();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManv.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            var main = Application.OpenForms.OfType<GD_Chinh>().FirstOrDefault();
        }
    }
}
