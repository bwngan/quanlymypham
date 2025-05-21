namespace quanlymypham.Forms
{
    partial class formThemHDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpNgayban = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.CbomaKH = new System.Windows.Forms.ComboBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txttenKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.lblBangchu = new System.Windows.Forms.Label();
            this.txtsoHDB = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnXoasp = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.nudGiamgia = new System.Windows.Forms.NumericUpDown();
            this.nudSoluong = new System.Windows.Forms.NumericUpDown();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.txtDGB = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTaomoi = new System.Windows.Forms.Button();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoluongSP = new System.Windows.Forms.Label();
            this.lblTongSP = new System.Windows.Forms.Label();
            this.dataGridViewDSSP = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayban
            // 
            this.dtpNgayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayban.Location = new System.Drawing.Point(174, 101);
            this.dtpNgayban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayban.Name = "dtpNgayban";
            this.dtpNgayban.Size = new System.Drawing.Size(182, 26);
            this.dtpNgayban.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mskdienthoai);
            this.groupBox3.Controls.Add(this.CbomaKH);
            this.groupBox3.Controls.Add(this.txtDiachi);
            this.groupBox3.Controls.Add(this.txttenKH);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(776, 26);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(411, 191);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Khách hàng";
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Location = new System.Drawing.Point(199, 108);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(157, 26);
            this.mskdienthoai.TabIndex = 22;
            // 
            // CbomaKH
            // 
            this.CbomaKH.FormattingEnabled = true;
            this.CbomaKH.Location = new System.Drawing.Point(199, 26);
            this.CbomaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbomaKH.Name = "CbomaKH";
            this.CbomaKH.Size = new System.Drawing.Size(157, 28);
            this.CbomaKH.TabIndex = 21;
            this.CbomaKH.TextChanged += new System.EventHandler(this.CbomaKH_TextChanged);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(199, 151);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(157, 26);
            this.txtDiachi.TabIndex = 10;
            // 
            // txttenKH
            // 
            this.txttenKH.Location = new System.Drawing.Point(199, 71);
            this.txttenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttenKH.Name = "txttenKH";
            this.txttenKH.Size = new System.Drawing.Size(157, 26);
            this.txttenKH.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số Điện Thoại ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã khách hàng";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1288, 730);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(117, 29);
            this.btnDong.TabIndex = 59;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(1131, 664);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(117, 29);
            this.btnInHD.TabIndex = 58;
            this.btnInHD.Text = "In Hóa Đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Location = new System.Drawing.Point(971, 730);
            this.btnXoaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(117, 29);
            this.btnXoaHD.TabIndex = 57;
            this.btnXoaHD.Text = "Xóa Hóa Đơn";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // lblBangchu
            // 
            this.lblBangchu.AutoSize = true;
            this.lblBangchu.Location = new System.Drawing.Point(967, 604);
            this.lblBangchu.Name = "lblBangchu";
            this.lblBangchu.Size = new System.Drawing.Size(164, 20);
            this.lblBangchu.TabIndex = 56;
            this.lblBangchu.Text = "Tổng Tiền (Bằng Chữ)";
            // 
            // txtsoHDB
            // 
            this.txtsoHDB.Location = new System.Drawing.Point(174, 52);
            this.txtsoHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsoHDB.Name = "txtsoHDB";
            this.txtsoHDB.Size = new System.Drawing.Size(182, 26);
            this.txtsoHDB.TabIndex = 4;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(140, 26);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(157, 28);
            this.cboMaNV.TabIndex = 20;
            this.cboMaNV.TextChanged += new System.EventHandler(this.cboMaNV_TextChanged);
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(140, 75);
            this.txtTennv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(157, 26);
            this.txtTennv.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Nhân Viên ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày bán";
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Location = new System.Drawing.Point(971, 664);
            this.btnLuuHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(117, 29);
            this.btnLuuHD.TabIndex = 66;
            this.btnLuuHD.Text = "Lưu Hóa Đơn";
            this.btnLuuHD.UseVisualStyleBackColor = true;
            this.btnLuuHD.Click += new System.EventHandler(this.btnLuuHD_Click);
            // 
            // btnXoasp
            // 
            this.btnXoasp.Location = new System.Drawing.Point(1247, 378);
            this.btnXoasp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoasp.Name = "btnXoasp";
            this.btnXoasp.Size = new System.Drawing.Size(84, 29);
            this.btnXoasp.TabIndex = 65;
            this.btnXoasp.Text = "Xóa";
            this.btnXoasp.UseVisualStyleBackColor = true;
            this.btnXoasp.Click += new System.EventHandler(this.btnXoasp_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1247, 324);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 29);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboMaSP);
            this.groupBox4.Controls.Add(this.nudGiamgia);
            this.groupBox4.Controls.Add(this.nudSoluong);
            this.groupBox4.Controls.Add(this.txtThanhtien);
            this.groupBox4.Controls.Add(this.txtDGB);
            this.groupBox4.Controls.Add(this.txtTenSP);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(25, 289);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(1202, 134);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Hàng Hóa";
            // 
            // cboMaSP
            // 
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(170, 40);
            this.cboMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(182, 28);
            this.cboMaSP.TabIndex = 19;
            this.cboMaSP.TextChanged += new System.EventHandler(this.cboMaSP_TextChanged);
            // 
            // nudGiamgia
            // 
            this.nudGiamgia.Location = new System.Drawing.Point(946, 41);
            this.nudGiamgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudGiamgia.Name = "nudGiamgia";
            this.nudGiamgia.Size = new System.Drawing.Size(182, 26);
            this.nudGiamgia.TabIndex = 18;
            // 
            // nudSoluong
            // 
            this.nudSoluong.Location = new System.Drawing.Point(540, 41);
            this.nudSoluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudSoluong.Name = "nudSoluong";
            this.nudSoluong.Size = new System.Drawing.Size(182, 26);
            this.nudSoluong.TabIndex = 17;
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(946, 81);
            this.txtThanhtien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(182, 26);
            this.txtThanhtien.TabIndex = 16;
            this.txtThanhtien.TextChanged += new System.EventHandler(this.txtThanhtien_TextChanged);
            // 
            // txtDGB
            // 
            this.txtDGB.Location = new System.Drawing.Point(540, 81);
            this.txtDGB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDGB.Name = "txtDGB";
            this.txtDGB.Size = new System.Drawing.Size(182, 26);
            this.txtDGB.TabIndex = 14;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(170, 89);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(182, 26);
            this.txtTenSP.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(796, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "Thành Tiền";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(796, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "Giảm Giá";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(421, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Đơn giá bán";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(418, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Số Lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Tên sản phẩm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Mã sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboMaNV);
            this.groupBox2.Controls.Add(this.txtTennv);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(405, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(323, 114);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhân Viên ";
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.Location = new System.Drawing.Point(1131, 730);
            this.btnTaomoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(117, 29);
            this.btnTaomoi.TabIndex = 67;
            this.btnTaomoi.Text = "Tạo mới";
            this.btnTaomoi.UseVisualStyleBackColor = true;
            this.btnTaomoi.Click += new System.EventHandler(this.btnTaomoi_Click);
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(967, 555);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(79, 20);
            this.lblTongtien.TabIndex = 55;
            this.lblTongtien.Text = "Tổng Tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "HOÁ ĐƠN BÁN HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayban);
            this.groupBox1.Controls.Add(this.txtsoHDB);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1206, 230);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số hoá đơn bán";
            // 
            // lblSoluongSP
            // 
            this.lblSoluongSP.AutoSize = true;
            this.lblSoluongSP.Location = new System.Drawing.Point(967, 512);
            this.lblSoluongSP.Name = "lblSoluongSP";
            this.lblSoluongSP.Size = new System.Drawing.Size(196, 20);
            this.lblSoluongSP.TabIndex = 54;
            this.lblSoluongSP.Text = "Tổng Số Lượng Sản Phẩm";
            // 
            // lblTongSP
            // 
            this.lblTongSP.AutoSize = true;
            this.lblTongSP.Location = new System.Drawing.Point(967, 464);
            this.lblTongSP.Name = "lblTongSP";
            this.lblTongSP.Size = new System.Drawing.Size(147, 20);
            this.lblTongSP.TabIndex = 53;
            this.lblTongSP.Text = "Tổng Số Sản Phẩm";
            // 
            // dataGridViewDSSP
            // 
            this.dataGridViewDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSSP.Location = new System.Drawing.Point(20, 464);
            this.dataGridViewDSSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewDSSP.Name = "dataGridViewDSSP";
            this.dataGridViewDSSP.RowHeadersWidth = 51;
            this.dataGridViewDSSP.RowTemplate.Height = 24;
            this.dataGridViewDSSP.Size = new System.Drawing.Size(894, 331);
            this.dataGridViewDSSP.TabIndex = 52;
            this.dataGridViewDSSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSSP_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "Danh Sách Sản Phẩm";
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.Location = new System.Drawing.Point(1288, 664);
            this.btnSuaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(117, 29);
            this.btnSuaHD.TabIndex = 68;
            this.btnSuaHD.Text = "Sửa Hoá Đơn";
            this.btnSuaHD.UseVisualStyleBackColor = true;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // formThemHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 801);
            this.Controls.Add(this.btnSuaHD);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.lblBangchu);
            this.Controls.Add(this.btnLuuHD);
            this.Controls.Add(this.btnXoasp);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnTaomoi);
            this.Controls.Add(this.lblTongtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSoluongSP);
            this.Controls.Add(this.lblTongSP);
            this.Controls.Add(this.dataGridViewDSSP);
            this.Controls.Add(this.label10);
            this.Name = "formThemHDB";
            this.Text = "formThemHDB";
            this.Load += new System.EventHandler(this.formThemHDB_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayban;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.ComboBox CbomaKH;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txttenKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Label lblBangchu;
        private System.Windows.Forms.TextBox txtsoHDB;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnXoasp;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.NumericUpDown nudGiamgia;
        private System.Windows.Forms.NumericUpDown nudSoluong;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.TextBox txtDGB;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTaomoi;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoluongSP;
        private System.Windows.Forms.Label lblTongSP;
        private System.Windows.Forms.DataGridView dataGridViewDSSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSuaHD;
    }
}