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
    public class BUS_CTHD
    {
        DAL_CTHD ct = new DAL_CTHD();
        public int LaySLMonAn(int mahd,int mamon)
        {
            return ct.LaySLMonAn(mahd, mamon);
        }
        public void TaoCTHD(int mahd, int mamon,string tenmon,float gia, int sl)
        {
            ct.TaoCTHD(mahd, mamon,tenmon,gia, sl);
        }
        public void CapNhatCTHD(int mahd, int mamon, int sl)
        {
            ct.CapNhatCTHD(mahd, mamon, sl);
        }
        public void XoaCTHD(int mahd, int mamon)
        {
            ct.XoaCTHD(mahd, mamon);
        }
        public void xoaCTHDver2(int mahd)
        {
            ct.XoaCTHDver2(mahd);
        }
        public DataTable LayCTHD(int mahd)
        {
            return ct.LayCTHD(mahd);
        }
        public DataTable LayMaMonCTHD(int mahd)
        {
            return ct.LayMaMonCTHD(mahd);
        }
    }
}
