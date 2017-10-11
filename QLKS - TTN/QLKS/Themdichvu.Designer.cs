namespace QLKS
{
    partial class Themdichvu
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
            this.bntthem = new System.Windows.Forms.Button();
            this.txtgiadv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttendv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmadv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntthem
            // 
            this.bntthem.Location = new System.Drawing.Point(66, 167);
            this.bntthem.Name = "bntthem";
            this.bntthem.Size = new System.Drawing.Size(75, 23);
            this.bntthem.TabIndex = 28;
            this.bntthem.Text = "Thêm";
            this.bntthem.UseVisualStyleBackColor = true;
            this.bntthem.Click += new System.EventHandler(this.bntthem_Click);
            // 
            // txtgiadv
            // 
            this.txtgiadv.Location = new System.Drawing.Point(159, 113);
            this.txtgiadv.Name = "txtgiadv";
            this.txtgiadv.Size = new System.Drawing.Size(100, 20);
            this.txtgiadv.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Giá Dịch Vụ";
            // 
            // txttendv
            // 
            this.txttendv.Location = new System.Drawing.Point(159, 68);
            this.txttendv.Name = "txttendv";
            this.txttendv.Size = new System.Drawing.Size(100, 20);
            this.txttendv.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên Dịch Vụ";
            // 
            // txtmadv
            // 
            this.txtmadv.Location = new System.Drawing.Point(159, 35);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.Size = new System.Drawing.Size(100, 20);
            this.txtmadv.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã Dịch Vụ";
            // 
            // bnthoat
            // 
            this.bnthoat.Location = new System.Drawing.Point(184, 167);
            this.bnthoat.Name = "bnthoat";
            this.bnthoat.Size = new System.Drawing.Size(75, 23);
            this.bnthoat.TabIndex = 29;
            this.bnthoat.Text = "Thoát";
            this.bnthoat.UseVisualStyleBackColor = true;
            this.bnthoat.Click += new System.EventHandler(this.bnthoat_Click);
            // 
            // Themdichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 261);
            this.Controls.Add(this.bnthoat);
            this.Controls.Add(this.bntthem);
            this.Controls.Add(this.txtgiadv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttendv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmadv);
            this.Controls.Add(this.label1);
            this.Name = "Themdichvu";
            this.Text = "Themdichvu";
            this.Load += new System.EventHandler(this.Themdichvu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntthem;
        private System.Windows.Forms.TextBox txtgiadv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttendv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmadv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnthoat;
    }
}