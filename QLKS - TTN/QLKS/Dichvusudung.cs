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
    public partial class Dichvusudung : Form
    {
        public Dichvusudung()
        {
            InitializeComponent();
        }
        string cnn = @"Data Source=desktop-loq2vp6\sqlexpress;Initial Catalog=QLKhachsan;Integrated Security=True";
        SqlConnection conn;
        DataContextDataContext dt = new DataContextDataContext();
        private void ketnoicsdl()
        {

            datadvsd.DataSource = dt.Select_Dichvusudung();
        }

        private void datadvsd_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtcmnd.Text = Convert.ToString(datadvsd.CurrentRow.Cells["Socmnd"].Value);
                txtmadv.Text = Convert.ToString(datadvsd.CurrentRow.Cells["Madv"].Value);
                txtsoluong.Text = Convert.ToString(datadvsd.CurrentRow.Cells["Soluong"].Value);
                txtthanhtoan.Text = Convert.ToString(datadvsd.CurrentRow.Cells["Thanhtoan"].Value);

            }
        }

        private void datadvsd_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            datadvsd.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void Dichvusudung_Load(object sender, EventArgs e)
        {
            datadvsd.DataSource = dt.UPDATE_Dichvusudung();
            conn = new SqlConnection(cnn);
            conn.Open();
            ketnoicsdl();
        }

        private void bntthem_Click(object sender, EventArgs e)
        {
            Themdichvusudung t = new Themdichvusudung();
            t.Show();
        }
        int ad;
        private void bntsua_Click(object sender, EventArgs e)
        {
            txtcmnd.Enabled = true;
            txtcmnd.Focus();
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
                    dt.Update_DVSD(txtcmnd.Text, txtmadv.Text, Int32.Parse(txtsoluong.Text), float.Parse(txtthanhtoan.Text));

                    ad = 0;
                    bntthem.Enabled = true;
                    bntxoa.Enabled = true;
                    bntsua.Enabled = true;
                }
                Dichvusudung_Load(sender, e);
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

                dt.Xoa_DVSD(txtcmnd.Text);
                txtcmnd.Text = "";
                txtmadv.Text = "";
                txtsoluong.Text = "";
                txtthanhtoan.Text = "";

                Dichvusudung_Load(sender, e);
            }
        }

        private void bntcapnhat_Click(object sender, EventArgs e)
        {
            Dichvusudung_Load(sender, e);
        }
    }
}