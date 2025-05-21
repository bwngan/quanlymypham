using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelRange = Microsoft.Office.Interop.Excel.Range;
using ExcelXlHAlign = Microsoft.Office.Interop.Excel.XlHAlign;
using ExcelXlLineStyle = Microsoft.Office.Interop.Excel.XlLineStyle;
using ExcelXlBorderWeight = Microsoft.Office.Interop.Excel.XlBorderWeight;


namespace quanlymypham.Forms
{
    public partial class formBaocaoSP : Form
    {
        DataTable tblSanPham, tblBanChay;
        public formBaocaoSP()
        {
            InitializeComponent();
            cboThoigian.Items.Clear();
            cboThoigian.Items.AddRange(new object[] { "Hôm nay", "Ngày", "Tháng", "Năm" });
            cboThoigian.SelectedIndex = 0;
            this.cboThoigian.SelectedIndexChanged += new EventHandler(this.cboThoigian_SelectedIndexChanged);

            // Ẩn tất cả filter lúc khởi tạo
            HideAllFilters();
        }

        private void formBaocaoSP_Load(object sender, EventArgs e)
        {
            chartSL.Visible = false;
            chartDT.Visible = false;
        }        

        private void cboThoigian_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAllFilters(); // Ẩn tất cả filter trước khi hiển thị filter mới
            chartSL.Visible = false;
            chartDT.Visible = false;
            if (cboThoigian.Text == "Hôm nay")
            {
                LoadSanPham();
                LoadChart();
                LoadBanChay();
            }
            else if (cboThoigian.Text == "Ngày")
            {
                lblBD.Visible = lblKT.Visible = true;
                dtpNgaybd.Visible = dtpNgaykt.Visible = true;
            }
            else if (cboThoigian.Text == "Tháng")
            {
                lblBD.Visible = lblKT.Visible = true;
                cboBD.Visible = cboKT.Visible = true;
                cboNamBD.Visible = cboNamKT.Visible = true;
                // Thêm giá trị tháng và năm nếu chưa có
                if (cboBD.Items.Count == 0)
                    cboBD.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
                if (cboKT.Items.Count == 0)
                    cboKT.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
                if (cboNamBD.Items.Count == 0)
                    cboNamBD.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025" });
                if (cboNamKT.Items.Count == 0)
                    cboNamKT.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025" });
            }
            else if (cboThoigian.Text == "Năm")
            {
                lblBD.Visible = lblKT.Visible = true;
                cboBD.Visible = cboKT.Visible = true;
                // Thêm giá trị năm nếu chưa có
                if (cboBD.Items.Count == 0)
                    cboBD.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025" });
                if (cboKT.Items.Count == 0)
                    cboKT.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025" });
            }

        }
        private void btnHienthi_Click(object sender, EventArgs e)
        {
            string sqlWhere = "";
            if (cboThoigian.Text == "Hôm nay")
            {
                string ngay = DateTime.Today.ToString("yyyy-MM-dd");
                sqlWhere = $"WHERE CONVERT(date, hdb.NgayBan) = '{ngay}'";
            }
            else if (cboThoigian.Text == "Ngày")
            {
                string tuNgay = dtpNgaybd.Value.ToString("yyyy-MM-dd");
                string denNgay = dtpNgaykt.Value.ToString("yyyy-MM-dd");
                if (dtpNgaybd.Value > dtpNgaykt.Value)
                {
                    MessageBox.Show("Từ ngày phải nhỏ hơn đến ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sqlWhere = $"WHERE hdb.NgayBan BETWEEN '{tuNgay}' AND '{denNgay}'";
            }
            else if (cboThoigian.Text == "Tháng")
            {
                int thangBD, thangKT, namBD, namKT;
                if (!int.TryParse(cboBD.Text, out thangBD) ||
                    !int.TryParse(cboKT.Text, out thangKT) ||
                    !int.TryParse(cboNamBD.Text, out namBD) ||
                    !int.TryParse(cboNamKT.Text, out namKT))
                {
                    MessageBox.Show("Bạn phải chọn đúng năm và tháng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (namBD > namKT || (namBD == namKT && thangBD > thangKT))
                {
                    MessageBox.Show("Từ tháng phải nhỏ hơn hoặc bằng đến tháng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                sqlWhere = $@"
            WHERE
                ((YEAR(hdb.NgayBan) >={namBD} AND MONTH(hdb.NgayBan)>={thangBD})
                AND (YEAR(hdb.NgayBan) <={namKT} AND MONTH(hdb.NgayBan)<={thangKT}))
        ";
            }
            else if (cboThoigian.Text == "Năm")
            {
                int namBD, namKT;
                if (!int.TryParse(cboBD.Text, out namBD) ||
                    !int.TryParse(cboKT.Text, out namKT))
                {
                    MessageBox.Show("Bạn phải chọn đúng năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (namBD > namKT)
                {
                    MessageBox.Show("Từ năm phải nhỏ hơn hoặc bằng đến năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sqlWhere = $"WHERE YEAR(hdb.NgayBan) BETWEEN {namBD} AND {namKT}";
            }

            // Truy vấn dữ liệu sản phẩm bán
            string sql = $@"
        SELECT 
            sp.MaHang AS [Mã sản phẩm],
            sp.TenHangHoa AS [Tên sản phẩm],
            SUM(ct.SoLuong) AS [Số lượng đã bán],
            SUM(ct.ThanhTien) AS [Tổng doanh thu]
        FROM ChiTietHoaDonBan ct
        JOIN HangHoa sp ON ct.MaHang = sp.MaHang
        JOIN HoaDonBan hdb ON ct.SoHDB = hdb.SoHDB
        {sqlWhere}
        GROUP BY sp.MaHang, sp.TenHangHoa
        ORDER BY [Số lượng đã bán] DESC
    ";

            tblSanPham = Functions.GetDataToTable(sql);
            dgvSanPham.DataSource = tblSanPham;

            // Tìm sản phẩm bán chạy nhất
            if (tblSanPham.Rows.Count > 0)
            {
                int maxSL = tblSanPham.AsEnumerable().Max(r => r.Field<int>("Số lượng đã bán"));
                DataTable dtBanChay = tblSanPham.AsEnumerable()
                    .Where(r => r.Field<int>("Số lượng đã bán") == maxSL)
                    .CopyToDataTable();
                dgvBanChay.DataSource = dtBanChay;
            }
            else
            {
                dgvBanChay.DataSource = null;
            }
            chartSL.Visible = true;
            chartDT.Visible = true;

            // Vẽ lại biểu đồ
            chartSL.Series.Clear();
            chartDT.Series.Clear();
            Series serSL = new Series("Tổng số lượng đã bán") { ChartType = SeriesChartType.Column };
            Series serDT = new Series("Tổng doanh thu") { ChartType = SeriesChartType.Column };
            foreach (DataRow row in tblSanPham.Rows)
            {
                serSL.Points.AddXY(row["Tên sản phẩm"], row["Số lượng đã bán"]);
                serDT.Points.AddXY(row["Tên sản phẩm"], row["Tổng doanh thu"]);
            }
            chartSL.Series.Add(serSL);
            chartDT.Series.Add(serDT);
        }
        private void LoadSanPham()
        {
            // Lấy filter thời gian
            string sqlWhere = ""; 
            string sql = $@"
            SELECT 
                sp.MaHang AS [Mã sản phẩm],
                sp.TenHangHoa AS [Tên sản phẩm],
                SUM(ct.SoLuong) AS [Số lượng đã bán],
                SUM(ct.ThanhTien) AS [Tổng doanh thu]
            FROM ChiTietHoaDonBan ct
            JOIN HangHoa sp ON ct.MaHang = sp.MaHang
            JOIN HoaDonBan hdb ON ct.SoHDB = hdb.SoHDB
            {sqlWhere}
            GROUP BY sp.MaHang, sp.TenHangHoa
            ORDER BY [Số lượng đã bán] DESC";

            tblSanPham = Functions.GetDataToTable(sql);
            dgvSanPham.DataSource = tblSanPham;
        }
        private void LoadBanChay()
        {
            // Sản phẩm bán chạy nhất
            if (tblSanPham == null || tblSanPham.Rows.Count == 0) return;
            int maxSoLuong = tblSanPham.AsEnumerable().Max(r => r.Field<int>("Số lượng đã bán"));
            var dt = tblSanPham.AsEnumerable()
                .Where(r => r.Field<int>("Số lượng đã bán") == maxSoLuong)
                .CopyToDataTable();
            dgvBanChay.DataSource = dt;
        }
        private void LoadChart()
        {
            // Chart số lượng đã bán
            chartSL.Series.Clear();
            Series serSL = new Series("Tổng số lượng đã bán");
            serSL.ChartType = SeriesChartType.Column;
            foreach (DataRow row in tblSanPham.Rows)
                serSL.Points.AddXY(row["Tên sản phẩm"], row["Số lượng đã bán"]);
            chartSL.Series.Add(serSL);

            // Chart doanh thu
            chartDT.Series.Clear();
            Series serDT = new Series("Tổng doanh thu");
            serDT.ChartType = SeriesChartType.Column;
            foreach (DataRow row in tblSanPham.Rows)
                serDT.Points.AddXY(row["Tên sản phẩm"], row["Tổng doanh thu"]);
            chartDT.Series.Add(serDT);
        }
        private void HideAllFilters()
        {
            lblBD.Visible = lblKT.Visible = false;
            dtpNgaybd.Visible = dtpNgaykt.Visible = false;
            cboBD.Visible = cboKT.Visible = false;
            cboNamBD.Visible = cboNamKT.Visible = false;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ResetValues();
            cboThoigian.SelectedIndex = 0;
            LoadSanPham();
            LoadChart();
            LoadBanChay();
            dgvSanPham.DataSource = null;
            dgvBanChay.DataSource = null;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất ra Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1) Khởi tạo Excel và Workbook/Worksheet
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;
            var workbook = excelApp.Workbooks.Add();
            var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];

            // 2) Tiêu đề dòng đầu
            worksheet.Cells[1, 1] = "Cửa hàng mỹ phẩm TNL";
            worksheet.Cells[1, 1].Font.Color = Color.Blue.ToArgb();
            worksheet.Cells[2, 1] = "Địa chỉ: 12 Chùa Bộc, Quang Trung, Đống Đa, Hà Nội";
            worksheet.Cells[2, 1].Font.Color = Color.Blue.ToArgb();
            worksheet.Cells[3, 1] = "Số điện thoại: 086 984 5994";
            worksheet.Cells[3, 1].Font.Color = Color.Blue.ToArgb();

            // 3) Gộp ô và tạo dòng tiêu đề chính
            int headerRow = 7;
            var mergeRange = worksheet.Range[
                worksheet.Cells[5, 1],
                worksheet.Cells[5, 1 + dgvSanPham.Columns.Count]
            ];
            mergeRange.Merge();
            mergeRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            mergeRange.Value = "BÁO CÁO SẢN PHẨM BÁN";
            mergeRange.Font.Size = 18;
            mergeRange.Font.Color = Color.Red.ToArgb();

            // 4) In thời gian xuất
            worksheet.Cells[6, 1] = "Thời gian xuất danh sách: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // 5) Dòng tiêu đề cột (STT + các header của DataGridView)
            worksheet.Cells[headerRow, 1] = "STT";
            var sttHeader = worksheet.Cells[headerRow, 1];
            sttHeader.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            sttHeader.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            sttHeader.Interior.Color = Color.LightYellow.ToArgb();
            sttHeader.Font.Size = 12;
            sttHeader.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            for (int i = 0; i < dgvSanPham.Columns.Count; i++)
            {
                var hdrCell = worksheet.Cells[headerRow, i + 2];
                hdrCell.Value = dgvSanPham.Columns[i].HeaderText;
                hdrCell.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                hdrCell.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                hdrCell.Interior.Color = Color.LightYellow.ToArgb();
                hdrCell.Font.Size = 12;
                hdrCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                hdrCell.EntireColumn.AutoFit();
            }

            // 6) Điền dữ liệu từng dòng
            for (int r = 0; r < dgvSanPham.Rows.Count; r++)
            {
                int excelRow = headerRow + 1 + r;

                // 6.1 STT
                var sttCell = worksheet.Cells[excelRow, 1];
                sttCell.Value = r + 1;
                sttCell.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                sttCell.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                sttCell.Font.Size = 12;
                sttCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // 6.2 Các cột dữ liệu
                for (int c = 0; c < dgvSanPham.Columns.Count; c++)
                {
                    var dataCell = worksheet.Cells[excelRow, c + 2];
                    dataCell.Value = dgvSanPham.Rows[r].Cells[c].Value?.ToString() ?? "";
                    dataCell.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    dataCell.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                    dataCell.Font.Size = 12;
                    dataCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    dataCell.EntireColumn.AutoFit();
                }
            }
        }

        private void ResetValues()
        {
            cboThoigian.SelectedIndex = 0;

            LoadSanPham();
            LoadChart();
            LoadBanChay();

            lblBD.Visible = false;
            lblKT.Visible = false;

            cboBD.Text = "";
            cboBD.Items.Clear();
            cboKT.Items.Clear();
            cboKT.Text = "";

            cboNamBD.Items.Clear();
            cboNamKT.Items.Clear();
            cboNamBD.Text = "";
            cboNamKT.Text = "";

            dtpNgaybd.Text = "";
            dtpNgaykt.Text = "";

            cboBD.SelectedIndex = -1;
            cboKT.SelectedIndex = -1;
            cboNamBD.SelectedIndex = -1;
            cboNamKT.SelectedIndex = -1;


            // Ẩn các control chọn khoảng thời gian/tháng/năm
            cboBD.Visible = false;
            cboKT.Visible = false;
            cboNamBD.Visible = false;
            cboNamKT.Visible = false;
            dtpNgaybd.Visible = false;
            dtpNgaykt.Visible = false;
        }
    }
}
