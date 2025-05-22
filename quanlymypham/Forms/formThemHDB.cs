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
using Excel = Microsoft.Office.Interop.Excel;



namespace quanlymypham.Forms
{
    public partial class formThemHDB: Form
    {
        private System.Data.DataTable DStam;
        public formThemHDB()
        {
            InitializeComponent();
            txtDGB.TextChanged += (s, e) => tinhthanhtien();

            nudSoluong.ValueChanged += (s, e) => tinhthanhtien();

            nudGiamgia.ValueChanged += (s, e) => tinhthanhtien();
        }

        private void formThemHDB_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            Load_DStam();
            txtsoHDB.Text = Functions.CreateKey("HDB");
            dtpNgayban.Text = DateTime.Now.ToShortDateString();
            btnThem.Enabled = true;
            btnLuuHD.Enabled = false;
            btnXoaHD.Enabled = false;
            btnInHD.Enabled = false;
            txtsoHDB.ReadOnly = true;
            txtTennv.ReadOnly = true;
            txttenKH.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            mskdienthoai.ReadOnly = true;
            txtTenSP.ReadOnly = true;
            txtDGB.ReadOnly = true;
            txtThanhtien.ReadOnly = true;
            nudGiamgia.Text = "0";
            nudSoluong.Text = "0";
            Functions.FillCombo("SELECT TenKhach, MaKhach FROM KhachHang", CbomaKH,"TenKhach", "MaKhach");
            CbomaKH.SelectedIndex = -1;
            Functions.FillCombo("SELECT TenNV, MaNV FROM NhanVien",cboMaNV, "TenNV", "MaNV");
            cboMaNV.SelectedIndex = -1;
            Functions.FillCombo("SELECT TenHangHoa, MaHang FROM HangHoa", cboMaSP,"TenHangHoa", "MaHang");
            cboMaSP.SelectedIndex = -1;

        }

