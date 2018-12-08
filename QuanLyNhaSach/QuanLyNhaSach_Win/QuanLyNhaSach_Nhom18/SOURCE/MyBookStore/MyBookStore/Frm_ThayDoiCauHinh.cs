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

namespace MyBookStore
{
    public partial class Frm_ThayDoiCauHinh : DevExpress.XtraEditors.XtraForm
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung(); 
        public Frm_ThayDoiCauHinh()
        {
            InitializeComponent();
        }

        private void cb_ServerName_DropDown(object sender, EventArgs e)
        {
            DataTable dt = CauHinh.GetServerName();
            cb_ServerName.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
               cb_ServerName.Items.Add(row.ItemArray[0].ToString() + "//" +row.ItemArray[1].ToString());
            }

        }
        private void cboDataBase_DropDown(object sender, EventArgs e)
        {
            if (CheckedBeforSearchNameDB())
            {
                Combo_database.Items.Clear();
                List<string> _list = CauHinh.GetDatabaseName(cb_ServerName.Text, txt_Username.Text, txt_Password.Text);
                if (_list == null)
                {
                    MessageBox.Show("Thông tin cấu hình chưa chính xác");
                    return;
                }
                foreach (string item in _list)
                {
                    Combo_database.Items.Add(item);
                }
            }
        }

        private bool CheckedBeforSearchNameDB()
        {
            if (cb_ServerName.Text != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}