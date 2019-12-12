using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace GUI_QuanLi
{
    public class MonAn
    {
        public string mamon;
        public string tenmon;
        public int gia;
        public int phanloai;
        public string hinhanh;
    }


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


        public void AddInfo(MonAn ma)
        {
            try
            {
                SqlCommand myCmd = NganConnection.CreateCommand();
                myCmd.CommandText = "insert into QLCH.dbo.MONAN (tenmon, gia, phanloai, hinhanh) values (@tenmon, @gia, @phanloai, @hinhanh)";
                myCmd.Parameters.AddWithValue("@tenmon", ma.tenmon);
                myCmd.Parameters.AddWithValue("@gia", ma.gia);
                myCmd.Parameters.AddWithValue("@phanloai", ma.phanloai);
                myCmd.Parameters.AddWithValue("@hinhanh", ma.hinhanh);
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
        public List<MonAn> GetAllRecords()
        {
            List<MonAn> result = new List<MonAn>();
            SqlDataReader reader = null;

            try
            {
                SqlCommand myCmd = NganConnection.CreateCommand();
                myCmd.CommandText = "select * from QLSV.dbo.SV";

                reader = myCmd.ExecuteReader();
                while (reader.Read())
                {
                    MonAn monan = new MonAn()
                    {
                        mamon = reader["monan"] as string,
                        tenmon = reader["tenmon"] as string,
                        gia = (int)reader["gia"],
                        phanloai = (int)reader["gia"],
                        hinhanh = reader["hinhanh"] as string
                    };

                    result.Add(monan);
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
