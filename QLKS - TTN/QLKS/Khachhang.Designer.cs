namespace QLKS
{
    partial class Khachhang
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
            this.bntxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.bntsua = new System.Windows.Forms.Button();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntthem = new System.Windows.Forms.Button();
            this.txtngayden = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtngaytra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datakhachhang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngayden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntcapnhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datakhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // bntxoa
            // 
            this.bntxoa.Location = new System.Drawing.Point(386, 12);
            this.bntxoa.Name = "bntxoa";
            this.bntxoa.Size = new System.Drawing.Size(87, 23);
            this.bntxoa.TabIndex = 24;
            this.bntxoa.Text = "Xóa";
            this.bntxoa.UseVisualStyleBackColor = true;
            this.bntxoa.Click += new System.EventHandler(this.bntxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(264, 12);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(87, 23);
            this.btnluu.TabIndex = 23;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // bntsua
            // 
            this.bntsua.Location = new System.Drawing.Point(154, 12);
            this.bntsua.Name = "bntsua";
            this.bntsua.Size = new System.Drawing.Size(87, 23);
            this.bntsua.TabIndex = 22;
            this.bntsua.Text = "Sửa";
            this.bntsua.UseVisualStyleBackColor = true;
            this.bntsua.Click += new System.EventHandler(this.bntsua_Click);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(287, 88);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(105, 20);
            this.txtdiachi.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Địa chỉ";
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(287, 62);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(105, 20);
            this.txtcmnd.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "CMTND";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(79, 88);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(116, 20);
            this.txtsdt.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "SĐT";
            // 
            // txthoten
            // 
            this.txthoten.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txthoten.Location = new System.Drawing.Point(79, 62);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(116, 20);
            this.txthoten.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Họ Tên";
            // 
            // bntthem
            // 
            this.bntthem.Location = new System.Drawing.Point(49, 12);
            this.bntthem.Name = "bntthem";
            this.bntthem.Size = new System.Drawing.Size(87, 23);
            this.bntthem.TabIndex = 13;
            this.bntthem.Text = "Thêm Mới";
            this.bntthem.UseVisualStyleBackColor = true;
            this.bntthem.Click += new System.EventHandler(this.bntthem_Click);
            // 
            // txtngayden
            // 
            this.txtngayden.Location = new System.Drawing.Point(484, 88);
            this.txtngayden.Name = "txtngayden";
            this.txtngayden.Size = new System.Drawing.Size(105, 20);
            this.txtngayden.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ngày Đến";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(484, 62);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(105, 20);
            this.txtmaphong.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Mã Phòng";
            // 
            // txtngaytra
            // 
            this.txtngaytra.Location = new System.Drawing.Point(675, 88);
            this.txtngaytra.Name = "txtngaytra";
            this.txtngaytra.Size = new System.Drawing.Size(105, 20);
            this.txtngaytra.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ngày Trả";
            // 
            // datakhachhang
            // 
            this.datakhachhang.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datakhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datakhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Hoten,
            this.Socmnd,
            this.Sdt,
            this.Diachi,
            this.MaPhong,
            this.Ngayden,
            this.Ngaytra});
            this.datakhachhang.Location = new System.Drawing.Point(26, 129);
            this.datakhachhang.Name = "datakhachhang";
            this.datakhachhang.Size = new System.Drawing.Size(791, 150);
            this.datakhachhang.TabIndex = 31;
            this.datakhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datakhachhang_CellClick);
            this.datakhachhang.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.datakhachhang_RowPrePaint);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hoten";
            this.Hoten.HeaderText = "Họ Tên";
            this.Hoten.Name = "Hoten";
            // 
            // Socmnd
            // 
            this.Socmnd.DataPropertyName = "Socmnd";
            this.Socmnd.HeaderText = "CMTND";
            this.Socmnd.Name = "Socmnd";
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "SĐT";
            this.Sdt.Name = "Sdt";
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa Chỉ";
            this.Diachi.Name = "Diachi";
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // Ngayden
            // 
            this.Ngayden.DataPropertyName = "Ngayden";
            this.Ngayden.HeaderText = "Ngày Đến";
            this.Ngayden.Name = "Ngayden";
            // 
            // Ngaytra
            // 
            this.Ngaytra.DataPropertyName = "Ngaytra";
            this.Ngaytra.HeaderText = "Ngày Trả";
            this.Ngaytra.Name = "Ngaytra";
            // 
            // bntcapnhat
            // 
            this.bntcapnhat.Location = new System.Drawing.Point(503, 12);
            this.bntcapnhat.Name = "bntcapnhat";
            this.bntcapnhat.Size = new System.Drawing.Size(87, 23);
            this.bntcapnhat.TabIndex = 32;
            this.bntcapnhat.Text = "Cập nhật";
            this.bntcapnhat.UseVisualStyleBackColor = true;
            this.bntcapnhat.Click += new System.EventHandler(this.bntcapnhat_Click);
            // 
            // Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(834, 291);
            this.Controls.Add(this.bntcapnhat);
            this.Controls.Add(this.datakhachhang);
            this.Controls.Add(this.txtngaytra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtngayden);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bntxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.bntsua);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntthem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Khachhang";
            this.Text = "Khachhang";
            this.Load += new System.EventHandler(this.Khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datakhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button bntsua;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntthem;
        private System.Windows.Forms.TextBox txtngayden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtngaytra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView datakhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngayden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaytra;
        private System.Windows.Forms.Button bntcapnhat;
    }
}