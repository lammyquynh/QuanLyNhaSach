using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBookStore
{
    public partial class Frm_login : DevExpress.XtraEditors.XtraForm
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung(); 
        public Frm_login()
        {
            InitializeComponent();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_User.Text.Trim()))

            {
                MessageBox.Show("Không được bỏ trống" + lbl_Username.Text.ToLower());
                this.txt_User.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txt_Password.Text))

            {
                MessageBox.Show("Không được bỏ trống" + lbl_Password.Text.ToLower());
                this.txt_Password.Focus();
                return;
            }

            if (CauHinh.Check_Config() == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
                
            }

            if (CauHinh.Check_Config() == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                //ProcessConfig();
                Frm_ThayDoiCauHinh ch = new Frm_ThayDoiCauHinh();
                ch.Show();
                
            }
            if (CauHinh.Check_Config() == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                //ProcessConfig();
                Frm_ThayDoiCauHinh ch = new Frm_ThayDoiCauHinh();
                ch.Show();
            }
       }
        public void ProcessLogin()
        {
            int result;
            result = CauHinh.Check_User(txt_User.Text, txt_Password.Text);
            // Wrong username or pass
            if (result == 0)
            {
                MessageBox.Show("Sai " + lbl_Username.Text + " Hoặc " + lbl_Password.Text);
                return;
            }
            // Account had been disabled
            else if (result == -1)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            //if (Form_Main == null || Form_Main.IsDisposed)
            else
            {
                string s = CauHinh.User;
                RibbonForm1 fm = new RibbonForm1(s);
                fm.Show();
            }
            this.Visible = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
        }
        }
    }

