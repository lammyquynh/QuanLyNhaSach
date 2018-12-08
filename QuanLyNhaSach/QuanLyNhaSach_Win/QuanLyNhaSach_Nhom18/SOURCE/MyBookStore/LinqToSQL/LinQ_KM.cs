using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL
{
    public class LinQ_KM
    {
        QL_NSDataContext qlkm = new QL_NSDataContext();
        public List<KHUYENMAI> load_KM()
        {
            return qlkm.KHUYENMAIs.Select(t => t).ToList<KHUYENMAI>();
        }

        public int KT_KM(string makm)
        {
            KHUYENMAI m = qlkm.KHUYENMAIs.Where(t => t.MAKHUYENMAI == makm).FirstOrDefault();
            if (m != null)
            {
                return 1;
            }
            return 0;
        }

        public void them_km(KHUYENMAI m)
        {
            qlkm.KHUYENMAIs.InsertOnSubmit(m);
            qlkm.SubmitChanges();

        }

        public int xoa_km(KHUYENMAI m)
        {
            try
            {
                int kq_kt = KT_KM(m.MAKHUYENMAI);
                if (kq_kt == 1)
                {
                    KHUYENMAI km = qlkm.KHUYENMAIs.Where(t => t.MAKHUYENMAI == m.MAKHUYENMAI).FirstOrDefault();
                    qlkm.KHUYENMAIs.DeleteOnSubmit(km);
                    qlkm.SubmitChanges();
                    return 1; //xóa thành công
                }

                return 0; // xóa không thành công

            }
            catch (Exception ex)
            {
                return 2; // lỗi
            }
        }

        public bool sua_km(string makm, string tenkm, float tile)
        {
            KHUYENMAI m = qlkm.KHUYENMAIs.Where(t => t.MAKHUYENMAI == makm).FirstOrDefault();
            if (m != null)
            {

                m.MAKHUYENMAI = makm;
                m.TENKHUYENMAI = tenkm;
                m.TILEGIAMGIA = tile;
             
                qlkm.SubmitChanges();
                return true;
            }
            return false;

        }
    }
}
