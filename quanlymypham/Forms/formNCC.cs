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
    public partial class formNCC : Form
    {
        public formNCC()
        {
            InitializeComponent();
        }
        DataTable tblNCC;

        private void formNCC_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_dataGridViewNCC();
            mskDienthoai.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }
        private void Load_dataGridViewNCC()
        {
            string sql;
            sql = "SELECT MaNCC, TenNCC, DiaChi, DienThoai FROM NhaCungCap";
            tblNCC = Functions.GetDataToTable(sql);
            dataGridViewNCC.DataSource = tblNCC;
            dataGridViewNCC.Columns[0].HeaderText = "Mã nhà cung cấp";
            dataGridViewNCC.Columns[1].HeaderText = "Tên nhà cung cấp";
            dataGridViewNCC.Columns[2].HeaderText = "Địa chỉ";
            dataGridViewNCC.Columns[3].HeaderText = "Điện thoại";
            dataGridViewNCC.AllowUserToAddRows = false;
            dataGridViewNCC.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dataGridViewNCC_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMancc.Focus();
                return;
            }
            if (tblNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMancc.Text = dataGridViewNCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            txtTenncc.Text = dataGridViewNCC.CurrentRow.Cells["TenNCC"].Value.ToString();
            txtDiachi.Text = dataGridViewNCC.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskDienthoai.Text = dataGridViewNCC.CurrentRow.Cells["DienThoai"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtMancc.Enabled = true;
            txtMancc.Focus();
        }
        private void ResetValues()
        {
            txtMancc.Text = "";
            txtTenncc.Text = "";
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMancc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMancc.Focus();
                return;
            }
            if (txtTenncc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenncc.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            sql = "INSERT INTO NhaCungCap(MaNCC, TenNCC, DiaChi, DienThoai) VALUES (N'" + txtMancc.Text.Trim() + "', N'" + txtTenncc.Text.Trim() + "', N'" + txtDiachi.Text.Trim() + "', '" + mskDienthoai.Text.Trim() + "')";
            Functions.RunSql(sql);
            Load_dataGridViewNCC();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtMancc.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMancc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMancc.Focus();
                return;
            }
            if (txtTenncc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenncc.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            sql = "UPDATE NhaCungCap SET  TenNCC=N'" + txtTenncc.Text.Trim().ToString() +
                  "',Diachi=N'" + txtDiachi.Text.Trim().ToString() +
                  "',Dienthoai='" + mskDienthoai.Text.ToString() +
                  "' WHERE MaKhach=N'" + txtMancc.Text + "'";
            Functions.RunSql(sql);
            Load_dataGridViewNCC();
            ResetValues();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMancc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NhaCungCap WHERE MaNCC=N'" + txtMancc.Text + "'";
                Functions.RunSqlDel(sql);
                Load_dataGridViewNCC();
                ResetValues();
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtMancc.Enabled = false;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMancc.Text == "") && (txtTenncc.Text == "")
                && (txtDiachi.Text == "")
                && (mskDienthoai.Text == "")
                )
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM NhaCungCap WHERE 1=1";
            if (txtMancc.Text != "")
                sql = sql + " AND MaNCC Like N'%" + txtMancc.Text + "%'";
            if (txtTenncc.Text != "")
                sql = sql + " AND TenNCC Like N'%" + txtTenncc.Text + "%'";
            if (txtDiachi.Text != "")
                sql = sql + " AND DiaChi Like N'%" + txtDiachi.Text + "%'";
            if (mskDienthoai.Text.Trim().Length != 0)
                sql = sql + "AND DienThoai Like N'%" + mskDienthoai.Text + "%'";

            tblNCC = Functions.GetDataToTable(sql);
            if (tblNCC.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblNCC.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dataGridViewNCC.DataSource = tblNCC;
            ResetValues();
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            Load_dataGridViewNCC();
            ResetValues();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
            var main = Application.OpenForms.OfType<GD_Chinh>().FirstOrDefault();
        }
    }
}
