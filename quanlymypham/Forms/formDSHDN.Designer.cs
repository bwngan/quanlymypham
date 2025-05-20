namespace quanlymypham.Forms
{
    partial class formDSHDN
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
            this.dataGridViewHDN = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskNgaybd = new System.Windows.Forms.MaskedTextBox();
            this.mskNgaykt = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKhoangkt = new System.Windows.Forms.TextBox();
            this.txtKhoangbd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtSoHDN = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnTaoHDN = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblTongHD = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewHDN
            // 
            this.dataGridViewHDN.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHDN.Location = new System.Drawing.Point(459, 84);
            this.dataGridViewHDN.Name = "dataGridViewHDN";
            this.dataGridViewHDN.RowHeadersWidth = 51;
            this.dataGridViewHDN.RowTemplate.Height = 24;
            this.dataGridViewHDN.Size = new System.Drawing.Size(853, 513);
            this.dataGridViewHDN.TabIndex = 0;
            this.dataGridViewHDN.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHDN_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtSoHDN);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 497);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.mskNgaybd);
            this.groupBox3.Controls.Add(this.mskNgaykt);
            this.groupBox3.Location = new System.Drawing.Point(53, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 113);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ngày Tạo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Đến:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Từ: ";
            // 
            // mskNgaybd
            // 
            this.mskNgaybd.Location = new System.Drawing.Point(119, 32);
            this.mskNgaybd.Name = "mskNgaybd";
            this.mskNgaybd.Size = new System.Drawing.Size(131, 22);
            this.mskNgaybd.TabIndex = 3;
            // 
            // mskNgaykt
            // 
            this.mskNgaykt.Location = new System.Drawing.Point(119, 72);
            this.mskNgaykt.Name = "mskNgaykt";
            this.mskNgaykt.Size = new System.Drawing.Size(131, 22);
            this.mskNgaykt.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtKhoangkt);
            this.groupBox2.Controls.Add(this.txtKhoangbd);
            this.groupBox2.Location = new System.Drawing.Point(53, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 113);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đến:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Từ: ";
            // 
            // txtKhoangkt
            // 
            this.txtKhoangkt.Location = new System.Drawing.Point(119, 73);
            this.txtKhoangkt.Name = "txtKhoangkt";
            this.txtKhoangkt.Size = new System.Drawing.Size(131, 22);
            this.txtKhoangkt.TabIndex = 1;
            // 
            // txtKhoangbd
            // 
            this.txtKhoangbd.Location = new System.Drawing.Point(119, 32);
            this.txtKhoangbd.Name = "txtKhoangbd";
            this.txtKhoangbd.Size = new System.Drawing.Size(131, 22);
            this.txtKhoangbd.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số Hóa Đơn Nhập";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(172, 168);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(178, 22);
            this.txtMaNCC.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(172, 109);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(178, 22);
            this.txtMaNV.TabIndex = 1;
            // 
            // txtSoHDN
            // 
            this.txtSoHDN.Location = new System.Drawing.Point(172, 53);
            this.txtSoHDN.Name = "txtSoHDN";
            this.txtSoHDN.Size = new System.Drawing.Size(178, 22);
            this.txtSoHDN.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(78, 574);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(287, 574);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 3;
            this.btnBoqua.Text = "Bỏ Qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnTaoHDN
            // 
            this.btnTaoHDN.Location = new System.Drawing.Point(602, 606);
            this.btnTaoHDN.Name = "btnTaoHDN";
            this.btnTaoHDN.Size = new System.Drawing.Size(140, 23);
            this.btnTaoHDN.TabIndex = 4;
            this.btnTaoHDN.Text = "Tạo Hóa Đơn Mới";
            this.btnTaoHDN.UseVisualStyleBackColor = true;
            this.btnTaoHDN.Click += new System.EventHandler(this.btnTaoHDN_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(827, 606);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(140, 23);
            this.btnXuat.TabIndex = 5;
            this.btnXuat.Text = "Xuất Danh Sách";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1063, 606);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(140, 23);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblTongHD
            // 
            this.lblTongHD.AutoSize = true;
            this.lblTongHD.Location = new System.Drawing.Point(456, 51);
            this.lblTongHD.Name = "lblTongHD";
            this.lblTongHD.Size = new System.Drawing.Size(0, 16);
            this.lblTongHD.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(708, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "DANH SÁCH HÓA ĐƠN NHẬP";
            // 
            // formDSHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 641);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTongHD);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnTaoHDN);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewHDN);
            this.Name = "formDSHDN";
            this.Text = "formDSHDN";
            this.Load += new System.EventHandler(this.formDSHDN_Load);
            this.DoubleClick += new System.EventHandler(this.formDSHDN_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHDN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoHDN;
        private System.Windows.Forms.MaskedTextBox mskNgaykt;
        private System.Windows.Forms.MaskedTextBox mskNgaybd;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnTaoHDN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKhoangkt;
        private System.Windows.Forms.TextBox txtKhoangbd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTongHD;
        private System.Windows.Forms.Label label8;
    }
}