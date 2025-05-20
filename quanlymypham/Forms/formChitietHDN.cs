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
            lblTongtien.Text = sumThanhtien.ToString();
            lblSoluongSP.Text = sumSoluongSP.ToString();
            lblTongSP.Text = sumSP.ToString();
            lblBangchu.Text = Functions.ChuyenSoSangChu(sumThanhtien.ToString());

        }
    }
}
