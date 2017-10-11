namespace QLKS
{
    partial class Themdichvusudung
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
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bnthoat = new System.Windows.Forms.Button();
            this.bntthem = new System.Windows.Forms.Button();
            this.txtmadv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.CMTND = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(90, 94);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 20);
            this.txtsoluong.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Số Lượng";
            // 
            // bnthoat
            // 
            this.bnthoat.Location = new System.Drawing.Point(164, 140);
            this.bnthoat.Name = "bnthoat";
            this.bnthoat.Size = new System.Drawing.Size(75, 23);
            this.bnthoat.TabIndex = 53;
            this.bnthoat.Text = "Thoát";
            this.bnthoat.UseVisualStyleBackColor = true;
            this.bnthoat.Click += new System.EventHandler(this.bnthoat_Click);
            // 
            // bntthem
            // 
            this.bntthem.Location = new System.Drawing.Point(45, 140);
            this.bntthem.Name = "bntthem";
            this.bntthem.Size = new System.Drawing.Size(75, 23);
            this.bntthem.TabIndex = 52;
            this.bntthem.Text = "Thêm";
            this.bntthem.UseVisualStyleBackColor = true;
            this.bntthem.Click += new System.EventHandler(this.bntthem_Click);
            // 
            // txtmadv
            // 
            this.txtmadv.Location = new System.Drawing.Point(90, 55);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.Size = new System.Drawing.Size(100, 20);
            this.txtmadv.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Mã Dịch Vụ";
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(90, 18);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(100, 20);
            this.txtcmnd.TabIndex = 47;
            // 
            // CMTND
            // 
            this.CMTND.AutoSize = true;
            this.CMTND.Location = new System.Drawing.Point(29, 21);
            this.CMTND.Name = "CMTND";
            this.CMTND.Size = new System.Drawing.Size(46, 13);
            this.CMTND.TabIndex = 46;
            this.CMTND.Text = "CMTND";
            // 
            // Themdichvusudung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 250);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bnthoat);
            this.Controls.Add(this.bntthem);
            this.Controls.Add(this.txtmadv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.CMTND);
            this.Name = "Themdichvusudung";
            this.Text = "Themdichvusudung";
            this.Load += new System.EventHandler(this.Themdichvusudung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bnthoat;
        private System.Windows.Forms.Button bntthem;
        private System.Windows.Forms.TextBox txtmadv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.Label CMTND;
    }
}