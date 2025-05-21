using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;



namespace quanlymypham.Forms
{

    public partial class formChitietHDB : Form
    {
        public event EventHandler HoaDonDaXoa;

        public string SoHDB { get; set; }

        public formChitietHDB()
        {
            InitializeComponent();
        }
        DataTable DS = new DataTable();
        private void formChitietHDB_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            Load_ThongtinHDB();
            Load_DS();
            txtsoHDB.ReadOnly = true;
            txtmaNV.ReadOnly = true;
            txttenNV.ReadOnly = true;
            txtmaKH.ReadOnly = true;
            txttenKH.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            mskdienthoai.ReadOnly = true;
            dtpngayban.Enabled = false;

        }
        private void Load_ThongtinHDB()
        {

            txtsoHDB.Text = SoHDB;
            string sql = @"SELECT HoaDonBan.SoHDB, HoaDonBan.NgayBan, NhanVien.MaNV, Nhanvien.TenNV, KhachHang.MaKhach, KhachHang.TenKhach, KhachHang.DiaChi, KhachHang.DienThoai FROM HoaDonBan 
                           INNER JOIN NhanVien ON HoaDonBan.MaNV = NhanVien.MaNV
                           INNER JOIN KhachHang ON HoaDonBan.MaKhach = KhachHang.MaKhach
                           WHERE HoaDonBan.SoHDB = '" + SoHDB + "'";
            DataTable dt = Functions.GetDataToTable(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];

                txtsoHDB.Text = r["SoHDB"].ToString();
                dtpngayban.Value = Convert.ToDateTime(r["NgayBan"]);
                txtmaNV.Text = r["MaNV"].ToString();
                txttenNV.Text = r["TenNV"].ToString();
                txtmaKH.Text = r["MaKhach"].ToString();
                txttenKH.Text = r["TenKhach"].ToString();
                txtdiachi.Text = r["DiaChi"].ToString();
                mskdienthoai.Text = r["DienThoai"].ToString();
            }
            
        }
        private void ResetValues()
        {
            txtsoHDB.Text = Functions.CreateKey("HDB");
            dtpngayban.Text = DateTime.Now.ToShortDateString();
            txtsoHDB.Text = "";
            txtmaNV.Text = "";
            txttenNV.Text = "";
            txtmaKH.Text = "";
            txttenKH.Text = "";
            txtdiachi.Text = "";
            mskdienthoai.Text = "";
            btnIn.Enabled = false;
            btnXoa.Enabled = false;
            DS.Clear();
            lblBangchu.Text = "Tổng tiền(Bằng chữ): ";
            lblSoluongSP.Text = "Số lượng sản phẩm: ";
            lblTongSP.Text = "Số sản phẩm:";
            lblTongtien.Text = "Tổng tiền:";
        }
        private void Load_DS()
        {
            string sql;
            sql = @"SELECT HangHoa.MaHang, HangHoa.TenHangHoa, ChiTietHoaDonBan.SoLuong, ChiTietHoaDonBan.GiamGia, ChiTietHoaDonBan.ThanhTien
                      FROM HangHoa INNER JOIN ChiTietHoaDonBan ON HangHoa.MaHang=ChiTietHoaDonBan.MaHang
                      WHERE ChiTietHoaDonBan.SoHDB = '" + SoHDB + "'";
            DataTable dt = Functions.GetDataToTable(sql);
            dataGridViewDSSP.DataSource = dt;
            DS = dt;

            dataGridViewDSSP.Columns[0].HeaderText = "Mã Hàng";
            dataGridViewDSSP.Columns[1].HeaderText = "Tên Hàng";
            dataGridViewDSSP.Columns[2].HeaderText = "Số Lượng";
            dataGridViewDSSP.Columns[3].HeaderText = "Giảm Giá (%)";
            dataGridViewDSSP.Columns[4].HeaderText = "Thành Tiền";
            dataGridViewDSSP.Columns[0].Width = 100;
            dataGridViewDSSP.Columns[1].Width = 150;
            dataGridViewDSSP.Columns[2].Width = 100;
            dataGridViewDSSP.Columns[3].Width = 100;
            dataGridViewDSSP.Columns[4].Width = 120;
            dataGridViewDSSP.EditMode = DataGridViewEditMode.EditProgrammatically;

            int sumSoluongSp = 0;
            int sumSp = DS.Rows.Count;
            decimal sumTongtien = 0;
            for( int i=0; i<DS.Rows.Count; i++)
            {
                sumSoluongSp += Convert.ToInt32(DS.Rows[i]["SoLuong"]);
                sumTongtien += Convert.ToDecimal(DS.Rows[i]["ThanhTien"]);
            }
            lblSoluongSP.Text = "Số lượng sản phẩm:" + sumSoluongSp;
            lblTongSP.Text = "Số sản phẩm:" + sumSp;
            lblTongtien.Text = "Tổng tiền:" + sumTongtien;
            lblBangchu.Text = "Tổng tiền (Bằng chữ):" + Functions.ChuyenSoSangChu(sumTongtien.ToString());


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xoá hoá đơn này không","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
            {
                string sql = "DELETE FROM HoaDonBan WHERE SoHDB = N'" + txtsoHDB.Text + "'";
                string sqlCT = "DELETE FROM ChiTietHoaDonBan WHERE SoHDB = N'" + txtsoHDB.Text + "'";
                Functions.RunSql(sql);
                Functions.RunSql(sqlCT);
                foreach (DataRow row in DS.Rows)
                {
                    string masp = row["MaHang"].ToString();
                    int soluongsp = Convert.ToInt32(row["SoLuong"]);
                    sql = @"UPDATE HangHoa SET SoLuong = SoLuong + " + soluongsp + " WHERE MaHang = N'" + masp + "'";
                    Functions.RunSql(sql);
                }
                ResetValues();
                if(HoaDonDaXoa != null)
                {
                    HoaDonDaXoa(this, EventArgs.Empty);
                    this.Close();
                }    
            }    

        }

        private void btnIn_Click(object sender, EventArgs e)
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
            worksheet.Cells[8, 3] = dtpngayban.Value;
            worksheet.Cells[8, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
            worksheet.Cells[7, 7] = "Khách hàng";
            worksheet.Cells[7, 8] = txttenKH;
            worksheet.Cells[8, 7] = "Số điện thoại";
            worksheet.Cells[8, 8] = mskdienthoai.Text;
            worksheet.Cells[9, 7] = "Địa chỉ";
            worksheet.Cells[9, 8] = txtdiachi.Text;
            worksheet.Cells[9, 2] = "Nhân viên";
            worksheet.Cells[9, 3] = txttenNV.Text;
            worksheet.Cells[11, 2] = "STT";
            worksheet.Cells[11, 2].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            worksheet.Cells[11, 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
            worksheet.Cells[11, 2].Interior.Color = Color.LightYellow;
            worksheet.Cells[11, 2].Font.Size = 12;
            worksheet.Cells[11, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            for ( int i=1; i<= dataGridViewDSSP.Columns.Count; i++)
            {
                worksheet.Cells[11, i + 2].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[11, i + 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
                worksheet.Cells[11, i + 2].Value = dataGridViewDSSP.Columns[i-1].HeaderText;
                worksheet.Cells[11, i + 2].Interior.Color = Color.LightYellow;
                worksheet.Cells[11, i + 2].Font.Size = 12;
                worksheet.Cells[11, i + 2].EntireColumn.AutoFit() ;
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
            worksheet.Cells[(dataGridViewDSSP.Rows.Count + 12) + 8, 6] = "Hà Nội, Ngay " + dtpngayban.Value.Day + ", tháng " + dtpngayban.Value.Month + ", năm" + dtpngayban.Value.Year;
            excelApp.ScreenUpdating = true;
            excelApp.Visible = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            var main = Application.OpenForms.OfType<GD_Chinh>().FirstOrDefault();
        }
    }
    
}
