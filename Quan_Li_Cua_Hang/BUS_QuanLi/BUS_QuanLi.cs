using DAL_QuanLi;
using DTO_QuanLi;
using DTO_QuanLi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLi
{
    public static class BUS_QuanLi
    {
        public delegate void LoadResult(List<DTO_MonAn> monAns);

        public static void LoadMon(PhanLoai phanLoai, LoadResult resultHandler)
        {
            try
            {
                new Task(() =>
                {
                    DAL_MonAn.StartService();
                    List<DTO_MonAn> monAns = DAL_MonAn.Instance.GetAllRecords(phanLoai);
                    resultHandler(monAns);
                }).Start();
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
