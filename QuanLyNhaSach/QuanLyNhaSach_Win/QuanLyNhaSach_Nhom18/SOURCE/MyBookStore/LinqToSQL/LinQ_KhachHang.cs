using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL
{
    public class LinQ_KhachHang
    {
        QL_NSDataContext qlkh = new QL_NSDataContext();
        public Object LoadKH()
        {
            var khachhangs = from kh in qlkh.KHACHHANGs
                             join ma in qlkh.LOAIKHACHHANGs on kh.MALOAI_KH equals ma.MALOAI_KH
                             //join hd in qlkh.HOADONs on  kh.MAKH equals hd.MAKH
                             //group hd by hd.TONGTHANHTIEN into tt
                             select new {kh.MAKH,kh.TENKH, kh.MALOAI_KH, ma.TENLOAI_KH, kh.SDT_KH, kh.DIACHI_KH,ma.CHIETKHAU_KH,};
            return khachhangs;
        }
        public Object XuatTongHD(string s)
        {
            var khachhangs = from  hd in qlkh.HOADONs
                             where hd.MAKH.Equals(s)
                             group hd by hd.MAKH into kq
                             select new {TongThanhToan = kq.Sum(t => t.TONGTHANHTIEN) };
            return khachhangs;
        }
        public void ThemKH(string makh, string tenkh, string diachi, string sdt)
        {
            KHACHHANG kh = new KHACHHANG();
            kh.MAKH = makh;
            kh.TENKH = tenkh;
            kh.DIACHI_KH = diachi;
            kh.MALOAI_KH = "LK001";
            kh.SDT_KH = sdt;
            qlkh.KHACHHANGs.InsertOnSubmit(kh);
            qlkh.SubmitChanges();
        }
        public bool khoangoai_KH_HD(string makh)
        {
            HOADON hd = qlkh.HOADONs.Where(t => t.MAKH == makh).FirstOrDefault();
            if (hd != null)
            {
                return false;
            }
            else
                return true;
        }
        public bool XoaKH(string makh)
        {
            if (khoangoai_KH_HD(makh))
            {
                KHACHHANG kh = qlkh.KHACHHANGs.Where(t => t.MAKH == makh).FirstOrDefault();
                qlkh.KHACHHANGs.DeleteOnSubmit(kh);
                qlkh.SubmitChanges();
                return true;
            }
            else
                return false;
        }
        public bool Sua_KH(string makh, string tenkh, string diachi, string sdt)
        {
            KHACHHANG kh = qlkh.KHACHHANGs.Where(t => t.MAKH == makh).FirstOrDefault();
            kh.TENKH = tenkh; kh.DIACHI_KH = diachi; kh.SDT_KH = sdt;
            qlkh.SubmitChanges();
            return true;
        }

        
    }
}
