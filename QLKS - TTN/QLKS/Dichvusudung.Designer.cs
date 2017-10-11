namespace QLKS
{
    partial class Dichvusudung
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
            this.bntluu = new System.Windows.Forms.Button();
            this.bntsua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmadv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntthem = new System.Windows.Forms.Button();
            this.datadvsd = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtthanhtoan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bntcapnhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datadvsd)).BeginInit();
            this.SuspendLayout();
            // 
            // bntxoa
            // 
            this.bntxoa.Location = new System.Drawing.Point(364, 21);
            this.bntxoa.Name = "bntxoa";
            this.bntxoa.Size = new System.Drawing.Size(87, 23);
            this.bntxoa.TabIndex = 35;
            this.bntxoa.Text = "Xóa";
            this.bntxoa.UseVisualStyleBackColor = true;
            this.bntxoa.Click += new System.EventHandler(this.bntxoa_Click);
            // 
            // bntluu
            // 
            this.bntluu.Location = new System.Drawing.Point(241, 21);
            this.bntluu.Name = "bntluu";
            this.bntluu.Size = new System.Drawing.Size(87, 23);
            this.bntluu.TabIndex = 34;
            this.bntluu.Text = "Lưu";
            this.bntluu.UseVisualStyleBackColor = true;
            this.bntluu.Click += new System.EventHandler(this.bntluu_Click);
            // 
            // bntsua
            // 
            this.bntsua.Location = new System.Drawing.Point(132, 21);
            this.bntsua.Name = "bntsua";
            this.bntsua.Size = new System.Drawing.Size(87, 23);
            this.bntsua.TabIndex = 33;
            this.bntsua.Text = "Sửa";
            this.bntsua.UseVisualStyleBackColor = true;
            this.bntsua.Click += new System.EventHandler(this.bntsua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 32;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(364, 71);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(105, 20);
            this.txtsoluong.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Số Lượng ";
            // 
            // txtmadv
            // 
            this.txtmadv.Location = new System.Drawing.Point(132, 97);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.Size = new System.Drawing.Size(116, 20);
            this.txtmadv.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã Dịch vụ";
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(132, 71);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(116, 20);
            this.txtcmnd.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Socmnd";
            // 
            // bntthem
            // 
            this.bntthem.Location = new System.Drawing.Point(27, 21);
            this.bntthem.Name = "bntthem";
            this.bntthem.Size = new System.Drawing.Size(87, 23);
            this.bntthem.TabIndex = 25;
            this.bntthem.Text = "Thêm Mới";
            this.bntthem.UseVisualStyleBackColor = true;
            this.bntthem.Click += new System.EventHandler(this.bntthem_Click);
            // 
            // datadvsd
            // 
            this.datadvsd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadvsd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Hoten,
            this.Socmnd,
            this.Madv,
            this.Tendv,
            this.Soluong,
            this.Thanhtoan});
            this.datadvsd.Location = new System.Drawing.Point(27, 141);
            this.datadvsd.Name = "datadvsd";
            this.datadvsd.Size = new System.Drawing.Size(859, 182);
            this.datadvsd.TabIndex = 36;
            this.datadvsd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datadvsd_CellClick);
            this.datadvsd.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.datadvsd_RowPrePaint);
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
            // Madv
            // 
            this.Madv.DataPropertyName = "Madv";
            this.Madv.HeaderText = "Mã Dịch Vụ";
            this.Madv.Name = "Madv";
            // 
            // Tendv
            // 
            this.Tendv.DataPropertyName = "Tendv";
            this.Tendv.HeaderText = "Tendv";
            this.Tendv.Name = "Tendv";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số Lượng";
            this.Soluong.Name = "Soluong";
            // 
            // Thanhtoan
            // 
            this.Thanhtoan.DataPropertyName = "Thanhtoan";
            this.Thanhtoan.HeaderText = "Thanh Toán";
            this.Thanhtoan.Name = "Thanhtoan";
            // 
            // txtthanhtoan
            // 
            this.txtthanhtoan.Location = new System.Drawing.Point(605, 71);
            this.txtthanhtoan.Name = "txtthanhtoan";
            this.txtthanhtoan.Size = new System.Drawing.Size(105, 20);
            this.txtthanhtoan.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Thanh Toán";
            // 
            // bntcapnhat
            // 
            this.bntcapnhat.Location = new System.Drawing.Point(482, 21);
            this.bntcapnhat.Name = "bntcapnhat";
            this.bntcapnhat.Size = new System.Drawing.Size(87, 23);
            this.bntcapnhat.TabIndex = 39;
            this.bntcapnhat.Text = "Cập nhật";
            this.bntcapnhat.UseVisualStyleBackColor = true;
            this.bntcapnhat.Click += new System.EventHandler(this.bntcapnhat_Click);
            // 
            // Dichvusudung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 358);
            this.Controls.Add(this.bntcapnhat);
            this.Controls.Add(this.txtthanhtoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datadvsd);
            this.Controls.Add(this.bntxoa);
            this.Controls.Add(this.bntluu);
            this.Controls.Add(this.bntsua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmadv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntthem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Dichvusudung";
            this.Text = "Dichvusudung";
            this.Load += new System.EventHandler(this.Dichvusudung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datadvsd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntxoa;
        private System.Windows.Forms.Button bntluu;
        private System.Windows.Forms.Button bntsua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmadv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntthem;
        private System.Windows.Forms.DataGridView datadvsd;
        private System.Windows.Forms.TextBox txtthanhtoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtoan;
        private System.Windows.Forms.Button bntcapnhat;
    }
}