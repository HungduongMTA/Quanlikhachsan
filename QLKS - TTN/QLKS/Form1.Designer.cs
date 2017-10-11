namespace QLKS
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
            System.Windows.Forms.Button bntThongtinTK;
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bntThanhtoan = new System.Windows.Forms.Button();
            this.bntKhachhang = new System.Windows.Forms.Button();
            this.bntDvSudung = new System.Windows.Forms.Button();
            this.bntTTdichvu = new System.Windows.Forms.Button();
            this.bntTTPhong = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txttk = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.lbTenTK = new System.Windows.Forms.Label();
            this.lbTenNguoidung = new System.Windows.Forms.Label();
            this.bntDangxuat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            bntThongtinTK = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntThongtinTK
            // 
            bntThongtinTK.Location = new System.Drawing.Point(12, 23);
            bntThongtinTK.Name = "bntThongtinTK";
            bntThongtinTK.Size = new System.Drawing.Size(87, 48);
            bntThongtinTK.TabIndex = 0;
            bntThongtinTK.Text = "Thông tin các tài khoản";
            bntThongtinTK.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bntThanhtoan);
            this.tabPage2.Controls.Add(this.bntKhachhang);
            this.tabPage2.Controls.Add(this.bntDvSudung);
            this.tabPage2.Controls.Add(this.bntTTdichvu);
            this.tabPage2.Controls.Add(this.bntTTPhong);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(899, 95);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh mục";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // bntThanhtoan
            // 
            this.bntThanhtoan.Location = new System.Drawing.Point(525, 19);
            this.bntThanhtoan.Name = "bntThanhtoan";
            this.bntThanhtoan.Size = new System.Drawing.Size(100, 58);
            this.bntThanhtoan.TabIndex = 5;
            this.bntThanhtoan.Text = "Thanh Toán";
            this.bntThanhtoan.UseVisualStyleBackColor = true;
            this.bntThanhtoan.Click += new System.EventHandler(this.bntThanhtoan_Click);
            // 
            // bntKhachhang
            // 
            this.bntKhachhang.Location = new System.Drawing.Point(138, 19);
            this.bntKhachhang.Name = "bntKhachhang";
            this.bntKhachhang.Size = new System.Drawing.Size(100, 58);
            this.bntKhachhang.TabIndex = 3;
            this.bntKhachhang.Text = "Khách Hàng";
            this.bntKhachhang.UseVisualStyleBackColor = true;
            this.bntKhachhang.Click += new System.EventHandler(this.bntKhachhang_Click);
            // 
            // bntDvSudung
            // 
            this.bntDvSudung.Location = new System.Drawing.Point(395, 19);
            this.bntDvSudung.Name = "bntDvSudung";
            this.bntDvSudung.Size = new System.Drawing.Size(100, 58);
            this.bntDvSudung.TabIndex = 2;
            this.bntDvSudung.Text = " Dịch vụ sử dụng";
            this.bntDvSudung.UseVisualStyleBackColor = true;
            this.bntDvSudung.Click += new System.EventHandler(this.bntDvSudung_Click);
            // 
            // bntTTdichvu
            // 
            this.bntTTdichvu.Location = new System.Drawing.Point(261, 19);
            this.bntTTdichvu.Name = "bntTTdichvu";
            this.bntTTdichvu.Size = new System.Drawing.Size(100, 58);
            this.bntTTdichvu.TabIndex = 1;
            this.bntTTdichvu.Text = "Thông tin dịch Vụ";
            this.bntTTdichvu.UseVisualStyleBackColor = true;
            this.bntTTdichvu.Click += new System.EventHandler(this.bntTTdichvu_Click);
            // 
            // bntTTPhong
            // 
            this.bntTTPhong.Location = new System.Drawing.Point(12, 19);
            this.bntTTPhong.Name = "bntTTPhong";
            this.bntTTPhong.Size = new System.Drawing.Size(100, 58);
            this.bntTTPhong.TabIndex = 0;
            this.bntTTPhong.Text = "Quản lí phòng";
            this.bntTTPhong.UseVisualStyleBackColor = true;
            this.bntTTPhong.Click += new System.EventHandler(this.bntTTPhong_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txttk);
            this.tabPage1.Controls.Add(this.txttennv);
            this.tabPage1.Controls.Add(this.lbTenTK);
            this.tabPage1.Controls.Add(this.lbTenNguoidung);
            this.tabPage1.Controls.Add(this.bntDangxuat);
            this.tabPage1.Controls.Add(bntThongtinTK);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(899, 95);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hệ Thống";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(695, 38);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(133, 20);
            this.txttk.TabIndex = 5;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(385, 38);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(133, 20);
            this.txttennv.TabIndex = 3;
            // 
            // lbTenTK
            // 
            this.lbTenTK.AutoSize = true;
            this.lbTenTK.Location = new System.Drawing.Point(565, 41);
            this.lbTenTK.Name = "lbTenTK";
            this.lbTenTK.Size = new System.Drawing.Size(86, 13);
            this.lbTenTK.TabIndex = 4;
            this.lbTenTK.Text = "Tên tài khoản";
            // 
            // lbTenNguoidung
            // 
            this.lbTenNguoidung.AutoSize = true;
            this.lbTenNguoidung.Location = new System.Drawing.Point(282, 41);
            this.lbTenNguoidung.Name = "lbTenNguoidung";
            this.lbTenNguoidung.Size = new System.Drawing.Size(96, 13);
            this.lbTenNguoidung.TabIndex = 2;
            this.lbTenNguoidung.Text = "Tên người dùng";
            // 
            // bntDangxuat
            // 
            this.bntDangxuat.Location = new System.Drawing.Point(124, 23);
            this.bntDangxuat.Name = "bntDangxuat";
            this.bntDangxuat.Size = new System.Drawing.Size(87, 48);
            this.bntDangxuat.TabIndex = 1;
            this.bntDangxuat.Text = "Đăng xuất";
            this.bntDangxuat.UseVisualStyleBackColor = true;
            this.bntDangxuat.Click += new System.EventHandler(this.bntDangxuat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(-2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 121);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(899, 95);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Trợ Giúp";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 368);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bntKhachhang;
        private System.Windows.Forms.Button bntDvSudung;
        private System.Windows.Forms.Button bntTTdichvu;
        private System.Windows.Forms.Button bntTTPhong;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.Label lbTenTK;
        private System.Windows.Forms.Label lbTenNguoidung;
        private System.Windows.Forms.Button bntDangxuat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button bntThanhtoan;


    }
}

