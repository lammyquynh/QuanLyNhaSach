using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BLL_NhanVien
    {

        DAL_NhanVien dalNV = new DAL_NhanVien();
        
        //string User;
        public BLL_NhanVien()
        {
        }
        public DataTable LoadNV()
        {
            return dalNV.LNV();
        }
        public DataTable xuatTTNV(string s)
        {
            return dalNV.XuatTTNV(s);
        }
        public DataTable xuatNhomNguoiDung(string s)
        {
            string str = dalNV.LayNV_NhomNV(s).Rows[0][1].ToString();
            return dalNV.Lay_NhomNguoiDung(str);
        }
        public int CapNhat_TTNV(string nDiaChi,string nSDT, string manv)
        {
            return dalNV.CapNhat_TTNV(nDiaChi, nSDT, manv);
        }
        public int Capnhat_MatKhau(string manv, string matkhau)
        {
            return dalNV.Capnhat_MatKhau(manv, matkhau);
        }
        public int? KiemTra_MatKhau(string manv, string matkhau)
        {
            return dalNV.KiemTra_MatKhau(manv, matkhau);
        }
        public int? KT_KhoaChinh(string manv)
        {
            return dalNV.KT_KhoaChinh(manv);
        }
        public int ThemNV(string manv, string mk, string ten, string diachi, string sdt)
        {
            return dalNV.ThemNV(manv, mk, ten, diachi, sdt);
        }
        public int Capnhat_NhanVien(string manv, string mk, string ten, string diachi, string sdt)
        {
            return dalNV.Capnhat_NhanVien(manv,mk, ten, diachi, sdt);
        }
        public int Xoa_PQ(string s)
        {
            return dalNV.Xoa_PQ(s);
        }
        public int Xoa_NV(string s)
        {
            return dalNV.Xoa_NV(s);
        }
        public DataTable XuatNhomNgDung_ThemNV()
        {
            return dalNV.XuatNhomNgDung();
        }
        public DataTable TimMaNhonNgDung(string s)
        {
            return dalNV.TimMaNhonNgDung(s);
        }
        public int ThemND_NND(string manv, string man)
        {
            return dalNV.ThemND_NND(manv, man);
        }
    }
}
