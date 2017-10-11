namespace QLKS
{
    partial class Phong
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
            this.dataphong = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giaphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtloaiphong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgiaphong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bntluu = new System.Windows.Forms.Button();
            this.bntxoa = new System.Windows.Forms.Button();
            this.bntcapnhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataphong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataphong
            // 
            this.dataphong.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPhong,
            this.Tinhtrang,
            this.Giaphong,
            this.Loaiphong});
            this.dataphong.Location = new System.Drawing.Point(66, 153);
            this.dataphong.Name = "dataphong";
            this.dataphong.Size = new System.Drawing.Size(504, 126);
            this.dataphong.TabIndex = 0;
            this.dataphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataphong_CellClick);
            this.dataphong.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataphong_RowPrePaint);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // Tinhtrang
            // 
            this.Tinhtrang.DataPropertyName = "Tinhtrang";
            this.Tinhtrang.HeaderText = "Tình Trạng";
            this.Tinhtrang.Name = "Tinhtrang";
            // 
            // Giaphong
            // 
            this.Giaphong.DataPropertyName = "Giaphong";
            this.Giaphong.HeaderText = "Giá Phòng";
            this.Giaphong.Name = "Giaphong";
            // 
            // Loaiphong
            // 
            this.Loaiphong.DataPropertyName = "Loaiphong";
            this.Loaiphong.HeaderText = "Loại Phòng";
            this.Loaiphong.Name = "Loaiphong";
            // 
            // bntthem
            // 
            this.bntthem.Location = new System.Drawing.Point(30, 29);
            this.bntthem.Name = "bntthem";
            this.bntthem.Size = new System.Drawing.Size(87, 23);
            this.bntthem.TabIndex = 1;
            this.bntthem.Text = "Thêm Mới";
            this.bntthem.UseVisualStyleBackColor = true;
            this.bntthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Phòng";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(135, 79);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(116, 20);
            this.txtmaphong.TabIndex = 3;
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(135, 105);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(116, 20);
            this.txttinhtrang.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tình Trạng";
            // 
            // txtloaiphong
            // 
            this.txtloaiphong.Location = new System.Drawing.Point(367, 105);
            this.txtloaiphong.Name = "txtloaiphong";
            this.txtloaiphong.Size = new System.Drawing.Size(105, 20);
            this.txtloaiphong.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loại Phòng";
            // 
            // txtgiaphong
            // 
            this.txtgiaphong.Location = new System.Drawing.Point(367, 79);
            this.txtgiaphong.Name = "txtgiaphong";
            this.txtgiaphong.Size = new System.Drawing.Size(105, 20);
            this.txtgiaphong.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá Phòng";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntluu
            // 
            this.bntluu.Location = new System.Drawing.Point(245, 29);
            this.bntluu.Name = "bntluu";
            this.bntluu.Size = new System.Drawing.Size(87, 23);
            this.bntluu.TabIndex = 11;
            this.bntluu.Text = "Lưu";
            this.bntluu.UseVisualStyleBackColor = true;
            this.bntluu.Click += new System.EventHandler(this.bntluu_Click);
            // 
            // bntxoa
            // 
            this.bntxoa.Location = new System.Drawing.Point(367, 29);
            this.bntxoa.Name = "bntxoa";
            this.bntxoa.Size = new System.Drawing.Size(87, 23);
            this.bntxoa.TabIndex = 12;
            this.bntxoa.Text = "Xóa";
            this.bntxoa.UseVisualStyleBackColor = true;
            this.bntxoa.Click += new System.EventHandler(this.bntxoa_Click);
            // 
            // bntcapnhat
            // 
            this.bntcapnhat.Location = new System.Drawing.Point(493, 29);
            this.bntcapnhat.Name = "bntcapnhat";
            this.bntcapnhat.Size = new System.Drawing.Size(87, 23);
            this.bntcapnhat.TabIndex = 13;
            this.bntcapnhat.Text = "Cập nhật";
            this.bntcapnhat.UseVisualStyleBackColor = true;
            this.bntcapnhat.Click += new System.EventHandler(this.bntcapnhat_Click);
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 291);
            this.Controls.Add(this.bntcapnhat);
            this.Controls.Add(this.bntxoa);
            this.Controls.Add(this.bntluu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtloaiphong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtgiaphong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttinhtrang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaphong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntthem);
            this.Controls.Add(this.dataphong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Phong";
            this.Text = "Phong";
            this.Load += new System.EventHandler(this.Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataphong;
        private System.Windows.Forms.Button bntthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtloaiphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgiaphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bntluu;
        private System.Windows.Forms.Button bntxoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giaphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loaiphong;
        private System.Windows.Forms.Button bntcapnhat;
    }
}