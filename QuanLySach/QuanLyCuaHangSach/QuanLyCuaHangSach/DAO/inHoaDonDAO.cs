using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace QuanLyCuaHangSach.DAO
{
    class inHoaDonDAO
    {
        string str;
        public inHoaDonDAO()
        {
            str = @"Data Source=DESKTOP-61R69JO\SQLEXPRESS;Initial Catalog=BOOKSTORT;Integrated Security=True";
        }

        public SqlConnection sqlConnection()
        {
            return new SqlConnection(str);
        }
    }
}
