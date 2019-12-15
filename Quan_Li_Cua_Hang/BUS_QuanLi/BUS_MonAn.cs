using BUS_QuanLi.Utils;
using DAL_QuanLi;
using DTO_QuanLi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLi
{
    public static class BUS_MonAn
    {
        public static void DeleteTSLCKKCKLDLKCKKDLCKLKLCKLD(DTO_MonAn data)
        {
            try
            {
                new Task(() => 
                {
                    DAL_MonAn.StartService();
                    DAL_MonAn.Instance.DeleteInfo(data.Mamon);
                }).Start();
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void UpdateLKKLKLCDKLCKLCKLCD(DTO_MonAn data)
        {
            try
            {
                new Task(() =>
                {
                    DAL_MonAn.StartService();
                    data.Hinhanh = ResourceUtil.CopyToResource(data.Hinhanh);
                    //Code DAL UPDATE VAO DAY
                }).Start();
            } catch (Exception e)
            {
                Console.WriteLine(e);
            } 
        }

        public static void AddNewIOKLLKKLKLMKLMMKLMKL(DTO_MonAn data)
        {
            try
            {
                new Task(() =>
                {
                    DAL_MonAn.StartService();
                    data.Hinhanh = ResourceUtil.CopyToResource(data.Hinhanh);
                    DAL_MonAn.Instance.AddInfo(data);
                }).Start();
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
