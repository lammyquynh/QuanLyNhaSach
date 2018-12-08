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
    public partial class Frm_KhachHang : DevExpress.XtraEditors.XtraForm
    {
        public Frm_KhachHang()
        {
            InitializeComponent();
        }
        LinQ_KhachHang qlkh = new LinQ_KhachHang();
        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NHASACH.DM_MANHINH' table. You can move, or remove it, as needed.
            this.dM_MANHINHTableAdapter.Fill(this.qL_NHASACH.DM_MANHINH);
            // TODO: This line of code loads data into the 'qL_NHASACH.KHACHHANG' table. You can move, or remove it, as needed.
            grid_khachhang.DataSource = qlkh.LoadKH();
            binding_NV();
            //txt_TongHD.Text = qlkh.XuatTongHD(txt_makhachhang).ToString;
        }
        public bool check_empty()
        {
            if (txt_tenkhachhang.Text != "" && combo_maloaikhachhang.Text != "" && txt_diachi.Text != "" && txt_sodt.Text != "")
                return true;
            else
                return false;
        }
        public void binding_NV()
        {
            txt_makhachhang.DataBindings.Add("text", grid_khachhang.DataSource, "MAKH");
            txt_tenkhachhang.DataBindings.Add("text", grid_khachhang.DataSource, "TENKH");
            txt_sodt.DataBindings.Add("text", grid_khachhang.DataSource, "SDT_KH");
            txt_diachi.DataBindings.Add("text", grid_khachhang.DataSource, "DIACHI_KH");
            combo_maloaikhachhang.DataBindings.Add("text", grid_khachhang.DataSource, "TENLOAI_KH");
            txt_ChietKhau.DataBindings.Add("text", grid_khachhang.DataSource, "CHIETKHAU_KH");
            
        }
        private void btn_themkh_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_empty())
                {
                    qlkh.ThemKH(txt_makhachhang.Text, txt_tenkhachhang.Text, txt_diachi.Text, txt_sodt.Text);
                    grid_khachhang.DataSource = "";
                    grid_khachhang.DataSource = qlkh.LoadKH();
                }
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin khách hàng trước khi thêm!");
                    
                }
            }
            catch
            {
                MessageBox.Show("Thêm khách hàng thất bại");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txt_makhachhang.Text = txt_tenkhachhang.Text = txt_sodt.Text = txt_diachi.Text = txt_ChietKhau.Text = "";
            combo_maloaikhachhang.Text = "KHÁCH HÀNG THÂN THIẾT";
            txt_ChietKhau.Text = "0.1";
            btn_themkh.Enabled = true;
        }
        public void Refresh()
        {
            grid_khachhang.DataSource = "";
            grid_khachhang.DataSource = qlkh.LoadKH();
        }
        private void btn_xoakh_Click(object sender, EventArgs e)
        {
            if (qlkh.XoaKH(txt_makhachhang.Text))
            {
                MessageBox.Show("Xóa Thành Công!");
                Refresh();
            }
            else
                MessageBox.Show("Xóa Thất Bại!!!");
        }

        private void btn_suakh_Click(object sender, EventArgs e)
        {
            btn_suakh.Enabled = false;
            btn_luukh.Enabled = btn_huykh.Enabled = true;

        }

        private void btn_luukh_Click(object sender, EventArgs e)
        {
            if (qlkh.Sua_KH(txt_makhachhang.Text, txt_tenkhachhang.Text, txt_diachi.Text, txt_sodt.Text))
            {
                MessageBox.Show("Lưu Thành Công!");
                Refresh();
                btn_luukh.Enabled = btn_huykh.Enabled = false;
                btn_suakh.Enabled = true;
            }
            else
                MessageBox.Show("Lưu Thất Bại!!!");
        }

        private void btn_huykh_Click(object sender, EventArgs e)
        {
            btn_luukh.Enabled = btn_huykh.Enabled = false;
            btn_suakh.Enabled = true;
        }
    }
}