using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlymypham.Forms
{
    public partial class formNhanvien : Form
    {
        public formNhanvien()
        {
            InitializeComponent();
        }

        DataTable dt;

        private void formNhanvien_Load(object sender, EventArgs e)
        {
            txtManv.Enabled = false;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView() 
        {
            string sql;
            sql = "SELECT MaNV,TenNV,GioiTinh,NgaySinh,DienThoai, DiaChi, MaCV FROM NhanVien";
            dt=Functions.GetDataToTable(sql);
            dgvNhanvien.DataSource = dt;
            dgvNhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanvien.Columns[2].HeaderText = "Giới tính";
            dgvNhanvien.Columns[3].HeaderText = "Ngày sinh";
            dgvNhanvien.Columns[4].HeaderText = "Mã công việc";
            dgvNhanvien.Columns[5].HeaderText = "Điện thoại";
            dgvNhanvien.Columns[6].HeaderText = "Địa chỉ";
            dgvNhanvien.AllowUserToAddRows = false;
            dgvNhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManv.Focus();
                return;
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            txtManv.Text = dgvNhanvien.CurrentRow.Cells["MaNV"].Value.ToString();
            txtTennv.Text = dgvNhanvien.CurrentRow.Cells["TenNV"].Value.ToString();
            txtDiachi.Text = dgvNhanvien.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskDienthoai.Text = dgvNhanvien.CurrentRow.Cells["DienThoai"].Value.ToString();
            mskNgaysinh.Text = dgvNhanvien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            if (dgvNhanvien.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam")
                cbNam.Checked = true;
            else
                cbNu.Checked = true;
            ma = dgvNhanvien.CurrentRow.Cells["MaNV"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;

        }

    }
}
