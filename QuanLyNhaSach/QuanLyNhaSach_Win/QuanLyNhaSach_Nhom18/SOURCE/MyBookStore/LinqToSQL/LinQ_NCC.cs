using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL
{
    public class LinQ_NCC
    {
        QL_NSDataContext qlncc = new QL_NSDataContext();
        public List<NHACUNGCAP> load_NCC()
        {
            return qlncc.NHACUNGCAPs.Select(t => t).ToList<NHACUNGCAP>();
        }

        public int KT_NCC(string mancc)
        {
            NHACUNGCAP c = qlncc.NHACUNGCAPs.Where(t => t.MANCC == mancc).FirstOrDefault();
            if (c != null)
            {
                return 1;
            }
            return 0;
        }

        public void them_ncc(NHACUNGCAP c)
        {
            qlncc.NHACUNGCAPs.InsertOnSubmit(c);
            qlncc.SubmitChanges();

        }

        public int xoa_ncc(NHACUNGCAP c)
        {
            try
            {
                int kq_kt = KT_NCC(c.MANCC);
                if (kq_kt == 1)
                {
                    NHACUNGCAP cungcap = qlncc.NHACUNGCAPs.Where(t => t.MANCC == c.MANCC).FirstOrDefault();
                    qlncc.NHACUNGCAPs.DeleteOnSubmit(cungcap);
                    qlncc.SubmitChanges();
                    return 1; //xóa thành công
                }

                return 0; // xóa không thành công

            }
            catch (Exception ex)
            {
                return 2; // lỗi
            }
        }

        public bool sua_ncc(string mancc, string tenncc, string diachi, string sdt)
        {
            NHACUNGCAP c = qlncc.NHACUNGCAPs.Where(t => t.MANCC == mancc).FirstOrDefault();
            if (c != null)
            {

                c.MANCC = mancc;
                c.TENNCC = tenncc;
                c.DIACHI_NCC = diachi;
                c.SDT_NCC = sdt;
                qlncc.SubmitChanges();
                return true;
            }
            return false;

        }

    }
}
