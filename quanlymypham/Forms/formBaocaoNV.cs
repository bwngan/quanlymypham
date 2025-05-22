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
    public partial class formBaocaoNV : Form
    {
        DataTable tblNhanVien;
        public formBaocaoNV()
        {
            InitializeComponent();
            cboThoigian.Items.Clear();
            cboThoigian.Items.AddRange(new object[] { "Hôm nay", "Ngày", "Tháng", "Năm" });
            cboThoigian.SelectedIndex = 0;
            this.cboThoigian.SelectedIndexChanged += new EventHandler(this.cboThoigian_SelectedIndexChanged);

            // Ẩn tất cả filter lúc khởi tạo
            HideAllFilters();
        }



        private void formBaocaoNV_Load(object sender, EventArgs e)
        {
            chartSoDon.Visible = false;
            chartDoanhThu.Visible = false;
        }

        

        private void cboThoigian_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAllFilters();
            chartSoDon.Visible = false;
            chartDoanhThu.Visible = false;
            if (cboThoigian.Text == "Ngày")
            {
                lblBD.Visible = lblKT.Visible = true;
                dtpNgaybd.Visible = dtpNgaykt.Visible = true;
            }
            else if (cboThoigian.Text == "Tháng")
            {
                lblBD.Visible = lblKT.Visible = true;
                cboBD.Visible = cboKT.Visible = true;
                cboNamBD.Visible = cboNamKT.Visible = true;
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

            // Query lấy báo cáo nhân viên
            string sql = $@"
                SELECT 
                    nv.MaNV AS [Mã nhân viên],
                    nv.TenNV AS [Tên nhân viên],
                    COUNT(DISTINCT hdb.SoHDB) AS [Số đơn hàng đã bán],
                    COALESCE(SUM(hdb.TongTien),0) AS [Tổng doanh thu]
                FROM NhanVien nv
                LEFT JOIN HoaDonBan hdb ON nv.MaNV = hdb.MaNV
                {sqlWhere}
                GROUP BY nv.MaNV, nv.TenNV
                ORDER BY [Tổng doanh thu] DESC
            ";

            tblNhanVien = Functions.GetDataToTable(sql);
            dgvNhanVien.DataSource = tblNhanVien;

            // Nhân viên doanh thu cao nhất
            if (tblNhanVien.Rows.Count > 0)
            {
                double maxDT = tblNhanVien.AsEnumerable().Max(r => r.Field<object>("Tổng doanh thu") == DBNull.Value ? 0 : Convert.ToDouble(r["Tổng doanh thu"]));
                DataTable dtDoanhThuCao = tblNhanVien.AsEnumerable()
                    .Where(r =>
                        (r.Field<object>("Tổng doanh thu") == DBNull.Value ? 0 : Convert.ToDouble(r["Tổng doanh thu"])) == maxDT
                    )
                    .CopyToDataTable();
                dgvNVDoanhThuCao.DataSource = dtDoanhThuCao;
            }
            else
            {
                dgvNVDoanhThuCao.DataSource = null;
            }

            chartSoDon.Visible = true;
            chartDoanhThu.Visible = true;

            // Chart số đơn hàng
            chartSoDon.Series.Clear();
            Series serSoDon = new Series("Tổng số đơn hàng") { ChartType = SeriesChartType.Column };
            foreach (DataRow row in tblNhanVien.Rows)
                serSoDon.Points.AddXY(row["Tên nhân viên"], row["Số đơn hàng đã bán"]);
            chartSoDon.Series.Add(serSoDon);

            // Chart doanh thu
            chartDoanhThu.Series.Clear();
            Series serDT = new Series("Tổng doanh thu") { ChartType = SeriesChartType.Column };
            foreach (DataRow row in tblNhanVien.Rows)
                serDT.Points.AddXY(row["Tên nhân viên"], row["Tổng doanh thu"]);
            chartDoanhThu.Series.Add(serDT);
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvNhanVien.DataSource = null;
            dgvNVDoanhThuCao.DataSource = null;
            chartSoDon.Visible = false;
            chartDoanhThu.Visible = false;
        }
        private void ResetValues()
        {
            cboThoigian.SelectedIndex = 0;
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
            cboBD.Visible = false;
            cboKT.Visible = false;
            cboNamBD.Visible = false;
            cboNamKT.Visible = false;
            dtpNgaybd.Visible = false;
            dtpNgaykt.Visible = false;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất ra Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var excelApp = new Excel.Application();
            excelApp.Visible = true;
            var workbook = excelApp.Workbooks.Add();
            var worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            worksheet.Cells[1, 1] = "Cửa hàng mỹ phẩm TNL";
            worksheet.Cells[1, 1].Font.Color = Color.Blue.ToArgb();
            worksheet.Cells[2, 1] = "Địa chỉ: 12 Chùa Bộc, Quang Trung, Đống Đa, Hà Nội";
            worksheet.Cells[2, 1].Font.Color = Color.Blue.ToArgb();
            worksheet.Cells[3, 1] = "Số điện thoại: 086 984 5994";
            worksheet.Cells[3, 1].Font.Color = Color.Blue.ToArgb();

            int headerRow = 7;
            var mergeRange = worksheet.Range[
                worksheet.Cells[5, 1],
                worksheet.Cells[5, 1 + dgvNhanVien.Columns.Count]
            ];
            mergeRange.Merge();
            mergeRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            mergeRange.Value = "BÁO CÁO NHÂN VIÊN";
            mergeRange.Font.Size = 18;
            mergeRange.Font.Color = Color.Red.ToArgb();

            worksheet.Cells[6, 1] = "Thời gian xuất danh sách: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            worksheet.Cells[headerRow, 1] = "STT";
            var sttHeader = worksheet.Cells[headerRow, 1];
            sttHeader.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            sttHeader.Borders.Weight = Excel.XlBorderWeight.xlThin;
            sttHeader.Interior.Color = Color.LightYellow.ToArgb();
            sttHeader.Font.Size = 12;
            sttHeader.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            for (int i = 0; i < dgvNhanVien.Columns.Count; i++)
            {
                var hdrCell = worksheet.Cells[headerRow, i + 2];
                hdrCell.Value = dgvNhanVien.Columns[i].HeaderText;
                hdrCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                hdrCell.Borders.Weight = Excel.XlBorderWeight.xlThin;
                hdrCell.Interior.Color = Color.LightYellow.ToArgb();
                hdrCell.Font.Size = 12;
                hdrCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                hdrCell.EntireColumn.AutoFit();
            }

            for (int r = 0; r < dgvNhanVien.Rows.Count; r++)
            {
                int excelRow = headerRow + 1 + r;
                var sttCell = worksheet.Cells[excelRow, 1];
                sttCell.Value = r + 1;
                sttCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                sttCell.Borders.Weight = Excel.XlBorderWeight.xlThin;
                sttCell.Font.Size = 12;
                sttCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                for (int c = 0; c < dgvNhanVien.Columns.Count; c++)
                {
                    var dataCell = worksheet.Cells[excelRow, c + 2];
                    dataCell.Value = dgvNhanVien.Rows[r].Cells[c].Value?.ToString() ?? "";
                    dataCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    dataCell.Borders.Weight = Excel.XlBorderWeight.xlThin;
                    dataCell.Font.Size = 12;
                    dataCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    dataCell.EntireColumn.AutoFit();
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HideAllFilters()
        {
            lblBD.Visible = lblKT.Visible = false;
            dtpNgaybd.Visible = dtpNgaykt.Visible = false;
            cboBD.Visible = cboKT.Visible = false;
            cboNamBD.Visible = cboNamKT.Visible = false;
        }


    }
}
