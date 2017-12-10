using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Form1 : Form
    {
        private string _taikhoan;
        DataContextDataContext dt = new DataContextDataContext();
        public Form1(string taikhoan)
            : this()
        {
            _taikhoan = taikhoan;
            txttk.Text = taikhoan;
          
        }
        public Form1()
        {
            InitializeComponent();
        }
      
        private void bntDvSudung_Click(object sender, EventArgs e)
        {
            Dichvusudung dv = new Dichvusudung();
            dv.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bntTTPhong_Click(object sender, EventArgs e)
        {
            Phong p = new Phong();
            p.Show();
        }

        private void bntKhachhang_Click(object sender, EventArgs e)
        {
            Khachhang kh = new Khachhang();
            kh.Show();

        }

        private void bntTTdichvu_Click(object sender, EventArgs e)
        {
            dichvu dv = new dichvu();
            dv.Show();
        }

        private void bntThanhtoan_Click(object sender, EventArgs e)
        {
            ThanhToan t = new ThanhToan();
            t.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // txttennv.DataBindings.Clear();
           // txttennv.DataBindings.Add("Text", dt.Select_Nhanvien(txttk.Text), "TenNV");
        }

        private void bntDangxuat_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
        }
    }
}
