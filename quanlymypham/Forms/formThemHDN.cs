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
using Excel = Microsoft.Office.Interop.Excel;
using ExcelRange = Microsoft.Office.Interop.Excel.Range;
using ExcelXlHAlign = Microsoft.Office.Interop.Excel.XlHAlign;
using ExcelXlLineStyle = Microsoft.Office.Interop.Excel.XlLineStyle;
using ExcelXlBorderWeight = Microsoft.Office.Interop.Excel.XlBorderWeight;

namespace quanlymypham.Forms
    {
        public partial class formThemHDN : Form
        {
            public formThemHDN()
            {
                InitializeComponent();
                this.nudSoluong.ValueChanged += new System.EventHandler(this.nudSoluong_ValueChanged);
                this.nudGiamgia.ValueChanged += new System.EventHandler(this.nudGiamgia_ValueChanged);
                this.txtDGN.TextChanged += new System.EventHandler(this.txtDGN_TextChanged);
            }
            DataTable tblTHDN;
            private decimal dongiaGoc = 0;
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
                txtDGN.ReadOnly = false;
                txtThanhtien.ReadOnly = true;
                nudGiamgia.ReadOnly = true;
                nudSoluong.ReadOnly = true;
                btnXoa.Enabled = false;
                btnIn.Enabled = false;
                btnLuu.Enabled = false;
                btnXoasp.Enabled = false;
                dtpNgaynhap.Value = DateTime.Now;            
                Functions.FillCombo("SELECT  TenNV ,MaNV FROM NhanVien", cboMaNV, "TenNV", "MaNV");
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
                if (cboMaNV.Text == "")
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
                    dongiaGoc = 0;
                    return;
                }
                str = "SELECT TenHangHoa FROM HangHoa WHERE MaHang = N'" + cboMaHH.Text + "'";
                txtTenHH.Text = Functions.GetFieldValues(str).ToString();
                str = "SELECT DonGiaNhap FROM HangHoa WHERE MaHang = N'" + cboMaHH.Text + "'";
                string giaNhap = Functions.GetFieldValues(str).ToString();
                txtDGN.Text = giaNhap;
                decimal.TryParse(giaNhap, out dongiaGoc); // Lưu giá gốc
            }
            private void Tinhthanhtien()
            {
                decimal dongia = 0;
                int soluong = (int)nudSoluong.Value;
                int giamgia = (int)nudGiamgia.Value;
                decimal.TryParse(txtDGN.Text, out dongia);
                decimal thanhtien = (dongia * soluong) - ((dongia * soluong) * giamgia / 100);
                txtThanhtien.Text = thanhtien.ToString("0");
            }
            private void Load_dataGridViewDSSP()
            {
                tblTHDN = new DataTable();
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
                if (cboMaHH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboMaHH.Focus();
                    return;
                }
                if (nudSoluong.Value == 0)
                {
                    MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudSoluong.Focus();
                    return;
                }
                if (nudGiamgia.Value < 0)
                {
                    MessageBox.Show("Bạn chưa nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudGiamgia.Focus();
                    return;
                }

                foreach (DataGridViewRow row in dataGridViewDSSP.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == cboMaHH.SelectedValue.ToString())
                    {
                        MessageBox.Show("Sản phẩm đã có trong danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboMaHH.Focus();
                        return;
                    }
                }

                decimal giaHienTai = 0;
                decimal.TryParse(txtDGN.Text, out giaHienTai);

                // Chỉ cảnh báo nếu giá đã sửa
                if (giaHienTai != dongiaGoc)
                {
                    var tb = MessageBox.Show("Đơn giá nhập không đúng với hệ thống, bạn có muốn thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tb == DialogResult.No)
                    {
                        txtDGN.Text = dongiaGoc.ToString();
                        Tinhthanhtien();
                        cboMaHH.Focus();
                        return;
                    }
                }

                DataRow newRow = tblTHDN.NewRow();
                newRow["Mã Hàng Hóa"] = cboMaHH.Text; // Lưu mã hàng
                newRow["Tên Hàng Hóa"] = cboMaHH.SelectedValue.ToString();
                newRow["Số Lượng"] = nudSoluong.Value.ToString();
                newRow["Đơn Giá Nhập"] = txtDGN.Text;
                newRow["Giảm Giá"] = nudGiamgia.Value.ToString();
                newRow["Thành Tiền"] = txtThanhtien.Text;
                tblTHDN.Rows.Add(newRow);
                dataGridViewDSSP.DataSource = tblTHDN;

                // Tính lại tổng số lượng, tổng thành tiền...
                int sumSoluongSP = 0;
                int sumSp;
                decimal sumThanhtien = 0;
                for (int i = 0; i < tblTHDN.Rows.Count; i++)
                {
                    sumSoluongSP += Convert.ToInt32(tblTHDN.Rows[i][2]);
                    var value = tblTHDN.Rows[i][5].ToString();
                    if (!string.IsNullOrWhiteSpace(value))
                        sumThanhtien += Convert.ToDecimal(value);
                }
                sumSp = tblTHDN.Rows.Count;
                lblSoluongSP.Text = "Tổng Số Lượng Sản Phẩm: " + sumSoluongSP.ToString();
                lblTongSP.Text = "Tổng Số Sản Phẩm: " + sumSp.ToString();
                lblTongtien.Text = "Tổng Tiền: " + sumThanhtien.ToString();
                lblBangchu.Text = "Tổng Tiền (Bằng Chữ): " + Functions.ChuyenSoSangChu(sumThanhtien.ToString());
                cboMaHH.Text = "";
                txtTenHH.Text = "";
                nudSoluong.Value = 0;
                nudGiamgia.Value = 0;
                txtDGN.Text = "0";
                txtThanhtien.Text = "0";
                dongiaGoc = 0;
                cboMaHH.Focus();
                btnIn.Enabled = true;
                btnLuu.Enabled = true;
                btnXoa.Enabled = true;
            }
            private void ResetValue()
            {
                cboMaHH.Text = "";
                txtTenHH.Text = "";
                nudSoluong.Value = 0;
                nudGiamgia.Value = 0;
                txtDGN.Text = "0";
                txtThanhtien.Text = "0";
                dongiaGoc = 0;
                cboMaHH.SelectedIndex = -1;
                cboMaNCC.SelectedIndex = -1;
                cboMaNV.SelectedIndex = -1;
                txtTennv.Text = "";
                txtTenNCC.Text = "";
                txtDiachi.Text = "";
                mskDienthoai.Text = "";
                lblBangchu.Text = "Tổng Tiền (Bằng Chữ): ";
                lblSoluongSP.Text = "Tổng Số Lượng Sản Phẩm: 0";
                lblTongSP.Text = "Tổng Số Sản Phẩm: 0";
                lblTongtien.Text = "Tổng Tiền: 0";
                btnIn.Enabled = false;
                btnLuu.Enabled = false;
                btnXoa.Enabled = false;
                btnXoasp.Enabled = false;
                cboMaHH.Focus();
            }

            private void nudSoluong_ValueChanged(object sender, EventArgs e)
            {
                Tinhthanhtien();
            }

            private void nudGiamgia_ValueChanged(object sender, EventArgs e)
            {
                Tinhthanhtien();
            }

            private void txtDGN_TextChanged(object sender, EventArgs e)
            {
                Tinhthanhtien();
            }
            private int currentRowIndex = -1; // Biến lưu dòng đang chọn
            private void dataGridViewDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                // Kiểm tra dòng hợp lệ (không click tiêu đề)
                if (e.RowIndex >= 0)
                {
                    currentRowIndex = e.RowIndex;
                    btnXoasp.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = true;
                    btnIn.Enabled = true;

                    // Hiển thị lại thông tin sản phẩm vào groupbox nhập liệu (nếu muốn sửa, nhập lại)
                    cboMaHH.Text = dataGridViewDSSP.Rows[e.RowIndex].Cells["Mã Hàng Hóa"].Value.ToString();
                    txtTenHH.Text = dataGridViewDSSP.Rows[e.RowIndex].Cells["Tên Hàng Hóa"].Value.ToString();
                    nudSoluong.Value = Convert.ToDecimal(dataGridViewDSSP.Rows[e.RowIndex].Cells["Số Lượng"].Value);
                    txtDGN.Text = dataGridViewDSSP.Rows[e.RowIndex].Cells["Đơn Giá Nhập"].Value.ToString();
                    nudGiamgia.Value = Convert.ToDecimal(dataGridViewDSSP.Rows[e.RowIndex].Cells["Giảm Giá"].Value);
                    txtThanhtien.Text = dataGridViewDSSP.Rows[e.RowIndex].Cells["Thành Tiền"].Value.ToString();
                }
            }

            private void btnXoasp_Click(object sender, EventArgs e)
            {
                if (currentRowIndex >= 0 && currentRowIndex < tblTHDN.Rows.Count)
                {
                    tblTHDN.Rows.RemoveAt(currentRowIndex);
                    dataGridViewDSSP.DataSource = tblTHDN;
                    ResetValue();
                    btnXoa.Enabled = false; // Xóa xong thì disable lại
                }

                // Reset lại tổng hợp số lượng, thành tiền v.v...
                int sumSoluongSP = 0;
                int sumSp;
                decimal sumThanhtien = 0;
                for (int i = 0; i < tblTHDN.Rows.Count; i++)
                {
                    sumSoluongSP += Convert.ToInt32(tblTHDN.Rows[i][2]);
                    var value = tblTHDN.Rows[i][5].ToString();
                    if (!string.IsNullOrWhiteSpace(value))
                        sumThanhtien += Convert.ToDecimal(value);
                }
                sumSp = tblTHDN.Rows.Count;
                lblSoluongSP.Text = "Tổng Số Lượng Sản Phẩm: " + sumSoluongSP.ToString();
                lblTongSP.Text = "Tổng Số Sản Phẩm: " + sumSp.ToString();
                lblTongtien.Text = "Tổng Tiền: " + sumThanhtien.ToString();
                lblBangchu.Text = "Tổng Tiền (Bằng Chữ): " + Functions.ChuyenSoSangChu(sumThanhtien.ToString());
            }

            private void btnLuu_Click(object sender, EventArgs e)
            {
            
                string maNV = "";
                if (cboMaNV.SelectedItem != null)
                {
                    DataRowView drv = (DataRowView)cboMaNV.SelectedItem;
                    maNV = drv["MaNV"].ToString();
                }
            
                string maHang = "";
                if (cboMaHH.SelectedItem != null)
                {
                    DataRowView drv = (DataRowView)cboMaHH.SelectedItem;
                    maHang = drv["MaHang"].ToString();
                }
                string sql;
                // 1. Tính tổng tiền hóa đơn nhập
                decimal sumTongTien = 0;
                for (int i = 0; i < tblTHDN.Rows.Count; i++)
                {
                    sumTongTien += Convert.ToDecimal(tblTHDN.Rows[i]["Thành Tiền"]);
                }

                // 2. Thêm hóa đơn nhập vào bảng HoaDonNhap
                sql = $"INSERT INTO HoaDonNhap (SoHDN, MaNV, NgayNhap, MaNCC, TongTien) " +
          $"VALUES (N'{txtSoHDN.Text}', N'{maNV}', '{dtpNgaynhap.Value:yyyy-MM-dd}', N'{cboMaNCC.Text}', {sumTongTien})";
                Functions.RunSql(sql);

                // 3. Thêm từng sản phẩm vào ChiTietHoaDonNhap và cập nhật tồn kho
                foreach (DataRow row in tblTHDN.Rows)
                {
                    string MaHang = row["Mã Hàng Hóa"].ToString();
                    int soLuong = Convert.ToInt32(row["Số Lượng"]);
                    decimal donGiaNhap = Convert.ToDecimal(row["Đơn Giá Nhập"]);
                    int giamGia = Convert.ToInt32(row["Giảm Giá"]);
                    decimal thanhTien = Convert.ToDecimal(row["Thành Tiền"]);
                
                    // Thêm vào chi tiết hóa đơn nhập
                    sql = $"INSERT INTO ChiTietHoaDonNhap (SoHDN, MaHang, SoLuong, GiamGia, ThanhTien) " +
                          $"VALUES (N'{txtSoHDN.Text}', N'{MaHang}', {soLuong}, {giamGia}, {thanhTien})";
                    Functions.RunSql(sql);

                    // Cập nhật số lượng và giá hàng hóa
                    decimal donGiaBan = Math.Round(donGiaNhap * 1.1M, 0); // Giá bán = 110% giá nhập
                    sql = $"UPDATE HangHoa SET " +
                          $"SoLuong = ISNULL(SoLuong, 0) + {soLuong}, " +
                          $"DonGiaNhap = {donGiaNhap}, " +
                          $"DonGiaBan = {donGiaBan} " +
                          $"WHERE MaHang = N'{maHang}'";
                    Functions.RunSql(sql);
                }

                MessageBox.Show("Đã lưu hóa đơn nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValue();
            }


            private void btnDong_Click(object sender, EventArgs e)
            {
                this.Close();
                var main = Application.OpenForms.OfType<GD_Chinh>().FirstOrDefault();
            }

            private void btnXoa_Click(object sender, EventArgs e)
            {
                ResetValue();
                Load_dataGridViewDSSP();
            }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi tạo Excel
            var excelApp = new Excel.Application();
            excelApp.ScreenUpdating = false;
            excelApp.DisplayAlerts = false;
            var workbook = excelApp.Workbooks.Add();
            var worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            // Thông tin cửa hàng
            worksheet.Cells[1, 1] = "Cửa hàng mỹ phẩm TNL";
            worksheet.Cells[1, 1].Font.Color = Color.Blue.ToArgb();
            worksheet.Cells[2, 1] = "Địa chỉ: 12 Chùa Bộc, Quang Trung, Đống Đa, Hà Nội";
            worksheet.Cells[2, 1].Font.Color = Color.Blue.ToArgb();
            worksheet.Cells[3, 1] = "Số điện thoại: 097 114 0994";
            worksheet.Cells[3, 1].Font.Color = Color.Blue.ToArgb();

            // Tiêu đề hóa đơn
            Excel.Range mergeRange = worksheet.Range[worksheet.Cells[5, 1], worksheet.Cells[5, 7]];
            mergeRange.Merge();
            mergeRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            mergeRange.Value = "CHI TIẾT HÓA ĐƠN NHẬP";
            mergeRange.Font.Size = 18;
            mergeRange.Font.Color = Color.Red.ToArgb();

            // Thông tin hóa đơn nhập
            worksheet.Cells[7, 2] = "Số hóa đơn nhập:";
            worksheet.Cells[7, 3] = txtSoHDN.Text;
            worksheet.Cells[8, 2] = "Ngày nhập:";
            worksheet.Cells[8, 3] = dtpNgaynhap.Value.ToString("dd/MM/yyyy");
            worksheet.Cells[8, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

            worksheet.Cells[7, 5] = "Nhà cung cấp:";
            worksheet.Cells[7, 6] = cboMaNCC.Text + " - " + txtTenNCC.Text;
            worksheet.Cells[8, 5] = "Số điện thoại:";
            worksheet.Cells[8, 6] = mskDienthoai.Text;
            worksheet.Cells[9, 5] = "Địa chỉ:";
            worksheet.Cells[9, 6] = txtDiachi.Text;

            worksheet.Cells[9, 2] = "Nhân viên:";
            worksheet.Cells[9, 3] = cboMaNV.Text + " - " + txtTennv.Text;

            // Header cho bảng sản phẩm
            worksheet.Cells[11, 2] = "STT";
            worksheet.Cells[11, 2].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            worksheet.Cells[11, 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
            worksheet.Cells[11, 2].Interior.Color = Color.LightYellow.ToArgb();
            worksheet.Cells[11, 2].Font.Size = 12;
            worksheet.Cells[11, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Lấy header từ DataTable/DataGridView
            for (int i = 0; i < dataGridViewDSSP.Columns.Count; i++)
            {
                worksheet.Cells[11, i + 3].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[11, i + 3].Borders.Weight = Excel.XlBorderWeight.xlThin;
                worksheet.Cells[11, i + 3].Value = dataGridViewDSSP.Columns[i].HeaderText;
                worksheet.Cells[11, i + 3].Interior.Color = Color.LightYellow.ToArgb();
                worksheet.Cells[11, i + 3].Font.Size = 12;
                worksheet.Cells[11, i + 3].EntireColumn.AutoFit();
                worksheet.Cells[11, i + 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }

            // Dữ liệu sản phẩm
            for (int i = 0; i < dataGridViewDSSP.Rows.Count; i++)
            {
                worksheet.Cells[i + 12, 2].Value = i + 1;
                worksheet.Cells[i + 12, 2].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[i + 12, 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
                worksheet.Cells[i + 12, 2].Font.Size = 12;
                worksheet.Cells[i + 12, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                for (int j = 0; j < dataGridViewDSSP.Columns.Count; j++)
                {
                    worksheet.Cells[i + 12, j + 3].Value = dataGridViewDSSP.Rows[i].Cells[j].Value?.ToString();
                    worksheet.Cells[i + 12, j + 3].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[i + 12, j + 3].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    worksheet.Cells[i + 12, j + 3].Font.Size = 12;
                    worksheet.Cells[i + 12, j + 3].EntireColumn.AutoFit();
                    worksheet.Cells[i + 12, j + 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }
            }

            // Tổng kết
            int rowEnd = dataGridViewDSSP.Rows.Count + 12;
            worksheet.Cells[rowEnd + 2, 6] = lblSoluongSP.Text;
            worksheet.Cells[rowEnd + 3, 6] = lblTongSP.Text;
            worksheet.Cells[rowEnd + 4, 6] = lblTongtien.Text;
            worksheet.Cells[rowEnd + 5, 6] = lblBangchu.Text;

            worksheet.Cells[rowEnd + 8, 4] = "Hà Nội, Ngày " + dtpNgaynhap.Value.Day + ", tháng " + dtpNgaynhap.Value.Month + ", năm " + dtpNgaynhap.Value.Year;

            // Hiện Excel
            excelApp.ScreenUpdating = true;
            excelApp.Visible = true;
            ResetValue();
            Load_dataGridViewDSSP();
        }
    }
    }
