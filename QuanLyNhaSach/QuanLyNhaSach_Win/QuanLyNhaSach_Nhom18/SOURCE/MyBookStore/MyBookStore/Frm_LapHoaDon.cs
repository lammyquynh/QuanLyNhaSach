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
    public partial class Frm_LapHoaDon : DevExpress.XtraEditors.XtraForm
    {

        string User;
        LinQ_HoaDon qlhd = new LinQ_HoaDon();
        double tt=0;
        public Frm_LapHoaDon(string s)
        {
            InitializeComponent();
            User = s;
        }

        private void txt_mahd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupControl1.Enabled = true;
            }
            if (radioButton2.Checked == true)
            {
                groupControl1.Enabled = false;
            }
        }

        private void btn_themhd_Click(object sender, EventArgs e)
        {
            groupControl2.Enabled = true;
            bool kq;
            if (radioButton1.Checked == true)
            {
               kq = qlhd.Them_HD(txt_mahd.Text, User, txt_MaKH.Text, null);
            }
            else
            {
                kq = qlhd.Them_HD(txt_mahd.Text, User, null, null);
            }
            if (kq == false)
            {
                MessageBox.Show("Mã Hóa Đơn Đã Tồn Tại ");
                return;
            }
            grid_laphoadon.Enabled = true;
            grid_laphoadon.DataSource = qlhd.Load_CTHD(txt_mahd.Text);
        }

        private void textEdit5_Enter(object sender, EventArgs e)
        {
            //HANGHOA hh = qlhd.Tim_SP(txt_MaSp.Text);
            //if (hh == null)
            //{
            //    MessageBox.Show("Sản Phẩm Không Tồn Tại");
            //}
            //else
            //{
            //    txt_TenSP.Text = hh.TENHH;
            //    txt_dongia.Text = hh.GIATIEN.ToString();
            //    txt_KM.Text = hh.KHUYENMAI.ToString();
            //}
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
                txt_KM.Text = hh.MAKHUYENMAI.ToString();
            }
        }

        private void btn_ghihd_Click(object sender, EventArgs e)
        {
            try
            {
                CT_HOADON ct = new CT_HOADON();
                ct.MAHH = txt_MaSp.Text;
                ct.MAHD = txt_mahd.Text;
                ct.SOLUONG_BAN = Convert.ToInt32(txt_Sl.Text);
                ct.DONGIA_BAN =  Convert.ToInt32(txt_dongia.Text);
                qlhd.Them_CT(txt_mahd.Text, txt_MaSp.Text, Convert.ToInt32(txt_Sl.Text), Convert.ToInt32(txt_dongia.Text));
                grid_laphoadon.DataSource = null;
                grid_laphoadon.DataSource = qlhd.Load_CTHD(txt_mahd.Text);
                tt += Convert.ToInt32(txt_Sl.Text) * Convert.ToInt32(txt_dongia.Text);
                sotien.Text =  tt.ToString();
            }
            catch
            {
                MessageBox.Show("Không Thể Thêm");
            }
        }

        private void btn_lapcthd_Click(object sender, EventArgs e)
        {
            bool kq = qlhd.LapHD(txt_mahd.Text, tt);
            FormReportHH a = new FormReportHH();
            a.Show();
            this.Hide();
            if (kq)
            {

            }
            else
                MessageBox.Show("In");
        }

        private void btn_huycthd_Click(object sender, EventArgs e)
        {
            grid_laphoadon.DataSource = null;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}