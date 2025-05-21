using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
    public partial class formBaocaoDT : Form
    {
        public formBaocaoDT()
        {
            InitializeComponent();
            // Setup ComboBox ngay khi khởi tạo
            cboThoigian.Items.Clear();
            cboThoigian.Items.AddRange(new object[] { "Hôm nay", "Ngày", "Tháng", "Năm" });
            cboThoigian.SelectedIndex = 0;
            this.cboThoigian.SelectedIndexChanged += new EventHandler(this.cboThoigian_SelectedIndexChanged);

            // Ẩn tất cả filter lúc khởi tạo
            HideAllFilters();
        }
        DataTable tblBCDT;
        private void formBaocaoDT_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            Load_Baocaohientai();
            LoadChartDataSP();
            UpdateTongHop();
            ResetValues();

        }
        private void HideAllFilters()
        {
            lblBD.Visible = false;
            lblKT.Visible = false;
            dtpNgaybd.Visible = false;
            dtpNgaykt.Visible = false;
            cboNamBD.Visible = false;
            cboNamKT.Visible = false;
            cboBD.Visible = false;
            cboKT.Visible = false;
        }
        private void cboThoigian_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAllFilters(); // Ẩn tất cả filter trước khi hiển thị filter mới
            if (cboThoigian.Text == "Hôm nay")
            {
                Load_Baocaohientai();
                LoadChartDataSP();
                UpdateTongHop();
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
            string sql = "";

            if (cboThoigian.Text == "Hôm nay")
            {
                Load_Baocaohientai();
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
                sql = $@"
                    SELECT CONVERT(date, HoaDonNhap.NgayNhap) AS Ngay,
                           COALESCE(COUNT(DISTINCT HoaDonNhap.SoHDN),0) AS SoluongHDN,
                           COALESCE(SUM(ChiTietHoaDonNhap.SoLuong),0) AS Soluongnhap,
                           COALESCE(SUM(ChiTietHoaDonNhap.ThanhTien),0) AS Chiphinhap,
                           COALESCE(COUNT(DISTINCT HoaDonBan.SoHDB),0) AS SoluongHoaDon,
                           COALESCE(SUM(ChiTietHoaDonBan.SoLuong),0) AS Soluongsanpham,
                           COALESCE(SUM(ChiTietHoaDonBan.ThanhTien),0) AS TongDoanhThu
                    FROM HoaDonNhap
                    LEFT JOIN ChiTietHoaDonNhap ON HoaDonNhap.SoHDN = ChiTietHoaDonNhap.SoHDN
                    LEFT JOIN HoaDonBan ON CONVERT(date, HoaDonBan.NgayBan) = CONVERT(date, HoaDonNhap.NgayNhap)
                    LEFT JOIN ChiTietHoaDonBan ON HoaDonBan.SoHDB = ChiTietHoaDonBan.SoHDB
                    WHERE HoaDonNhap.NgayNhap BETWEEN '{tuNgay}' AND '{denNgay}'
                    GROUP BY CONVERT(date, HoaDonNhap.NgayNhap)
                    ORDER BY Ngay";
                tblBCDT = Functions.GetDataToTable(sql);
                dataGridViewBaocao.DataSource = tblBCDT;
                SetGridHeader("Ngày");
            }
            else if (cboThoigian.Text == "Tháng")
            {
                int thangBD = int.Parse(cboBD.Text);
                int thangKT = int.Parse(cboKT.Text);
                int namBD = int.Parse(cboNamBD.Text);
                int namKT = int.Parse(cboNamKT.Text);

                if (namBD > namKT || (namBD == namKT && thangBD > thangKT))
                {
                    MessageBox.Show("Từ tháng phải nhỏ hơn hoặc bằng đến tháng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Lấy giá trị tháng/năm

                if (namBD > namKT || (namBD == namKT && thangBD > thangKT))
                {
                    MessageBox.Show("Từ tháng phải nhỏ hơn hoặc bằng đến tháng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                sql = $@"
                    SELECT (CAST(MONTH(HoaDonNhap.NgayNhap) AS VARCHAR) + '/' + CAST(YEAR(HoaDonNhap.NgayNhap) AS VARCHAR)) AS ThangNam,
                           COALESCE(COUNT(DISTINCT HoaDonNhap.SoHDN),0) AS SoluongHDN,
                           COALESCE(SUM(ChiTietHoaDonNhap.SoLuong),0) AS Soluongnhap,
                           COALESCE(SUM(ChiTietHoaDonNhap.ThanhTien),0) AS Chiphinhap,
                           COALESCE(COUNT(DISTINCT HoaDonBan.SoHDB),0) AS SoluongHoaDon,
                           COALESCE(SUM(ChiTietHoaDonBan.SoLuong),0) AS Soluongsanpham,
                           COALESCE(SUM(ChiTietHoaDonBan.ThanhTien),0) AS TongDoanhThu
                    FROM HoaDonNhap
                    LEFT JOIN ChiTietHoaDonNhap ON HoaDonNhap.SoHDN = ChiTietHoaDonNhap.SoHDN
                    LEFT JOIN HoaDonBan ON MONTH(HoaDonBan.NgayBan) = MONTH(HoaDonNhap.NgayNhap) AND YEAR(HoaDonBan.NgayBan) = YEAR(HoaDonNhap.NgayNhap)
                    LEFT JOIN ChiTietHoaDonBan ON HoaDonBan.SoHDB = ChiTietHoaDonBan.SoHDB
                    WHERE ((YEAR(HoaDonNhap.NgayNhap) >={namBD} AND MONTH(HoaDonNhap.NgayNhap)>={thangBD})
                        AND (YEAR(HoaDonNhap.NgayNhap) <={namKT} AND MONTH(HoaDonNhap.NgayNhap)<={thangKT}))
                    GROUP BY MONTH(HoaDonNhap.NgayNhap), YEAR(HoaDonNhap.NgayNhap)
                    ORDER BY YEAR(HoaDonNhap.NgayNhap), MONTH(HoaDonNhap.NgayNhap)";
                tblBCDT = Functions.GetDataToTable(sql);
                dataGridViewBaocao.DataSource = tblBCDT;
                SetGridHeader("Tháng/Năm");
            }
            else if (cboThoigian.Text == "Năm")
            {
                int namBD = int.Parse(cboBD.Text);
                int namKT = int.Parse(cboKT.Text);

                if (namBD > namKT)
                {
                    MessageBox.Show("Từ năm phải nhỏ hơn hoặc bằng đến năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sql = $@"
                    SELECT YEAR(HoaDonNhap.NgayNhap) AS Nam,
                           COALESCE(COUNT(DISTINCT HoaDonNhap.SoHDN),0) AS SoluongHDN,
                           COALESCE(SUM(ChiTietHoaDonNhap.SoLuong),0) AS Soluongnhap,
                           COALESCE(SUM(ChiTietHoaDonNhap.ThanhTien),0) AS Chiphinhap,
                           COALESCE(COUNT(DISTINCT HoaDonBan.SoHDB),0) AS SoluongHoaDon,
                           COALESCE(SUM(ChiTietHoaDonBan.SoLuong),0) AS Soluongsanpham,
                           COALESCE(SUM(ChiTietHoaDonBan.ThanhTien),0) AS TongDoanhThu
                    FROM HoaDonNhap
                    LEFT JOIN ChiTietHoaDonNhap ON HoaDonNhap.SoHDN = ChiTietHoaDonNhap.SoHDN
                    LEFT JOIN HoaDonBan ON YEAR(HoaDonBan.NgayBan) = YEAR(HoaDonNhap.NgayNhap)
                    LEFT JOIN ChiTietHoaDonBan ON HoaDonBan.SoHDB = ChiTietHoaDonBan.SoHDB
                    WHERE YEAR(HoaDonNhap.NgayNhap) BETWEEN {namBD} AND {namKT}
                    GROUP BY YEAR(HoaDonNhap.NgayNhap)
                    ORDER BY Nam";
                tblBCDT = Functions.GetDataToTable(sql);
                dataGridViewBaocao.DataSource = tblBCDT;
                SetGridHeader("Năm");
            }
            LoadChartDataSP();
            UpdateTongHop();
        }
        private void SetGridHeader(string timeColName)
        {
            if (dataGridViewBaocao.Columns.Count < 7) return;
            dataGridViewBaocao.Columns[0].HeaderText = timeColName;
            dataGridViewBaocao.Columns[1].HeaderText = "Số hóa đơn nhập";
            dataGridViewBaocao.Columns[2].HeaderText = "Số sản phẩm đã nhập";
            dataGridViewBaocao.Columns[3].HeaderText = "Chi phí nhập hàng";
            dataGridViewBaocao.Columns[4].HeaderText = "Số đơn hàng";
            dataGridViewBaocao.Columns[5].HeaderText = "Số sản phẩm đã bán";
            dataGridViewBaocao.Columns[6].HeaderText = "Doanh thu";
            // Căn chỉnh lại size
            for (int i = 0; i <= 6; i++)
                dataGridViewBaocao.Columns[i].Width = 120;
        }
        private void LoadChartDataSP()
        {
            if (tblBCDT == null || tblBCDT.Rows.Count == 0)
            {
                chart1.Series.Clear();
                chart1.ChartAreas.Clear();
            }
            else
            {
                chart1.Series.Clear();
                chart1.ChartAreas.Clear();
                ChartArea chartArea = new ChartArea();
                chart1.ChartAreas.Add(chartArea);

                Series series = new Series();
                series.ChartType = SeriesChartType.Column;

                string xField = "Ngay";
                if (cboThoigian.Text == "Tháng") xField = "ThangNam";
                else if (cboThoigian.Text == "Năm") xField = "Nam";

                series.XValueMember = xField;
                series.YValueMembers = "SoluongHoaDon";
                chart1.Series.Add(series);
                series.Name = "Tổng số đơn hàng";
                chart1.DataSource = tblBCDT;
                chart1.DataBind();
            }
        }
        private void Load_Baocaohientai()
        {
            string sql = @"     WITH Ngay AS (
                                SELECT CAST('" + DateTime.Today.ToString("yyyy-MM-dd") + @"' AS DATE) AS Ngay
                                UNION ALL
                                SELECT DATEADD(day, 1, Ngay)
                                FROM Ngay
                                WHERE DATEADD(day, 1, Ngay) <= CAST('" + DateTime.Today.ToString("yyyy-MM-dd") + @"' AS DATE)
                            )
                            SELECT Ngay.Ngay,
                                COALESCE(COUNT(HoaDonNhap.SoHDN), 0) AS SoluongHDN,
                                COALESCE(SUM(ChiTietHoaDonNhap.SoLuong), 0) AS Soluongnhap,
                                COALESCE(SUM(ChiTietHoaDonNhap.ThanhTien), 0) AS Chiphinhap,
                                COALESCE(COUNT(HoaDonBan.SoHDB), 0) AS SoluongHoaDon,
                                COALESCE(SUM(ChiTietHoaDonBan.SoLuong), 0) AS Soluongsanpham,
                                COALESCE(SUM(ChiTietHoaDonBan.ThanhTien), 0) AS TongDoanhThu
                            FROM Ngay
                            LEFT JOIN HoaDonBan ON CONVERT(DATE, Ngay.Ngay) = CONVERT(DATE, HoaDonBan.Ngayban)
                            LEFT JOIN HoaDonNhap ON CONVERT(DATE, Ngay.Ngay) = CONVERT(DATE, HoaDonNhap.Ngaynhap)
                            LEFT JOIN ChiTietHoaDonNhap ON HoaDonNhap.SoHDN = ChiTietHoaDonNhap.SoHDN
                            LEFT JOIN HangHoa ON ChiTietHoaDonNhap.MaHang = HangHoa.MaHang
                            LEFT JOIN ChiTietHoaDonBan ON HoaDonBan.SoHDB = ChiTietHoaDonBan.SoHDB
                            GROUP BY Ngay.Ngay
                            ORDER BY Ngay.Ngay
                            OPTION (MAXRECURSION 0);";

            tblBCDT = Functions.GetDataToTable(sql);
            dataGridViewBaocao.DataSource = tblBCDT;
            SetGridHeader("Ngày");
            dataGridViewBaocao.AllowUserToAddRows = false;
            dataGridViewBaocao.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void UpdateTongHop()
        {
            if (tblBCDT == null || tblBCDT.Rows.Count == 0) return;

            int tongHDN = tblBCDT.AsEnumerable().Sum(r => r.Field<int>("SoluongHDN"));
            int tongSPNhap = tblBCDT.AsEnumerable().Sum(r => r.Field<int>("Soluongnhap"));
            decimal tongChiPhiNhap = tblBCDT.AsEnumerable().Sum(r => r["Chiphinhap"] == DBNull.Value ? 0 : Convert.ToDecimal(r["Chiphinhap"]));
            int tongHDBan = tblBCDT.AsEnumerable().Sum(r => r.Field<int>("SoluongHoaDon"));
            int tongSPBan = tblBCDT.AsEnumerable().Sum(r => r.Field<int>("Soluongsanpham"));
            decimal tongDoanhThu = tblBCDT.AsEnumerable().Sum(r => r["TongDoanhThu"] == DBNull.Value ? 0 : Convert.ToDecimal(r["TongDoanhThu"]));

            lblTongHDN.Text = "Tổng Số Hóa Đơn Nhập: " + tongHDN.ToString();
            lblTongSPNhap.Text = "Tổng Số Sản Phẩm Nhập: " + tongSPNhap.ToString();
            lblTongChiPhiNhap.Text = "Tổng Chi Phí Nhập: " + tongChiPhiNhap.ToString("N0");
            lblTongHDBan.Text = "Tổng Số Hóa Đơn Bán: " + tongHDBan.ToString();
            lblTongSPBan.Text = "Tổng Số Sản Phẩm Bán: " + tongSPBan.ToString();
            lblTongDoanhThu.Text = "Tổng Doanh Thu: " + tongDoanhThu.ToString("N0");
        }
        private void ResetValues()
        {
            cboThoigian.SelectedIndex = 0;

            Load_Baocaohientai();
            
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

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ResetValues();
            cboThoigian.SelectedIndex = 0;
            Load_Baocaohientai();
            LoadChartDataSP();
            UpdateTongHop();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dataGridViewBaocao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất ra Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1) Khởi tạo Excel và Workbook/Worksheet
            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            var workbook = excelApp.Workbooks.Add();
            var worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            // 2) Tiêu đề dòng đầu
            worksheet.Cells[1, 1] = "Cửa hàng mỹ phẩm TNL";
            worksheet.Cells[1, 1].Font.Color = Color.Blue.ToArgb();
            worksheet.Cells[2, 1] = "Địa chỉ: 12 Chùa Bộc, Quang Trung, Đống Đa, Hà Nội";
            worksheet.Cells[2, 1].Font.Color = Color.Blue.ToArgb();
            worksheet.Cells[3, 1] = "Số điện thoại: 086 984 5994";
            worksheet.Cells[3, 1].Font.Color = Color.Blue.ToArgb();

            // 3) Gộp ô và tạo dòng tiêu đề chính
            int headerRow = 11;
            var mergeRange = worksheet.Range[
                worksheet.Cells[5, 1],
                worksheet.Cells[5, 2 + dataGridViewBaocao.Columns.Count]
            ];
            mergeRange.Merge();
            mergeRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            mergeRange.Value = "DANH SÁCH HÓA ĐƠN NHẬP";
            mergeRange.Font.Size = 18;
            mergeRange.Font.Color = Color.Red.ToArgb();

            // 4) In thời gian xuất
            worksheet.Cells[7, 1] = "Thời gian xuất danh sách: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // 5) Dòng tiêu đề cột (STT + các header của DataGridView)
            worksheet.Cells[headerRow, 2] = "STT";
            var sttHeader = worksheet.Cells[headerRow, 2];
            sttHeader.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            sttHeader.Borders.Weight = Excel.XlBorderWeight.xlThin;
            sttHeader.Interior.Color = Color.LightYellow.ToArgb();
            sttHeader.Font.Size = 12;
            sttHeader.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            for (int i = 0; i < dataGridViewBaocao.Columns.Count; i++)
            {
                var hdrCell = worksheet.Cells[headerRow, i + 3];
                hdrCell.Value = dataGridViewBaocao.Columns[i].HeaderText;
                hdrCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                hdrCell.Borders.Weight = Excel.XlBorderWeight.xlThin;
                hdrCell.Interior.Color = Color.LightYellow.ToArgb();
                hdrCell.Font.Size = 12;
                hdrCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                hdrCell.EntireColumn.AutoFit();
            }

            // 6) Điền dữ liệu từng dòng
            for (int r = 0; r < dataGridViewBaocao.Rows.Count; r++)
            {
                int excelRow = headerRow + 1 + r;

                // 6.1 STT
                var sttCell = worksheet.Cells[excelRow, 2];
                sttCell.Value = r + 1;
                sttCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                sttCell.Borders.Weight = Excel.XlBorderWeight.xlThin;
                sttCell.Font.Size = 12;
                sttCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // 6.2 Các cột dữ liệu
                for (int c = 0; c < dataGridViewBaocao.Columns.Count; c++)
                {
                    var dataCell = worksheet.Cells[excelRow, c + 3];
                    dataCell.Value = dataGridViewBaocao.Rows[r].Cells[c].Value?.ToString() ?? "";
                    dataCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    dataCell.Borders.Weight = Excel.XlBorderWeight.xlThin;
                    dataCell.Font.Size = 12;
                    dataCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    dataCell.EntireColumn.AutoFit();
                }
            }
        }
    }
}


