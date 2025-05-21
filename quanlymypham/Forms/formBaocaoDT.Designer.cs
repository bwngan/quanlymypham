namespace quanlymypham.Forms
{
    partial class formBaocaoDT
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboKT = new System.Windows.Forms.ComboBox();
            this.cboBD = new System.Windows.Forms.ComboBox();
            this.cboNamKT = new System.Windows.Forms.ComboBox();
            this.cboNamBD = new System.Windows.Forms.ComboBox();
            this.lblKT = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.dtpNgaykt = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaybd = new System.Windows.Forms.DateTimePicker();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.cboThoigian = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBaocao = new System.Windows.Forms.DataGridView();
            this.lblTongHDN = new System.Windows.Forms.Label();
            this.lblTongHDBan = new System.Windows.Forms.Label();
            this.lblTongSPNhap = new System.Windows.Forms.Label();
            this.lblTongSPBan = new System.Windows.Forms.Label();
            this.lblTongChiPhiNhap = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboKT);
            this.groupBox1.Controls.Add(this.cboBD);
            this.groupBox1.Controls.Add(this.cboNamKT);
            this.groupBox1.Controls.Add(this.cboNamBD);
            this.groupBox1.Controls.Add(this.lblKT);
            this.groupBox1.Controls.Add(this.lblBD);
            this.groupBox1.Controls.Add(this.dtpNgaykt);
            this.groupBox1.Controls.Add(this.dtpNgaybd);
            this.groupBox1.Controls.Add(this.btnHienthi);
            this.groupBox1.Controls.Add(this.cboThoigian);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Thời Gian ";
            // 
            // cboKT
            // 
            this.cboKT.FormattingEnabled = true;
            this.cboKT.Location = new System.Drawing.Point(141, 98);
            this.cboKT.Name = "cboKT";
            this.cboKT.Size = new System.Drawing.Size(121, 24);
            this.cboKT.TabIndex = 14;
            // 
            // cboBD
            // 
            this.cboBD.FormattingEnabled = true;
            this.cboBD.Location = new System.Drawing.Point(141, 63);
            this.cboBD.Name = "cboBD";
            this.cboBD.Size = new System.Drawing.Size(121, 24);
            this.cboBD.TabIndex = 13;
            // 
            // cboNamKT
            // 
            this.cboNamKT.FormattingEnabled = true;
            this.cboNamKT.Location = new System.Drawing.Point(282, 98);
            this.cboNamKT.Name = "cboNamKT";
            this.cboNamKT.Size = new System.Drawing.Size(121, 24);
            this.cboNamKT.TabIndex = 12;
            // 
            // cboNamBD
            // 
            this.cboNamBD.FormattingEnabled = true;
            this.cboNamBD.Location = new System.Drawing.Point(282, 63);
            this.cboNamBD.Name = "cboNamBD";
            this.cboNamBD.Size = new System.Drawing.Size(121, 24);
            this.cboNamBD.TabIndex = 11;
            // 
            // lblKT
            // 
            this.lblKT.AutoSize = true;
            this.lblKT.Location = new System.Drawing.Point(48, 98);
            this.lblKT.Name = "lblKT";
            this.lblKT.Size = new System.Drawing.Size(31, 16);
            this.lblKT.TabIndex = 8;
            this.lblKT.Text = "Đến";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Location = new System.Drawing.Point(48, 70);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(26, 16);
            this.lblBD.TabIndex = 7;
            this.lblBD.Text = "Từ ";
            // 
            // dtpNgaykt
            // 
            this.dtpNgaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaykt.Location = new System.Drawing.Point(141, 98);
            this.dtpNgaykt.Name = "dtpNgaykt";
            this.dtpNgaykt.Size = new System.Drawing.Size(174, 22);
            this.dtpNgaykt.TabIndex = 6;
            // 
            // dtpNgaybd
            // 
            this.dtpNgaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaybd.Location = new System.Drawing.Point(141, 65);
            this.dtpNgaybd.Name = "dtpNgaybd";
            this.dtpNgaybd.Size = new System.Drawing.Size(174, 22);
            this.dtpNgaybd.TabIndex = 5;
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(445, 109);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(75, 23);
            this.btnHienthi.TabIndex = 4;
            this.btnHienthi.Text = "Hiển Thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // cboThoigian
            // 
            this.cboThoigian.FormattingEnabled = true;
            this.cboThoigian.Location = new System.Drawing.Point(141, 30);
            this.cboThoigian.Name = "cboThoigian";
            this.cboThoigian.Size = new System.Drawing.Size(121, 24);
            this.cboThoigian.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Báo Cáo Theo ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "BÁO CÁO THEO TÌNH HÌNH KINH DOANH ";
            // 
            // dataGridViewBaocao
            // 
            this.dataGridViewBaocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaocao.Location = new System.Drawing.Point(28, 299);
            this.dataGridViewBaocao.Name = "dataGridViewBaocao";
            this.dataGridViewBaocao.RowHeadersWidth = 51;
            this.dataGridViewBaocao.RowTemplate.Height = 24;
            this.dataGridViewBaocao.Size = new System.Drawing.Size(1273, 330);
            this.dataGridViewBaocao.TabIndex = 2;
            // 
            // lblTongHDN
            // 
            this.lblTongHDN.AutoSize = true;
            this.lblTongHDN.Location = new System.Drawing.Point(29, 215);
            this.lblTongHDN.Name = "lblTongHDN";
            this.lblTongHDN.Size = new System.Drawing.Size(151, 16);
            this.lblTongHDN.TabIndex = 3;
            this.lblTongHDN.Text = "Tổng Số Hóa Đơn Nhập";
            // 
            // lblTongHDBan
            // 
            this.lblTongHDBan.AutoSize = true;
            this.lblTongHDBan.Location = new System.Drawing.Point(29, 249);
            this.lblTongHDBan.Name = "lblTongHDBan";
            this.lblTongHDBan.Size = new System.Drawing.Size(142, 16);
            this.lblTongHDBan.TabIndex = 4;
            this.lblTongHDBan.Text = "Tổng Số Hóa Đơn Bán";
            // 
            // lblTongSPNhap
            // 
            this.lblTongSPNhap.AutoSize = true;
            this.lblTongSPNhap.Location = new System.Drawing.Point(241, 215);
            this.lblTongSPNhap.Name = "lblTongSPNhap";
            this.lblTongSPNhap.Size = new System.Drawing.Size(163, 16);
            this.lblTongSPNhap.TabIndex = 5;
            this.lblTongSPNhap.Text = "Tổng Số Sản Phẩm Nhập ";
            // 
            // lblTongSPBan
            // 
            this.lblTongSPBan.AutoSize = true;
            this.lblTongSPBan.Location = new System.Drawing.Point(241, 248);
            this.lblTongSPBan.Name = "lblTongSPBan";
            this.lblTongSPBan.Size = new System.Drawing.Size(151, 16);
            this.lblTongSPBan.TabIndex = 6;
            this.lblTongSPBan.Text = "Tổng Số Sản Phẩm Bán";
            // 
            // lblTongChiPhiNhap
            // 
            this.lblTongChiPhiNhap.AutoSize = true;
            this.lblTongChiPhiNhap.Location = new System.Drawing.Point(470, 215);
            this.lblTongChiPhiNhap.Name = "lblTongChiPhiNhap";
            this.lblTongChiPhiNhap.Size = new System.Drawing.Size(119, 16);
            this.lblTongChiPhiNhap.TabIndex = 7;
            this.lblTongChiPhiNhap.Text = "Tổng Chi Phí Nhập";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(470, 244);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(108, 16);
            this.lblTongDoanhThu.TabIndex = 8;
            this.lblTongDoanhThu.Text = "Tổng Doanh Thu";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(984, 270);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 23);
            this.btnLammoi.TabIndex = 9;
            this.btnLammoi.Text = "Làm Mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(1110, 270);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 10;
            this.btnXuat.Text = "Xuất Excel";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1226, 270);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(832, 53);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(469, 211);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // formBaocaoDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 641);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.lblTongChiPhiNhap);
            this.Controls.Add(this.lblTongSPBan);
            this.Controls.Add(this.lblTongSPNhap);
            this.Controls.Add(this.lblTongHDBan);
            this.Controls.Add(this.lblTongHDN);
            this.Controls.Add(this.dataGridViewBaocao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "formBaocaoDT";
            this.Text = "formBaocaoDT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.ComboBox cboThoigian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBaocao;
        private System.Windows.Forms.Label lblTongHDN;
        private System.Windows.Forms.Label lblTongHDBan;
        private System.Windows.Forms.Label lblTongSPNhap;
        private System.Windows.Forms.Label lblTongSPBan;
        private System.Windows.Forms.Label lblTongChiPhiNhap;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.DateTimePicker dtpNgaybd;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dtpNgaykt;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblKT;
        private System.Windows.Forms.ComboBox cboBD;
        private System.Windows.Forms.ComboBox cboNamKT;
        private System.Windows.Forms.ComboBox cboNamBD;
        private System.Windows.Forms.ComboBox cboKT;

    }
}