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
    public class DAL_CTHD : DBConnect
    {
        public int LaySLMonAn(int mahd,int mamon)
        {
            int sl = 0;
            _conn.Open();
            string sql = "select solg from CTHD where mahd='"+mahd+"'and mamon='"+mamon+"'";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (Convert.IsDBNull(reader.GetValue(0)) == true)
                        {
                            sl = 0;
                        }
                        else
                        {
                            sl = Convert.ToInt32(reader.GetValue(0));
                        }
                    }
                    reader.Close();
                }
            }
            _conn.Close();
            return sl;
        }
        public void TaoCTHD(int mahd,int mamon,string tenmon,float gia,int sl)
        {
            _conn.Open();
            string sql = "insert into CTHD values('"+mahd+"','"+mamon+"',N'"+tenmon+"','"+gia+"','"+sl+"')";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public void CapNhatCTHD(int mahd, int mamon, int sl)
        {
            _conn.Open();
            string sql = "update CTHD set solg='"+sl+"' where mahd ='" + mahd + "'and mamon='"+mamon+"'";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public void XoaCTHD(int mahd, int mamon)
        {
            _conn.Open();
            string sql = "delete from CTHD where mahd='"+mahd+"' and mamon ='"+mamon+"'";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public void XoaCTHDver2(int mahd)
        {
            _conn.Open();
            string sql = "delete from CTHD where mahd='" + mahd + "'";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public DataTable LayCTHD(int mahd)
        {
            SqlDataAdapter da = new SqlDataAdapter("select tenmon,gia,solg from CTHD,HOADON where CTHD.mahd = HOADON.mahd and HOADON.mahd=" + mahd, _conn);
            DataTable dtCTHD = new DataTable();
            da.Fill(dtCTHD);
            return dtCTHD;
        }
    }
}
