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
using ExcelRange = Microsoft.Office.Interop.Excel.Range;
using ExcelXlHAlign = Microsoft.Office.Interop.Excel.XlHAlign;
using ExcelXlLineStyle = Microsoft.Office.Interop.Excel.XlLineStyle;
using ExcelXlBorderWeight = Microsoft.Office.Interop.Excel.XlBorderWeight;
using System.Text.RegularExpressions;

namespace quanlymypham.Forms
{
    public partial class formChitietHDN : Form
    {
        private string soHDN;
        private DataTable tblCTHDN;
        private decimal dongiaGoc = 0;
        public formChitietHDN(string SoHDN)
        {
            InitializeComponent();
            this.soHDN = SoHDN;
            this.nudSoluong.ValueChanged += new System.EventHandler(this.nudSoluong_ValueChanged);
            this.nudGiamgia.ValueChanged += new System.EventHandler(this.nudGiamgia_ValueChanged);
            this.txtDGN.TextChanged += new System.EventHandler(this.txtDGN_TextChanged);
        }
        // tạo 1 dgv lưu thông tin dssp

        private void formChitietHDN_Load(object sender, EventArgs e)
        {
            Functions.Connect();

            // 1. Fill combobox TRƯỚC khi gán SelectedValue
            Functions.FillCombo("SELECT TenNV, MaNV FROM NhanVien", cboMaNV, "TenNV", "MaNV");
            Functions.FillCombo("SELECT TenNCC, MaNCC FROM NhaCungCap", cboMaNCC, "TenNCC", "MaNCC");
            Functions.FillCombo("SELECT TenHangHoa, MaHang FROM HangHoa", cboMaHH, "TenHangHoa", "MaHang");
           
            // Trong formChitietHDN_Load
            cboMaNV.TextChanged += cboMaNV_TextChanged;
            cboMaNCC.TextChanged += cboMaNCC_TextChanged;


            // 2. Load thông tin hóa đơn + detail
            Load_ThongtinHDN(soHDN);
            Load_DSSP(soHDN);

            // 3. Set ReadOnly/cấm sửa control
            SetReadOnlyMode(true);
        }
        private void Load_ThongtinHDN(string soHDN)
        {
            // Fill Combo trước
            Functions.FillCombo("SELECT MaNV, TenNV FROM NhanVien", cboMaNV, "TenNV", "MaNV");
            Functions.FillCombo("SELECT MaNCC, TenNCC FROM NhaCungCap", cboMaNCC, "TenNCC", "MaNCC");

            string sql = $@"
                            SELECT HoaDonNhap.SoHDN, HoaDonNhap.NgayNhap, HoaDonNhap.MaNV, NhanVien.TenNV, 
                                   HoaDonNhap.MaNCC, NhaCungCap.TenNCC, NhaCungCap.DienThoai, NhaCungCap.DiaChi
                            FROM HoaDonNhap
                            JOIN NhanVien ON HoaDonNhap.MaNV = NhanVien.MaNV
                            JOIN NhaCungCap ON HoaDonNhap.MaNCC = NhaCungCap.MaNCC
                            WHERE HoaDonNhap.SoHDN = N'{soHDN}'    ";
            var dt = Functions.GetDataToTable(sql);
            if (dt.Rows.Count > 0)
            {
                cboMaNV.Text = dt.Rows[0]["MaNV"].ToString();
                cboMaNCC.Text = dt.Rows[0]["MaNCC"].ToString();
                txtSoHDN.Text = dt.Rows[0]["SoHDN"].ToString();
                dtpNgaynhap.Value = Convert.ToDateTime(dt.Rows[0]["NgayNhap"]);
                txtTennv.Text = dt.Rows[0]["TenNV"].ToString();
                txtTenNCC.Text = dt.Rows[0]["TenNCC"].ToString();
                mskDienthoai.Text = dt.Rows[0]["DienThoai"].ToString();
                txtDiachi.Text = dt.Rows[0]["DiaChi"].ToString();
            }
        }

