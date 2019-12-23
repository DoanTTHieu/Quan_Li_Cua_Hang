using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLi;
using System.Data;
using DTO_QuanLi;
namespace BUS_QuanLi
{
    public class BUS_NhanVien
    {
        DAL_NhanVien ql = new DAL_NhanVien();
        public string DangNhap(string us, string pw)
        {
            return ql.DangNhap(us,pw);
        }
        public int TaoTaiKhoanNhanVien(string us, string pw1, string pw2, int cv, string mkql)
        {
            return ql.TaoTaiKhoanNhanVien(us, pw1, pw2,cv, mkql);
        }
        public int TaoTaiKhoanQuanLi(string us, string pw1, string pw2, int cv)
        {
            return ql.TaoTaiKhoanQuanLi(us, pw1, pw2, cv);
        }

        public int KiemTraTonTaiQuanLi()
        {
            return ql.KiemTraTonTaiQuanLi();
        }
        public string getMatKhauQuanLi()
        {
            return ql.getMatKhauQuanLi();
        }
    }
}
