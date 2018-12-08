using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BLL;
namespace MyBookStore
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string User;
        public RibbonForm1(string s)
        {
            InitializeComponent();
            User = s;
        }

        public RibbonForm1()
        {
            // TODO: Complete member initialization
        }
        private bool kiemtraform(Form a)
        {
            foreach (Form child in MdiChildren)
            {
                if (child.Name == a.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            //Frm_TTNhanVien forms = new Frm_TTNhanVien(User);
            //if (kiemtraform(forms))
            //    return;
            //    forms.MdiParent = this;
            //    forms.Text = "Thông tin cá nhân";
            //    forms.Show();
        }
        

        private void barButton_info_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_TTNhanVien forms = new Frm_TTNhanVien(User);
            if (kiemtraform(forms))
                return;
            forms.MdiParent = this;
            forms.Text = "Thông tin cá nhân";
            forms.Show();
        }
        BLL_NhanVien bllNV = new BLL_NhanVien();
        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            DataTable cv;
            cv = bllNV.xuatNhomNguoiDung(User);
            string pq = cv.Rows[0][1].ToString();
            if (pq == "THỦ KHO")
            {
                rib_LapHoaDon.Visible = false;
                rib_KhachHang.Visible = false;
                rib_QuanLy.Visible = false;
            }
            if (pq == "NHÂN VIÊN BÁN HÀNG")
            {
                rib_HangHoa.Visible = false;
                rib_QuanLy.Visible = false;
                rib_Nhap.Visible = false;
                ribbonPage3.Visible = false;
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Doimatkhauu forms = new frm_Doimatkhauu(User);
            if (kiemtraform(forms))
                return;
            //forms.MdiParent = this;
            //forms.Text = "Đổi mật khẩu";
            forms.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Đăng Xuất?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Frm_login f = new Frm_login();
                f.Show();
            }
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_NhanVien forms = new Frm_NhanVien();
            if (kiemtraform(forms))
                return;
            forms.MdiParent = this;
            forms.Text = "Quản lý nhân viên";
            forms.Show();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_HangHoa forms = new Frm_HangHoa();
            if (kiemtraform(forms))
                return;
            forms.MdiParent = this;
            forms.Text = "Quản Lý Hàng Hóa";
            forms.Show();
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_LoaiHang forms = new Frm_LoaiHang();
            if (kiemtraform(forms))
                return;
            forms.MdiParent = this;
            forms.Text = "Quản Lý loại Hàng Hóa";
            forms.Show();
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_NhaCungCap forms = new Frm_NhaCungCap();
            if (kiemtraform(forms))
                return;
            forms.MdiParent = this;
            forms.Text = "Quản Lý Nhà Cung Cấp";
            forms.Show();
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_KhachHang forms = new Frm_KhachHang();
            if (kiemtraform(forms))
                return;
            forms.MdiParent = this;
            forms.Text = "Quản Lý Khách Hàng";
            forms.Show();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_KhuyenMai forms = new Frm_KhuyenMai();
            if (kiemtraform(forms))
                return;
            forms.MdiParent = this;
            forms.Text = "Quản Lý Khách Hàng";
            forms.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_LapHoaDon forms = new Frm_LapHoaDon(User);
            if (kiemtraform(forms))
                return;
            forms.MdiParent = this;
            forms.Text = "Lập Hóa Đơn";
            forms.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_PhieuNhap forms = new Frm_PhieuNhap(User);
            if (kiemtraform(forms))
                return;
            forms.MdiParent = this;
            forms.Text = "Lập Phiếu Nhập";
            forms.Show();
        }
    }
}