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

namespace quanlymypham.Forms
{
    public partial class formChitietHDN : Form
    {
        DataTable DS = new DataTable();
        private string SoHDN;
        public formChitietHDN(string SoHDN)
        {
            InitializeComponent();
            this.SoHDN = SoHDN;
        }
        // tạo 1 dgv lưu thông tin dssp
        

        private void formChitietHDN_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            Load_ThongtinHDN(SoHDN);
            Load_DS(SoHDN);
            txtSoHDN.ReadOnly = true;
            txtTennv.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            mskDienthoai.ReadOnly = true;
            txtMaNCC.ReadOnly = true;
            txtMaNV.ReadOnly = true;
            dtpNgaynhap.Enabled = false;

        }
        private void ResetValues()
        {
            txtSoHDN.Text = Functions.CreateKey("HDN");
            txtSoHDN.Text = "";
            txtTennv.Text = "";
            txtTenNCC.Text = "";
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
            txtMaNCC.Text = "";
            txtMaNV.Text = "";
            dtpNgaynhap.Value = DateTime.Now;
            btnIn.Enabled = false;
            btnXoa.Enabled = false;
            DS.Clear();
        }
        private void Load_ThongtinHDN(string SoHDN)
        {
            txtSoHDN.Text = SoHDN;
            string sql = @"SELECT HoaDonNhap.SoHDN,
                          HoaDonNhap.NgayNhap,
                          NhanVien.MaNV,
                          NhanVien.TenNV,
                          NhaCungCap.MaNCC,
                          NhaCungCap.TenNCC,
                          NhaCungCap.DienThoai,
                          NhaCungCap.DiaChi
                   FROM HoaDonNhap
                   INNER JOIN NhanVien ON HoaDonNhap.MaNV = NhanVien.MaNV
                   INNER JOIN NhaCungCap ON HoaDonNhap.MaNCC = NhaCungCap.MaNCC
                   WHERE HoaDonNhap.SoHDN = '" + SoHDN + "'";
            DataTable dt = Functions.GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                txtSoHDN.Text = dt.Rows[0]["SoHDN"].ToString();
                dtpNgaynhap.Text = dt.Rows[0]["NgayNhap"].ToString();
                txtMaNV.Text = dt.Rows[0]["MaNV"].ToString();
                txtTennv.Text = dt.Rows[0]["TenNV"].ToString();
                txtMaNCC.Text = dt.Rows[0]["MaNCC"].ToString();
                txtTenNCC.Text = dt.Rows[0]["TenNCC"].ToString();
                mskDienthoai.Text = dt.Rows[0]["DienThoai"].ToString();
                txtDiachi.Text = dt.Rows[0]["DiaChi"].ToString();
            }
        }
        private void Load_DS(string SoHDN)
        {
            string sql = @"SELECT ChiTietHoaDonNhap.SoHDN,
                          ChiTietHoaDonNhap.MaHang,
                          HangHoa.TenHangHoa,
                          ChiTietHoaDonNhap.SoLuong,
                          HangHoa.DonGiaNhap,
                          ChiTietHoaDonNhap.GiamGia,
                          ChiTietHoaDonNhap.ThanhTien
                   FROM ChiTietHoaDonNhap
                   INNER JOIN HangHoa ON ChiTietHoaDonNhap.MaHang = HangHoa.MaHang
                   WHERE ChiTietHoaDonNhap.SoHDN = '" + SoHDN + "'";
            DS = Functions.GetDataToTable(sql);
            dataGridViewdssp.DataSource = DS;
            dataGridViewdssp.Columns[0].HeaderText = "Số HĐN";
            dataGridViewdssp.Columns[1].HeaderText = "Mã SP";
            dataGridViewdssp.Columns[2].HeaderText = "Tên Hàng Hóa";
            dataGridViewdssp.Columns[3].HeaderText = "Số lượng";
            dataGridViewdssp.Columns[4].HeaderText = "Đơn Giá";
            dataGridViewdssp.Columns[5].HeaderText = "Giảm Giá";
            dataGridViewdssp.Columns[6].HeaderText = "Thành Tiền";
            dataGridViewdssp.AllowUserToAddRows = false;
            dataGridViewdssp.EditMode = DataGridViewEditMode.EditProgrammatically;
            int sumSoluongSP = 0;
            int sumSP=DS.Rows.Count;
            decimal sumThanhtien = 0;
            for (int i = 0; i < DS.Rows.Count; i++)
            {
                sumSoluongSP += Convert.ToInt32(DS.Rows[i]["SoLuong"]);
                sumThanhtien += Convert.ToDecimal(DS.Rows[i]["ThanhTien"]);
            }
            lblTongtien.Text ="Tổng Tiền:"+ sumThanhtien.ToString();
            lblSoluongSP.Text ="Tổng Số Lượng Sản Phẩm:"+ sumSoluongSP.ToString();
            lblTongSP.Text ="Tổng Số Sản Phẩm:"+ sumSP.ToString();
            lblBangchu.Text ="Tổng Tiền (Bằng Chữ):"+ Functions.ChuyenSoSangChu(sumThanhtien.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM HoaDonNhap WHERE SoHDN='" + txtSoHDN.Text + "'";
                string sqlct = "DELETE FROM ChiTietHoaDonNhap WHERE SoHDN='" + txtSoHDN.Text + "'";
                Functions.RunSqlDel(sqlct);
                Functions.RunSqlDel(sql);
                foreach(DataRow row in DS.Rows)
                {
                    string maHang = row["MaHang"].ToString();
                    int soLuongsp = Convert.ToInt32(row["SoLuong"]);
                    string sql1 = $"UPDATE HangHoa SET Soluong = Soluong - {soLuongsp} WHERE MaHang = N'{maHang}'";
                    Functions.RunSql(sql1);                    
                }
                ResetValues();
                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            worksheet.Cells[10, 3] = txtMaNCC.Text;
            worksheet.Cells[11, 2] = "Điện thoại:";
            worksheet.Cells[11, 3] = mskDienthoai.Text;
            worksheet.Cells[12, 2] = "Địa chỉ:";
            worksheet.Cells[12, 3] = txtDiachi.Text;
            worksheet.Cells[13, 2] = "Nhân viên:";
            worksheet.Cells[13, 3] = txtTennv.Text;
            worksheet.Cells[14, 2] = "Mã nhân viên:";
            worksheet.Cells[14, 3] = txtMaNV.Text;

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
            for (int i = 0; i < dataGridViewdssp.Rows.Count; i++)
            {
                int rowExcel = headerRow + 1 + i;
                worksheet.Cells[rowExcel, 2] = (i + 1); // STT
                worksheet.Cells[rowExcel, 3] = dataGridViewdssp.Rows[i].Cells["MaHang"].Value?.ToString();
                worksheet.Cells[rowExcel, 4] = dataGridViewdssp.Rows[i].Cells["TenHangHoa"].Value?.ToString();
                worksheet.Cells[rowExcel, 5] = dataGridViewdssp.Rows[i].Cells["SoLuong"].Value?.ToString();
                worksheet.Cells[rowExcel, 6] = dataGridViewdssp.Rows[i].Cells["DonGiaNhap"].Value?.ToString();
                worksheet.Cells[rowExcel, 7] = dataGridViewdssp.Rows[i].Cells["GiamGia"].Value?.ToString();
                worksheet.Cells[rowExcel, 8] = dataGridViewdssp.Rows[i].Cells["ThanhTien"].Value?.ToString();

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
            int footerRow = headerRow + 2 + dataGridViewdssp.Rows.Count;
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
    }
}