        private void Load_DSSP(string soHDN)
        {
            string sql = $@"SELECT ct.MaHang, hh.TenHangHoa, ct.SoLuong, hh.DonGiaNhap, ct.GiamGia, ct.ThanhTien
                        FROM ChiTietHoaDonNhap ct
                        JOIN HangHoa hh ON ct.MaHang = hh.MaHang
                        WHERE ct.SoHDN = N'{soHDN}' 
                            ";
            tblCTHDN = Functions.GetDataToTable(sql);
            dataGridViewDSSP.DataSource = tblCTHDN;

            // Đặt header
            dataGridViewDSSP.Columns[0].HeaderText = "Mã Hàng Hóa";
            dataGridViewDSSP.Columns[1].HeaderText = "Tên Hàng Hóa";
            dataGridViewDSSP.Columns[2].HeaderText = "Số Lượng";
            dataGridViewDSSP.Columns[3].HeaderText = "Đơn Giá Nhập";
            dataGridViewDSSP.Columns[4].HeaderText = "Giảm Giá";
            dataGridViewDSSP.Columns[5].HeaderText = "Thành Tiền";
            dataGridViewDSSP.AllowUserToAddRows = false;
            dataGridViewDSSP.EditMode = DataGridViewEditMode.EditProgrammatically;

            CapNhatTongHop();
            if (tblCTHDN.Rows.Count > 0)
            {
                DataRow r = tblCTHDN.Rows[0];
                cboMaHH.Text = r["MaHang"].ToString();
                txtTenHH.Text = r["TenHangHoa"].ToString();

                // Nếu là NumericUpDown, phải chuyển về decimal/int đúng kiểu
                nudSoluong.Value = Convert.ToDecimal(r["SoLuong"]);
                txtDGN.Text = r["DonGiaNhap"].ToString();
                nudGiamgia.Value = Convert.ToDecimal(r["GiamGia"]);
                txtThanhtien.Text = Convert.ToDecimal(r["ThanhTien"]).ToString("0");
            }
        }

        private void CapNhatTongHop()
        {
            int tongSP = tblCTHDN.Rows.Count;
            int tongSoLuong = tblCTHDN.AsEnumerable().Sum(r => Convert.ToInt32(r["SoLuong"]));
            decimal tongTien = tblCTHDN.AsEnumerable().Sum(r => Convert.ToDecimal(r["ThanhTien"]));
            lblTongSP.Text = "Tổng Số Sản Phẩm: " + tongSP;
            lblSoluongSP.Text = "Tổng Số Lượng Sản Phẩm: " + tongSoLuong;
            lblTongtien.Text = "Tổng Tiền: " + tongTien.ToString("N0");
            lblBangchu.Text = "Tổng Tiền (Bằng Chữ): " + Functions.ChuyenSoSangChu(tongTien.ToString());
        }
                
        private void btnSua_Click(object sender, EventArgs e)
        {
            SetReadOnlyMode(false); // Cho phép chỉnh sửa
            btnSua.Enabled = false; // Tắt nút Sửa
        }

