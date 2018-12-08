using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL
{
    public class LinQ_TheLoaiHangHoa
    {
        QL_NSDataContext qlloai = new QL_NSDataContext();
        public List<LOAIHANGHOA> load_LoaiHangHoa()
        {
            return qlloai.LOAIHANGHOAs.Select(t => t).ToList<LOAIHANGHOA>();
        }

        public int KT_loai(string maloai)
        {
            LOAIHANGHOA l = qlloai.LOAIHANGHOAs.Where(t => t.MALOAI_HH == maloai).FirstOrDefault();
            if (l != null)
            {
                return 1;
            }
            return 0;
        }

        public void them_loai(LOAIHANGHOA l)
        {
            qlloai.LOAIHANGHOAs.InsertOnSubmit(l);
            qlloai.SubmitChanges();

        }

        public int xoa_loai(LOAIHANGHOA l)
        {
            try
            {
                int kq_kt = KT_loai(l.MALOAI_HH);
                if (kq_kt == 1)
                {
                    LOAIHANGHOA loai = qlloai.LOAIHANGHOAs.Where(t => t.MALOAI_HH == l.MALOAI_HH).FirstOrDefault();
                    qlloai.LOAIHANGHOAs.DeleteOnSubmit(loai);
                    qlloai.SubmitChanges();
                    return 1; //xóa thành công
                }

                return 0; // xóa không thành công

            }
            catch (Exception ex)
            {
                return 2; // lỗi
            }
        }

        public bool sua_loai(string maloai, string tenloai)
        {
            LOAIHANGHOA l = qlloai.LOAIHANGHOAs.Where(t => t.MALOAI_HH == maloai).FirstOrDefault();
            if (l != null)
            {

                l.MALOAI_HH = maloai;
                l.TENLOAI_HH = tenloai;
                qlloai.SubmitChanges();
                return true;
            }
            return false;

        }


    }
}
