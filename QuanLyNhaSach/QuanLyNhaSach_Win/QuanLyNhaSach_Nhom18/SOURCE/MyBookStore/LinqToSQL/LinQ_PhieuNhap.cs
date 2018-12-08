using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL
{
    public class LinQ_PhieuNhap
    {
        QL_NSDataContext qlpn = new QL_NSDataContext();
        public bool KhoaChinh_HD(string mapn)
        {
            PHIEUNHAP hd = qlpn.PHIEUNHAPs.Where(t => t.MAPG == mapn).FirstOrDefault();
            if (hd != null)
            {
                return false;
            }
            else
                return true;
        }
        public bool Them_PN(string mapn, string manv, string tt)
        {
            try
            {
                PHIEUNHAP hd = new PHIEUNHAP();
                hd.MAPG = mapn;
                hd.MANV = manv;
                hd.MANCC = null;
                hd.NGAYNHAP = DateTime.Now;
                hd.TONGTHANHTIEN_NHAP = null;
                qlpn.PHIEUNHAPs.InsertOnSubmit(hd);
                qlpn.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Them_CTPN(string mahh, string mapn, int sl,double dg )
        {
            try
            {
                CT_PHIEUNHAP ct = new CT_PHIEUNHAP();
                ct.MAHH = mahh;
                ct.MAPG = mapn;
                ct.SOLUONG_NHAP = sl;
                ct.DONGIA_NHAP = dg;
                qlpn.CT_PHIEUNHAPs.InsertOnSubmit(ct);
                qlpn.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Object Load_CTPN(string s)
        {
            
            var cthd = from ct in qlpn.CT_PHIEUNHAPs
                       where ct.MAPG.Equals(s)
                       select ct;
                return cthd;
        
        }
    }
}
