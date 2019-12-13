using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DTO_QuanLi;
using GUI_QuanLi.Utils;

namespace GUI_QuanLi
{
    public class MD
    {
        public static MD Instance { get; private set; }
        String connectStr = @"Data Source=localhost;Initial Catalog=master;Integrated Security=True";
        SqlConnection NganConnection;
        private void Dtb()
        {
            NganConnection = new SqlConnection(connectStr);
            try
            {
                NganConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }


        public void AddInfo(DTO_MonAn ma)
        {
            try
            {
                SqlCommand myCmd = NganConnection.CreateCommand();
                myCmd.CommandText = "insert into QLCH.dbo.MONAN (tenmon, gia, phanloai, hinhanh) values (@tenmon, @gia, @phanloai, @hinhanh)";
                myCmd.Parameters.AddWithValue("@tenmon", ma.Tenmon);
                myCmd.Parameters.AddWithValue("@gia", ma.Gia);
                myCmd.Parameters.AddWithValue("@phanloai", ma.Phanloai);
                myCmd.Parameters.AddWithValue("@hinhanh", ma.Hinhanh);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void DeleteInfo(int i)
        {
            try
            {
                SqlCommand myCmd = NganConnection.CreateCommand();
                myCmd.CommandText = "delete from QLCH.dbo.MONAN where mamon = @mamon";
                myCmd.Parameters.AddWithValue("@mamon", i);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }
        private MD()
        {
            Dtb();
        }

        public static void StartService(bool forceRestart = false)
        {
            if (Instance == null || forceRestart)
            {
                Instance = new MD();
            }

        }
        public List<DTO_MonAn> GetAllRecords(PhanLoai phanLoai)
        {
            List<DTO_MonAn> result = new List<DTO_MonAn>();
            SqlDataReader reader = null;

            try
            {
                SqlCommand myCmd = NganConnection.CreateCommand();
                myCmd.CommandText = "select * from QLCH.dbo.MONAN Where phanloai = @phanloai";
                myCmd.Parameters.AddWithValue("@phanloai", (int)phanLoai);
                reader = myCmd.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        DTO_MonAn monan = new DTO_MonAn();

                        monan.Mamon = (int)reader["mamon"];
                        monan.Tenmon = reader["tenmon"] as string;
                        monan.Gia = float.Parse(reader["gia"].ToString());
                        monan.Phanloai = (int)reader["phanloai"];
                        monan.Hinhanh = reader["hinhanh"] as string;

                        result.Add(monan);
                    } catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }

            return result;
        }
    }
}
