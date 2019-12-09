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
    public class DAL_NhanVien : DBConnect
    {

        public string DangNhap(string un, string pw)
        {
            // int result = -1;

            // _conn.Open();
            // //SqlCommand cmd = new SqlCommand("select * from NHANVIEN where dangnhap=@un and pass=@pw", _conn);
            // SqlCommand cmd1 = new SqlCommand("select chucvu from NHANVIEN where dangnhap=@un and pass=@pw", _conn);
            // //
            //// cmd.Parameters.AddWithValue("@un", un);
            // //cmd.Parameters.AddWithValue("@pw", pw);

            // cmd1.Parameters.AddWithValue("@un", un);
            // cmd1.Parameters.AddWithValue("@pw", pw);

            // SqlDataReader reader1 = cmd1.ExecuteReader();
            // if (reader1.Read())
            // {
            //     //if (reader1["dangnhap"].ToString().Equals(un, StringComparison.InvariantCulture) && reader1["pass"].ToString().Equals(pw, StringComparison.InvariantCulture))
            //     //{
            //         result = int.Parse(reader1["chucvu"].ToString());
            //         //result = int.Parse(reader["chucvu"].ToString());
            //         reader1.Close();
            //         cmd1.Dispose();
            //         //SqlDataReader reader1 = cmd1.ExecuteReader();

            //         //if (reader1.Read())
            //         //{
            //         //    //reader1["chucvu"].GetValues();
            //         //    //result = reader1.GetInt32(0
            //         //    result = int.Parse(reader1["chucvu"].ToString());
            //         //}
            //         //else
            //         //    result = -1;
            //         //reader1.Close();
            //         //cmd1.Dispose();
            //     //}
            //     //else
            //     //    result = -1;
            // }
            // else
            //     result = -1;
            // _conn.Close();
            // return result;
          
                string chucvu= "-1";
                try
                {
                    _conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE dangnhap ='" + un + "' and pass='" + pw + "'", _conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                       
                        string tam=dr["chucvu"].ToString();
                        if (tam == "1")
                            chucvu = "1";
                        else
                            chucvu = "0";

                        }
                    }
                }
                catch (Exception)
                {
                    return "-1";
                    //MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
                }
                finally
                {
                    _conn.Close();
                }
                return chucvu;
          
        }
    }
}
