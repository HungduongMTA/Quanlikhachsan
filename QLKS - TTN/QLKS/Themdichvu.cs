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
    public partial class Themdichvu : Form
    {
        public Themdichvu()
        {
            InitializeComponent();
        }
        string cnn = @"Data Source=DESKTOP-78OK5HK\NGUYENTHAIBAO;Initial Catalog=QLKhachsan;Integrated Security=True";
        SqlConnection conn;
        DataContextDataContext dt = new DataContextDataContext();
        private void Themdichvu_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(cnn);
            conn.Open();
        }

        private void bntthem_Click(object sender, EventArgs e)
        {
            dt.Them_Dichvu(txtmadv.Text, txttendv.Text, float.Parse(txtgiadv.Text));
            MessageBox.Show("Thêm mới thành công!");
            Themdichvu_Load(sender, e);
        }

        private void bnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}