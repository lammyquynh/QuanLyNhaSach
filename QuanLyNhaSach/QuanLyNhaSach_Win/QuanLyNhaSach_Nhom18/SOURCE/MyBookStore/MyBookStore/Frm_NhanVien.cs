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
using DevExpress.XtraGrid.Views.Grid;
using MyBookStore.QL_NHASACHDataSetTableAdapters;
namespace MyBookStore
{
    public partial class Frm_NhanVien : DevExpress.XtraEditors.XtraForm
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
        }
        BLL_NhanVien bllnv = new BLL_NhanVien();
        
        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NHASACH1.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_NHASACH1.NHANVIEN);
            gridNhanVien.DataSource = bllnv.LoadNV();
            //binding_NV();
            
        }
        public void binding_NV_Clear()
        {
            txt_manhanvien.DataBindings.Clear();
            txt_tennhanvien.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            txt_sodt.DataBindings.Clear();
            txt_matkhau.DataBindings.Clear();
            comboCV.Text = "";
            
        }
        public void binding_NV()
        {
            txt_manhanvien.DataBindings.Add("text", gridNhanVien.DataSource, "MANV");
            txt_tennhanvien.DataBindings.Add("text", gridNhanVien.DataSource, "TENNV");
            txt_matkhau.DataBindings.Add("text", gridNhanVien.DataSource, "MATKHAU");
            txt_diachi.DataBindings.Add("text", gridNhanVien.DataSource, "DIACHI_NV");
            txt_sodt.DataBindings.Add("text", gridNhanVien.DataSource, "SDT_NV");

            //comboCV.DataBindings.Add("text", bllnv.xuatNhomNguoiDung(txt_manhanvien.Text) ,"");
            DataTable cv;
            cv = bllnv.xuatNhomNguoiDung(txt_manhanvien.Text);
            comboCV.Text = cv.Rows[0][1].ToString();
        }
        private void btn_huynv_Click(object sender, EventArgs e)
        {
            binding_NV_Clear();
            btn_huynv.Enabled = false;
            btn_luunv.Enabled = false;
            btn_suanv.Enabled = true;
            txt_manhanvien.Text = txt_tennhanvien.Text = txt_diachi.Text = txt_sodt.Text = txt_matkhau.Text = "";
        }
        NHANVIENTableAdapter adtNV = new NHANVIENTableAdapter();
        public void refresh()
        {
            gridNhanVien.BeginUpdate();
            try
            {
                gridNhanVien.DataSource = null;
                gridNhanVien.DataSource = bllnv.LoadNV();
            }
            catch
            {
                gridNhanVien.EndUpdate();
            }
        }
        private void btn_themnv_Click(object sender, EventArgs e)
        {
            string manhom = bllnv.TimMaNhonNgDung(comboCV.Text).Rows[0][0].ToString();
            if (txt_manhanvien.Text != "" && txt_tennhanvien.Text != "" && txt_matkhau.Text != "" && txt_diachi.Text != "" && txt_sodt.Text != "")
            {
                int? kc = bllnv.KT_KhoaChinh(txt_manhanvien.Text);
                if (kc == 0)
                {
                                        
                    int kq = bllnv.ThemNV(txt_manhanvien.Text, txt_matkhau.Text, txt_tennhanvien.Text, txt_diachi.Text, txt_sodt.Text);
                    int pq = bllnv.ThemND_NND(txt_manhanvien.Text, manhom);
                    if (kq == 1&& pq ==1)
                    {
                        MessageBox.Show("Thêm Nhân Viên Thành Công");
                        gridNhanVien.DataSource = null;
                        gridNhanVien.DataSource = bllnv.LoadNV();
                    }
                    else
                        MessageBox.Show("Thêm Nhân Viên Thất Bại ");
                }
                else
                    MessageBox.Show("Kiểm Tra Trùng Khóa Chính");
            }
            else
            {
                MessageBox.Show("Yêu cầu nhập đủ thông tin trước khi thêm");
            }

        }

        private void gridControl1_CursorChanged(object sender, EventArgs e)
        {

            //GridView gridView = gridNhanVien.FocusedView as GridView;
            //object selectedRowData = gridView.GetRow(gridView.FocusedRowHandle);
        }

        private void gb_quanlynhanvien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vGridControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_suanv_Click(object sender, EventArgs e)
        {
            
            btn_huynv.Enabled = true;
            btn_luunv.Enabled = true;
            txt_manhanvien.ReadOnly = true;
        }

        private void gridNhanVien_Click(object sender, EventArgs e)
        {
            btn_suanv.Enabled = true;
        }
        public void refresh_grid()
        {
            gridNhanVien.DataSource = null;
            gridNhanVien.DataSource = bllnv.LoadNV();
        }
        private void btn_xoanv_Click(object sender, EventArgs e)
        {
            int pq = bllnv.Xoa_PQ(txt_manhanvien.Text);
            int kq = bllnv.Xoa_NV(txt_manhanvien.Text);
            
            if (kq == 1 && pq == 1)
            {
                MessageBox.Show("Xóa Nhân Viên Thành Công");
                gridNhanVien.DataSource = null;
                gridNhanVien.DataSource = bllnv.LoadNV();
            }
            else
            {
                MessageBox.Show("Xóa Nhân Viên Không Thành Công");
            }
        }

        private void btn_luunv_Click(object sender, EventArgs e)
        {
           int kq = bllnv.Capnhat_NhanVien(txt_manhanvien.Text, txt_matkhau.Text, txt_tennhanvien.Text, txt_diachi.Text, txt_sodt.Text);
           if (kq == 1)
           {  
                MessageBox.Show("Cập Nhập Nhân Viên Thành Công");
                gridNhanVien.DataSource = null;
                gridNhanVien.DataSource = bllnv.LoadNV();
           }
           else
           {
               MessageBox.Show("Cập Nhập Nhân Viên Không Thành Công");
           }
           btn_luunv.Enabled = false;
           btn_suanv.Enabled = true;
           btn_huynv.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txt_diachi.Text = txt_manhanvien.Text = txt_matkhau.Text = txt_sodt.Text = txt_tennhanvien.Text = "";
            btn_themnv.Enabled = true;
            btn_themmoi.Enabled = false;
        }

        
    }
}