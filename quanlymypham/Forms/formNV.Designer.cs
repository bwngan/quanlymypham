namespace quanlymypham.Forms
{
    partial class formNV
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
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.mskNgaysinh = new System.Windows.Forms.MaskedTextBox();
            this.cboMacv = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNu = new System.Windows.Forms.CheckBox();
            this.cbNam = new System.Windows.Forms.CheckBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1038, 602);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 32;
            this.btnDong.Text = "Đóng ";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(927, 602);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 31;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(811, 602);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(81, 23);
            this.btnHienthi.TabIndex = 30;
            this.btnHienthi.Text = "Hiển thị DS";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(701, 602);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 29;
            this.btnTimkiem.Text = "Tìm kiếm ";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(564, 602);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(422, 602);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(309, 602);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(184, 602);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Location = new System.Drawing.Point(26, 225);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.RowHeadersWidth = 51;
            this.dataGridViewNV.RowTemplate.Height = 24;
            this.dataGridViewNV.Size = new System.Drawing.Size(1282, 351);
            this.dataGridViewNV.TabIndex = 24;
            this.dataGridViewNV.Click += new System.EventHandler(this.dataGridViewNV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.mskDienthoai);
            this.groupBox1.Controls.Add(this.mskNgaysinh);
            this.groupBox1.Controls.Add(this.cboMacv);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbNu);
            this.groupBox1.Controls.Add(this.cbNam);
            this.groupBox1.Controls.Add(this.txtTennv);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1282, 166);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên ";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(963, 70);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(170, 22);
            this.txtDiachi.TabIndex = 14;
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.Location = new System.Drawing.Point(963, 34);
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(170, 22);
            this.mskDienthoai.TabIndex = 13;
            // 
            // mskNgaysinh
            // 
            this.mskNgaysinh.Location = new System.Drawing.Point(551, 73);
            this.mskNgaysinh.Name = "mskNgaysinh";
            this.mskNgaysinh.Size = new System.Drawing.Size(170, 22);
            this.mskNgaysinh.TabIndex = 12;
            // 
            // cboMacv
            // 
            this.cboMacv.FormattingEnabled = true;
            this.cboMacv.Location = new System.Drawing.Point(551, 31);
            this.cboMacv.Name = "cboMacv";
            this.cboMacv.Size = new System.Drawing.Size(170, 24);
            this.cboMacv.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(877, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Địa chỉ ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(877, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Điện thoại ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày sinh ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã CV";
            // 
            // cbNu
            // 
            this.cbNu.AutoSize = true;
            this.cbNu.Location = new System.Drawing.Point(267, 109);
            this.cbNu.Name = "cbNu";
            this.cbNu.Size = new System.Drawing.Size(46, 20);
            this.cbNu.TabIndex = 6;
            this.cbNu.Text = "Nữ";
            this.cbNu.UseVisualStyleBackColor = true;
            // 
            // cbNam
            // 
            this.cbNam.AutoSize = true;
            this.cbNam.Location = new System.Drawing.Point(155, 108);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(58, 20);
            this.cbNam.TabIndex = 5;
            this.cbNam.Text = "Nam";
            this.cbNam.UseVisualStyleBackColor = true;
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(155, 70);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(170, 22);
            this.txtTennv.TabIndex = 4;
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(155, 31);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(170, 22);
            this.txtManv.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "NHÂN VIÊN ";
            // 
            // formNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 641);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "formNV";
            this.Text = "formNV";
            this.Load += new System.EventHandler(this.formNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.MaskedTextBox mskNgaysinh;
        private System.Windows.Forms.ComboBox cboMacv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbNu;
        private System.Windows.Forms.CheckBox cbNam;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}