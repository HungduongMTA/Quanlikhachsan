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
    public partial class Themphong : Form
    {
        public Themphong()
        {
            InitializeComponent();
        }
        string cnn = @"Data Source=desktop-loq2vp6\sqlexpress;Initial Catalog=QLKhachsan;Integrated Security=True";
        SqlConnection conn;
        DataContextDataContext dt = new DataContextDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            dt.Them_Phong(txtmaphong.Text, txttinhtrang.Text, float.Parse(txtgiaphong.Text), txtgiaphong.Text);
            MessageBox.Show("Thêm mới thành công!");
            Themphong_Load(sender, e);

        }

        private void Themphong_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(cnn);
            conn.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}