using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LinqToSQL;
namespace MyBookStore
{
    public partial class Frm_PhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        LinQ_PhieuNhap qlpn = new LinQ_PhieuNhap();
        LinQ_HoaDon qlhd = new LinQ_HoaDon();
        string User;
        public Frm_PhieuNhap(string s)
        {
            InitializeComponent();
            User = s;
        }

        private void gb_timkiemphieunhap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Frm_PhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                qlpn.Them_PN(txt_MAPN.Text, User, null);
                
                pn.Enabled = true;
            }
            catch
            {
            }

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            HANGHOA hh = qlhd.Tim_SP(txt_MaSp.Text);
            if (hh == null)
            {
                MessageBox.Show("Sản Phẩm Không Tồn Tại");
            }
            else
            {
                txt_TenSP.Text = hh.TENHH;
                txt_dongia.Text = hh.GIATIEN.ToString();               
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            qlpn.Them_CTPN(txt_MaSp.Text, txt_MAPN.Text, int.Parse(txt_Sl.Text), double.Parse(txt_dongia.Text));
            grid_ketqua.Enabled = true;
            grid_ketqua.DataSource = null;
            grid_ketqua.DataSource = qlpn.Load_CTPN(txt_MAPN.Text);
        }
    }
}