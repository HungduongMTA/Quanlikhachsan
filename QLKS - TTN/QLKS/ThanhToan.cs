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
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }
        string cnn = @"Data Source=desktop-loq2vp6\sqlexpress;Initial Catalog=QLKhachsan;Integrated Security=True";
        SqlConnection conn;
        DataContextDataContext dt = new DataContextDataContext();
        private void ketnoicsdl()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHACHHANG", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datakhachhang.DataSource = dt;

        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            datakhachhang.DataSource = dt.Update_Thanhtoan();
            conn = new SqlConnection(cnn);
            conn.Open();
            ketnoicsdl();
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
                txttongtien.Text = Convert.ToString(datakhachhang.CurrentRow.Cells["Tienthanhtoan"].Value);
                datathanhtoan.DataSource = dt.Select_ThanhtoanDVSD(txtcmnd.Text);
            }
        }
    }
}