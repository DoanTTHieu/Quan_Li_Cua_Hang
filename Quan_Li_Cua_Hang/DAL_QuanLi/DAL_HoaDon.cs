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
            string sql = "insert into HOADON(ngayhd,trigia,trangthai) values ('" + DateTime.Today.ToString() + "','0','0')";
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
        public void CapNhatHoaDonv2(float tien, int tam, int ban)
        {
            _conn.Open();
            string sql = "update HOADON set trigia ='" + tien + "',ban='" + ban + "'where mahd='" + tam + "'";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public void CapNhatBan(int ban,int tam)
        {
            _conn.Open();
            string sql = "update HOADON set ban='" + ban + "'where mahd='" + tam + "'";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public DataTable TongTien(DateTime ngay)
        {
            SqlDataAdapter da = new SqlDataAdapter("select sum(trigia) trigia from HOADON where trangthai = 1 and ngayhd='" + ngay + "'", _conn);
            DataTable dtHoaDon = new DataTable();
            da.Fill(dtHoaDon);
            return dtHoaDon;
        }
        public DataTable SLHoaDon(DateTime ngay)
        {
            SqlDataAdapter da = new SqlDataAdapter("select count(mahd) sl from HOADON where trangthai = 1 and ngayhd='" + ngay + "'", _conn);
            DataTable dtHoaDon = new DataTable();
            da.Fill(dtHoaDon);
            return dtHoaDon;
        }
        public DataTable LayHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select mahd,trigia,ban from HOADON where mahd>0 and trangthai = 0 ", _conn);
            DataTable dtHoaDon = new DataTable();
            da.Fill(dtHoaDon);
            return dtHoaDon;
        }
        public DataTable LayThongTinHoaDon(int tam)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select trigia,ban from HOADON where mahd='"+tam+"'", _conn);
            DataTable dtHoaDon = new DataTable();
            da.Fill(dtHoaDon);
            return dtHoaDon;
        }
        public DataTable LayHoaDonChoQuanLi(DateTime ngay)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select mahd,trigia,ban from HOADON where mahd>0 and trangthai = 1 and ngayhd='"+ngay+"'", _conn);
            DataTable dtHoaDon = new DataTable();
            da.Fill(dtHoaDon);
            return dtHoaDon;
        }
    }
}
