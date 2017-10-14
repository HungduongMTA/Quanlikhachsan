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
    public partial class Themdichvusudung : Form
    {
        public Themdichvusudung()
        {
            InitializeComponent();
        }
        string cnn = @"Data Source=desktop-loq2vp6\sqlexpress;Initial Catalog=QLKhachsan;Integrated Security=True";
        SqlConnection conn;
        DataContextDataContext dt = new DataContextDataContext();
        private void Themdichvusudung_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(cnn);
            conn.Open();

        }

        private void bntthem_Click(object sender, EventArgs e)
        {
            if (txtcmnd.Text == "" || txtmadv.Text == "" || txtsoluong.Text == "")
            {
                MessageBox.Show("Xin kiểm tra lại thông tin nhập");
            }
            else
            {
                dt.Them_DVSD(txtcmnd.Text, txtmadv.Text, Int32.Parse(txtsoluong.Text));
                MessageBox.Show("Thêm mới thành công!");
            }
            Themdichvusudung_Load(sender, e);
        }

        private void bnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}