        // Hàm đặt ReadOnly/Enable cho toàn form
        private void SetReadOnlyMode(bool isReadOnly)
        {
            // Thông tin hóa đơn
            cboMaNV.Enabled = !isReadOnly;
            cboMaNCC.Enabled = !isReadOnly;
            txtSoHDN.ReadOnly = true; 
            dtpNgaynhap.Enabled = !isReadOnly;
            // Thông tin nhân viên 
            txtTennv.ReadOnly=true;
            // Thông tin nhà cung cấp 
            txtTenNCC.ReadOnly = true;
            mskDienthoai.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            // Thông tin hàng hóa
            cboMaHH.Enabled = !isReadOnly;
            txtTenHH.ReadOnly = true; // Tên hàng không tự sửa
            txtDGN.ReadOnly = isReadOnly;
            nudSoluong.ReadOnly = isReadOnly;
            nudGiamgia.ReadOnly = isReadOnly;
            txtThanhtien.ReadOnly = true;

            // Danh sách sản phẩm: Không cho sửa trực tiếp trên lưới
            dataGridViewDSSP.ReadOnly = true;

            // Nút Lưu chỉ bật khi đang ở chế độ sửa
            btnLuu.Enabled = !isReadOnly;
        }
        private void CapNhatDataRow()
        {
            if (dataGridViewDSSP.CurrentRow != null)
            {
                int rowIndex = dataGridViewDSSP.CurrentRow.Index;
                if (rowIndex >= 0 && rowIndex < tblCTHDN.Rows.Count)
                {
                    DataRow r = tblCTHDN.Rows[rowIndex];
                    r["SoLuong"] = nudSoluong.Value;
                    r["DonGiaNhap"] = txtDGN.Text;
                    r["GiamGia"] = nudGiamgia.Value;
                    r["ThanhTien"] = txtThanhtien.Text;
                }
            }
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
            CapNhatDataRow();
            // Update HoaDonNhap
            string sqlHDN = $"UPDATE HoaDonNhap SET MaNV=N'{cboMaNV.Text}', NgayNhap='{dtpNgaynhap.Value:yyyy-MM-dd}', MaNCC=N'{cboMaNCC.Text}' WHERE SoHDN=N'{txtSoHDN.Text}'";
            Functions.RunSql(sqlHDN);

            // Xóa toàn bộ ChiTietHoaDonNhap cũ rồi thêm lại (cách đơn giản nhất)
            Functions.RunSql($"DELETE FROM ChiTietHoaDonNhap WHERE SoHDN=N'{txtSoHDN.Text}'");
            foreach (DataGridViewRow row in dataGridViewDSSP.Rows)
            {
                if (row.IsNewRow) continue;
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                decimal donGiaNhap = Convert.ToDecimal(row.Cells["DonGiaNhap"].Value);
                int giamGia = Convert.ToInt32(row.Cells["GiamGia"].Value);
                decimal thanhTien = Convert.ToDecimal(row.Cells["ThanhTien"].Value);

                string sqlCT = $"INSERT INTO ChiTietHoaDonNhap (SoHDN, MaHang, SoLuong,  GiamGia, ThanhTien) " +
                               $"VALUES (N'{txtSoHDN.Text}', N'{maHang}', {soLuong}, {giamGia}, {thanhTien})";
                Functions.RunSql(sqlCT);

                // Update lại số lượng tồn trong HangHoa 
                string sqlUpdateHang = $"UPDATE HangHoa SET SoLuong = ISNULL(SoLuong, 0) + {soLuong}, DonGiaNhap={donGiaNhap} WHERE MaHang=N'{maHang}'";
                Functions.RunSql(sqlUpdateHang);
                // Cập nhật số lượng và giá hàng hóa
                decimal donGiaBan = Math.Round(donGiaNhap * 1.1M, 0); // Giá bán = 110% giá nhập
                string sql = $"UPDATE HangHoa SET " +
                      $"SoLuong = ISNULL(SoLuong, 0) + {soLuong}, " +
                      $"DonGiaNhap = {donGiaNhap}, " +
                      $"DonGiaBan = {donGiaBan} " +
                      $"WHERE MaHang = N'{maHang}'";
                Functions.RunSql(sql);
            }
            if (dataGridViewDSSP.CurrentRow != null)
            {
                var row = dataGridViewDSSP.CurrentRow;
                row.Cells["SoLuong"].Value = nudSoluong.Value;
                row.Cells["DonGiaNhap"].Value = txtDGN.Text;
                row.Cells["GiamGia"].Value = nudGiamgia.Value;
                row.Cells["ThanhTien"].Value = txtThanhtien.Text;
            }
            MessageBox.Show("Đã cập nhật hóa đơn thành công!");
            SetReadOnlyMode(true); // Đặt lại chế độ ReadOnly
            Load_DSSP(txtSoHDN.Text); // Tải lại danh sách sản phẩm
            CapNhatTongHop(); // Cập nhật tổng hợp
            btnSua.Enabled = true; // Bật lại nút Sửa
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Functions.RunSql($"DELETE FROM ChiTietHoaDonNhap WHERE SoHDN = N'{soHDN}'");
                Functions.RunSql($"DELETE FROM HoaDonNhap WHERE SoHDN = N'{soHDN}'");
                MessageBox.Show("Đã xóa hóa đơn thành công!");
                this.Close();
            }
        }        

