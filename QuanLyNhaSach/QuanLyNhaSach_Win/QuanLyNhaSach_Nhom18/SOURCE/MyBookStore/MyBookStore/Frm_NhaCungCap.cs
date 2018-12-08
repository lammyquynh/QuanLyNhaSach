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
    public partial class Frm_NhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        LinQ_NCC qlncc = new LinQ_NCC();
        public Frm_NhaCungCap()
        {
            InitializeComponent();
        }

        private void Frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NHASACH.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.qL_NHASACH.NHACUNGCAP);
            Load_Grid_NCC();
            binding_NCC();
            
        }
        public void Load_Grid_NCC()
        {
            grid_nhacungcap.DataSource = qlncc.load_NCC();
        }
        public void binding_NCC()
        {
            txt_mancc.DataBindings.Add("text", grid_nhacungcap.DataSource, "MANCC");
            txt_tenncc.DataBindings.Add("text", grid_nhacungcap.DataSource, "TENNCC");
            txt_diachi.DataBindings.Add("text", grid_nhacungcap.DataSource, "DIACHI_NCC");
            txt_sdt.DataBindings.Add("text", grid_nhacungcap.DataSource, "SDT_NCC");


        }
        public bool check_empty()
        {
            if (txt_mancc.Text != "" && txt_tenncc.Text != "" && txt_diachi.Text != "" && txt_sdt.Text != "")
                return true;
            else
                return false;
        }
        private void btn_themncc_Click(object sender, EventArgs e)
        {
            NHACUNGCAP c = new NHACUNGCAP();
            c.MANCC = txt_mancc.Text;
            c.TENNCC = txt_tenncc.Text;
            c.DIACHI_NCC = txt_diachi.Text;
            c.SDT_NCC = txt_sdt.Text;
            try
            {
                if (check_empty())
                {
                    qlncc.them_ncc(c);
                    MessageBox.Show("Thêm Nhà Cung Cấp THÀNH CÔNG");
                }
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin Nhà Cung Cấp trước khi thêm!");
                    Refresh();
                }
            }
            catch
            {
                MessageBox.Show("Thêm Nhà Cung Cấp thất bại");
            }
            Load_Grid_NCC();
            Refresh();
        }

        private void btn_xoancc_Click(object sender, EventArgs e)
        {
            NHACUNGCAP c = new NHACUNGCAP();
            c.MANCC = txt_mancc.Text;
            c.TENNCC = txt_tenncc.Text;
            c.DIACHI_NCC = txt_diachi.Text;
            c.SDT_NCC = txt_sdt.Text;
            int kq = qlncc.xoa_ncc(c);
            if (kq == 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa Thất Bại");
            Load_Grid_NCC();
            Refresh();
        }
    }
}