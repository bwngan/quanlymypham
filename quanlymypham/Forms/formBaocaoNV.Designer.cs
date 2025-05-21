namespace quanlymypham.Forms
{
    partial class formBaocaoNV
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvNVDoanhThuCao = new System.Windows.Forms.DataGridView();
            this.chartSoDon = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVDoanhThuCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Doanh Thu Theo Nhân Viên";
            // 
            // chartDoanhThu
            // 
            chartArea13.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend13);
            this.chartDoanhThu.Location = new System.Drawing.Point(781, 329);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chartDoanhThu.Series.Add(series13);
            this.chartDoanhThu.Size = new System.Drawing.Size(506, 248);
            this.chartDoanhThu.TabIndex = 37;
            this.chartDoanhThu.Text = "chart2";
            // 
            // dgvNVDoanhThuCao
            // 
            this.dgvNVDoanhThuCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvNVDoanhThuCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVDoanhThuCao.Location = new System.Drawing.Point(49, 471);
            this.dgvNVDoanhThuCao.Name = "dgvNVDoanhThuCao";
            this.dgvNVDoanhThuCao.RowHeadersWidth = 51;
            this.dgvNVDoanhThuCao.RowTemplate.Height = 24;
            this.dgvNVDoanhThuCao.Size = new System.Drawing.Size(692, 156);
            this.dgvNVDoanhThuCao.TabIndex = 36;
            // 
            // chartSoDon
            // 
            chartArea14.Name = "ChartArea1";
            this.chartSoDon.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chartSoDon.Legends.Add(legend14);
            this.chartSoDon.Location = new System.Drawing.Point(781, 46);
            this.chartSoDon.Name = "chartSoDon";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chartSoDon.Series.Add(series14);
            this.chartSoDon.Size = new System.Drawing.Size(506, 257);
            this.chartSoDon.TabIndex = 35;
            this.chartSoDon.Text = "chart1";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1214, 604);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 34;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(1098, 604);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 33;
            this.btnXuat.Text = "Xuất Excel";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(972, 604);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 23);
            this.btnLammoi.TabIndex = 32;
            this.btnLammoi.Text = "Làm Mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(49, 179);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(692, 267);
            this.dgvNhanVien.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "BÁO CÁO NHÂN VIÊN";
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
            this.groupBox1.Location = new System.Drawing.Point(49, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 127);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Thời Gian ";
            // 
            // cboKT
            // 
            this.cboKT.FormattingEnabled = true;
            this.cboKT.Location = new System.Drawing.Point(157, 91);
            this.cboKT.Name = "cboKT";
            this.cboKT.Size = new System.Drawing.Size(121, 24);
            this.cboKT.TabIndex = 14;
            // 
            // cboBD
            // 
            this.cboBD.FormattingEnabled = true;
            this.cboBD.Location = new System.Drawing.Point(157, 56);
            this.cboBD.Name = "cboBD";
            this.cboBD.Size = new System.Drawing.Size(121, 24);
            this.cboBD.TabIndex = 13;
            // 
            // cboNamKT
            // 
            this.cboNamKT.FormattingEnabled = true;
            this.cboNamKT.Location = new System.Drawing.Point(298, 91);
            this.cboNamKT.Name = "cboNamKT";
            this.cboNamKT.Size = new System.Drawing.Size(121, 24);
            this.cboNamKT.TabIndex = 12;
            // 
            // cboNamBD
            // 
            this.cboNamBD.FormattingEnabled = true;
            this.cboNamBD.Location = new System.Drawing.Point(298, 56);
            this.cboNamBD.Name = "cboNamBD";
            this.cboNamBD.Size = new System.Drawing.Size(121, 24);
            this.cboNamBD.TabIndex = 11;
            // 
            // lblKT
            // 
            this.lblKT.AutoSize = true;
            this.lblKT.Location = new System.Drawing.Point(64, 91);
            this.lblKT.Name = "lblKT";
            this.lblKT.Size = new System.Drawing.Size(31, 16);
            this.lblKT.TabIndex = 8;
            this.lblKT.Text = "Đến";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Location = new System.Drawing.Point(64, 63);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(26, 16);
            this.lblBD.TabIndex = 7;
            this.lblBD.Text = "Từ ";
            // 
            // dtpNgaykt
            // 
            this.dtpNgaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaykt.Location = new System.Drawing.Point(157, 91);
            this.dtpNgaykt.Name = "dtpNgaykt";
            this.dtpNgaykt.Size = new System.Drawing.Size(174, 22);
            this.dtpNgaykt.TabIndex = 6;
            // 
            // dtpNgaybd
            // 
            this.dtpNgaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaybd.Location = new System.Drawing.Point(157, 58);
            this.dtpNgaybd.Name = "dtpNgaybd";
            this.dtpNgaybd.Size = new System.Drawing.Size(174, 22);
            this.dtpNgaybd.TabIndex = 5;
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(611, 93);
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
            this.cboThoigian.Location = new System.Drawing.Point(157, 23);
            this.cboThoigian.Name = "cboThoigian";
            this.cboThoigian.Size = new System.Drawing.Size(121, 24);
            this.cboThoigian.TabIndex = 1;
            this.cboThoigian.SelectedIndexChanged += new System.EventHandler(this.cboThoigian_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Báo Cáo Theo ";
            // 
            // formBaocaoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 641);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartDoanhThu);
            this.Controls.Add(this.dgvNVDoanhThuCao);
            this.Controls.Add(this.chartSoDon);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "formBaocaoNV";
            this.Text = "formBaocaoNV";
            this.Load += new System.EventHandler(this.formBaocaoNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVDoanhThuCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.DataGridView dgvNVDoanhThuCao;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSoDon;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboKT;
        private System.Windows.Forms.ComboBox cboBD;
        private System.Windows.Forms.ComboBox cboNamKT;
        private System.Windows.Forms.ComboBox cboNamBD;
        private System.Windows.Forms.Label lblKT;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.DateTimePicker dtpNgaykt;
        private System.Windows.Forms.DateTimePicker dtpNgaybd;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.ComboBox cboThoigian;
        private System.Windows.Forms.Label label2;
    }
}