namespace quanlymypham.Forms
{
    partial class formChitietHDB
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblBangchu = new System.Windows.Forms.Label();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.lblSoluongSP = new System.Windows.Forms.Label();
            this.lblTongSP = new System.Windows.Forms.Label();
            this.dataGridViewDSSP = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttenNV = new System.Windows.Forms.TextBox();
            this.txtmaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenKH = new System.Windows.Forms.TextBox();
            this.txtmaKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpngayban = new System.Windows.Forms.DateTimePicker();
            this.txtsoHDB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1260, 603);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(84, 38);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(981, 603);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 38);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa Hóa Đơn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblBangchu
            // 
            this.lblBangchu.AutoSize = true;
            this.lblBangchu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBangchu.Location = new System.Drawing.Point(976, 514);
            this.lblBangchu.Name = "lblBangchu";
            this.lblBangchu.Size = new System.Drawing.Size(182, 25);
            this.lblBangchu.TabIndex = 18;
            this.lblBangchu.Text = "Tổng Tiền (Bằng Chữ)";
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(977, 474);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(79, 20);
            this.lblTongtien.TabIndex = 17;
            this.lblTongtien.Text = "Tổng Tiền";
            // 
            // lblSoluongSP
            // 
            this.lblSoluongSP.AutoSize = true;
            this.lblSoluongSP.Location = new System.Drawing.Point(976, 427);
            this.lblSoluongSP.Name = "lblSoluongSP";
            this.lblSoluongSP.Size = new System.Drawing.Size(196, 20);
            this.lblSoluongSP.TabIndex = 16;
            this.lblSoluongSP.Text = "Tổng Số Lượng Sản Phẩm";
            // 
            // lblTongSP
            // 
            this.lblTongSP.AutoSize = true;
            this.lblTongSP.Location = new System.Drawing.Point(976, 386);
            this.lblTongSP.Name = "lblTongSP";
            this.lblTongSP.Size = new System.Drawing.Size(147, 20);
            this.lblTongSP.TabIndex = 15;
            this.lblTongSP.Text = "Tổng Số Sản Phẩm";
            // 
            // dataGridViewDSSP
            // 
            this.dataGridViewDSSP.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSSP.Location = new System.Drawing.Point(39, 386);
            this.dataGridViewDSSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewDSSP.Name = "dataGridViewDSSP";
            this.dataGridViewDSSP.RowHeadersWidth = 51;
            this.dataGridViewDSSP.RowTemplate.Height = 24;
            this.dataGridViewDSSP.Size = new System.Drawing.Size(894, 389);
            this.dataGridViewDSSP.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Danh Sách Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số hoá đơn bán";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(1121, 603);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(117, 38);
            this.btnIn.TabIndex = 20;
            this.btnIn.Text = "In Hóa Đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttenNV);
            this.groupBox2.Controls.Add(this.txtmaNV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(446, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(323, 160);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhân Viên ";
            // 
            // txttenNV
            // 
            this.txttenNV.Location = new System.Drawing.Point(141, 94);
            this.txttenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttenNV.Name = "txttenNV";
            this.txttenNV.Size = new System.Drawing.Size(157, 26);
            this.txttenNV.TabIndex = 6;
            // 
            // txtmaNV
            // 
            this.txtmaNV.Location = new System.Drawing.Point(141, 45);
            this.txtmaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmaNV.Name = "txtmaNV";
            this.txtmaNV.Size = new System.Drawing.Size(157, 26);
            this.txtmaNV.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Nhân Viên ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số Điện Thoại ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên khách hàng";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(201, 166);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(157, 26);
            this.txtdiachi.TabIndex = 10;
            // 
            // txttenKH
            // 
            this.txttenKH.Location = new System.Drawing.Point(201, 86);
            this.txttenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttenKH.Name = "txttenKH";
            this.txttenKH.Size = new System.Drawing.Size(157, 26);
            this.txttenKH.TabIndex = 8;
            // 
            // txtmaKH
            // 
            this.txtmaKH.Location = new System.Drawing.Point(201, 45);
            this.txtmaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmaKH.Name = "txtmaKH";
            this.txtmaKH.Size = new System.Drawing.Size(157, 26);
            this.txtmaKH.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Địa Chỉ";
            // 
            // dtpngayban
            // 
            this.dtpngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngayban.Location = new System.Drawing.Point(214, 120);
            this.dtpngayban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpngayban.Name = "dtpngayban";
            this.dtpngayban.Size = new System.Drawing.Size(182, 26);
            this.dtpngayban.TabIndex = 5;
            // 
            // txtsoHDB
            // 
            this.txtsoHDB.Location = new System.Drawing.Point(214, 71);
            this.txtsoHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsoHDB.Name = "txtsoHDB";
            this.txtsoHDB.Size = new System.Drawing.Size(182, 26);
            this.txtsoHDB.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mskdienthoai);
            this.groupBox3.Controls.Add(this.txtdiachi);
            this.groupBox3.Controls.Add(this.txttenKH);
            this.groupBox3.Controls.Add(this.txtmaKH);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(822, 27);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(411, 211);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Khách hàng";
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Location = new System.Drawing.Point(201, 123);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(157, 26);
            this.mskdienthoai.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpngayban);
            this.groupBox1.Controls.Add(this.txtsoHDB);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(39, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1305, 270);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "HOÁ ĐƠN BÁN HÀNG";
            // 
            // formChitietHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1410, 920);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblBangchu);
            this.Controls.Add(this.lblTongtien);
            this.Controls.Add(this.lblSoluongSP);
            this.Controls.Add(this.lblTongSP);
            this.Controls.Add(this.dataGridViewDSSP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "formChitietHDB";
            this.Text = "formChitietHDB";
            this.Load += new System.EventHandler(this.formChitietHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblBangchu;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label lblSoluongSP;
        private System.Windows.Forms.Label lblTongSP;
        private System.Windows.Forms.DataGridView dataGridViewDSSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttenNV;
        private System.Windows.Forms.TextBox txtmaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenKH;
        private System.Windows.Forms.TextBox txtmaKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpngayban;
        private System.Windows.Forms.TextBox txtsoHDB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}