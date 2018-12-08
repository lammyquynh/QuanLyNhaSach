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
    public partial class Frm_KhuyenMai : DevExpress.XtraEditors.XtraForm
    {
        LinQ_KM qlkm = new LinQ_KM();
        public Frm_KhuyenMai()
        {
            InitializeComponent();
        }

        private void Frm_KhuyenMai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NHASACH.KHUYENMAI' table. You can move, or remove it, as needed.
            this.kHUYENMAITableAdapter.Fill(this.qL_NHASACH.KHUYENMAI);
            Load_Grid_KM();
            binding_KM();
        }
        public void Load_Grid_KM()
        {
            grid_khuyenmai.DataSource = qlkm.load_KM();
        }
        public void binding_KM()
        {
            txt_makhuyenmai.DataBindings.Add("text", grid_khuyenmai.DataSource, "MAKHUYENMAI");
            txt_tenkhuyenmai.DataBindings.Add("text", grid_khuyenmai.DataSource, "TENKHUYENMAI");
            txt_tilegiamgia.DataBindings.Add("text", grid_khuyenmai.DataSource, "TILEGIAMGIA");
           


        }
        public bool check_empty()
        {
            if (txt_makhuyenmai.Text != "" && txt_tenkhuyenmai.Text != "" && txt_tilegiamgia.Text != "")
                return true;
            else
                return false;
        }
        private void btn_themkm_Click(object sender, EventArgs e)
        {
            KHUYENMAI m = new KHUYENMAI();
            m.MAKHUYENMAI= txt_makhuyenmai.Text;
            m.TENKHUYENMAI = txt_tenkhuyenmai.Text;
            m.TILEGIAMGIA = float.Parse(txt_tilegiamgia.Text);
            try
            {
                if (check_empty())
                {
                    qlkm.them_km(m);
                    MessageBox.Show("Thêm Khuyến Mãi THÀNH CÔNG");
                }
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin Khuyến Mãi trước khi thêm!");
                    Refresh();
                }
            }
            catch
            {
                MessageBox.Show("Thêm Khuyến Mãi thất bại");
            }
            Load_Grid_KM();
            Refresh();
        }

        private void btn_xoakm_Click(object sender, EventArgs e)
        {
            KHUYENMAI m = new KHUYENMAI();
            m.MAKHUYENMAI = txt_makhuyenmai.Text;
            m.TENKHUYENMAI = txt_tenkhuyenmai.Text;
            m.TILEGIAMGIA = float.Parse(txt_tilegiamgia.Text);
        
            int kq = qlkm.xoa_km(m);
            if (kq == 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa Thất Bại");
            Load_Grid_KM();
            Refresh();
        }

        private void btn_suakm_Click(object sender, EventArgs e)
        {
            if (qlkm.sua_km(txt_makhuyenmai.Text, txt_tenkhuyenmai. Text,float.Parse(txt_tilegiamgia.Text)))
            {
                MessageBox.Show("Lưu Thành Công!");
                Refresh();

            }
            else
                MessageBox.Show("Lưu Thất Bại!!!");
        }

        private void btn_luukm_Click(object sender, EventArgs e)
        {

        }

        private void btn_huykm_Click(object sender, EventArgs e)
        {

        }
    }
}