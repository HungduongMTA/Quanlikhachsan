using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLKS
{
    public partial class Themkhachhang : Form
    {
        public Themkhachhang()
        {
            InitializeComponent();
        }
        string cnn = @"Data Source=desktop-loq2vp6\sqlexpress;Initial Catalog=QLKhachsan;Integrated Security=True";
        SqlConnection conn; 
        DataContextDataContext dt = new DataContextDataContext();
        private void Themkhachhang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(cnn);
            conn.Open();
        }
        private void bntthem_Click(object sender, EventArgs e)
        {
            if (txthoten.Text == "" || txtcmnd.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "" || txtmaphong.Text == "" || txtngayden.Text == "" || txtngaytra.Text == "")
            {
                MessageBox.Show("Xin kiểm tra lại thông tin nhập");
            }
            else
            {
                dt.Them_Khachhang(txtcmnd.Text, txthoten.Text, txtdiachi.Text, txtsdt.Text, txtmaphong.Text, DateTime.Parse(txtngayden.Text), DateTime.Parse(txtngaytra.Text));
                MessageBox.Show("Thêm mới thành công!");
            }
            Themkhachhang_Load(sender, e);
        }



        private void bnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}