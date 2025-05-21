using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;  

namespace quanlymypham.Forms
{
    public partial class formDSHDB: Form
    {
        public formDSHDB()
        {
            InitializeComponent();
        }
        DataTable tblDSHDB;
        private void formDSHDB_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            Load_dgridDSHDB();
        }
        private void Load_dgridDSHDB()
        {
            string sql;
            sql = " SELECT * FROM HoaDonBan";
            tblDSHDB = Functions.GetDataToTable(sql);
            dataGridViewHDB.DataSource = tblDSHDB;
            dataGridViewHDB.Columns[0].HeaderText = "Số hoá đơn bán";
            dataGridViewHDB.Columns[1].HeaderText = "Mã nhân viên";
            dataGridViewHDB.Columns[2].HeaderText = "Ngày bán";
            dataGridViewHDB.Columns[3].HeaderText = "Mã khách hàng";
            dataGridViewHDB.Columns[4].HeaderText = "Tổng tiền";
            dataGridViewHDB.Columns[0].Width = 80;
            dataGridViewHDB.Columns[1].Width = 100;
            dataGridViewHDB.Columns[2].Width = 80;
            dataGridViewHDB.Columns[3].Width = 80;
            dataGridViewHDB.Columns[4].Width = 100;
            dataGridViewHDB.AllowUserToAddRows = false;
            dataGridViewHDB.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void formDSHDB_DoubleClick(object sender, EventArgs e)
        {
            formChitietHDB a = new formChitietHDB();
            a.Show();
        }

        private void btntaohoadonmoi_Click(object sender, EventArgs e)
        {
            using (var them = new formThemHDB())
            {
                them.ShowDialog();
            }
            Load_dgridDSHDB();
        }

        private void dataGridViewHDB_DoubleClick(object sender, EventArgs e)
        {
            
            if (dataGridViewHDB.CurrentRow == null) return;
            string soHDB = dataGridViewHDB.CurrentRow.Cells["SoHDB"].Value.ToString();

            var frm = new formChitietHDB();
            frm.SoHDB = soHDB;

            frm.ShowDialog();
            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if((txtkhoangbd.Text != "")&&(txtkhoangkt.Text==""))
            {
                MessageBox.Show("Hãy nhập khoảng tiền tối đa muốn tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkhoangkt.Focus();
                return;
            }  
            if((txtkhoangbd.Text=="")&& (txtkhoangkt.Text != ""))
            {
                MessageBox.Show("Hãy nhập khoảng tiền tối thiểu muốn tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkhoangbd.Focus();
                return;
            }
            if ((txtkhoangbd.Text != "") && (txtkhoangkt.Text != "")&&Convert.ToInt32(txtkhoangbd.Text) >= Convert.ToInt32(txtkhoangkt.Text))
            {
                MessageBox.Show("Khoảng tiền tối thiểu không được lớn hơn khoảng tiền tối đa muốn tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkhoangbd.Focus();
                return;
            }
            if ((mskngaybd.Text != " / /") && (mskngaykt.Text == "/ /"))
            {
                MessageBox.Show("Hãy nhập khoảng thời gian kết thúc muốn tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaykt.Focus();
                return;
            }
            if ((mskngaybd.Text == " / /") && (mskngaykt.Text != "/ /"))
            {
                MessageBox.Show("Hãy nhập khoảng thời gian bắt đầu muốn tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaybd.Focus();
                return;
            }
            if(mskngaybd.Text!= " / /"&& !Functions.IsDate(mskngaybd.Text))
            {
                MessageBox.Show("Thời gian bắt đầu không đúng, hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaybd.Focus();
                return;
            }
            if (mskngaykt.Text != " / /" && !Functions.IsDate(mskngaykt.Text))
            {
                MessageBox.Show("Thời gian kết thúc không đúng, hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaykt.Focus();
                return;
            }
            if((txtsoHDB.Text == "")&&(txtmanhanvien.Text == "")&& (txtmakhachhang.Text == "") && (txtkhoangbd.Text=="")&& ( txtkhoangkt.Text=="") && (mskngaybd.Text==" / /") && (mskngaykt.Text == " / /"))
            {
                MessageBox.Show("Hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngaybd = DateTime.MinValue, ngaykt = DateTime.MinValue;
            if (mskngaybd.Text != " / /")
                ngaybd = Convert.ToDateTime(mskngaybd.Text);
            if (mskngaykt.Text != " / /")
                ngaykt = Convert.ToDateTime(mskngaykt.Text);

            // Tạo câu lệnh cơ bản
            sql = "SELECT * FROM HoaDonBan WHERE 1=1";

            // Thêm điều kiện theo SoHDB
            if (!string.IsNullOrEmpty(txtsoHDB.Text.Trim()))
                sql += " AND SoHDB LIKE N'%" + txtsoHDB.Text.Trim() + "%'";

            // Thêm điều kiện theo MaNV
            if (!string.IsNullOrEmpty(txtmanhanvien.Text.Trim()))
                sql += " AND MaNV = N'" + txtmanhanvien.Text.Trim() + "'";

            // Thêm điều kiện theo MaKhach
            if (!string.IsNullOrEmpty(txtmakhachhang.Text.Trim()))
                sql += " AND MaKhach = N'" + txtmakhachhang.Text.Trim() + "'";

            // Thêm điều kiện khoảng tiền
            if (!string.IsNullOrEmpty(txtkhoangbd.Text.Trim()) &&
                !string.IsNullOrEmpty(txtkhoangkt.Text.Trim()))
            {
                int bd = int.Parse(txtkhoangbd.Text.Trim());
                int kt = int.Parse(txtkhoangkt.Text.Trim());
                sql += $" AND TongTien BETWEEN {bd} AND {kt}";
            }

            // Thêm điều kiện khoảng ngày
            if (mskngaybd.Text != " / /" && mskngaykt.Text != " / /")
            {
                sql += " AND Ngayban BETWEEN '"
                     + ngaybd.ToString("yyyy-MM-dd")
                     + "' AND '"
                     + ngaykt.ToString("yyyy-MM-dd") + "'";
            }

            // Lấy data và binding
            tblDSHDB = Functions.GetDataToTable(sql);
            dataGridViewHDB.DataSource = tblDSHDB;

            // Thông báo kết quả
            if (tblDSHDB.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show($"Đã có {tblDSHDB.Rows.Count} bản ghi thoả mãn điều kiện", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
        }
        private void ResetValues()
        {
            Load_dgridDSHDB();
            txtsoHDB.Text = "";
            txtmanhanvien.Text = "";
            txtmakhachhang.Text = "";
            txtkhoangbd.Text = "";
            txtkhoangkt.Text = "";
            mskngaybd.Text = " / /";
            mskngaykt.Text = " / /";

        }

        private void btnxuatDS_Click(object sender, EventArgs e)
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
            Excel.Range mergeRange = worksheet.Range[worksheet.Cells[5, 1], worksheet.Cells[5, 8]];
            mergeRange.Merge();
            mergeRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            mergeRange.Value = "DANH SÁCH HOÁ ĐƠN BÁN";
            mergeRange.Font.Size = 18;
            mergeRange.Font.Color = Color.Red;
            worksheet.Cells[7, 1] = "Thời gian xuất danh sách: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            worksheet.Cells[11, 2] = "STT";
            worksheet.Cells[11, 2].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            worksheet.Cells[11, 2].Interior.Color = Color.LightYellow;
            worksheet.Cells[11, 2].Font.Size = 12;
            worksheet.Cells[11, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            for (int i = 1; i <= dataGridViewHDB.Columns.Count; i++)
            {
                worksheet.Cells[11, i + 2].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[11, i + 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
                worksheet.Cells[11, i + 2].Value = dataGridViewHDB.Columns[i - 1].HeaderText;
                worksheet.Cells[11, i + 2].Interior.Color = Color.LightYellow;
                worksheet.Cells[11, i + 2].Font.Size = 12;
                worksheet.Cells[11, i + 2].EntireColumn.AutoFit();
                worksheet.Cells[11, i + 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            }
            for ( int i = 0; i< dataGridViewHDB.Rows.Count; i++)
            {
                worksheet.Cells[i + 12, 2].Value = i + 1;
                worksheet.Cells[i + 12, 2].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                worksheet.Cells[i + 12, 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
                worksheet.Cells[i + 12, 2].Font.Size = 12;
                worksheet.Cells[i + 12, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }
            for ( int j =0; j< dataGridViewHDB.Columns.Count; j++)
                for ( int i=0; i< dataGridViewHDB.Rows.Count; i++)
                {
                    worksheet.Cells[i + 12, j + 3].Value = dataGridViewHDB.Rows[i].Cells[j].Value?.ToString();
                    worksheet.Cells[i + 12, j + 3].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    worksheet.Cells[i + 12, j + 3].Borders.Weight= Excel.XlBorderWeight.xlThin;
                    worksheet.Cells[i + 12, j + 3].Font.Size = 12;
                    worksheet.Cells[i + 12, j + 3].EntireColumn.AutoFit();
                    worksheet.Cells[i + 12, j + 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                }

            excelApp.ScreenUpdating = true;
            excelApp.Visible = true;

        }
                   
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
            var main = Application.OpenForms.OfType<GD_Chinh>().FirstOrDefault();

        }
    }
    
    
}
