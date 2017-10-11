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
            
        }
        private void bntthem_Click(object sender, EventArgs e)
        {
           
        }

      

        private void bnthoat_Click(object sender, EventArgs e)
        {
           
        }
    }
}
