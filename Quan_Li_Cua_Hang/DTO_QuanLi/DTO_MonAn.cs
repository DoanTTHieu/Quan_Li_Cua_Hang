using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLi
{
    public class DTO_MonAn
    {
        private int mamon;
        private string tenmon;
        private float gia;
        private int phanloai;
        private string hinhanh;

        public int Mamon { get => mamon; set => mamon = value; }
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public float Gia { get => gia; set => gia = value; }
        public int Phanloai { get => phanloai; set => phanloai = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }

        public DTO_MonAn()
        {

        }
        public DTO_MonAn(int ma, string ten, float gia, int loai, string anh)
        {
            this.Mamon = ma;
            this.Tenmon = ten;
            this.Gia = gia;
            this.Phanloai = loai;
            this.Hinhanh = anh;

        }
        public DTO_MonAn(string ten, float gia, int loai, string anh)
        {
            this.Tenmon = ten;
            this.Gia = gia;
            this.Phanloai = loai;
            this.Hinhanh = anh;
        }
    }
}
