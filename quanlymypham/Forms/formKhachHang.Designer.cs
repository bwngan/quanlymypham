namespace quanlymypham.Forms
{
    partial class formKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.txtmakhach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewKH = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÁCH HÀNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskdienthoai);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txttenkhach);
            this.groupBox1.Controls.Add(this.txtmakhach);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(63, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1048, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Location = new System.Drawing.Point(672, 79);
            this.mskdienthoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(200, 22);
            this.mskdienthoai.TabIndex = 7;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(672, 34);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(200, 22);
            this.txtdiachi.TabIndex = 6;
            // 
            // txttenkhach
            // 
            this.txttenkhach.Location = new System.Drawing.Point(179, 77);
            this.txttenkhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.Size = new System.Drawing.Size(200, 22);
            this.txttenkhach.TabIndex = 5;
            // 
            // txtmakhach
            // 
            this.txtmakhach.Location = new System.Drawing.Point(179, 31);
            this.txtmakhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmakhach.Name = "txtmakhach";
            this.txtmakhach.Size = new System.Drawing.Size(200, 22);
            this.txtmakhach.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách";
            // 
            // dataGridViewKH
            // 
            this.dataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKH.Location = new System.Drawing.Point(63, 222);
            this.dataGridViewKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewKH.Name = "dataGridViewKH";
            this.dataGridViewKH.RowHeadersWidth = 62;
            this.dataGridViewKH.RowTemplate.Height = 28;
            this.dataGridViewKH.Size = new System.Drawing.Size(1048, 242);
            this.dataGridViewKH.TabIndex = 2;
            this.dataGridViewKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKH_CellContentClick);
            this.dataGridViewKH.Click += new System.EventHandler(this.dataGridViewKH_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(127, 472);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(98, 24);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(250, 472);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(98, 24);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(375, 472);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(98, 24);
            this.btnsua.TabIndex = 5;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(496, 472);
            this.btnluu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(98, 24);
            this.btnluu.TabIndex = 6;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(615, 472);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(98, 24);
            this.btntimkiem.TabIndex = 7;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(735, 472);
            this.btnhienthi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(98, 24);
            this.btnhienthi.TabIndex = 8;
            this.btnhienthi.Text = "Hiển thị DS";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(857, 472);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(98, 24);
            this.btnboqua.TabIndex = 9;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(975, 472);
            this.btndong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(98, 24);
            this.btndong.TabIndex = 10;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // formKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1186, 534);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridViewKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formKhachHang";
            this.Text = "formKhachHang";
            this.Load += new System.EventHandler(this.formKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmakhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.DataGridView dataGridViewKH;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
    }
}