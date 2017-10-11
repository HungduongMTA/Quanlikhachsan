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
    public partial class dichvu : Form
    {
        public dichvu()
        {
            InitializeComponent();
        }
        string cnn = @"Data Source=desktop-loq2vp6\sqlexpress;Initial Catalog=QLKhachsan;Integrated Security=True";
        SqlConnection conn;
        DataContextDataContext dt = new DataContextDataContext();
        private void ketnoicsdl()
        {

           
        }
        private void dichvu_Load(object sender, EventArgs e)
        {
           
        }

        private void datadichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void datadichvu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
           
        }
        int ad;
        private void bntthem_Click(object sender, EventArgs e)
        {
          
        }

        private void bntsua_Click(object sender, EventArgs e)
        {
            
        }

        private void bntluu_Click(object sender, EventArgs e)
        {
           
        }

        private void bntxoa_Click(object sender, EventArgs e)
        {
            
        }

        private void bntcapnhat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
