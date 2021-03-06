﻿using DTO_QuanLi;
using DTO_QuanLi.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using System.Runtime.CompilerServices;

namespace DAL_QuanLi
{
    public class DAL_MonAn : DBConnect
    {
        public static DAL_MonAn Instance { get; private set; }
        SqlConnection Connection;
        private void Dtb()
        {
            Connection = _conn;
            try
            {
                Connection.Open();
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
                SqlCommand myCmd = Connection.CreateCommand();
                myCmd.CommandText = "insert into QLCH.dbo.MONAN (tenmon, gia, phanloai, hinhanh) values (N'"+ma.Tenmon+"', @gia, @phanloai, @hinhanh)";
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


        public void UpdateInfo(DTO_MonAn ma, [CallerMemberName] string caller = null)
        {
            Console.WriteLine(caller);
            try
            {
                SqlCommand myCmd = Connection.CreateCommand();
                myCmd.CommandText = "update QLCH.dbo.MONAN set tenmon = N'"+ma.Tenmon+"', gia = @gia, phanloai = @phanloai, hinhanh = @hinhanh where mamon = @mamon";
                myCmd.Parameters.AddWithValue("@mamon", ma.Mamon);
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
                SqlCommand myCmd = Connection.CreateCommand();
                myCmd.CommandText = "delete from QLCH.dbo.MONAN where mamon = @mamon";
                myCmd.Parameters.AddWithValue("@mamon", i);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }
        public DAL_MonAn()
        {
            Dtb();
        }

        public static void StartService(bool forceRestart = false)
        {
            if (Instance == null || forceRestart)
            {
                Instance = new DAL_MonAn();
            }

        }
        public List<DTO_MonAn> GetAllRecords(PhanLoai phanLoai)
        {
            List<DTO_MonAn> result = new List<DTO_MonAn>();
            SqlDataReader reader = null;

            try
            {
                SqlCommand myCmd = Connection.CreateCommand();
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
                    }
                    catch (Exception e)
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
        //
        public DataTable LayMonAn(int loai)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from MONAN where phanloai=" + loai, _conn);
            DataTable dtMonAn = new DataTable();
            da.Fill(dtMonAn);
            return dtMonAn;
        }
    }
}
