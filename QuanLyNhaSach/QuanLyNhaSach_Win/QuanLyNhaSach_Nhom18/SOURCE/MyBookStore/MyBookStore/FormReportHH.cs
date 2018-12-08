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
    public partial class FormReportHH : Form
    {
       // Frm_LapHoaDon l = new Frm_LapHoaDon();
        public FormReportHH()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            rptHD rpt = new rptHD();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            //rpt.SetParameterValue("LocHH", txt_mahd.Text);
            
        }
    }
}
