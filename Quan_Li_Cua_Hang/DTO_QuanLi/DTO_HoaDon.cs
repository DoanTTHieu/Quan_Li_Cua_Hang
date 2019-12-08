using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLi
{
    class DTO_HoaDon
    {
        private int mahd;
        private DateTime ngayhd;
        private float trigia;
        private int trangthai;

        public int Mahd { get => mahd; set => mahd = value; }
        public DateTime Ngayhd { get => ngayhd; set => ngayhd = value; }
        public float Trigia { get => trigia; set => trigia = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }

        public DTO_HoaDon()
        {

        }
        public DTO_HoaDon(int ma, DateTime ngay, float gia, int t_thai)
        {
            this.Mahd = ma;
            this.Ngayhd = ngay;
            this.Trigia = gia;
            this.Trangthai = t_thai;
        }
        public DTO_HoaDon(DateTime ngay, float gia, int t_thai)
        {
            this.Ngayhd = ngay;
            this.Trigia = gia;
            this.Trangthai = t_thai;
        }

    }
}