        private void btnIn_Click(object sender, EventArgs e)
        {
            // 1) Khởi tạo Excel và Workbook/Worksheet
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            var workbook = excelApp.Workbooks.Add();
            var worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            // 2) Header thông tin công ty
            worksheet.Cells[1, 1] = "Cửa hàng mỹ phẩm TNL";
            worksheet.Cells[1, 1].Font.Color = Color.Blue;
            worksheet.Cells[2, 1] = "Địa chỉ: 12 Chùa Bộc, Quang Trung, Đống Đa, Hà Nội";
            worksheet.Cells[2, 1].Font.Color = Color.Blue;
            worksheet.Cells[3, 1] = "Số điện thoại: 086 984 5994";
            worksheet.Cells[3, 1].Font.Color = Color.Blue;

            // 3) Gộp ô tiêu đề chính
            var mergeRange = worksheet.Range[worksheet.Cells[5, 1], worksheet.Cells[5, 8]];
            mergeRange.Merge();
            mergeRange.HorizontalAlignment = ExcelXlHAlign.xlHAlignCenter;
            mergeRange.Value = "CHI TIẾT HÓA ĐƠN NHẬP HÀNG";
            mergeRange.Font.Size = 18;
            mergeRange.Font.Color = Color.Red;

            // 4) Thông tin hóa đơn nhập
            worksheet.Cells[7, 2] = "Số hóa đơn:";
            worksheet.Cells[7, 3] = txtSoHDN.Text;
            worksheet.Cells[8, 2] = "Ngày nhập:";
            worksheet.Cells[8, 3] = dtpNgaynhap.Value.ToString("dd/MM/yyyy");
            worksheet.Cells[9, 2] = "Nhà cung cấp:";
            worksheet.Cells[9, 3] = txtTenNCC.Text;
            worksheet.Cells[10, 2] = "Mã NCC:";
            worksheet.Cells[10, 3] = cboMaNCC.Text;
            worksheet.Cells[11, 2] = "Điện thoại:";
            worksheet.Cells[11, 3] = mskDienthoai.Text;
            worksheet.Cells[12, 2] = "Địa chỉ:";
            worksheet.Cells[12, 3] = txtDiachi.Text;
            worksheet.Cells[13, 2] = "Nhân viên:";
            worksheet.Cells[13, 3] = txtTennv.Text;
            worksheet.Cells[14, 2] = "Mã nhân viên:";
            worksheet.Cells[14, 3] = cboMaNV.Text;

            // 5) Tiêu đề bảng sản phẩm
            int headerRow = 16;
            worksheet.Cells[headerRow, 2] = "STT";
            worksheet.Cells[headerRow, 3] = "Mã hàng";
            worksheet.Cells[headerRow, 4] = "Tên hàng hóa";
            worksheet.Cells[headerRow, 5] = "Số lượng";
            worksheet.Cells[headerRow, 6] = "Đơn giá nhập";
            worksheet.Cells[headerRow, 7] = "Giảm giá";
            worksheet.Cells[headerRow, 8] = "Thành tiền";

            // Định dạng tiêu đề
            for (int c = 2; c <= 8; c++)
            {
                var cell = worksheet.Cells[headerRow, c];
                cell.Borders.LineStyle = ExcelXlLineStyle.xlContinuous;
                cell.Borders.Weight = ExcelXlBorderWeight.xlThin;
                cell.Interior.Color = Color.LightYellow;
                cell.Font.Size = 12;
                cell.HorizontalAlignment = ExcelXlHAlign.xlHAlignCenter;
                ((ExcelRange)cell).EntireColumn.AutoFit();
            }

            // 6) Ghi từng dòng sản phẩm
            for (int i = 0; i < dataGridViewDSSP.Rows.Count; i++)
            {
                int rowExcel = headerRow + 1 + i;
                worksheet.Cells[rowExcel, 2] = (i + 1); // STT
                worksheet.Cells[rowExcel, 3] = dataGridViewDSSP.Rows[i].Cells["MaHang"].Value?.ToString();
                worksheet.Cells[rowExcel, 4] = dataGridViewDSSP.Rows[i].Cells["TenHangHoa"].Value?.ToString();
                worksheet.Cells[rowExcel, 5] = dataGridViewDSSP.Rows[i].Cells["SoLuong"].Value?.ToString();
                worksheet.Cells[rowExcel, 6] = dataGridViewDSSP.Rows[i].Cells["DonGiaNhap"].Value?.ToString();
                worksheet.Cells[rowExcel, 7] = dataGridViewDSSP.Rows[i].Cells["GiamGia"].Value?.ToString();
                worksheet.Cells[rowExcel, 8] = dataGridViewDSSP.Rows[i].Cells["ThanhTien"].Value?.ToString();

                // Định dạng border
                for (int c = 2; c <= 8; c++)
                {
                    var cell = worksheet.Cells[rowExcel, c];
                    cell.Borders.LineStyle = ExcelXlLineStyle.xlContinuous;
                    cell.Borders.Weight = ExcelXlBorderWeight.xlThin;
                    cell.Font.Size = 12;
                    cell.HorizontalAlignment = ExcelXlHAlign.xlHAlignCenter;
                }
            }

            // 7) Tổng kết hóa đơn
            int footerRow = headerRow + 2 + dataGridViewDSSP.Rows.Count;
            worksheet.Cells[footerRow, 7] = "Tổng tiền:";
            worksheet.Cells[footerRow, 8] = lblTongtien.Text;

            worksheet.Cells[footerRow + 2, 7] = "Bằng chữ:";
            worksheet.Cells[footerRow + 2, 8] = lblBangchu.Text;

            // 8) Ghi ngày in phiếu
            worksheet.Cells[footerRow + 4, 7] = $"Hà Nội, ngày {dtpNgaynhap.Value.Day}, tháng {dtpNgaynhap.Value.Month}, năm {dtpNgaynhap.Value.Year}";
            worksheet.Cells[footerRow + 5, 7] = "Người lập phiếu";

            // Định dạng chữ ký
            worksheet.Cells[footerRow + 5, 7].HorizontalAlignment = ExcelXlHAlign.xlHAlignCenter;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void Tinhthanhtien()
        {
            decimal dongia = 0;
            int soluong = (int)nudSoluong.Value;
            int giamgia = (int)nudGiamgia.Value;
            decimal.TryParse(txtDGN.Text, out dongia);
            decimal thanhtien = (dongia * soluong) - ((dongia * soluong) * giamgia / 100);
            txtThanhtien.Text = thanhtien.ToString("0");
        }

        private void dataGridViewDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo không click vào header hoặc dòng trống
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewDSSP.Rows.Count)
            {
                DataGridViewRow row = dataGridViewDSSP.Rows[e.RowIndex];
                // Gán thông tin sản phẩm lên control
                cboMaHH.Text = row.Cells["MaHang"].Value?.ToString();
                txtTenHH.Text = row.Cells["TenHangHoa"].Value?.ToString();
                nudSoluong.Value = Convert.ToDecimal(row.Cells["SoLuong"].Value);
                txtDGN.Text = row.Cells["DonGiaNhap"].Value?.ToString();
                nudGiamgia.Value = Convert.ToDecimal(row.Cells["GiamGia"].Value);
                txtThanhtien.Text = Convert.ToDecimal(row.Cells["ThanhTien"].Value).ToString("0");
            }
        }
    }
}

