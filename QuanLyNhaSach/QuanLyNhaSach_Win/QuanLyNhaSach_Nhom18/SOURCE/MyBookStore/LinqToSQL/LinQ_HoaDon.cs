using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL
{
    public class LinQ_HoaDon
    {
        QL_NSDataContext qlhd  = new QL_NSDataContext();
        public LinQ_HoaDon()
        {
        }
        public Object Load_CTHD(string s)
        {
            var cthd = from ct in qlhd.CT_HOADONs
                       where ct.MAHD.Equals(s)
                       select new { ct.MAHD, ct.MAHH, ct.HANGHOA, ct.DONGIA_BAN };
                return cthd;
        }
        public bool KhoaChinh_HD(string mahd)
        {
            HOADON hd = qlhd.HOADONs.Where(t => t.MAHD == mahd).FirstOrDefault();
            if (hd != null)
            {
                return false;
            }
            else
                return true;
        }
        public bool Them_HD(string mahd,string manv,string makh,string tt)
        {
            try
            {
                HOADON hd = new HOADON();
                hd.MAHD = mahd;
                hd.MANV = manv;
                hd.MAKH = makh;
                hd.NGAYLAP = DateTime.Now;
                hd.TONGTHANHTIEN = null;
                qlhd.HOADONs.InsertOnSubmit(hd);
                qlhd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public HANGHOA Tim_SP(string masp)
        {
            HANGHOA hh = qlhd.HANGHOAs.Where(t => t.MAHH == masp).FirstOrDefault();
            return hh;      
        }
        public bool Them_CT(string mahd,string mahh,int sl,double dongia)
        {
            try
            {
                CT_HOADON ct = new CT_HOADON();
                ct.MAHD = mahd;
                ct.MAHH = mahh;
                ct.SOLUONG_BAN = sl;
                ct.DONGIA_BAN = dongia;
                qlhd.CT_HOADONs.InsertOnSubmit(ct);
                qlhd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
           
        }
        public bool LapHD(string MAHD,Double tt)
        {
            QL_NSDataContext qlkh = new QL_NSDataContext();
            try
            {
                HOADON hh = qlhd.HOADONs.Where(t => t.MAHD == MAHD).FirstOrDefault();
                hh.TONGTHANHTIEN = tt;
                qlhd.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
