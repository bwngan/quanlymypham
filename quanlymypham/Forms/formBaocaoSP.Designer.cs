namespace quanlymypham.Forms
{
    partial class formBaocaoSP
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
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
            this.dgvBanChay = new System.Windows.Forms.DataGridView();
            this.chartDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSL
            // 
            chartArea11.Name = "ChartArea1";
            this.chartSL.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chartSL.Legends.Add(legend11);
            this.chartSL.Location = new System.Drawing.Point(763, 48);
            this.chartSL.Name = "chartSL";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chartSL.Series.Add(series11);
            this.chartSL.Size = new System.Drawing.Size(506, 257);
            this.chartSL.TabIndex = 25;
            this.chartSL.Text = "chart1";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1196, 606);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 24;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(1080, 606);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 23;
            this.btnXuat.Text = "Xuất Excel";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(954, 606);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 23);
            this.btnLammoi.TabIndex = 22;
            this.btnLammoi.Text = "Làm Mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(31, 181);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(692, 267);
            this.dgvSanPham.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "BÁO CÁO SẢN PHẨM";
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
            this.groupBox1.Location = new System.Drawing.Point(31, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 127);
            this.groupBox1.TabIndex = 13;
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
            // dgvBanChay
            // 
            this.dgvBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanChay.Location = new System.Drawing.Point(31, 473);
            this.dgvBanChay.Name = "dgvBanChay";
            this.dgvBanChay.RowHeadersWidth = 51;
            this.dgvBanChay.RowTemplate.Height = 24;
            this.dgvBanChay.Size = new System.Drawing.Size(692, 156);
            this.dgvBanChay.TabIndex = 26;
            // 
            // chartDT
            // 
            chartArea12.Name = "ChartArea1";
            this.chartDT.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chartDT.Legends.Add(legend12);
            this.chartDT.Location = new System.Drawing.Point(763, 331);
            this.chartDT.Name = "chartDT";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chartDT.Series.Add(series12);
            this.chartDT.Size = new System.Drawing.Size(506, 248);
            this.chartDT.TabIndex = 27;
            this.chartDT.Text = "chart2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sản Phẩm Bán Chạy";
            // 
            // formBaocaoSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 641);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartDT);
            this.Controls.Add(this.dgvBanChay);
            this.Controls.Add(this.chartSL);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "formBaocaoSP";
            this.Text = "formBaocaoSP";
            this.Load += new System.EventHandler(this.formBaocaoSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSL;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.DataGridView dgvSanPham;
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
        private System.Windows.Forms.DataGridView dgvBanChay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDT;
        private System.Windows.Forms.Label label3;
    }
}