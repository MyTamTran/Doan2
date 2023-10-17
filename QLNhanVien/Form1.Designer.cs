namespace QLNhanVien
{
    partial class Form1
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
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.SDT = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.DiaChi = new System.Windows.Forms.TextBox();
            this.MaPhong = new System.Windows.Forms.TextBox();
            this.GioiTinh = new System.Windows.Forms.TextBox();
            this.NgaySinh = new System.Windows.Forms.TextBox();
            this.TenNV = new System.Windows.Forms.TextBox();
            this.MaNV = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNV.Location = new System.Drawing.Point(59, 139);
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.RowHeadersWidth = 51;
            this.dgvDSNV.RowTemplate.Height = 24;
            this.dgvDSNV.Size = new System.Drawing.Size(894, 376);
            this.dgvDSNV.TabIndex = 1;
            this.dgvDSNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvDSNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SDT
            // 
            this.SDT.Location = new System.Drawing.Point(729, 73);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(100, 22);
            this.SDT.TabIndex = 8;
            this.SDT.TextChanged += new System.EventHandler(this.SDT_TextChanged);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(853, 73);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 22);
            this.Email.TabIndex = 9;
            // 
            // DiaChi
            // 
            this.DiaChi.Location = new System.Drawing.Point(596, 73);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(100, 22);
            this.DiaChi.TabIndex = 7;
            // 
            // MaPhong
            // 
            this.MaPhong.Location = new System.Drawing.Point(481, 73);
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Size = new System.Drawing.Size(100, 22);
            this.MaPhong.TabIndex = 6;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Location = new System.Drawing.Point(365, 73);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(100, 22);
            this.GioiTinh.TabIndex = 5;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Location = new System.Drawing.Point(259, 73);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(100, 22);
            this.NgaySinh.TabIndex = 4;
            // 
            // TenNV
            // 
            this.TenNV.Location = new System.Drawing.Point(144, 73);
            this.TenNV.Name = "TenNV";
            this.TenNV.Size = new System.Drawing.Size(100, 22);
            this.TenNV.TabIndex = 3;
            // 
            // MaNV
            // 
            this.MaNV.Location = new System.Drawing.Point(28, 73);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(100, 22);
            this.MaNV.TabIndex = 2;
            this.MaNV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sua";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Xoa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ma NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ten NV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngay Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gioi Tinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ma Phong";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Dia chi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(726, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "SDT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(850, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Email";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(471, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Tim";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 552);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.DiaChi);
            this.Controls.Add(this.MaPhong);
            this.Controls.Add(this.GioiTinh);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.TenNV);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.dgvDSNV);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SDT;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox DiaChi;
        private System.Windows.Forms.TextBox MaPhong;
        private System.Windows.Forms.TextBox GioiTinh;
        private System.Windows.Forms.TextBox NgaySinh;
        private System.Windows.Forms.TextBox TenNV;
        private System.Windows.Forms.TextBox MaNV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
    }
}

