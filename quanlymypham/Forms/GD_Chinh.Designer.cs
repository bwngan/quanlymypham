namespace quanlymypham.Forms
{
    partial class GD_Chinh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GD_Chinh));
            this.QuanlychungTransition = new System.Windows.Forms.Timer(this.components);
            this.HoadonnhapTransition = new System.Windows.Forms.Timer(this.components);
            this.HoadonbanTransition = new System.Windows.Forms.Timer(this.components);
            this.SidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.BaocaoTransition = new System.Windows.Forms.Timer(this.components);
            this.btnMucluc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuanlychungContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQuanlychung = new System.Windows.Forms.Button();
            this.btnsanpham = new System.Windows.Forms.Button();
            this.btnkhachhang = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.HoadonnhapContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHoadonhap = new System.Windows.Forms.Button();
            this.btnDshoadon = new System.Windows.Forms.Button();
            this.btnTaohoadon = new System.Windows.Forms.Button();
            this.HoadonbanContainer = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHoadonban = new System.Windows.Forms.Button();
            this.BaocaoContainer = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.pnDangxuat = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btnMucluc)).BeginInit();
            this.panel1.SuspendLayout();
            this.QuanlychungContainer.SuspendLayout();
            this.HoadonnhapContainer.SuspendLayout();
            this.HoadonbanContainer.SuspendLayout();
            this.BaocaoContainer.SuspendLayout();
            this.pnDangxuat.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuanlychungTransition
            // 
            this.QuanlychungTransition.Interval = 10;
            this.QuanlychungTransition.Tick += new System.EventHandler(this.QuanlychungTransition_Tick);
            // 
            // HoadonnhapTransition
            // 
            this.HoadonnhapTransition.Interval = 10;
            this.HoadonnhapTransition.Tick += new System.EventHandler(this.HoadonnhapTransition_Tick);
            // 
            // HoadonbanTransition
            // 
            this.HoadonbanTransition.Interval = 10;
            this.HoadonbanTransition.Tick += new System.EventHandler(this.HoadonbanTransition_Tick);
            // 
            // SidebarTransition
            // 
            this.SidebarTransition.Interval = 10;
            this.SidebarTransition.Tick += new System.EventHandler(this.SidebarTransition_Tick);
            // 
            // BaocaoTransition
            // 
            this.BaocaoTransition.Interval = 10;
            this.BaocaoTransition.Tick += new System.EventHandler(this.BaocaoTransition_Tick);
            // 
            // btnMucluc
            // 
            this.btnMucluc.Image = ((System.Drawing.Image)(resources.GetObject("btnMucluc.Image")));
            this.btnMucluc.Location = new System.Drawing.Point(14, 0);
            this.btnMucluc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMucluc.Name = "btnMucluc";
            this.btnMucluc.Size = new System.Drawing.Size(46, 42);
            this.btnMucluc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMucluc.TabIndex = 1;
            this.btnMucluc.TabStop = false;
            this.btnMucluc.Click += new System.EventHandler(this.btnMucluc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMucluc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 46);
            this.panel1.TabIndex = 0;
            // 
            // QuanlychungContainer
            // 
            this.QuanlychungContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.QuanlychungContainer.Controls.Add(this.btnQuanlychung);
            this.QuanlychungContainer.Controls.Add(this.btnsanpham);
            this.QuanlychungContainer.Controls.Add(this.btnkhachhang);
            this.QuanlychungContainer.Controls.Add(this.btnNhanvien);
            this.QuanlychungContainer.Controls.Add(this.btnNCC);
            this.QuanlychungContainer.Location = new System.Drawing.Point(3, 4);
            this.QuanlychungContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuanlychungContainer.Name = "QuanlychungContainer";
            this.QuanlychungContainer.Size = new System.Drawing.Size(258, 275);
            this.QuanlychungContainer.TabIndex = 5;
            // 
            // btnQuanlychung
            // 
            this.btnQuanlychung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnQuanlychung.FlatAppearance.BorderSize = 0;
            this.btnQuanlychung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanlychung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanlychung.ForeColor = System.Drawing.Color.White;
            this.btnQuanlychung.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanlychung.Image")));
            this.btnQuanlychung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanlychung.Location = new System.Drawing.Point(3, 4);
            this.btnQuanlychung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuanlychung.Name = "btnQuanlychung";
            this.btnQuanlychung.Size = new System.Drawing.Size(236, 59);
            this.btnQuanlychung.TabIndex = 2;
            this.btnQuanlychung.Text = "  Quản lý chung";
            this.btnQuanlychung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanlychung.UseVisualStyleBackColor = false;
            this.btnQuanlychung.Click += new System.EventHandler(this.btnQuanlychung_Click);
            // 
            // btnsanpham
            // 
            this.btnsanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsanpham.FlatAppearance.BorderSize = 0;
            this.btnsanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsanpham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsanpham.ForeColor = System.Drawing.Color.White;
            this.btnsanpham.Image = ((System.Drawing.Image)(resources.GetObject("btnsanpham.Image")));
            this.btnsanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsanpham.Location = new System.Drawing.Point(3, 71);
            this.btnsanpham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsanpham.Name = "btnsanpham";
            this.btnsanpham.Size = new System.Drawing.Size(209, 46);
            this.btnsanpham.TabIndex = 2;
            this.btnsanpham.Text = " Sản phẩm";
            this.btnsanpham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsanpham.UseVisualStyleBackColor = false;
            this.btnsanpham.Click += new System.EventHandler(this.btnsanpham_Click);
            // 
            // btnkhachhang
            // 
            this.btnkhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnkhachhang.FlatAppearance.BorderSize = 0;
            this.btnkhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkhachhang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhachhang.ForeColor = System.Drawing.Color.White;
            this.btnkhachhang.Image = ((System.Drawing.Image)(resources.GetObject("btnkhachhang.Image")));
            this.btnkhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhachhang.Location = new System.Drawing.Point(3, 125);
            this.btnkhachhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.Size = new System.Drawing.Size(209, 46);
            this.btnkhachhang.TabIndex = 2;
            this.btnkhachhang.Text = " Khách hàng ";
            this.btnkhachhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnkhachhang.UseVisualStyleBackColor = false;
            this.btnkhachhang.Click += new System.EventHandler(this.btnkhachhang_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNhanvien.FlatAppearance.BorderSize = 0;
            this.btnNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanvien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.ForeColor = System.Drawing.Color.White;
            this.btnNhanvien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanvien.Image")));
            this.btnNhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.Location = new System.Drawing.Point(3, 179);
            this.btnNhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(209, 46);
            this.btnNhanvien.TabIndex = 2;
            this.btnNhanvien.Text = " Nhân viên ";
            this.btnNhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanvien.UseVisualStyleBackColor = false;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNCC.FlatAppearance.BorderSize = 0;
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.ForeColor = System.Drawing.Color.White;
            this.btnNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnNCC.Image")));
            this.btnNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.Location = new System.Drawing.Point(3, 233);
            this.btnNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(209, 46);
            this.btnNCC.TabIndex = 2;
            this.btnNCC.Text = " Nhà cung cấp";
            this.btnNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNCC.UseVisualStyleBackColor = false;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // HoadonnhapContainer
            // 
            this.HoadonnhapContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HoadonnhapContainer.Controls.Add(this.btnHoadonhap);
            this.HoadonnhapContainer.Controls.Add(this.btnDshoadon);
            this.HoadonnhapContainer.Controls.Add(this.btnTaohoadon);
            this.HoadonnhapContainer.Location = new System.Drawing.Point(3, 287);
            this.HoadonnhapContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HoadonnhapContainer.Name = "HoadonnhapContainer";
            this.HoadonnhapContainer.Size = new System.Drawing.Size(258, 59);
            this.HoadonnhapContainer.TabIndex = 6;
            // 
            // btnHoadonhap
            // 
            this.btnHoadonhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHoadonhap.FlatAppearance.BorderSize = 0;
            this.btnHoadonhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoadonhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadonhap.ForeColor = System.Drawing.Color.White;
            this.btnHoadonhap.Image = ((System.Drawing.Image)(resources.GetObject("btnHoadonhap.Image")));
            this.btnHoadonhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoadonhap.Location = new System.Drawing.Point(3, 4);
            this.btnHoadonhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHoadonhap.Name = "btnHoadonhap";
            this.btnHoadonhap.Size = new System.Drawing.Size(236, 46);
            this.btnHoadonhap.TabIndex = 2;
            this.btnHoadonhap.Text = "  Hóa đơn nhập";
            this.btnHoadonhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoadonhap.UseVisualStyleBackColor = false;
            this.btnHoadonhap.Click += new System.EventHandler(this.btnHoadonhap_Click);
            // 
            // btnDshoadon
            // 
            this.btnDshoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDshoadon.FlatAppearance.BorderSize = 0;
            this.btnDshoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDshoadon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDshoadon.ForeColor = System.Drawing.Color.White;
            this.btnDshoadon.Image = ((System.Drawing.Image)(resources.GetObject("btnDshoadon.Image")));
            this.btnDshoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDshoadon.Location = new System.Drawing.Point(3, 58);
            this.btnDshoadon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDshoadon.Name = "btnDshoadon";
            this.btnDshoadon.Size = new System.Drawing.Size(236, 46);
            this.btnDshoadon.TabIndex = 2;
            this.btnDshoadon.Text = " Danh sách hóa đơn";
            this.btnDshoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDshoadon.UseVisualStyleBackColor = false;
            // 
            // btnTaohoadon
            // 
            this.btnTaohoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTaohoadon.FlatAppearance.BorderSize = 0;
            this.btnTaohoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaohoadon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaohoadon.ForeColor = System.Drawing.Color.White;
            this.btnTaohoadon.Image = ((System.Drawing.Image)(resources.GetObject("btnTaohoadon.Image")));
            this.btnTaohoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaohoadon.Location = new System.Drawing.Point(3, 112);
            this.btnTaohoadon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaohoadon.Name = "btnTaohoadon";
            this.btnTaohoadon.Size = new System.Drawing.Size(209, 46);
            this.btnTaohoadon.TabIndex = 2;
            this.btnTaohoadon.Text = " Tạo hóa đơn ";
            this.btnTaohoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaohoadon.UseVisualStyleBackColor = false;
            // 
            // HoadonbanContainer
            // 
            this.HoadonbanContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HoadonbanContainer.Controls.Add(this.button2);
            this.HoadonbanContainer.Controls.Add(this.button1);
            this.HoadonbanContainer.Controls.Add(this.btnHoadonban);
            this.HoadonbanContainer.Location = new System.Drawing.Point(3, 354);
            this.HoadonbanContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HoadonbanContainer.Name = "HoadonbanContainer";
            this.HoadonbanContainer.Size = new System.Drawing.Size(258, 59);
            this.HoadonbanContainer.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 108);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = " Quản lý chung";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = " Danh sách hóa đơn ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnHoadonban
            // 
            this.btnHoadonban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHoadonban.FlatAppearance.BorderSize = 0;
            this.btnHoadonban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoadonban.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadonban.ForeColor = System.Drawing.Color.White;
            this.btnHoadonban.Image = ((System.Drawing.Image)(resources.GetObject("btnHoadonban.Image")));
            this.btnHoadonban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoadonban.Location = new System.Drawing.Point(3, 4);
            this.btnHoadonban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHoadonban.Name = "btnHoadonban";
            this.btnHoadonban.Size = new System.Drawing.Size(236, 46);
            this.btnHoadonban.TabIndex = 2;
            this.btnHoadonban.Text = "  Hóa đơn bán ";
            this.btnHoadonban.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoadonban.UseVisualStyleBackColor = false;
            this.btnHoadonban.Click += new System.EventHandler(this.btnHoadonban_Click);
            // 
            // BaocaoContainer
            // 
            this.BaocaoContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BaocaoContainer.Controls.Add(this.button5);
            this.BaocaoContainer.Controls.Add(this.button3);
            this.BaocaoContainer.Controls.Add(this.button4);
            this.BaocaoContainer.Controls.Add(this.btnBaocao);
            this.BaocaoContainer.Location = new System.Drawing.Point(3, 421);
            this.BaocaoContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BaocaoContainer.Name = "BaocaoContainer";
            this.BaocaoContainer.Size = new System.Drawing.Size(258, 59);
            this.BaocaoContainer.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 161);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 46);
            this.button5.TabIndex = 5;
            this.button5.Text = " Sản phẩm";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 108);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = " Nhân viên ";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 58);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(241, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = " Kinh doanh ";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnBaocao
            // 
            this.btnBaocao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBaocao.FlatAppearance.BorderSize = 0;
            this.btnBaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaocao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaocao.ForeColor = System.Drawing.Color.White;
            this.btnBaocao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaocao.Image")));
            this.btnBaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaocao.Location = new System.Drawing.Point(3, 4);
            this.btnBaocao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(209, 46);
            this.btnBaocao.TabIndex = 2;
            this.btnBaocao.Text = "  Báo cáo ";
            this.btnBaocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaocao.UseVisualStyleBackColor = false;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // pnDangxuat
            // 
            this.pnDangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnDangxuat.Controls.Add(this.button8);
            this.pnDangxuat.Controls.Add(this.button11);
            this.pnDangxuat.Controls.Add(this.button12);
            this.pnDangxuat.Controls.Add(this.btnDangxuat);
            this.pnDangxuat.Location = new System.Drawing.Point(3, 488);
            this.pnDangxuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnDangxuat.Name = "pnDangxuat";
            this.pnDangxuat.Size = new System.Drawing.Size(258, 59);
            this.pnDangxuat.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(3, 161);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(209, 46);
            this.button8.TabIndex = 5;
            this.button8.Text = " Sản phẩm";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(3, 108);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(209, 46);
            this.button11.TabIndex = 4;
            this.button11.Text = " Nhân viên ";
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(3, 58);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(241, 46);
            this.button12.TabIndex = 3;
            this.button12.Text = " Kinh doanh ";
            this.button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDangxuat.FlatAppearance.BorderSize = 0;
            this.btnDangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangxuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.ForeColor = System.Drawing.Color.White;
            this.btnDangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangxuat.Image")));
            this.btnDangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangxuat.Location = new System.Drawing.Point(3, 4);
            this.btnDangxuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(209, 46);
            this.btnDangxuat.TabIndex = 2;
            this.btnDangxuat.Text = "  Đăng xuất ";
            this.btnDangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangxuat.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(284, 46);
            this.panelContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(807, 589);
            this.panelContent.TabIndex = 2;
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Sidebar.Controls.Add(this.QuanlychungContainer);
            this.Sidebar.Controls.Add(this.HoadonnhapContainer);
            this.Sidebar.Controls.Add(this.HoadonbanContainer);
            this.Sidebar.Controls.Add(this.BaocaoContainer);
            this.Sidebar.Controls.Add(this.pnDangxuat);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 46);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(284, 589);
            this.Sidebar.TabIndex = 1;
            // 
            // GD_Chinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 635);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GD_Chinh";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GD_Chinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMucluc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.QuanlychungContainer.ResumeLayout(false);
            this.HoadonnhapContainer.ResumeLayout(false);
            this.HoadonbanContainer.ResumeLayout(false);
            this.BaocaoContainer.ResumeLayout(false);
            this.pnDangxuat.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer QuanlychungTransition;
        private System.Windows.Forms.Timer HoadonnhapTransition;
        private System.Windows.Forms.Timer HoadonbanTransition;
        private System.Windows.Forms.Timer SidebarTransition;
        private System.Windows.Forms.Timer BaocaoTransition;
        private System.Windows.Forms.PictureBox btnMucluc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel QuanlychungContainer;
        private System.Windows.Forms.Button btnQuanlychung;
        private System.Windows.Forms.Button btnsanpham;
        private System.Windows.Forms.Button btnkhachhang;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.FlowLayoutPanel HoadonnhapContainer;
        private System.Windows.Forms.Button btnHoadonhap;
        private System.Windows.Forms.Button btnTaohoadon;
        private System.Windows.Forms.Panel HoadonbanContainer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHoadonban;
        private System.Windows.Forms.Panel BaocaoContainer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Panel pnDangxuat;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.Button btnDshoadon;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
    }
}