using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QuanLi
{
    class DBConnect
    {
        //hieu
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-9E5E5MG;Initial Catalog=QLCH;Integrated Security=True");
        //sinh
        //protected SqlConnection _conn = new SqlConnection("Data Source = COMPUTER; Initial Catalog = QLCH; Integrated Security = True");

    }
}
