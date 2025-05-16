using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlymypham.Forms
{
    public partial class formKhachHang : Form
    {
        public formKhachHang()
        {
            InitializeComponent();
        }
        DataTable tblKH;
        private void formKhachHang_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_dgridKH();
            mskdienthoai.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

        }
        private void Load_dgridKH()
        {
            string sql;
            sql = "SELECT MaKhach, TenKhach, DiaChi, DienThoai FROM KhachHang";
            tblKH = Functions.GetDataToTable(sql);
            dataGridViewKH.DataSource = tblKH;
            dataGridViewKH.Columns[0].HeaderText = "Mã khách";
            dataGridViewKH.Columns[1].HeaderText = "Tên khách";
            dataGridViewKH.Columns[2].HeaderText = "Địa chỉ";
            dataGridViewKH.Columns[3].HeaderText = "Điện thoại";
            dataGridViewKH.Columns[0].Width = 100;
            dataGridViewKH.Columns[1].Width = 200;
            dataGridViewKH.Columns[2].Width = 250;
            dataGridViewKH.Columns[3].Width = 150;
            dataGridViewKH.AllowUserToAddRows = false;
            dataGridViewKH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridViewKH_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakhach.Focus();
                return;
            }
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmakhach.Text = dataGridViewKH.CurrentRow.Cells["MaKhach"].Value.ToString();
            txttenkhach.Text = dataGridViewKH.CurrentRow.Cells["TenKhach"].Value.ToString();
            txtdiachi.Text = dataGridViewKH.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskdienthoai.Text = dataGridViewKH.CurrentRow.Cells["DienThoai"].Value.ToString();
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
            txtmakhach.Enabled = true;
            txtmakhach.Focus();
        }
        private void ResetValues()
        {
            txtmakhach.Text = "";
            txttenkhach.Text = "";
            txtdiachi.Text = "";
            mskdienthoai.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakhach.Focus();
                return;
            }
            if (txttenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhach.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            sql = "SELECT MaKhach FROM KhachHang WHERE MaKhach=N'" + txtmakhach.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakhach.Focus();
                txtmakhach.Text = "";
                return;
            }
            sql = "INSERT INTO KhachHang(MaKhach,TenKhach,DiaChi,DienThoai) VALUES (N'" + txtmakhach.Text.Trim() + "',N'" + txttenkhach.Text.Trim() + "',N'" + txtdiachi.Text.Trim() + "','" + mskdienthoai.Text + "')";
            Functions.RunSql(sql);
            Load_dgridKH();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmakhach.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhach.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            sql = "UPDATE KhachHang SET  TenKhach=N'" + txttenkhach.Text.Trim().ToString() +
                  "',Diachi=N'" + txtdiachi.Text.Trim().ToString() +
                  "',Dienthoai='" + mskdienthoai.Text.ToString() +
                  "' WHERE MaKhach=N'" + txtmakhach.Text + "'";
            Functions.RunSql(sql);
            Load_dgridKH();
            ResetValues();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE KhachHang WHERE MaKhach=N'" + txtmakhach.Text + "'";
                Functions.RunSqlDel(sql);
                Load_dgridKH();
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
            txtmakhach.Enabled = false;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtmakhach.Text == "") && (txttenkhach.Text == "")
                && (txtdiachi.Text == "")
                && (mskdienthoai.Text == "")
                )
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM KhachHang WHERE 1=1";
            if (txtmakhach.Text != "")
                sql = sql + " AND MaKhach Like N'%" + txtmakhach.Text + "%'";
            if (txttenkhach.Text != "")
                sql = sql + " AND TenKhach Like N'%" + txttenkhach.Text + "%'";
            if (txtdiachi.Text != "")
                sql = sql + " AND DiaChi Like N'%" + txtdiachi.Text + "%'";
            if (mskdienthoai.Text.Trim().Length != 0)
                sql = sql + "AND DienThoai Like N'%" + mskdienthoai.Text + "%'";

            tblKH = Functions.GetDataToTable(sql);
            if (tblKH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblKH.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dataGridViewKH.DataSource = tblKH;
            ResetValues();

        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            Load_dgridKH();
            ResetValues();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
            var main = Application.OpenForms.OfType<GD_Chinh>().FirstOrDefault();
            
        }
    }
}
