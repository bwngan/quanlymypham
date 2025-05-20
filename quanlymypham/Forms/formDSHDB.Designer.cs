namespace quanlymypham.Forms
{
    partial class formDSHDB
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
            this.label8 = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnxuatDS = new System.Windows.Forms.Button();
            this.btntaohoadonmoi = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkhoangkt = new System.Windows.Forms.TextBox();
            this.txtkhoangbd = new System.Windows.Forms.TextBox();
            this.lblTongHD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmakhachhang = new System.Windows.Forms.TextBox();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.txtsoHDB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHDB = new System.Windows.Forms.DataGridView();
            this.mskngaybd = new System.Windows.Forms.MaskedTextBox();
            this.mskngaykt = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(801, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "DANH SÁCH HOÁ ĐƠN BÁN";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(1201, 759);
            this.btndong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(158, 29);
            this.btndong.TabIndex = 17;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mskngaykt);
            this.groupBox3.Controls.Add(this.mskngaybd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(60, 451);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(334, 141);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ngày Tạo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Đến:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Từ: ";
            // 
            // btnxuatDS
            // 
            this.btnxuatDS.Location = new System.Drawing.Point(935, 759);
            this.btnxuatDS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxuatDS.Name = "btnxuatDS";
            this.btnxuatDS.Size = new System.Drawing.Size(158, 29);
            this.btnxuatDS.TabIndex = 16;
            this.btnxuatDS.Text = "Xuất Danh Sách";
            this.btnxuatDS.UseVisualStyleBackColor = true;
            // 
            // btntaohoadonmoi
            // 
            this.btntaohoadonmoi.Location = new System.Drawing.Point(682, 759);
            this.btntaohoadonmoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntaohoadonmoi.Name = "btntaohoadonmoi";
            this.btntaohoadonmoi.Size = new System.Drawing.Size(158, 29);
            this.btntaohoadonmoi.TabIndex = 15;
            this.btntaohoadonmoi.Text = "Tạo Hóa Đơn Mới";
            this.btntaohoadonmoi.UseVisualStyleBackColor = true;
            this.btntaohoadonmoi.Click += new System.EventHandler(this.btntaohoadonmoi_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(328, 719);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(84, 29);
            this.btnboqua.TabIndex = 14;
            this.btnboqua.Text = "Bỏ Qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(93, 719);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(84, 29);
            this.btntimkiem.TabIndex = 13;
            this.btntimkiem.Text = "Tìm Kiếm ";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtkhoangkt);
            this.groupBox2.Controls.Add(this.txtkhoangbd);
            this.groupBox2.Location = new System.Drawing.Point(60, 280);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(334, 141);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đến:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Từ: ";
            // 
            // txtkhoangkt
            // 
            this.txtkhoangkt.Location = new System.Drawing.Point(134, 91);
            this.txtkhoangkt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtkhoangkt.Name = "txtkhoangkt";
            this.txtkhoangkt.Size = new System.Drawing.Size(147, 26);
            this.txtkhoangkt.TabIndex = 1;
            // 
            // txtkhoangbd
            // 
            this.txtkhoangbd.Location = new System.Drawing.Point(134, 40);
            this.txtkhoangbd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtkhoangbd.Name = "txtkhoangbd";
            this.txtkhoangbd.Size = new System.Drawing.Size(147, 26);
            this.txtkhoangbd.TabIndex = 0;
            // 
            // lblTongHD
            // 
            this.lblTongHD.AutoSize = true;
            this.lblTongHD.Location = new System.Drawing.Point(518, 65);
            this.lblTongHD.Name = "lblTongHD";
            this.lblTongHD.Size = new System.Drawing.Size(0, 20);
            this.lblTongHD.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số hoá đơn bán";
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.Location = new System.Drawing.Point(194, 210);
            this.txtmakhachhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new System.Drawing.Size(200, 26);
            this.txtmakhachhang.TabIndex = 2;
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(194, 136);
            this.txtmanhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(200, 26);
            this.txtmanhanvien.TabIndex = 1;
            // 
            // txtsoHDB
            // 
            this.txtsoHDB.Location = new System.Drawing.Point(194, 66);
            this.txtsoHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsoHDB.Name = "txtsoHDB";
            this.txtsoHDB.Size = new System.Drawing.Size(200, 26);
            this.txtsoHDB.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmakhachhang);
            this.groupBox1.Controls.Add(this.txtmanhanvien);
            this.groupBox1.Controls.Add(this.txtsoHDB);
            this.groupBox1.Location = new System.Drawing.Point(19, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(479, 621);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // dataGridViewHDB
            // 
            this.dataGridViewHDB.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHDB.Location = new System.Drawing.Point(521, 106);
            this.dataGridViewHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewHDB.Name = "dataGridViewHDB";
            this.dataGridViewHDB.RowHeadersWidth = 51;
            this.dataGridViewHDB.RowTemplate.Height = 24;
            this.dataGridViewHDB.Size = new System.Drawing.Size(960, 641);
            this.dataGridViewHDB.TabIndex = 11;
            // 
            // mskngaybd
            // 
            this.mskngaybd.Location = new System.Drawing.Point(134, 37);
            this.mskngaybd.Mask = "00/00/0000";
            this.mskngaybd.Name = "mskngaybd";
            this.mskngaybd.Size = new System.Drawing.Size(147, 26);
            this.mskngaybd.TabIndex = 5;
            this.mskngaybd.ValidatingType = typeof(System.DateTime);
            // 
            // mskngaykt
            // 
            this.mskngaykt.Location = new System.Drawing.Point(134, 88);
            this.mskngaykt.Mask = "00/00/0000";
            this.mskngaykt.Name = "mskngaykt";
            this.mskngaykt.Size = new System.Drawing.Size(147, 26);
            this.mskngaykt.TabIndex = 6;
            this.mskngaykt.ValidatingType = typeof(System.DateTime);
            // 
            // formDSHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 801);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnxuatDS);
            this.Controls.Add(this.btntaohoadonmoi);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.lblTongHD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewHDB);
            this.Name = "formDSHDB";
            this.Text = "formDSHDB";
            this.Load += new System.EventHandler(this.formDSHDB_Load);
            this.DoubleClick += new System.EventHandler(this.formDSHDB_DoubleClick);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnxuatDS;
        private System.Windows.Forms.Button btntaohoadonmoi;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkhoangkt;
        private System.Windows.Forms.TextBox txtkhoangbd;
        private System.Windows.Forms.Label lblTongHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmakhachhang;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.TextBox txtsoHDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewHDB;
        private System.Windows.Forms.MaskedTextBox mskngaykt;
        private System.Windows.Forms.MaskedTextBox mskngaybd;
    }
}