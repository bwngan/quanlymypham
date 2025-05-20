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
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelRange = Microsoft.Office.Interop.Excel.Range;
using ExcelXlHAlign = Microsoft.Office.Interop.Excel.XlHAlign;
using ExcelXlLineStyle = Microsoft.Office.Interop.Excel.XlLineStyle;
using ExcelXlBorderWeight = Microsoft.Office.Interop.Excel.XlBorderWeight;

namespace quanlymypham.Forms
{
    public partial class formDSHDN : Form
    {
        public formDSHDN()
        {
            InitializeComponent();
        }
        DataTable tblHDN;
        private void formDSHDN_Load(object sender, EventArgs e)
        {
            Load_dataGridViewHDN();
        }
        private void Load_dataGridViewHDN()
        {
            string sql;
            sql = "SELECT * FROM HoaDonNhap";
            tblHDN = Functions.GetDataToTable(sql);
            dataGridViewHDN.DataSource = tblHDN;
            dataGridViewHDN.Columns[0].HeaderText = "Số Hóa Đơn Nhập";
            dataGridViewHDN.Columns[1].HeaderText = "Mã Nhân Viên";
            dataGridViewHDN.Columns[2].HeaderText = "Ngày Nhập";
            dataGridViewHDN.Columns[3].HeaderText = "Mã Nhà Cung Cấp";
            dataGridViewHDN.Columns[4].HeaderText = "Tổng Tiền";
            dataGridViewHDN.Columns[0].Width = 150;
            dataGridViewHDN.Columns[1].Width = 150;
            dataGridViewHDN.Columns[2].Width = 150;
            dataGridViewHDN.Columns[3].Width = 150;
            dataGridViewHDN.Columns[4].Width = 150;
            dataGridViewHDN.AllowUserToAddRows = false;
            dataGridViewHDN.EditMode = DataGridViewEditMode.EditProgrammatically;
            int sumSoluongHD = dataGridViewHDN.Rows.Count;
            lblTongHD.Text = "Số Lượng Hóa Đơn: " + sumSoluongHD;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           
            // 1. Khởi tạo SQL
            string sql = "SELECT * FROM HoaDonNhap WHERE 1=1";

            // 2. Thêm điều kiện SoHDN, MaNV, MaNCC nếu có
            if (!string.IsNullOrWhiteSpace(txtSoHDN.Text))
                sql += $" AND SoHDN LIKE N'%{txtSoHDN.Text}%'";
            if (!string.IsNullOrWhiteSpace(txtMaNV.Text))
                sql += $" AND MaNV LIKE N'%{txtMaNV.Text}%'";
            if (!string.IsNullOrWhiteSpace(txtMaNCC.Text))
                sql += $" AND MaNCC LIKE N'%{txtMaNCC.Text}%'";

            // 3. Tổng tiền
            bool hasMin = !string.IsNullOrWhiteSpace(txtKhoangbd.Text);
            bool hasMax = !string.IsNullOrWhiteSpace(txtKhoangkt.Text);
            if (hasMin && hasMax)
            {
                int minTien = int.Parse(txtKhoangbd.Text);
                int maxTien = int.Parse(txtKhoangkt.Text);
                sql += $" AND TongTien BETWEEN {minTien} AND {maxTien}";
            }
            else if (hasMin)
            {
                int minTien = int.Parse(txtKhoangbd.Text);
                sql += $" AND TongTien >= {minTien}";
            }
            else if (hasMax)
            {
                int maxTien = int.Parse(txtKhoangkt.Text);
                sql += $" AND TongTien <= {maxTien}";
            }

            // 4. Ngày tạo
            // MaskedTextBox rỗng mặc định là "  /  /" (copy nguyên text trên form)
            const string emptyMask = "  /  /";
            bool hasFromDate = mskNgaybd.Text != emptyMask;
            bool hasToDate = mskNgaykt.Text != emptyMask;

            // 4.1 Validate format nếu có nhập
            if (hasFromDate && !Functions.IsDate(mskNgaybd.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng dd/MM/yyyy cho từ ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (hasToDate && !Functions.IsDate(mskNgaykt.Text))
            {
                MessageBox.Show("Bạn phải nhập đúng dd/MM/yyyy cho đến ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4.2 Parse
            DateTime ngaybd = DateTime.MinValue, ngaykt = DateTime.MinValue;
            if (hasFromDate)
                ngaybd = DateTime.ParseExact(mskNgaybd.Text, "dd/MM/yyyy", null);
            if (hasToDate)
                ngaykt = DateTime.ParseExact(mskNgaykt.Text, "dd/MM/yyyy", null);

            // 4.3 Kiểm tra thứ tự nếu cả hai đều nhập
            if (hasFromDate && hasToDate && ngaybd >= ngaykt)
            {
                MessageBox.Show("Từ ngày phải nhỏ hơn đến ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4.4 Nối vào SQL
            if (hasFromDate && hasToDate)
            {
                sql += $" AND NgayNhap BETWEEN '{ngaybd:yyyy-MM-dd}' AND '{ngaykt:yyyy-MM-dd}'";
            }
            else if (hasFromDate)
            {
                sql += $" AND NgayNhap >= '{ngaybd:yyyy-MM-dd}'";
            }
            else if (hasToDate)
            {
                sql += $" AND NgayNhap <= '{ngaykt:yyyy-MM-dd}'";
            }

            // 5. Thực thi và bind
            tblHDN = Functions.GetDataToTable(sql);
            dataGridViewHDN.DataSource = tblHDN;
            lblTongHD.Text = "Số Lượng Hóa Đơn: " + tblHDN.Rows.Count;

            MessageBox.Show(
                tblHDN.Rows.Count == 0
                    ? "Không có bản ghi thỏa mãn điều kiện"
                    : $"Đã có {tblHDN.Rows.Count} bản ghi thỏa mãn điều kiện",
                "Thông báo",
                MessageBoxButtons.OK,
                tblHDN.Rows.Count == 0 ? MessageBoxIcon.Information : MessageBoxIcon.Information
            );
        
   
        }

        private void formDSHDN_DoubleClick(object sender, EventArgs e)
        {
            formChitietHDN a = new formChitietHDN();
            a.Show();
        }

        private void btnTaoHDN_Click(object sender, EventArgs e)
        {
            formThemHDN a = new formThemHDN();
            a.Show();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
        }
        private void ResetValue()
        {
            txtSoHDN.Text = "";
            txtMaNV.Text = "";
            txtMaNCC.Text = "";
            txtKhoangbd.Text = "";
            txtKhoangkt.Text = "";
            mskNgaybd.Text = "  /  /";
            mskNgaykt.Text = "  /  /";
            Load_dataGridViewHDN();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            // 1) Khởi tạo Excel và Workbook/Worksheet
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            var workbook = excelApp.Workbooks.Add();
            var worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            // 2) Tiêu đề dòng đầu
            worksheet.Cells[1, 1] = "Cửa hàng mỹ phẩm TNL";
            worksheet.Cells[1, 1].Font.Color = Color.Blue;
            worksheet.Cells[2, 1] = "Địa chỉ: 12 Chùa Bộc, Quang Trung, Đống Đa, Hà Nội";
            worksheet.Cells[2, 1].Font.Color = Color.Blue;
            worksheet.Cells[3, 1] = "Số điện thoại: 097 114 0994";
            worksheet.Cells[3, 1].Font.Color = Color.Blue;

            // 3) Gộp ô và tạo dòng tiêu đề chính
            var mergeRange = worksheet.Range[
                worksheet.Cells[5, 1],
                worksheet.Cells[5, 1 + dataGridViewHDN.Columns.Count]
            ];
            mergeRange.Merge();
            mergeRange.HorizontalAlignment = ExcelXlHAlign.xlHAlignCenter;
            mergeRange.Value = "DANH SÁCH HÓA ĐƠN NHẬP";
            mergeRange.Font.Size = 18;
            mergeRange.Font.Color = Color.Red;

            // 4) In thời gian xuất
            worksheet.Cells[7, 1] = "Thời gian xuất danh sách: " +
                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // 5) Dòng tiêu đề cột (STT + các header của DataGridView)
            int headerRow = 11;
            // 5.1 STT
            var sttHeader = worksheet.Cells[headerRow, 2];
            sttHeader.Value = "STT";
            sttHeader.Borders.LineStyle = ExcelXlLineStyle.xlContinuous;
            sttHeader.Borders.Weight = ExcelXlBorderWeight.xlThin;
            sttHeader.Interior.Color = Color.LightYellow;
            sttHeader.Font.Size = 12;
            sttHeader.HorizontalAlignment = ExcelXlHAlign.xlHAlignCenter;

            // 5.2 Tiêu đề từng cột từ DataGridView
            for (int i = 0; i < dataGridViewHDN.Columns.Count; i++)
            {
                var hdrCell = worksheet.Cells[headerRow, i + 3];
                hdrCell.Value = dataGridViewHDN.Columns[i].HeaderText;
                hdrCell.Borders.LineStyle = ExcelXlLineStyle.xlContinuous;
                hdrCell.Borders.Weight = ExcelXlBorderWeight.xlThin;
                hdrCell.Interior.Color = Color.LightYellow;
                hdrCell.Font.Size = 12;
                hdrCell.HorizontalAlignment = ExcelXlHAlign.xlHAlignCenter;
                ((ExcelRange)hdrCell).EntireColumn.AutoFit();
            }

            // 6) Điền dữ liệu từng dòng
            for (int r = 0; r < dataGridViewHDN.Rows.Count; r++)
            {
                int excelRow = headerRow + 1 + r;

                // 6.1 STT
                var sttCell = worksheet.Cells[excelRow, 2];
                sttCell.Value = r + 1;
                sttCell.Borders.LineStyle = ExcelXlLineStyle.xlContinuous;
                sttCell.Borders.Weight = ExcelXlBorderWeight.xlThin;
                sttCell.Font.Size = 12;
                sttCell.HorizontalAlignment = ExcelXlHAlign.xlHAlignCenter;

                // 6.2 Các cột dữ liệu
                for (int c = 0; c < dataGridViewHDN.Columns.Count; c++)
                {
                    var dataCell = worksheet.Cells[excelRow, c + 3];
                    dataCell.Value = dataGridViewHDN.Rows[r].Cells[c].Value?.ToString() ?? "";
                    dataCell.Borders.LineStyle = ExcelXlLineStyle.xlContinuous;
                    dataCell.Borders.Weight = ExcelXlBorderWeight.xlThin;
                    dataCell.Font.Size = 12;
                    dataCell.HorizontalAlignment = ExcelXlHAlign.xlHAlignCenter;
                    ((ExcelRange)dataCell).EntireColumn.AutoFit();
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            var main = Application.OpenForms.OfType<GD_Chinh>().FirstOrDefault();
        }
    }
   }

