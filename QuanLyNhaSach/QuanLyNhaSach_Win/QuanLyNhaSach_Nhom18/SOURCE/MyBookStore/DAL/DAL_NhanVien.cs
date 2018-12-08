using DAL.QL_TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        NHANVIENTableAdapter adtNV = new NHANVIENTableAdapter();
        NHOMNGUOIDUNG_NVTableAdapter adtNV_NND = new NHOMNGUOIDUNG_NVTableAdapter();
        NHOMNGUOIDUNGTableAdapter datNND = new NHOMNGUOIDUNGTableAdapter();
        public DAL_NhanVien()
        {
        }
        public DataTable LNV()
        {
            return adtNV.GetData();
        }
        public DataTable XuatTTNV(string s)
        {
            return adtNV.XuatTTNV(s);
        }
        public DataTable LayNV_NhomNV(string s)
        {
            return adtNV_NND.lay_NhomNV(s);
        }
        public DataTable Lay_NhomNguoiDung(string str)
        {
            return datNND.lay_NHOMNGUOIDUNG(str);
        }
        public int CapNhat_TTNV(string nDiaChi,string nSDT, string manv )
        {
            return adtNV.CapNhat_TTNV(nDiaChi, nSDT, manv);
        }
        public int Capnhat_MatKhau(string manv, string matkhau)
        {
            return adtNV.DoiMK(matkhau,manv);
        }
        public int? KiemTra_MatKhau(string manv, string matkhau)
        {
            return adtNV.KiemTraMKCu(manv, matkhau);
        }
        public int? KT_KhoaChinh(string manv)
        {
            return adtNV.KiemTra_KhoaChinh(manv);
        }
        public int ThemNV(string manv, string mk, string ten, string diachi, string sdt )
        {
            return adtNV.ThemNV(manv,mk,ten,diachi,sdt);
        }

        public int Capnhat_NhanVien(string manv, string mk, string ten, string diachi, string sdt)
        {
            return adtNV.CapNhat_NhanVien(mk, ten, diachi, sdt, manv);
        }
        public int Xoa_PQ(string s)
        {
            return adtNV_NND.XoaPQ(s);
        }
        public int Xoa_NV(string s)
        {
            return adtNV.Xoa_nv(s);
        }
        public DataTable XuatNhomNgDung()
        {
            return datNND.GetData();
        }
        public DataTable TimMaNhonNgDung(string s)
        {
            return datNND.LayMaNhom(s);
        }
        public int ThemND_NND(string manv, string man)
        {
            return adtNV_NND.ThemNV_NND(manv,man);
        }
    }
}
