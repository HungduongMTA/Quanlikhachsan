namespace QLKS
{
    partial class Login
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
            this.lbtk = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.bntdangnhap = new System.Windows.Forms.Button();
            this.bntthoat = new System.Windows.Forms.Button();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.lbmk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbtk
            // 
            this.lbtk.AutoSize = true;
            this.lbtk.BackColor = System.Drawing.Color.White;
            this.lbtk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtk.Location = new System.Drawing.Point(46, 76);
            this.lbtk.Name = "lbtk";
            this.lbtk.Size = new System.Drawing.Size(79, 19);
            this.lbtk.TabIndex = 0;
            this.lbtk.Text = "Tài Khoản";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txttaikhoan.Location = new System.Drawing.Point(146, 77);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(125, 20);
            this.txttaikhoan.TabIndex = 1;
            // 
            // bntdangnhap
            // 
            this.bntdangnhap.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bntdangnhap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntdangnhap.ForeColor = System.Drawing.SystemColors.Control;
            this.bntdangnhap.Location = new System.Drawing.Point(64, 159);
            this.bntdangnhap.Name = "bntdangnhap";
            this.bntdangnhap.Size = new System.Drawing.Size(75, 36);
            this.bntdangnhap.TabIndex = 2;
            this.bntdangnhap.Text = "Đăng Nhập";
            this.bntdangnhap.UseVisualStyleBackColor = false;
            this.bntdangnhap.Click += new System.EventHandler(this.bntdangnhap_Click);
            // 
            // bntthoat
            // 
            this.bntthoat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bntthoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntthoat.ForeColor = System.Drawing.Color.White;
            this.bntthoat.Location = new System.Drawing.Point(182, 159);
            this.bntthoat.Name = "bntthoat";
            this.bntthoat.Size = new System.Drawing.Size(75, 36);
            this.bntthoat.TabIndex = 3;
            this.bntthoat.Text = "Thoát";
            this.bntthoat.UseVisualStyleBackColor = false;
            this.bntthoat.Click += new System.EventHandler(this.bntthoat_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtmatkhau.Location = new System.Drawing.Point(146, 118);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(125, 20);
            this.txtmatkhau.TabIndex = 5;
            // 
            // lbmk
            // 
            this.lbmk.AutoSize = true;
            this.lbmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmk.Location = new System.Drawing.Point(47, 118);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(78, 19);
            this.lbmk.TabIndex = 4;
            this.lbmk.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(127, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.lbmk);
            this.Controls.Add(this.bntthoat);
            this.Controls.Add(this.bntdangnhap);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.lbtk);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtk;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Button bntdangnhap;
        private System.Windows.Forms.Button bntthoat;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label lbmk;
        private System.Windows.Forms.Label label1;
    }
}