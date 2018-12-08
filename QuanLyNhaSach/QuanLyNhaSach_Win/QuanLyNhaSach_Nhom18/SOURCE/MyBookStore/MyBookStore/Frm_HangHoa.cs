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
using System.Data.SqlClient;
using LinqToSQL;

namespace MyBookStore
{
    public partial class Frm_HangHoa : DevExpress.XtraEditors.XtraForm
    {
        LinQ_HangHoa qlhh = new LinQ_HangHoa();
        public Frm_HangHoa()
        {
            InitializeComponent();
        }

        private void Frm_HangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NHASACH.HANGHOA' table. You can move, or remove it, as needed.
       //  this.hANGHOATableAdapter.Fill(this.qL_NHASACH.HANGHOA);
            Load_Grid_HangHoa();
            binding_HH();
            

        }
        public void binding_HH()
        {
            txt_mahanghoa.DataBindings.Clear();
            txt_maloaihanghoa.DataBindings.Clear();
            cbo_makhuyenmai.DataBindings.Clear();
            txt_tenhanghoa.DataBindings.Clear();
            txt_soluongton.DataBindings.Clear();
            txt_giatien.DataBindings.Clear();
            txt_noidung.DataBindings.Clear();

            txt_mahanghoa.DataBindings.Add("text", grid_hanghoa.DataSource, "MAHH");
            txt_maloaihanghoa.DataBindings.Add("text", grid_hanghoa.DataSource, "MALOAI_HH");
            cbo_makhuyenmai.DataBindings.Add("text", grid_hanghoa.DataSource, "MAKHUYENMAI");
            txt_tenhanghoa.DataBindings.Add("text", grid_hanghoa.DataSource, "TENHH");
            txt_soluongton.DataBindings.Add("text", grid_hanghoa.DataSource, "SOLUONGTON");
            txt_giatien.DataBindings.Add("text", grid_hanghoa.DataSource, "GIATIEN");
            txt_noidung.DataBindings.Add("text", grid_hanghoa.DataSource, "NOIDUNG");

        }
        public void Load_Grid_HangHoa()
        {
            grid_hanghoa.DataSource = qlhh.load_HangHoa();
        }
        public bool check_empty()
        {
            if (txt_mahanghoa.Text != "" && txt_maloaihanghoa.Text != "" && txt_tenhanghoa.Text != ""  && txt_soluongton.Text != "" && txt_giatien.Text != "" && txt_noidung.Text != "")
                return true;
            else
                return false;
        }
        private void btn_themhanghoa_Click(object sender, EventArgs e)
        {
            //HANGHOA h = new HANGHOA();
            //h.MAHH = txt_mahanghoa.Text;
            //h.MALOAI_HH = txt_maloaihanghoa.Text;
            //h.MAKHUYENMAI = cbo_makhuyenmai.SelectedItem.ToString();
            //h.TENHH = txt_tenhanghoa.Text;
            //h.SOLUONGTON = int.Parse(txt_soluongton.Text);
            //h.GIATIEN = float.Parse(txt_giatien.Text);
            //h.NOIDUNG = txt_noidung.Text;

            //try
            //{
                if (check_empty())
                {
                    qlhh.them_hanghoa(txt_mahanghoa.Text,txt_maloaihanghoa.Text,cbo_makhuyenmai.SelectedItem.ToString(),txt_tenhanghoa.Text,int.Parse(txt_soluongton.Text),double.Parse(txt_giatien.Text),txt_noidung.Text);
                    MessageBox.Show("Thêm hàng hóa THÀNH CÔNG");
                }
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin hàng hóa trước khi thêm!");
                    Refresh();
                }
            //}
            //catch
            //{
            //    MessageBox.Show("Thêm hàng hóa thất bại");
            //}
            grid_hanghoa.DataSource = qlhh.load_HangHoa();
            
        }

        private void btn_xoahanghoa_Click(object sender, EventArgs e)
        {
            HANGHOA h = new HANGHOA();
            h.MAHH = txt_mahanghoa.Text;
            h.MALOAI_HH = txt_maloaihanghoa.Text;
            h.MAKHUYENMAI = cbo_makhuyenmai.SelectedItem.ToString();
            h.TENHH = txt_tenhanghoa.Text;
            h.SOLUONGTON = int.Parse(txt_soluongton.Text);
            h.GIATIEN = float.Parse(txt_giatien.Text);
            h.NOIDUNG = txt_noidung.Text;
            int kq = qlhh.xoa_hanghoa(h);
            if (kq == 1)
                MessageBox.Show("Xóa thành công");
            else 
                MessageBox.Show("Xóa Thất Bại");
            Load_Grid_HangHoa();
        }

        private void btn_suahanghoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_luuhanghoa_Click(object sender, EventArgs e)
        {
            if (qlhh.sua_hanghoa(txt_mahanghoa.Text, txt_maloaihanghoa.Text, cbo_makhuyenmai.SelectedItem.ToString(), txt_tenhanghoa.Text, int.Parse(txt_soluongton.Text), float.Parse(txt_giatien.Text), txt_noidung.Text))
            {
                MessageBox.Show("Lưu Thành Công!");
                Refresh();

            }
            else
                MessageBox.Show("Lưu Thất Bại!!!");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txt_mahanghoa.Text = txt_tenhanghoa.Text = "";

            txt_mahanghoa.DataBindings.Clear();
            txt_maloaihanghoa.DataBindings.Clear();
            cbo_makhuyenmai.DataBindings.Clear();
            txt_tenhanghoa.DataBindings.Clear();
            txt_soluongton.DataBindings.Clear();
            txt_giatien.DataBindings.Clear();
            txt_noidung.DataBindings.Clear();

        }
    }
}