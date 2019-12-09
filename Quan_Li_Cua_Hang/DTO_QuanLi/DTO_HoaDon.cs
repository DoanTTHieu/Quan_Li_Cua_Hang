using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLi
{
    public class DTO_HoaDon
    {
        private int mahd;
        private DateTime ngayhd;
        private float trigia;
        private int trangthai;
        private int soban;

        public int Mahd { get => mahd; set => mahd = value; }
        public DateTime Ngayhd { get => ngayhd; set => ngayhd = value; }
        public float Trigia { get => trigia; set => trigia = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
        public int Soban { get => soban; set => soban = value; }

        public DTO_HoaDon()
        {

        }
        public DTO_HoaDon(int ma, DateTime ngay, float gia, int t_thai,int s_ban)
        {
            this.Mahd = ma;
            this.Ngayhd = ngay;
            this.Trigia = gia;
            this.Trangthai = t_thai;
            this.Soban = s_ban;
        }
        public DTO_HoaDon(DateTime ngay, float gia, int t_thai,int s_ban)
        {
            this.Ngayhd = ngay;
            this.Trigia = gia;
            this.Trangthai = t_thai;
            this.Soban = s_ban;
        }

    }
}
