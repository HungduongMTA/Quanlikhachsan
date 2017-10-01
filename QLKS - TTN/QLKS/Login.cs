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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string cnn = @"Data Source=desktop-loq2vp6\sqlexpress;Initial Catalog=QLKhachsan;Integrated Security=True";

        DataContextDataContext dt = new DataContextDataContext();
        DataTable dt2 = new DataTable();

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void bntdangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cnn);
            SqlDataAdapter da = new SqlDataAdapter("Select count(*) from TAIKHOAN where TENTAIKHOAN='" + txttaikhoan.Text + "' and MATKHAU='" + txtmatkhau.Text + "'", conn);
            DataTable dtt = new DataTable();
            da.Fill(dtt);
            if (dtt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form1 f = new Form1(txttaikhoan.Text);
                f.Show();
            }
            else
            {
                MessageBox.Show("Xin Kiểm tra lại thông tin đăng nhập");
            }

        }

        private void bntthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
