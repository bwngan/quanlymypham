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
            this.btnHoadonban = new System.Windows.Forms.Button();
            this.btntaoHD = new System.Windows.Forms.Button();
            this.btndanhsachHD = new System.Windows.Forms.Button();
            this.BaocaoContainer = new System.Windows.Forms.Panel();
            this.btnBCSP = new System.Windows.Forms.Button();
            this.btnBCNV = new System.Windows.Forms.Button();
            this.btnBCKD = new System.Windows.Forms.Button();
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
            this.btnMucluc.Location = new System.Drawing.Point(12, 0);
            this.btnMucluc.Name = "btnMucluc";
            this.btnMucluc.Size = new System.Drawing.Size(41, 34);
            this.btnMucluc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMucluc.TabIndex = 1;
            this.btnMucluc.TabStop = false;
            this.btnMucluc.Click += new System.EventHandler(this.btnMucluc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 37);
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
            this.QuanlychungContainer.Location = new System.Drawing.Point(3, 3);
            this.QuanlychungContainer.Name = "QuanlychungContainer";
            this.QuanlychungContainer.Size = new System.Drawing.Size(229, 47);
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
            this.btnQuanlychung.Location = new System.Drawing.Point(3, 3);
            this.btnQuanlychung.Name = "btnQuanlychung";
            this.btnQuanlychung.Size = new System.Drawing.Size(210, 47);
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
            this.btnsanpham.Location = new System.Drawing.Point(3, 56);
            this.btnsanpham.Name = "btnsanpham";
            this.btnsanpham.Size = new System.Drawing.Size(186, 37);
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
            this.btnkhachhang.Location = new System.Drawing.Point(3, 99);
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.Size = new System.Drawing.Size(186, 37);
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
            this.btnNhanvien.Location = new System.Drawing.Point(3, 142);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(186, 37);
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
            this.btnNCC.Location = new System.Drawing.Point(3, 185);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(186, 37);
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
            this.HoadonnhapContainer.Location = new System.Drawing.Point(3, 56);
            this.HoadonnhapContainer.Name = "HoadonnhapContainer";
            this.HoadonnhapContainer.Size = new System.Drawing.Size(229, 47);
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
            this.btnHoadonhap.Location = new System.Drawing.Point(3, 3);
            this.btnHoadonhap.Name = "btnHoadonhap";
            this.btnHoadonhap.Size = new System.Drawing.Size(210, 37);
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
            this.btnDshoadon.Location = new System.Drawing.Point(3, 46);
            this.btnDshoadon.Name = "btnDshoadon";
            this.btnDshoadon.Size = new System.Drawing.Size(210, 37);
            this.btnDshoadon.TabIndex = 2;
            this.btnDshoadon.Text = " Danh sách hóa đơn";
            this.btnDshoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDshoadon.UseVisualStyleBackColor = false;
            this.btnDshoadon.Click += new System.EventHandler(this.btnDshoadon_Click);
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
            this.btnTaohoadon.Location = new System.Drawing.Point(3, 89);
            this.btnTaohoadon.Name = "btnTaohoadon";
            this.btnTaohoadon.Size = new System.Drawing.Size(186, 37);
            this.btnTaohoadon.TabIndex = 2;
            this.btnTaohoadon.Text = " Tạo hóa đơn ";
            this.btnTaohoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaohoadon.UseVisualStyleBackColor = false;
            this.btnTaohoadon.Click += new System.EventHandler(this.btnTaohoadon_Click);
            // 
            // HoadonbanContainer
            // 
            this.HoadonbanContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.HoadonbanContainer.Controls.Add(this.btnHoadonban);
            this.HoadonbanContainer.Controls.Add(this.btntaoHD);
            this.HoadonbanContainer.Controls.Add(this.btndanhsachHD);
            this.HoadonbanContainer.Location = new System.Drawing.Point(3, 109);
            this.HoadonbanContainer.Name = "HoadonbanContainer";
            this.HoadonbanContainer.Size = new System.Drawing.Size(229, 47);
            this.HoadonbanContainer.TabIndex = 4;
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
            this.btnHoadonban.Location = new System.Drawing.Point(3, 7);
            this.btnHoadonban.Name = "btnHoadonban";
            this.btnHoadonban.Size = new System.Drawing.Size(210, 37);
            this.btnHoadonban.TabIndex = 2;
            this.btnHoadonban.Text = "  Hóa đơn bán ";
            this.btnHoadonban.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoadonban.UseVisualStyleBackColor = false;
            this.btnHoadonban.Click += new System.EventHandler(this.btnHoadonban_Click);
            // 
            // btntaoHD
            // 
            this.btntaoHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btntaoHD.FlatAppearance.BorderSize = 0;
            this.btntaoHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntaoHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaoHD.ForeColor = System.Drawing.Color.White;
            this.btntaoHD.Image = ((System.Drawing.Image)(resources.GetObject("btntaoHD.Image")));
            this.btntaoHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntaoHD.Location = new System.Drawing.Point(3, 86);
            this.btntaoHD.Name = "btntaoHD";
            this.btntaoHD.Size = new System.Drawing.Size(186, 37);
            this.btntaoHD.TabIndex = 4;
            this.btntaoHD.Text = "Tạo hoá đơn";
            this.btntaoHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntaoHD.UseVisualStyleBackColor = false;
            this.btntaoHD.Click += new System.EventHandler(this.btntaoHD_Click);
            // 
            // btndanhsachHD
            // 
            this.btndanhsachHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btndanhsachHD.FlatAppearance.BorderSize = 0;
            this.btndanhsachHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndanhsachHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndanhsachHD.ForeColor = System.Drawing.Color.White;
            this.btndanhsachHD.Image = ((System.Drawing.Image)(resources.GetObject("btndanhsachHD.Image")));
            this.btndanhsachHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndanhsachHD.Location = new System.Drawing.Point(3, 46);
            this.btndanhsachHD.Name = "btndanhsachHD";
            this.btndanhsachHD.Size = new System.Drawing.Size(214, 37);
            this.btndanhsachHD.TabIndex = 3;
            this.btndanhsachHD.Text = " Danh sách hóa đơn ";
            this.btndanhsachHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndanhsachHD.UseVisualStyleBackColor = false;
            this.btndanhsachHD.Click += new System.EventHandler(this.btndanhsachHD_Click);
            // 
            // BaocaoContainer
            // 
            this.BaocaoContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BaocaoContainer.Controls.Add(this.btnBCSP);
            this.BaocaoContainer.Controls.Add(this.btnBCNV);
            this.BaocaoContainer.Controls.Add(this.btnBCKD);
            this.BaocaoContainer.Controls.Add(this.btnBaocao);
            this.BaocaoContainer.Location = new System.Drawing.Point(3, 162);
            this.BaocaoContainer.Name = "BaocaoContainer";
            this.BaocaoContainer.Size = new System.Drawing.Size(229, 180);
            this.BaocaoContainer.TabIndex = 5;
            // 
            // btnBCSP
            // 
            this.btnBCSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBCSP.FlatAppearance.BorderSize = 0;
            this.btnBCSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBCSP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCSP.ForeColor = System.Drawing.Color.White;
            this.btnBCSP.Image = ((System.Drawing.Image)(resources.GetObject("btnBCSP.Image")));
            this.btnBCSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBCSP.Location = new System.Drawing.Point(3, 129);
            this.btnBCSP.Name = "btnBCSP";
            this.btnBCSP.Size = new System.Drawing.Size(186, 37);
            this.btnBCSP.TabIndex = 5;
            this.btnBCSP.Text = " Sản phẩm";
            this.btnBCSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBCSP.UseVisualStyleBackColor = false;
            this.btnBCSP.Click += new System.EventHandler(this.btnBCSP_Click);
            // 
            // btnBCNV
            // 
            this.btnBCNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBCNV.FlatAppearance.BorderSize = 0;
            this.btnBCNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBCNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCNV.ForeColor = System.Drawing.Color.White;
            this.btnBCNV.Image = ((System.Drawing.Image)(resources.GetObject("btnBCNV.Image")));
            this.btnBCNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBCNV.Location = new System.Drawing.Point(3, 86);
            this.btnBCNV.Name = "btnBCNV";
            this.btnBCNV.Size = new System.Drawing.Size(186, 37);
            this.btnBCNV.TabIndex = 4;
            this.btnBCNV.Text = " Nhân viên ";
            this.btnBCNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBCNV.UseVisualStyleBackColor = false;
            this.btnBCNV.Click += new System.EventHandler(this.btnBCNV_Click);
            // 
            // btnBCKD
            // 
            this.btnBCKD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBCKD.FlatAppearance.BorderSize = 0;
            this.btnBCKD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBCKD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCKD.ForeColor = System.Drawing.Color.White;
            this.btnBCKD.Image = ((System.Drawing.Image)(resources.GetObject("btnBCKD.Image")));
            this.btnBCKD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBCKD.Location = new System.Drawing.Point(3, 46);
            this.btnBCKD.Name = "btnBCKD";
            this.btnBCKD.Size = new System.Drawing.Size(214, 37);
            this.btnBCKD.TabIndex = 3;
            this.btnBCKD.Text = " Kinh doanh ";
            this.btnBCKD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBCKD.UseVisualStyleBackColor = false;
            this.btnBCKD.Click += new System.EventHandler(this.btnBCKD_Click);
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
            this.btnBaocao.Location = new System.Drawing.Point(3, 3);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(186, 37);
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
            this.pnDangxuat.Location = new System.Drawing.Point(3, 348);
            this.pnDangxuat.Name = "pnDangxuat";
            this.pnDangxuat.Size = new System.Drawing.Size(229, 47);
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
            this.button8.Location = new System.Drawing.Point(3, 129);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(186, 37);
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
            this.button11.Location = new System.Drawing.Point(3, 86);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(186, 37);
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
            this.button12.Location = new System.Drawing.Point(3, 46);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(214, 37);
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
            this.btnDangxuat.Location = new System.Drawing.Point(3, 3);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(186, 37);
            this.btnDangxuat.TabIndex = 2;
            this.btnDangxuat.Text = "  Đăng xuất ";
            this.btnDangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangxuat.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(252, 37);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(718, 471);
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
            this.Sidebar.Location = new System.Drawing.Point(0, 37);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(252, 471);
            this.Sidebar.TabIndex = 1;
            // 
            // GD_Chinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 508);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Button btntaoHD;
        private System.Windows.Forms.Button btndanhsachHD;
        private System.Windows.Forms.Button btnHoadonban;
        private System.Windows.Forms.Panel BaocaoContainer;
        private System.Windows.Forms.Button btnBCSP;
        private System.Windows.Forms.Button btnBCNV;
        private System.Windows.Forms.Button btnBCKD;
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