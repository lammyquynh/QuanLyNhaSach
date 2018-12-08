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
    public partial class Frm_LoaiHang : DevExpress.XtraEditors.XtraForm
    {
        LinQ_TheLoaiHangHoa qlloai = new LinQ_TheLoaiHangHoa();
        public Frm_LoaiHang()
        {
            InitializeComponent();
        }

        private void Frm_LoaiHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NHASACH.LOAIHANGHOA' table. You can move, or remove it, as needed.
            this.lOAIHANGHOATableAdapter.Fill(this.qL_NHASACH.LOAIHANGHOA);
            Load_Grid_HangHoa();
            binding_LOAI();
            
        }
        public void binding_LOAI()
        {
            txt_maloai.DataBindings.Add("text", grid_loaihanghoa.DataSource, "MALOAI_HH");
            txt_tenloai.DataBindings.Add("text", grid_loaihanghoa.DataSource, "TENLOAI_HH");
          

        }
        public void Load_Grid_HangHoa()
        {
            grid_loaihanghoa.DataSource = qlloai.load_LoaiHangHoa();
        }
        public bool check_empty()
        {
            if (txt_tenloai .Text != "" && txt_maloai.Text != "" )
                return true;
            else
                return false;
        }
        private void btn_themloaihang_Click(object sender, EventArgs e)
        {
            LOAIHANGHOA l = new LOAIHANGHOA();
            l.MALOAI_HH = txt_maloai.Text;
            l.TENLOAI_HH = txt_tenloai.Text;
            try
            {
                if (check_empty())
                {
                    qlloai.them_loai(l);
                    MessageBox.Show("Thêm loại hàng hóa THÀNH CÔNG");
                }
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin loại hàng hóa trước khi thêm!");
                    Refresh();
                }
            }
            catch
            {
                MessageBox.Show("Thêm loại hàng hóa thất bại");
            }
            Load_Grid_HangHoa();
            Refresh();

        }

        private void btn_xoaloaihang_Click(object sender, EventArgs e)
        {
            LOAIHANGHOA l = new LOAIHANGHOA();
            l.MALOAI_HH = txt_maloai.Text;
            l.TENLOAI_HH = txt_tenloai.Text;
            int kq = qlloai.xoa_loai(l);
            if (kq == 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa Thất Bại");
            Load_Grid_HangHoa();
            Refresh();
        }

        private void btn_sualoaihang_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_luuloaihang_Click(object sender, EventArgs e)
        {
            if (qlloai.sua_loai(txt_maloai.Text, txt_tenloai.Text))
            {
                MessageBox.Show("Lưu Thành Công!");
                Refresh();

            }
            else
                MessageBox.Show("Lưu Thất Bại!!!");
            Load_Grid_HangHoa();
        }
    }
}