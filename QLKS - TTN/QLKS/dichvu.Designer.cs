namespace QLKS
{
    partial class dichvu
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
            this.txtgiadv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttendv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmadv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntthem = new System.Windows.Forms.Button();
            this.datadichvu = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giadv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntcapnhat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datadichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // bntxoa
            // 
            this.bntxoa.Location = new System.Drawing.Point(362, 21);
            this.bntxoa.Name = "bntxoa";
            this.bntxoa.Size = new System.Drawing.Size(87, 23);
            this.bntxoa.TabIndex = 24;
            this.bntxoa.Text = "Xóa";
            this.bntxoa.UseVisualStyleBackColor = true;
            this.bntxoa.Click += new System.EventHandler(this.bntxoa_Click);
            // 
            // bntluu
            // 
            this.bntluu.Location = new System.Drawing.Point(239, 21);
            this.bntluu.Name = "bntluu";
            this.bntluu.Size = new System.Drawing.Size(87, 23);
            this.bntluu.TabIndex = 23;
            this.bntluu.Text = "Lưu";
            this.bntluu.UseVisualStyleBackColor = true;
            this.bntluu.Click += new System.EventHandler(this.bntluu_Click);
            // 
            // bntsua
            // 
            this.bntsua.Location = new System.Drawing.Point(129, 21);
            this.bntsua.Name = "bntsua";
            this.bntsua.Size = new System.Drawing.Size(87, 23);
            this.bntsua.TabIndex = 22;
            this.bntsua.Text = "Sửa";
            this.bntsua.UseVisualStyleBackColor = true;
            this.bntsua.Click += new System.EventHandler(this.bntsua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 20;
            // 
            // txtgiadv
            // 
            this.txtgiadv.Location = new System.Drawing.Point(362, 71);
            this.txtgiadv.Name = "txtgiadv";
            this.txtgiadv.Size = new System.Drawing.Size(105, 20);
            this.txtgiadv.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giá Dịch Vụ";
            // 
            // txttendv
            // 
            this.txttendv.Location = new System.Drawing.Point(129, 97);
            this.txttendv.Name = "txttendv";
            this.txttendv.Size = new System.Drawing.Size(116, 20);
            this.txttendv.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Dịch vụ";
            // 
            // txtmadv
            // 
            this.txtmadv.Location = new System.Drawing.Point(129, 71);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.Size = new System.Drawing.Size(116, 20);
            this.txtmadv.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã Dịch Vụ";
            // 
            // bntthem
            // 
            this.bntthem.Location = new System.Drawing.Point(24, 21);
            this.bntthem.Name = "bntthem";
            this.bntthem.Size = new System.Drawing.Size(87, 23);
            this.bntthem.TabIndex = 13;
            this.bntthem.Text = "Thêm Mới";
            this.bntthem.UseVisualStyleBackColor = true;
            this.bntthem.Click += new System.EventHandler(this.bntthem_Click);
            // 
            // datadichvu
            // 
            this.datadichvu.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datadichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Madv,
            this.Tendv,
            this.Giadv});
            this.datadichvu.Location = new System.Drawing.Point(55, 142);
            this.datadichvu.Name = "datadichvu";
            this.datadichvu.Size = new System.Drawing.Size(447, 107);
            this.datadichvu.TabIndex = 25;
            this.datadichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datadichvu_CellClick);
            this.datadichvu.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.datadichvu_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
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
            this.Tendv.HeaderText = "Tên Dịch Vụ";
            this.Tendv.Name = "Tendv";
            // 
            // Giadv
            // 
            this.Giadv.DataPropertyName = "Giadv";
            this.Giadv.HeaderText = "Giá Dịch Vụ";
            this.Giadv.Name = "Giadv";
            // 
            // bntcapnhat
            // 
            this.bntcapnhat.Location = new System.Drawing.Point(485, 21);
            this.bntcapnhat.Name = "bntcapnhat";
            this.bntcapnhat.Size = new System.Drawing.Size(87, 23);
            this.bntcapnhat.TabIndex = 26;
            this.bntcapnhat.Text = "Cập nhật";
            this.bntcapnhat.UseVisualStyleBackColor = true;
            this.bntcapnhat.Click += new System.EventHandler(this.bntcapnhat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Chi tiết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntcapnhat);
            this.Controls.Add(this.datadichvu);
            this.Controls.Add(this.bntxoa);
            this.Controls.Add(this.bntluu);
            this.Controls.Add(this.bntsua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtgiadv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttendv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmadv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntthem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "dichvu";
            this.Text = "dichvu";
            this.Load += new System.EventHandler(this.dichvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datadichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntxoa;
        private System.Windows.Forms.Button bntluu;
        private System.Windows.Forms.Button bntsua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgiadv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttendv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmadv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntthem;
        private System.Windows.Forms.DataGridView datadichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giadv;
        private System.Windows.Forms.Button bntcapnhat;
        private System.Windows.Forms.Button button1;
    }
}