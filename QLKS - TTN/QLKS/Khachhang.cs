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
    public partial class Khachhang : Form
    {
        public Khachhang()
        {
            InitializeComponent();
        }
        string cnn = @"Data Source=DESKTOP-78OK5HK\NGUYENTHAIBAO;Initial Catalog=QLKhachsan;Integrated Security=True";
        SqlConnection conn;
        DataContextDataContext dt = new DataContextDataContext();
        private void ketnoicsdl()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHACHHANG", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datakhachhang.DataSource = dt;
        }
        private void datakhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txthoten.Text = Convert.ToString(datakhachhang.CurrentRow.Cells["HoTen"].Value);
                txtcmnd.Text = Convert.ToString(datakhachhang.CurrentRow.Cells["Socmnd"].Value);
                txtsdt.Text = Convert.ToString(datakhachhang.CurrentRow.Cells["SDT"].Value);
                txtdiachi.Text = Convert.ToString(datakhachhang.CurrentRow.Cells["Diachi"].Value);
                txtngayden.Text = Convert.ToString(datakhachhang.CurrentRow.Cells["Ngayden"].Value);
                txtngaytra.Text = Convert.ToString(datakhachhang.CurrentRow.Cells["Ngaytra"].Value);
                txtmaphong.Text = Convert.ToString(datakhachhang.CurrentRow.Cells["MaPhong"].Value);
            }
        }

        private void datakhachhang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            datakhachhang.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void bntthem_Click(object sender, EventArgs e)
        {
            Themkhachhang t = new Themkhachhang();
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

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (ad == 1)
                {
                    dt.Update_Khachhang(txtcmnd.Text, txthoten.Text, txtdiachi.Text, txtsdt.Text, txtmaphong.Text, DateTime.Parse(txtngayden.Text), DateTime.Parse(txtngaytra.Text));

                    ad = 0;
                    bntthem.Enabled = true;
                    bntxoa.Enabled = true;
                    bntsua.Enabled = true;
                }
                Khachhang_Load(sender, e);
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

                dt.Xoa_Khachhang(txtcmnd.Text);
                txthoten.Text = "";
                txtcmnd.Text = "";
                txtdiachi.Text = "";
                txtsdt.Text = "";
                txtmaphong.Text = "";
                txtngayden.Text = "";
                txtngaytra.Text = "";
                Khachhang_Load(sender, e);
            }
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(cnn);
            conn.Open();
            ketnoicsdl();
        }

        private void bntcapnhat_Click(object sender, EventArgs e)
        {
            Khachhang_Load(sender, e);
        }
    }
}