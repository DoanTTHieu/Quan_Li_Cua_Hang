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
    }
}
