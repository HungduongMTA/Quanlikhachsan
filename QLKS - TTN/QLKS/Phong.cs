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
    public partial class Phong : Form
    {
        public Phong()
        {
            InitializeComponent();
        }
        string cnn = @"Data Source=desktop-loq2vp6\sqlexpress;Initial Catalog=QLKhachsan;Integrated Security=True";
        SqlConnection conn;
        DataContextDataContext dt = new DataContextDataContext();
        private void ketnoicsdl()
        {

            
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            
        }

        private void dataphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataphong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bntxoa_Click(object sender, EventArgs e)
        {
            
        }
        int ad;
        private void bntcapnhat_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void bntluu_Click(object sender, EventArgs e)
        {
            
        }

    }
}
