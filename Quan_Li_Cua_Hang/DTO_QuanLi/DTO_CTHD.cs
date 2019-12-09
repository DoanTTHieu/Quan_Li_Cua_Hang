using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLi
{
    public class DTO_CTHD
    {
        private int mahd;
        private int mamon;
        private int solg;

        public int Mahd { get => mahd; set => mahd = value; }
        public int Mamon { get => mamon; set => mamon = value; }
        public int Solg { get => solg; set => solg = value; }

        public DTO_CTHD()
        {

        }
        public DTO_CTHD(int hd, int mm, int sl)
        {
            this.Mahd = hd;
            this.Mamon = mm;
            this.Solg = sl;
        }
    }
}
