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

namespace quanlymypham.Forms
{
    public partial class formThemHDN : Form
    {
        public formThemHDN()
        {
            InitializeComponent();
        }
        DataTable tblTHDN;
        private void formThemHDN_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            tblTHDN = new DataTable();
            txtSoHDN.Text = Functions.CreateKey("HDN");
            txtSoHDN.ReadOnly = true;
            txtTennv.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            mskDienthoai.ReadOnly = true;
            txtTenHH.ReadOnly = true;
            txtDGN.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            nudGiamgia.ReadOnly = true;
            nudSoluong.ReadOnly = true;
            btnXoa.Enabled = false;
            btnBoqua1.Enabled = false;
            btnIn.Enabled = false;
            btnXoasp.Enabled = false;            
            dtpNgaynhap.Value = DateTime.Now;
            btnIn.Enabled = false;
            btnXoa.Enabled = false;
            Functions.FillCombo("SELECT TenNV, MaNV FROM NhanVien", cboMaNV, "TenNV" ,"MaNV");
            cboMaNV.SelectedIndex = -1;
            Functions.FillCombo("SELECT TenNCC, MaNCC FROM NhaCungCap", cboMaNCC, "TenNCC", "MaNCC");
            cboMaNCC.SelectedIndex = -1;
            Functions.FillCombo("SELECT TenHangHoa, MaHang FROM HangHoa", cboMaHH, "TenHangHoa", "MaHang");
            cboMaHH.SelectedIndex = -1;
            Load_dataGridViewDSSP();
        }

        private void cboMaNV_TextChanged(object sender, EventArgs e)
        {
            string str;
            if(cboMaNV.Text == "")
            {
                txtTennv.Text = "";
                return;
            }
            str = "SELECT TenNV FROM NhanVien WHERE MaNV = N'" + cboMaNV.Text + "'";
            txtTennv.Text = Functions.GetFieldValues(str).ToString();
        }
        private void cboMaNCC_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNCC.Text == "")
            {
                txtTenNCC.Text = "";
                mskDienthoai.Text = "";
                txtDiachi.Text = "";
                return;
            }
            str = "SELECT TenNCC FROM NhaCungCap WHERE MaNCC = N'" + cboMaNCC.Text + "'";
            txtTenNCC.Text = Functions.GetFieldValues(str).ToString();
            str = "SELECT DiaChi FROM NhaCungCap WHERE MaNCC = N'" + cboMaNCC.Text + "'";
            txtDiachi.Text = Functions.GetFieldValues(str).ToString();
            str = "SELECT DienThoai FROM NhaCungCap WHERE MaNCC = N'" + cboMaNCC.Text + "'";
            mskDienthoai.Text = Functions.GetFieldValues(str).ToString();
        }
        private void cboMaHH_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaHH.Text == "")
            {
                txtTenHH.Text = "";
                txtDGN.Text = "0";
                return;
            }
            str = "SELECT TenHangHoa FROM HangHoa WHERE MaHang = N'" + cboMaHH.Text + "'";
            txtTenHH.Text = Functions.GetFieldValues(str).ToString();
            str = "SELECT DonGiaNhap FROM HangHoa WHERE MaHang = N'" + cboMaHH.Text + "'";
            txtDGN.Text = Functions.GetFieldValues(str).ToString();
        }
        private void Tinhthanhtien()
        {
            if (txtDGN.Text == "")
            {
                txtThanhtien.Text = "0";
            }
            if (nudSoluong.Text == "")
            {
                txtThanhtien.Text = "0";
            }
            if(nudGiamgia.Text == "")
            {
                nudGiamgia.Text = "0";
            }
            decimal Dongianhap = decimal.Parse(txtDGN.Text);
            int Giamgia= Convert.ToInt32(nudGiamgia.Value);
            int Soluong = Convert.ToInt32(nudSoluong.Value);
            decimal Thanhtien = (Dongianhap * Soluong) - ((Dongianhap * Soluong) * Giamgia / 100);
            txtThanhtien.Text = Thanhtien.ToString();
        }
        private void Load_dataGridViewDSSP()
        {
            tblTHDN.Columns.Add("Mã Hàng Hóa");
            tblTHDN.Columns.Add("Tên Hàng Hóa");
            tblTHDN.Columns.Add("Số Lượng");
            tblTHDN.Columns.Add("Đơn Giá Nhập");
            tblTHDN.Columns.Add("Giảm Giá");
            tblTHDN.Columns.Add("Thành Tiền");
            dataGridViewDSSP.DataSource = tblTHDN;
            dataGridViewDSSP.AllowUserToAddRows = false;
            dataGridViewDSSP.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cboMaHH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaHH.Focus();
                return;
            }
            if(nudSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudSoluong.Focus();
                return;
            }
            if (nudGiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudGiamgia.Focus();
                return;
            }
            //sp trùng
            foreach (DataGridViewRow row in dataGridViewDSSP.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == cboMaHH.SelectedValue.ToString())
                {
                    MessageBox.Show("Sản phẩm đã có trong danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaHH.Focus();
                    return;
                }
                
            }
            // hỏi lại trc khi thay đổi đơn giá
            string sql;
            DataTable tblDongia;
            sql = "SELECT MaHang, DonGiaNhap FROM HangHoa WHERE Mahang = '" + cboMaHH.SelectedValue + "'";
            tblDongia = Functions.GetDataToTable(sql);
            decimal dongia = 0;
            string mahang = string.Empty;
            for(int i = 0; i < tblDongia.Rows.Count; i++)
            {
                mahang = Convert.ToString(tblDongia.Rows[i]["MaHang"]);
                dongia = Convert.ToDecimal(tblDongia.Rows[i]["DonGiaNhap"]);
            }
            if(cboMaHH.Text== mahang && txtDGN.Text == dongia.ToString())
            {
                DataRow newRow = tblTHDN.NewRow();
                newRow["Mã Hàng Hóa"] = cboMaHH.SelectedValue.ToString();
                newRow["Tên Hàng Hóa"] = txtTenHH.Text;
                newRow["Số Lượng"] = nudSoluong.Value.ToString();
                newRow["Đơn Giá Nhập"] = txtDGN.Text;
                newRow["Giảm Giá"] = nudGiamgia.Value.ToString();
                newRow["Thành Tiền"] = txtThanhtien.Text;
                tblTHDN.Rows.Add(newRow);
                dataGridViewDSSP.DataSource = tblTHDN;
            }
            else
            {
                DialogResult tb;
                tb = MessageBox.Show("Đơn giá nhập không đúng, bạn có muốn thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tb == DialogResult.Yes)
                {
                    DataRow newRow = tblTHDN.NewRow();
                    newRow["Mã Hàng Hóa"] = cboMaHH.SelectedValue.ToString();
                    newRow["Tên Hàng Hóa"] = txtTenHH.Text;
                    newRow["Số Lượng"] = nudSoluong.Value.ToString();
                    newRow["Đơn Giá Nhập"] = txtDGN.Text;
                    newRow["Giảm Giá"] = nudGiamgia.Value.ToString();
                    newRow["Thành Tiền"] = txtThanhtien.Text;
                    tblTHDN.Rows.Add(newRow);
                    dataGridViewDSSP.DataSource = tblTHDN;
                }
                else
                {
                    MessageBox.Show("Bạn đã không thay đổi đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaHH.Focus();
                    return; 
                }
            }
        }
    }
}
