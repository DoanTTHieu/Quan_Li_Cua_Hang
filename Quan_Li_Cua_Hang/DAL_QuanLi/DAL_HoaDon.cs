using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLi;
using System.Data.Common;

namespace DAL_QuanLi
{
    public class DAL_HoaDon : DBConnect
    {
        public int LayIDHoaDon()
        {
            int idtam = 0;
            _conn.Open();
            string sql = "select max(mahd) from HOADON";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (Convert.IsDBNull(reader.GetValue(0)) == true)
                        {
                            idtam = 0;
                        }
                        else
                        {
                            idtam = Convert.ToInt32(reader.GetValue(0));
                        }
                    }
                    reader.Close();
                }
            }
            _conn.Close();
            return idtam;
        }
        public void TaoHoaDon()
        {
            _conn.Open();
            string sql = "insert into HOADON(ngayhd,trangthai) values ('" + DateTime.Today.ToString() + "','0')";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public void HuyHoaDon(int tam)
        {
            _conn.Open();
            string sql = "delete from HOADON where mahd ='" + tam + "'";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public void ResetMaHoaDon(int tam)
        {
            _conn.Open();
            string sql = "DBCC CHECKIDENT('HOADON', RESEED, " + (tam-1) + ")";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public void CapNhatTrangThai(int tam)
        {
            _conn.Open();
            string sql = "update HOADON set trangthai = 1 where mahd ='" + tam + "'";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public void CapNhatHoaDon(float tien,int tam)
        {
            _conn.Open();
            string sql = "update HOADON set trigia ='" + tien + "'where mahd='" + tam + "'";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
