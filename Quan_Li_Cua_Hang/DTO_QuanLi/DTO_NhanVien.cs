using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLi
{
    class DTO_NhanVien
    {
        private int id;
        private string tennv;
        private string sodt;
        private DateTime ngsinh;
        private string cmnd;
        private DateTime ngbdau;
        private string dangnhap;
        private string pass;
        private int chucvu;

        public int Id { get => id; set => id = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Sodt { get => sodt; set => sodt = value; }
        public DateTime Ngsinh { get => ngsinh; set => ngsinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public DateTime Ngbdau { get => ngbdau; set => ngbdau = value; }
        public string Dangnhap { get => dangnhap; set => dangnhap = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Chucvu { get => chucvu; set => chucvu = value; }

        public DTO_NhanVien()
        {

        }
        public DTO_NhanVien(int id, string ten, string sdt, DateTime ngsinh, string cmnd, DateTime ngvl, string dn, string pass, int chucvu)
        {
            this.Id = id;
            this.Tennv = ten;
            this.Sodt = sdt;
            this.Ngsinh = ngsinh;
            this.Cmnd = cmnd;
            this.Ngbdau = ngvl;
            this.Dangnhap = dn;
            this.Pass = pass;
            this.Chucvu = chucvu;
        }
        public DTO_NhanVien(string dn, string pass, int chucvu)
        {
            this.Dangnhap = dn;
            this.Pass = pass;
            this.Chucvu = chucvu;

        }


    }
}
