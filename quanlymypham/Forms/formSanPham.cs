using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace quanlymypham.Forms
{
    public partial class formSanPham : Form
    {
        public formSanPham()
        {
            InitializeComponent();
        }

       
        DataTable tblSP;
        private void formSanPham_Load(object sender, EventArgs e)
        {
            txtmasanpham.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_dgridSP();
            Functions.FillCombo("SELECT MaLoai, TenLoai FROM Loai", cbomaloai, "MaLoai", "TenLoai");
            Functions.FillCombo("SELECT MaKhoiLuong, TenKhoiLuong FROM KhoiLuong", cbomakhoiluong, "MaKhoiLuong", "TenKhoiLuong");
            Functions.FillCombo("SELECT MaHangSX, TenHangSX FROM HangSanXuat", cbomahangSX, "MaHangSX", "TenHangSX");
            Functions.FillCombo("SELECT MaChatLieu, TenChatLieu FROM ChatLieu", cbomachatlieu, "MaChatLieu", "TenChatLieu");
            Functions.FillCombo("SELECT MaCongDung, TenCongDung FROM CongDung", cbomacongdung, "MaCongDung", "TenCongDung");
            Functions.FillCombo("SELECT MaMua, TenMua FROM Mua", cbomamua, "MaMua", "TenMua");
            Functions.FillCombo("SELECT MaMau, TenMau FROM MauSac", cbomamausac, "MaMau", "TenMau");
            Functions.FillCombo("SELECT MaNuocSX, TenNuocSX FROM NuocSanXuat", cbomanuocSX, "MaNuocSX", "TenNuocSX");
            cbomaloai.SelectedIndex = -1;
            cbomakhoiluong.SelectedIndex = -1;
            cbomahangSX.SelectedIndex = -1;
            cbomachatlieu.SelectedIndex = -1;
            cbomacongdung.SelectedIndex = -1;
            cbomamua.SelectedIndex = -1;
            cbomamausac.SelectedIndex = -1;
            cbomanuocSX.SelectedIndex = -1;
            ResetValues();

        }
        private void ResetValues()
        {
            txtmasanpham.Text = "";
            txttensanpham.Text = "";
            cbomaloai.Text = "";
            cbomakhoiluong.Text = "";
            cbomahangSX.Text = "";
            cbomachatlieu.Text = "";
            cbomacongdung.Text = "";
            cbomamua.Text = "";
            cbomamausac.Text = "";
            cbomanuocSX.Text = "";
            txtsoluong.Text = "0";
            txtdongianhap.Text = "0";
            txtdongiaban.Text = "0";
            txtthoigianbaohanh.Text = "0";
            txtsoluong.Enabled = false;
            txtdongianhap.Enabled = false;
            txtdongiaban.Enabled = false;
            txtanh.Text = "";
            PicSanPham.Image = null;
            txtghichu.Text = "";
        }
        private void Load_dgridSP()
        {
            datagridViewSP.AutoGenerateColumns = true;

            string sql;
            sql = @"SELECT HangHoa.MaHang, HangHoa.TenHangHoa, Loai.TenLoai, KhoiLuong.TenKhoiLuong, HangSanXuat.TenHangSX, ChatLieu.TenChatLieu, CongDung.TenCongDung,
            Mua.TenMua, MauSac.TenMau, NuocSanXuat.TenNuocSX, HangHoa.SoLuong, HangHoa.DonGiaNhap, HangHoa.DonGiaBan, HangHoa.ThoiGianBaoHanh, HangHoa.Anh, HangHoa.GhiChu
            FROM HangHoa 
            JOIN Loai ON HangHoa.MaLoai=Loai.MaLoai
            JOIN KhoiLuong ON HangHoa.MaKhoiLuong=KhoiLuong.MaKhoiLuong
            JOIN HangSanXuat ON HangHoa.MaHangSX=HangSanXuat.MaHangSX
            JOIN ChatLieu ON HangHoa.MaChatLieu=ChatLieu.MaChatLieu
            JOIN CongDung ON HangHoa.MaCongDung = CongDung.MaCongDung
            JOIN Mua ON HangHoa.MaMua = Mua.MaMua
            JOIN MauSac ON HangHoa.MaMau = MauSac.MaMau
            JOIN NuocSanXuat ON HangHoa.MaNuocSX = NuocSanXuat.MaNuocSX";
            tblSP = Functions.GetDataToTable(sql);
            datagridViewSP.DataSource = tblSP;
            datagridViewSP.Columns[0].HeaderText = "Mã sản phẩm";
            datagridViewSP.Columns[1].HeaderText = "Tên sản phẩm";
            datagridViewSP.Columns[2].HeaderText = "Loại";
            datagridViewSP.Columns[3].HeaderText = "Khối lượng";
            datagridViewSP.Columns[4].HeaderText = "Hãng sản xuất";
            datagridViewSP.Columns[5].HeaderText = "Chất liệu ";
            datagridViewSP.Columns[6].HeaderText = "Công Dụng ";
            datagridViewSP.Columns[7].HeaderText = "Mùa ";
            datagridViewSP.Columns[8].HeaderText = "Màu sắc";
            datagridViewSP.Columns[9].HeaderText = "Nước sản xuất";
            datagridViewSP.Columns[10].HeaderText = "Số lượng ";
            datagridViewSP.Columns[11].HeaderText = "Đơn giá nhập ";
            datagridViewSP.Columns[12].HeaderText = "Đơn giá bán";
            datagridViewSP.Columns[13].HeaderText = "Thời gian bảo hành";

            datagridViewSP.Columns[0].Width = 80;
            datagridViewSP.Columns[1].Width = 100;
            datagridViewSP.Columns[2].Width = 80;
            datagridViewSP.Columns[3].Width = 80;
            datagridViewSP.Columns[4].Width = 100;
            datagridViewSP.Columns[5].Width = 80;
            datagridViewSP.Columns[6].Width = 80;
            datagridViewSP.Columns[7].Width = 100;
            datagridViewSP.Columns[8].Width = 80;
            datagridViewSP.Columns[9].Width = 100;
            datagridViewSP.Columns[10].Width = 80;
            datagridViewSP.Columns[11].Width = 100;
            datagridViewSP.Columns[12].Width = 100;
            datagridViewSP.Columns[13].Width = 100;
            datagridViewSP.AllowUserToAddRows = false;
            datagridViewSP.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void datagridViewSP_Click(object sender, EventArgs e)
        {
            string ten;
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasanpham.Focus();
                return;
            }
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmasanpham.Text = datagridViewSP.CurrentRow.Cells["MaHang"].Value.ToString();
            txttensanpham.Text = datagridViewSP.CurrentRow.Cells["TenHangHoa"].Value.ToString();
            ten = datagridViewSP.CurrentRow.Cells["TenLoai"].Value.ToString();
            cbomaloai.Text = Functions.GetFieldValues("SELECT TenLoai FROM Loai WHERE TenLoai= N'" + ten + "'");

            ten = datagridViewSP.CurrentRow.Cells["TenKhoiLuong"].Value.ToString();
            cbomakhoiluong.Text = Functions.GetFieldValues("SELECT TenKhoiLuong FROM KhoiLuong WHERE TenKhoiLuong= N'" + ten + "'");

            ten = datagridViewSP.CurrentRow.Cells["TenHangSX"].Value.ToString();
            cbomahangSX.Text = Functions.GetFieldValues("SELECT TenHangSX FROM HangSanXuat WHERE TenHangSX= N'" + ten + "'");

            ten = datagridViewSP.CurrentRow.Cells["TenChatLieu"].Value.ToString();
            cbomachatlieu.Text = Functions.GetFieldValues("SELECT TenChatLieu FROM ChatLieu WHERE TenChatLieu= N'" + ten + "'");

            ten = datagridViewSP.CurrentRow.Cells["TenCongDung"].Value.ToString();
            cbomacongdung.Text = Functions.GetFieldValues("SELECT TenCongDung FROM CongDung WHERE TenCongDung= N'" + ten + "'");

            ten = datagridViewSP.CurrentRow.Cells["TenMua"].Value.ToString();
            cbomamua.Text = Functions.GetFieldValues("SELECT TenMua FROM Mua WHERE TenMua= N'" + ten + "'");

            ten = datagridViewSP.CurrentRow.Cells["TenMau"].Value.ToString();
            cbomamausac.Text = Functions.GetFieldValues("SELECT TenMau FROM MauSac WHERE TenMau= N'" + ten + "'");

            ten = datagridViewSP.CurrentRow.Cells["TenNuocSX"].Value.ToString();
            cbomanuocSX.Text = Functions.GetFieldValues("SELECT TenNuocSX FROM NuocSanXuat WHERE TenNuocSX= N'" + ten + "'");

            txtsoluong.Text = datagridViewSP.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtdongianhap.Text = datagridViewSP.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtdongiaban.Text = datagridViewSP.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            txtthoigianbaohanh.Text = datagridViewSP.CurrentRow.Cells["ThoiGianBaoHanh"].Value.ToString();
            txtghichu.Text = Functions.GetFieldValues("SELECT Ghichu FROM HangHoa WHERE MaHang = N'" + txtmasanpham.Text + "'");
            txtanh.Text = Functions.GetFieldValues("SELECT Anh FROM HangHoa WHERE MaHang = N'" + txtmasanpham.Text + "'");
            string path = txtanh.Text;
            if (File.Exists(path))
            {
                PicSanPham.Image = Image.FromFile(path);
                PicSanPham.SizeMode = PictureBoxSizeMode.Zoom;  
            }
            else
            {
                PicSanPham.Image = null;
            }

            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmasanpham.Enabled = true;
            txtmasanpham.Focus();
            txtsoluong.Enabled = true;   
            txtdongianhap.Enabled = true;   
            txtdongiaban.Enabled = true;

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmasanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtmasanpham.Focus();
                return;
            }
            if (txttensanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txttensanpham.Focus();
                return;
            }
            if (cbomaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Loại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaloai.Focus();
                return;
            }
            if (cbomakhoiluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Khối Lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomakhoiluong.Focus();
                return;
            }
            if (cbomahangSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Hãng Sản Xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahangSX.Focus();
                return;
            }
            if (cbomachatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Chất Liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomachatlieu.Focus();
                return;
            }
            if (cbomacongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Công Dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomacongdung.Focus();
                return;
            }
            if (cbomamua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomamua.Focus();
                return;
            }
            if (cbomamausac.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Màu Sắc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomamausac.Focus();
                return;
            }
            if (cbomanuocSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Nước Sản Xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomamua.Focus();
                return;
            }

            if (txtanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho sản phẩm", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtanh.Focus();
                return;
            }
            sql = "SELECT MaHang FROM HangHoa WHERE MaHang=N'" + txtmasanpham.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmasanpham.Focus();
                txtmasanpham.Text = "";
                return;
            }
            sql = "INSERT INTO HangHoa(MaHang,TenHangHoa, MaLoai, MaKhoiLuong, MaHangSX, MaChatLieu, MaCongDung, MaMua, MaMau, MaNuocSX, SoLuong, DonGiaNhap, DonGiaBan,ThoiGianBaoHanh, Anh, GhiChu) VALUES("
      + "N'" + txtmasanpham.Text.Trim() + "', "
      + "N'" + txttensanpham.Text.Trim() + "', "
      + "N'" + cbomaloai.SelectedValue + "', "
      + "N'" + cbomakhoiluong.SelectedValue + "', "
      + "N'" + cbomahangSX.SelectedValue + "', "
      + "N'" + cbomachatlieu.SelectedValue + "', "
      + "N'" + cbomacongdung.SelectedValue + "', "
      + "N'" + cbomamua.SelectedValue + "', "
      + "N'" + cbomamausac.SelectedValue + "', "
      + "N'" + cbomanuocSX.SelectedValue + "', "
      + txtsoluong.Text.Trim() + ", "
      + txtdongianhap.Text.Trim() + ", "
      + txtdongiaban.Text.Trim() + ", "
      + txtthoigianbaohanh.Text.Trim() + ", "
      + "N'" + txtanh.Text.Trim().Replace("'", "''") + "', "
      + "N'" + txtghichu.Text.Trim().Replace("'", "''") + "'"
      + ")";

            Functions.RunSql(sql);
            Load_dgridSP();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmasanpham.Enabled = false;


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtmasanpham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttensanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txttensanpham.Focus();
                return;
            }

            if (cbomaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập loại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaloai.Focus();
                return;
            }

            if (cbomakhoiluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khối lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomakhoiluong.Focus();
                return;
            }
            if (cbomahangSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập hãng sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahangSX.Focus();
                return;
            }
            if (cbomachatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomachatlieu.Focus();
                return;
            }
            if (cbomacongdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập công dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomacongdung.Focus();
                return;
            }
            if (cbomamua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomamua.Focus();
                return;
            }
            if (cbomamausac.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập màu sắc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomamausac.Focus();
                return;
            }
            if (cbomanuocSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nước sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomanuocSX.Focus();
                return;
            }
            if(txtanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho sản phẩm", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtanh.Focus();
                return;
            }
            sql = "UPDATE HangHoa SET  TenHangHoa=N'" + txttensanpham.Text.Trim().ToString() +
    "',MaLoai=N'" + cbomaloai.SelectedValue.ToString() +
    "',MaKhoiLuong= N'" + cbomakhoiluong.SelectedValue.ToString() +
    "',MaHangSX= N'" + cbomahangSX.SelectedValue.ToString() +
    "',MaChatLieu= N'" + cbomachatlieu.SelectedValue.ToString() +
    "',MaCongDung= N'" + cbomacongdung.SelectedValue.ToString() +
    "',MaMua= N'" + cbomamua.SelectedValue.ToString() +
    "',MaMau= N'" + cbomamausac.SelectedValue.ToString() +
    "',MaNuocSX= N'" + cbomanuocSX.SelectedValue.ToString() +
    "',Ghichu=N'" + txtghichu.Text +
    "',Anh='" + txtanh.Text + "' WHERE MaHang=N'" + txtmasanpham.Text + "'";
            Functions.RunSql(sql);
            Load_dgridSP();
            ResetValues();
            btnboqua.Enabled = false;


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtmasanpham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE HangHoa WHERE MaHang=N'" + txtmasanpham.Text + "'";
                Functions.RunSqlDel(sql);
                Load_dgridSP();
                ResetValues();
            }

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmasanpham.Enabled = false;

        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Image Files|*.bmp;*.gif;*.jpg;*.jpeg;*.png|All Files|*.*";
            dlgOpen.InitialDirectory = "D:\\";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chon hinh anh de hien thi";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                PicSanPham.Image = Image.FromFile(dlgOpen.FileName);
                txtanh.Text = dlgOpen.FileName;
            }

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtmasanpham.Text == "") && (txttensanpham.Text == "") 
                && (cbomaloai.Text =="")
                && (cbomakhoiluong.Text == "")
                && (cbomahangSX.Text == "")
                && (cbomachatlieu.Text == "")
                && (cbomacongdung.Text == "")
                && (cbomamua.Text == "")
                && (cbomamausac.Text == "")
                && (cbomanuocSX.Text == "")
                )
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM HangHoa WHERE 1=1";
            if (txtmasanpham.Text != "")
                sql = sql + " AND MaHang Like N'%" + txtmasanpham.Text + "%'";
            if (txttensanpham.Text != "")
                sql = sql + " AND TenHangHoa Like N'%" + txttensanpham.Text + "%'";
            if (cbomaloai.Text != "")
                sql = sql + " AND MaLoai Like N'%" + cbomaloai.SelectedValue + "%'";
            if (cbomakhoiluong.Text != "")
                sql = sql + " AND MaKhoiLuong Like N'%" + cbomakhoiluong.SelectedValue + "%'";
            if (cbomahangSX.Text != "")
                sql = sql + " AND MaHangSX Like N'%" + cbomahangSX.SelectedValue + "%'";
            if (cbomachatlieu.Text != "")
                sql = sql + " AND MaChatLieu Like N'%" + cbomachatlieu.SelectedValue + "%'";
            if (cbomacongdung.Text != "")
                sql = sql + " AND MaCongDung Like N'%" + cbomacongdung.SelectedValue + "%'";
            if (cbomamua.Text != "")
                sql = sql + " AND MaMua Like N'%" + cbomamua.SelectedValue + "%'";
            if (cbomamausac.Text != "")
                sql = sql + " AND MaMau Like N'%" + cbomamausac.SelectedValue + "%'";
            if (cbomanuocSX.Text != "")
                sql = sql + " AND MaNuocSX Like N'%" + cbomanuocSX.SelectedValue + "%'";
            tblSP = Functions.GetDataToTable(sql);
            if (tblSP.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblSP.Rows.Count + " bản ghi thỏa mãn điều kiện!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            datagridViewSP.DataSource = tblSP;
            ResetValues();

        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaHang, TenHangHoa, MaLoai, MaKhoiLuong, MaHangSX, MaChatLieu, MaCongDung, MaMua, MaMau, MaNuocSX, SoLuong, DonGiaNhap, DonGiaBan,ThoiGianBaoHanh, Anh,GhiChu FROM HangHoa";
            tblSP = Functions.GetDataToTable(sql);
            datagridViewSP.DataSource = tblSP;


        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
            var main = Application.OpenForms.OfType<GD_Chinh>().FirstOrDefault();
            
        }
    }
 }

