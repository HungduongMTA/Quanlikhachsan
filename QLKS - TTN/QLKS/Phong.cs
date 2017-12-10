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
        string cnn = @"Data Source=DESKTOP-78OK5HK\NGUYENTHAIBAO;Initial Catalog=QLKhachsan;Integrated Security=True";
        SqlConnection conn;
        DataContextDataContext dt = new DataContextDataContext();
        private void ketnoicsdl()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHONG", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataphong.DataSource = dt;
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(cnn);
            conn.Open();
            ketnoicsdl();
        }

        private void dataphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtmaphong.Text = Convert.ToString(dataphong.CurrentRow.Cells["MaPhong"].Value);
                txttinhtrang.Text = Convert.ToString(dataphong.CurrentRow.Cells["Tinhtrang"].Value);
                txtgiaphong.Text = Convert.ToString(dataphong.CurrentRow.Cells["Giaphong"].Value);
                txtloaiphong.Text = Convert.ToString(dataphong.CurrentRow.Cells["Loaiphong"].Value);
            }
        }

        private void dataphong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataphong.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Themphong tp = new Themphong();
            tp.Show();
        }

        private void bntxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                dt.Xoa_Phong(txtmaphong.Text);
                txtmaphong.Text = "";
                txttinhtrang.Text = "";
                txtloaiphong.Text = "";
                txtgiaphong.Text = "";
                Phong_Load(sender, e);
            }
        }
        int ad;
        private void bntcapnhat_Click(object sender, EventArgs e)
        {
            Phong_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmaphong.Enabled = true;
            txtmaphong.Focus();
            ad = 1;
            bntthem.Enabled = false;
            bntxoa.Enabled = false;
            button2.Enabled = false;
        }

        private void bntluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (ad == 1)
                {
                    dt.Update_Phong(txtmaphong.Text, txttinhtrang.Text, float.Parse(txtgiaphong.Text), txtloaiphong.Text);

                    ad = 0;
                    bntthem.Enabled = true;
                    bntxoa.Enabled = true;
                    button2.Enabled = true;
                }
                Phong_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xin kiểm tra lại thông tin !");
            }
        }

    }
}