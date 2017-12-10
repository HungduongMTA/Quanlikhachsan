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
        string cnn = @"Data Source=DESKTOP-78OK5HK\NGUYENTHAIBAO;Initial Catalog=QLKhachsan;Integrated Security=True";
        SqlConnection conn;
        DataContextDataContext dt = new DataContextDataContext();
        private void ketnoicsdl()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DICHVU", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datadichvu.DataSource = dt;
        }
        private void dichvu_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(cnn);
            conn.Open();
            ketnoicsdl();
        }

        private void datadichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtmadv.Text = Convert.ToString(datadichvu.CurrentRow.Cells["Madv"].Value);
                txttendv.Text = Convert.ToString(datadichvu.CurrentRow.Cells["Tendv"].Value);
                txtgiadv.Text = Convert.ToString(datadichvu.CurrentRow.Cells["Giadv"].Value);

            }
        }

        private void datadichvu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            datadichvu.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        int ad;
        private void bntthem_Click(object sender, EventArgs e)
        {
            Themdichvu t = new Themdichvu();
            t.Show();
        }

        private void bntsua_Click(object sender, EventArgs e)
        {
            txtmadv.Enabled = true;
            txtmadv.Focus();
            ad = 1;
            bntthem.Enabled = false;
            bntxoa.Enabled = false;
            bntsua.Enabled = false;
        }

        private void bntluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (ad == 1)
                {
                    dt.Update_Dichvu(txtmadv.Text, txttendv.Text, float.Parse(txtgiadv.Text));

                    ad = 0;
                    bntthem.Enabled = true;
                    bntxoa.Enabled = true;
                    bntsua.Enabled = true;
                }
                dichvu_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xin kiểm tra lại thông tin !");
            }
        }

        private void bntxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                dt.Xoa_Dichvu(txtmadv.Text);
                txtmadv.Text = "";
                txttendv.Text = "";
                txtgiadv.Text = "";

                dichvu_Load(sender, e);
            }
        }

        private void bntcapnhat_Click(object sender, EventArgs e)
        {
            dichvu_Load(sender, e);
        }
    }
}