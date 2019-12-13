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
    public class BUS_HoaDon
    {
        DAL_HoaDon hd = new DAL_HoaDon();
        public int LayIDHoaDon()
        {
            return hd.LayIDHoaDon();
        }
        public void TaoHoaDon()
        {
            hd.TaoHoaDon();
        }
        public void HuyHoaDon(int tam)
        {
            hd.HuyHoaDon(tam);
        }
        public void ResetMaHoaDon(int tam)
        {
            hd.ResetMaHoaDon(tam);
        }
        public void CapNhatTrangThai(int tam)
        {
            hd.CapNhatTrangThai(tam);
        }
        public void CapNhatHoaDon(float tien,int tam)
        {
            hd.CapNhatHoaDon(tien,tam);
        }
    }
}
