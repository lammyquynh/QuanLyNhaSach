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
using BLL;

namespace MyBookStore
{
    public partial class frm_Doimatkhauu : DevExpress.XtraEditors.XtraForm
    {
        string User;
        BLL_NhanVien bllNV = new BLL_NhanVien();
        public frm_Doimatkhauu(string s)
        {
            InitializeComponent();
            User = s;
        }

        private void txtMKcu_TextChanged(object sender, EventArgs e)
        {
            if (txt_MKmoi.Text != "" && txtMKcu.Text != "" && txtMKmoiRe.Text != "")
            {
                if (txtMKmoiRe.Text == txt_MKmoi.Text)
                {
                    btnLuu.Enabled = true;
                    txtErro.Text = "";
                }
                else
                {
                    txtErro.Text = "Nhập lại mật khẩu mới chưa đúng";
                }
            }
            if (txt_MKmoi.Text != "" || txtMKcu.Text != "" || txtMKmoiRe.Text != "")
            {
                btn_reset.Enabled = true;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_MKmoi.Text = txtMKcu.Text = txtMKmoiRe.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int? kt = bllNV.KiemTra_MatKhau(User, txtMKcu.Text);
            if (kt != 0)
            {
                try
                {
                    int kq = bllNV.Capnhat_MatKhau(User, txt_MKmoi.Text);
                    if (kq == 1)
                    {
                        MessageBox.Show("Cập Nhật Thành Công!!");
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Thất Bại");
                        txt_MKmoi.Text = txtMKcu.Text = txtMKmoiRe.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hiện tại!");
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}