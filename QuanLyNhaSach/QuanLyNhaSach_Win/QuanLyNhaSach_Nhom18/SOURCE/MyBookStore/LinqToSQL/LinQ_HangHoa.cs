using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL
{
    public class LinQ_HangHoa
    {
        QL_NSDataContext qlhh = new QL_NSDataContext();
       
        public List<HANGHOA> load_HangHoa()
        {
            return qlhh.HANGHOAs.Select(t => t).ToList<HANGHOA>();
        }
        
        public int KT_HangHoa(string mahh)
        {
            HANGHOA h = qlhh.HANGHOAs.Where(t => t.MAHH == mahh).FirstOrDefault();
            if (h != null) 
            {
                return 1;
            }
            return 0;
        }

        public void them_hanghoa(string mahh, string maloai, string makm, string tenhh, int sl, double gt,string nd)
        {
            HANGHOA h = new HANGHOA();
            h.MAHH = mahh;
            h.MALOAI_HH = maloai;
            h.MAKHUYENMAI = makm;
            h.TENHH = tenhh;
            h.SOLUONGTON = sl;
            h.GIATIEN = gt;
            h.NOIDUNG = nd;
        
            qlhh.HANGHOAs.InsertOnSubmit(h);

            qlhh.SubmitChanges();
        }

        public int xoa_hanghoa(HANGHOA h)
        {
            try
            {
                int kq_kt = KT_HangHoa(h.MAHH);
                if (kq_kt == 1)
                {
                    HANGHOA hang = qlhh.HANGHOAs.Where(t => t.MAHH == h.MAHH).FirstOrDefault();
                    qlhh.HANGHOAs.DeleteOnSubmit(hang);
                    qlhh.SubmitChanges();      
                    return 1; //xóa thành công
                }

                return 0; // xóa không thành công

            }
            catch (Exception ex)
            {
                return 2; // lỗi
            }
        }

        public bool sua_hanghoa(string mahh, string maloaihh,string makm, string tenhh, int soluong, float giatien, string noidung)
        {
            HANGHOA h = qlhh.HANGHOAs.Where(t => t.MAHH == mahh).FirstOrDefault();
            if (h != null)
            {
                
                h.MAKHUYENMAI = makm; 
                h.TENHH = tenhh;
                h.SOLUONGTON = soluong;
                h.GIATIEN = giatien;
                h.NOIDUNG = noidung;
                qlhh.SubmitChanges();
                return true;
            }
            return false;
            
        }


    }
}
