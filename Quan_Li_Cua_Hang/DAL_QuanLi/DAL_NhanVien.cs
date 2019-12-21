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

        public int TaoTaiKhoan(string un, string pw1, string pw2, int cv)
        {
            int tam = 0;
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE dangnhap ='" + un + "'" , _conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    tam = 1;//chua co tai khoan
                }
                else
                {
                    tam = -1;//da ton tai tai khoan
                }

            }
            catch (Exception)
            {
                return -2;
                //MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                _conn.Close();
            }
            if(tam==1)
            {
                try
                {
                    if (pw1 != pw2)
                        tam = 3;//mau khau xac nhan chua dung
                    else
                    {
                        _conn.Open();
                        string SQL1 = string.Format("INSERT INTO NHANVIEN(dangnhap,pass, chucvu) VALUES ('{0}', '{1}', '{2}')", un, pw1, cv);
                        SqlCommand cmd1 = new SqlCommand(SQL1, _conn);
                        SqlDataAdapter da = new SqlDataAdapter(cmd1);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt != null)
                        {
                            tam = 2;
                        }
                        else
                        {
                            tam = -2;
                        }
                    }
                }
                catch (Exception)
                {
                    return -2;
                    //MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
                }
                finally
                {
                    _conn.Close();
                }
            }
            return tam;
        }

        public int KiemTraTonTaiQuanLi()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE chucvu ='" + 0 + "'", _conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception)
            {
                return -1;
                //MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
