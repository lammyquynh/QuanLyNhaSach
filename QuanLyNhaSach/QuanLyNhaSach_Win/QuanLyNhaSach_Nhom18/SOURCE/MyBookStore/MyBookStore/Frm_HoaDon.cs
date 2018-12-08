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
    public partial class Frm_HoaDon : DevExpress.XtraEditors.XtraForm
    {
        public Frm_HoaDon()
        {
            InitializeComponent();
        }

        private void Frm_HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_NHASACH.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.qL_NHASACH.HOADON);
            // TODO: This line of code loads data into the 'qL_NHASACH.HANGHOA' table. You can move, or remove it, as needed.
            this.hANGHOATableAdapter.Fill(this.qL_NHASACH.HANGHOA);

        }
    }
}