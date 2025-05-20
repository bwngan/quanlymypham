namespace quanlymypham.Forms
{
    partial class formNCC
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
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dataGridViewNCC = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenncc = new System.Windows.Forms.TextBox();
            this.txtMancc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(1055, 555);
            this.btndong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(98, 24);
            this.btndong.TabIndex = 21;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(937, 555);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(98, 24);
            this.btnboqua.TabIndex = 20;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(815, 555);
            this.btnhienthi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(98, 24);
            this.btnhienthi.TabIndex = 19;
            this.btnhienthi.Text = "Hiển thị DS";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(695, 555);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(98, 24);
            this.btntimkiem.TabIndex = 18;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(576, 555);
            this.btnluu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(98, 24);
            this.btnluu.TabIndex = 17;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(455, 555);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(98, 24);
            this.btnsua.TabIndex = 16;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(330, 555);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(98, 24);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(207, 555);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(98, 24);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dataGridViewNCC
            // 
            this.dataGridViewNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNCC.Location = new System.Drawing.Point(143, 305);
            this.dataGridViewNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewNCC.Name = "dataGridViewNCC";
            this.dataGridViewNCC.RowHeadersWidth = 62;
            this.dataGridViewNCC.RowTemplate.Height = 28;
            this.dataGridViewNCC.Size = new System.Drawing.Size(1048, 242);
            this.dataGridViewNCC.TabIndex = 13;
            this.dataGridViewNCC.Click += new System.EventHandler(this.dataGridViewNCC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskDienthoai);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtTenncc);
            this.groupBox1.Controls.Add(this.txtMancc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.l);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(143, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1048, 154);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.Location = new System.Drawing.Point(672, 79);
            this.mskDienthoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(200, 22);
            this.mskDienthoai.TabIndex = 7;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(672, 34);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(200, 22);
            this.txtDiachi.TabIndex = 6;
            // 
            // txtTenncc
            // 
            this.txtTenncc.Location = new System.Drawing.Point(195, 79);
            this.txtTenncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenncc.Name = "txtTenncc";
            this.txtTenncc.Size = new System.Drawing.Size(200, 22);
            this.txtTenncc.TabIndex = 5;
            // 
            // txtMancc
            // 
            this.txtMancc.Location = new System.Drawing.Point(195, 33);
            this.txtMancc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMancc.Name = "txtMancc";
            this.txtMancc.Size = new System.Drawing.Size(200, 22);
            this.txtMancc.TabIndex = 4;
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
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(80, 82);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(114, 16);
            this.l.TabIndex = 1;
            this.l.Text = "Tên nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhà Cung Cấp";
            // 
            // formNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 641);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridViewNCC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "formNCC";
            this.Load += new System.EventHandler(this.formNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridViewNCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenncc;
        private System.Windows.Forms.TextBox txtMancc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}