        private void cboMaNV_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNV.Text == "")
            {
                txtTennv.Text = "";
                return;

            }
            str = "Select TenNV from NhanVien where MaNV =N'" + cboMaNV.Text + "'";
            txtTennv.Text = Functions.GetFieldValues(str).ToString();
        }

        private void CbomaKH_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (CbomaKH.Text == "")
            {
                txttenKH.Text = "";
                txtDiachi.Text = "";
                mskdienthoai.Text = "";
                return;
            }
            str = "Select TenKhach from KhachHang where MaKhach = N'" + CbomaKH.Text+ "'";
            txttenKH.Text = Functions.GetFieldValues(str).ToString();
            str = "Select DiaChi from KhachHang where MaKhach = N'" + CbomaKH.Text+ "'";
            txtDiachi.Text = Functions.GetFieldValues(str).ToString();
            str = "Select DienThoai from KhachHang where MaKhach = N'" + CbomaKH.Text + "'";
            mskdienthoai.Text = Functions.GetFieldValues(str).ToString();

        }

        private void cboMaSP_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaSP.Text == "")
            {
                txtTenSP.Text = "";
                txtDGB.Text = "";
                return;
            }
            str = "SELECT TenHangHoa FROM HangHoa WHERE MaHang =N'" + cboMaSP.Text + "'";
            txtTenSP.Text = Functions.GetFieldValues(str).ToString();
            str = "SELECT DonGiaBan FROM HangHoa WHERE MaHang =N'" + cboMaSP.Text+ "'";
            txtDGB.Text = Functions.GetFieldValues(str).ToString();

        }

        private void txtThanhtien_TextChanged(object sender, EventArgs e)
        {

        }
        private void tinhthanhtien()
        {
            if (txtDGB.Text == "")
            {
                txtDGB.Text = "0";
            }    
            if(nudSoluong.Text == "")
            {
                nudSoluong.Value = 0;
            }    
            if(nudGiamgia.Text == "")
            {
                nudGiamgia.Value = 0;
            }
            decimal dongiaban = decimal.Parse(txtDGB.Text);
            int giamgia = Convert.ToInt32(nudGiamgia.Value);
            int soluong = Convert.ToInt32(nudSoluong.Value);
            decimal thanhtien = soluong * dongiaban - soluong * dongiaban * giamgia / 100;
            txtThanhtien.Text = thanhtien.ToString();
        }
        private void Load_DStam()
        {
            DStam = new System.Data.DataTable();

            DStam.Columns.Add("Mã sản phẩm");
            DStam.Columns.Add("Tên sản phẩm");
            DStam.Columns.Add("Số lượng");
            DStam.Columns.Add("Đơn giá bán");
            DStam.Columns.Add("Giảm giá");
            DStam.Columns.Add("Thành tiền");
            dataGridViewDSSP.DataSource = DStam;
            dataGridViewDSSP.Columns[0].Width = 120;
            dataGridViewDSSP.Columns[1].Width = 130;
            dataGridViewDSSP.Columns[2].Width = 120;
            dataGridViewDSSP.Columns[3].Width = 130;
            dataGridViewDSSP.Columns[4].Width = 100;
            dataGridViewDSSP.Columns[5].Width = 120;
            dataGridViewDSSP.EditMode = DataGridViewEditMode.EditProgrammatically;




        }

        private void btnThem_Click(object sender, EventArgs e)
        {


            if(cboMaSP.Text.Trim().Length == 0)
            {

                MessageBox.Show("Bạn chưa nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaSP.Focus();
                return;
            }    
    
            if (nudSoluong.Text.Trim().Length == 0 || nudSoluong.Text == "0")
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
            foreach (DataRow row in DStam.Rows)
            {
                if (row["Mã sản phẩm"].ToString() == cboMaSP.Text)
                {
                    MessageBox.Show("Sản phẩm này đã có, bạn phải chọn sản phẩm khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaSP.Focus();
                    return;
                }
            }


            string sql;
            System.Data.DataTable tblSoluong;
            sql = @"SELECT MaHang, SoLuong From HangHoa where MaHang ='" + cboMaSP.Text + "'";
            tblSoluong = Functions.GetDataToTable(sql);
            int soluong = 0;
            string mahang = string.Empty;
            for (int i = 0; i < tblSoluong.Rows.Count; i++)
            {
                soluong = Convert.ToInt32(tblSoluong.Rows[i]["SoLuong"]);
                mahang = Convert.ToString((tblSoluong.Rows[i]["MaHang"]));

            }
            if (cboMaSP.Text == mahang && nudSoluong.Value > soluong)
            {
                MessageBox.Show("Sản phẩm này không đủ số lượng. Số lượng sản phẩm hiện tại là" + soluong, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudSoluong.Focus();
                return;
            }
            DataRow newrow = DStam.NewRow();
            newrow["Mã sản phẩm"] = cboMaSP.Text;
            newrow["Tên sản phẩm"] = txtTenSP.Text;
            newrow["Số lượng"] = nudSoluong.Value;
            newrow["Đơn giá bán"] = txtDGB.Text;
            newrow["Giảm giá"] = nudGiamgia.Value;
            newrow["Thành Tiền"] = txtThanhtien.Text;
            DStam.Rows.Add(newrow);
            btnLuuHD.Enabled = true;
            CapNhatTong();
            ResetValuesSP();

        }
        private void CapNhatTong()
        {
            int tongSoLuong = 0;
            int tongSoMatHang = DStam.Rows.Count;
            decimal tongThanhTien = 0;

            foreach (DataRow row in DStam.Rows)
            {
                tongSoLuong += Convert.ToInt32(row["Số lượng"]);
                tongThanhTien += Convert.ToDecimal(row["Thành Tiền"]);
            }

            lblSoluongSP.Text = "Số lượng sản phẩm:"  + tongSoLuong.ToString();
            lblTongSP.Text = "Tổng Số sản phẩm:" + tongSoMatHang.ToString();
            lblBangchu.Text = "Tổng tiền (Bằng chữ):" + Functions.ChuyenSoSangChu(tongThanhTien.ToString());
            lblTongtien.Text = "Tổng tiền:" +  tongThanhTien.ToString();
        }

        private void dataGridViewDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDSSP.Rows[e.RowIndex];

                cboMaSP.Text = row.Cells[0].Value.ToString();
                txtTenSP.Text = row.Cells[1].Value.ToString();
                nudSoluong.Value = Convert.ToInt32(row.Cells[2].Value);
                txtDGB.Text = row.Cells[3].Value.ToString();
                nudGiamgia.Value = Convert.ToInt32(row.Cells[4].Value);
                txtThanhtien.Text = row.Cells[5].Value.ToString();

                btnLuuHD.Enabled = true;
                btnThem.Enabled = false;
                cboMaSP.Enabled = false;
                txtTenSP.ReadOnly = true;
                btnSuaHD.Enabled = true;
            }
        }
        private void ResetValuesSP()
        {
            cboMaSP.SelectedIndex = -1;
            txtTenSP.Clear();
            nudSoluong.Value = 0;
            txtDGB.Clear();
            nudGiamgia.Value = 0;
            txtThanhtien.Clear();
            cboMaSP.Enabled = true;
            btnThem.Enabled = true;
            btnXoaHD.Enabled = false;
            if (DStam.Rows.Count == 0)
                btnXoaHD.Enabled = false;
            else
                btnXoaHD.Enabled = true;

            if (DStam.Rows.Count == 0)
                btnLuuHD.Enabled = false;
            else
                btnLuuHD.Enabled = true;
            if (DStam.Rows.Count == 0)
                btnInHD.Enabled = false;
            else
                btnInHD.Enabled = true;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoasp_Click(object sender, EventArgs e)
        {

            if (dataGridViewDSSP.SelectedRows.Count == 0 ||
                dataGridViewDSSP.SelectedRows[0].Index >= DStam.Rows.Count)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int rowIndex = dataGridViewDSSP.SelectedRows[0].Index;
                DStam.Rows.RemoveAt(rowIndex);

                CapNhatTong();
                ResetValuesSP();
            }
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            string sql;
            decimal sumTongtien = 0;
            for (int i = 0; i < DStam.Rows.Count; i++)
            {
                sumTongtien += Convert.ToDecimal(DStam.Rows[i][5]);
            }
            sql = @"INSERT INTO HoaDonBan(SoHDB, MaNV, NgayBan, MaKhach, TongTien)  
       VALUES (N'" + txtsoHDB.Text + "', N'" + cboMaNV.Text + "', N'" + dtpNgayban.Value.ToString("yyyy-MM-dd") + "',N'" + CbomaKH.Text + "',N'" + sumTongtien + "')";
            Functions.RunSql(sql);
            foreach (DataRow row in DStam.Rows)
            {
                string masp = row["Mã sản phẩm"].ToString();
                string tensp = row["Tên sản phẩm"].ToString();
                int soluong = Convert.ToInt32(row["Số lượng"]);
                int giamgia = Convert.ToInt32(row["Giảm giá"]);
                decimal thanhtien = Convert.ToDecimal(row["Thành tiền"]);
                sql = @"INSERT INTO ChiTietHoaDonBan ( SoHDB, MaHang, SoLuong, GiamGia, ThanhTien) 
             VALUES ('" + txtsoHDB.Text + "','" + masp + "','" + soluong + "','" + giamgia + "','" + thanhtien + "')";
                Functions.RunSql(sql);
                sql = @"UPDATE HangHoa SET SoLuong = SoLuong - " + soluong + " WHERE MaHang = N'" + masp + "'";
                Functions.RunSql(sql);
            }

            Load_DStam();
            ResetValuesSP();
            btnXoaHD.Enabled = false;
            btnThem.Enabled = true;
            btnLuuHD.Enabled = false; 
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            
                Load_DStam();
                ResetValuesSP();
               
        }
        

        private void btnInHD_Click(object sender, EventArgs e)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.ScreenUpdating = false;
            excelApp.DisplayAlerts = false;
            var workbook = excelApp.Workbooks.Add();
            var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            worksheet.Cells[1, 1] = "Cửa hàng mỹ phẩm TNL";
            worksheet.Cells[1, 1].Font.Color = Color.Blue;
            worksheet.Cells[2, 1] = "Địa chỉ: 12 Chùa Bộc, Quang Trung, Đống Đa, Hà Nội";
            worksheet.Cells[2, 1].Font.Color = Color.Blue;
            worksheet.Cells[3, 1] = "Số điện thoại: 097 114 0994";
            worksheet.Cells[3, 1].Font.Color = Color.Blue;
            Excel.Range mergeRange = worksheet.Range[worksheet.Cells[5, 1], worksheet.Cells[5, 11]];
            mergeRange.Merge();
            mergeRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            mergeRange.Value = "CHI TIẾT HOÁ ĐƠN BÁN";
            mergeRange.Font.Size = 18;
            mergeRange.Font.Color = Color.Red;
            worksheet.Cells[7, 2] = "Số hoá đơn bán";
            worksheet.Cells[7, 3] = txtsoHDB.Text;
            worksheet.Cells[8, 2] = "Ngày bán";
            worksheet.Cells[8, 3] = dtpNgayban.Value;
            worksheet.Cells[8, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            worksheet.Cells[7, 7] = "Khách hàng";
            worksheet.Cells[7, 8] = txttenKH.Text;
            worksheet.Cells[8, 7] = "Số điện thoại";
            worksheet.Cells[8, 8] = mskdienthoai.Text;
            worksheet.Cells[9, 7] = "Địa chỉ";
            worksheet.Cells[9, 8] = txtDiachi.Text;
            worksheet.Cells[9, 2] = "Nhân viên";
            worksheet.Cells[9, 3] = txtTennv.Text;
            worksheet.Cells[11, 2] = "STT";
            worksheet.Cells[11, 2].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            worksheet.Cells[11, 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
            worksheet.Cells[11, 2].Interior.Color = Color.LightYellow;
            worksheet.Cells[11, 2].Font.Size = 12;
            worksheet.Cells[11, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            for (int i = 1; i <= dataGridViewDSSP.Columns.Count; i++)
            {
                worksheet.Cells[11, i + 2].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[11, i + 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
                worksheet.Cells[11, i + 2].Value = dataGridViewDSSP.Columns[i - 1].HeaderText;
                worksheet.Cells[11, i + 2].Interior.Color = Color.LightYellow;
                worksheet.Cells[11, i + 2].Font.Size = 12;
                worksheet.Cells[11, i + 2].EntireColumn.AutoFit();
                worksheet.Cells[11, i + 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            }
            for (int i = 0; i < dataGridViewDSSP.Rows.Count; i++)
            {
                worksheet.Cells[i + 12, 2].Value = i + 1;
                worksheet.Cells[i + 12, 2].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[i + 12, 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
                worksheet.Cells[i + 12, 2].Font.Size = 12;
                worksheet.Cells[i + 12, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }
            for (int j = 0; j < dataGridViewDSSP.Columns.Count; j++)
                for (int i = 0; i < dataGridViewDSSP.Rows.Count; i++)
                {
                    worksheet.Cells[i + 12, j + 3].Value = dataGridViewDSSP.Rows[i].Cells[j].Value?.ToString();
                    worksheet.Cells[i + 12, j + 3].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[i + 12, j + 3].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    worksheet.Cells[i + 12, j + 3].Font.Size = 12;
                    worksheet.Cells[i + 12, j + 3].EntireColumn.AutoFit();
                    worksheet.Cells[i + 12, j + 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                }
            worksheet.Cells[(dataGridViewDSSP.Rows.Count + 12) + 2, 8] = lblSoluongSP.Text;
            worksheet.Cells[(dataGridViewDSSP.Rows.Count + 12) + 3, 8] = lblTongSP.Text;
            worksheet.Cells[(dataGridViewDSSP.Rows.Count + 12) + 4, 8] = lblTongtien.Text;
            worksheet.Cells[(dataGridViewDSSP.Rows.Count + 12) + 5, 8] = lblBangchu.Text;
            worksheet.Cells[(dataGridViewDSSP.Rows.Count + 12) + 8, 6] = "Hà Nội, Ngay " + dtpNgayban.Value.Day + ", tháng " + dtpNgayban.Value.Month + ", năm" + dtpNgayban.Value.Year;
            excelApp.ScreenUpdating = true;
            excelApp.Visible = true;

        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            var main = Application.OpenForms.OfType<GD_Chinh>().FirstOrDefault();
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            txtsoHDB.Text = "";
            dtpNgayban.Value = DateTime.Now;

            cboMaNV.SelectedIndex = -1;
            txtTennv.Text = "";

            CbomaKH.SelectedIndex = -1;
            txttenKH.Text = "";
            mskdienthoai.Text = "";
            txtDiachi.Text = "";
            cboMaSP.SelectedIndex = -1;
            txtTenSP.Text = "";
            nudSoluong.Value = 0;
            nudGiamgia.Value = 0;
            txtDGB.Text = "";
            txtThanhtien.Text = "";
            lblTongSP.Text = "0";
            lblSoluongSP.Text = "0";
            lblTongtien.Text = "0";
            lblBangchu.Text = "";

            txtsoHDB.Focus();

        }
    }
    

}

