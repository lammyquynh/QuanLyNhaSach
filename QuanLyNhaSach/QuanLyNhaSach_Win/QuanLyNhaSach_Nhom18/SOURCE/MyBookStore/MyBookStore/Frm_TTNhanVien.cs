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
    public partial class Frm_TTNhanVien : DevExpress.XtraEditors.XtraForm
    {
        
        string User;
        public Frm_TTNhanVien(string s)
        {
            InitializeComponent();
            User = s;
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }
        BLL_NhanVien bllNV = new BLL_NhanVien();
        private void Frm_TTNhanVien_Load_1(object sender, EventArgs e)
        {
            DataTable nv;
            nv = bllNV.xuatTTNV(User);
            labMNV.Text = nv.Rows[0][0].ToString();
            txtHoten.Text = nv.Rows[0][2].ToString();
            txtDiaChi.Text = nv.Rows[0][3].ToString();
            txtSDT.Text = nv.Rows[0][4].ToString();
            DataTable cv;
            cv = bllNV.xuatNhomNguoiDung(User);
            combocv.Text = cv.Rows[0][1].ToString();
            string pic = User + ".jpg";
            pictureEdit1.Image = Image.FromFile("D:\\WinNC\\MyBookStore\\MyBookStore\\img\\"+ User + ".jpg");
        }
        
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Text == "Cập Nhật")
            {
                txtDiaChi.Enabled = true;
                txtSDT.Enabled = true;
                btnCapNhat.Text = "Lưu";
                btnHuy.Enabled = true;
            }
            else
            {
               int kq = bllNV.CapNhat_TTNV(txtDiaChi.Text, txtSDT.Text, User);
               if (kq == 1)
                   MessageBox.Show("Cập Nhật Thành Công!!");
               else
                   MessageBox.Show("Cập Nhật Thất Bại");
               txtDiaChi.Enabled = false;
               txtSDT.Enabled = false;
               btnHuy.Enabled = false;
               btnCapNhat.Text = "Cập Nhật";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DataTable nv;
            nv = bllNV.xuatTTNV(User);
            labMNV.Text = nv.Rows[0][0].ToString();
            txtHoten.Text = nv.Rows[0][2].ToString();
            txtDiaChi.Text = nv.Rows[0][3].ToString();
            txtSDT.Text = nv.Rows[0][4].ToString();
            DataTable cv;
            cv = bllNV.xuatNhomNguoiDung(User);
            TTCN.Text = cv.Rows[0][1].ToString();
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            btnHuy.Enabled = false;
            btnCapNhat.Text = "Cập Nhật";
        }

    }
}