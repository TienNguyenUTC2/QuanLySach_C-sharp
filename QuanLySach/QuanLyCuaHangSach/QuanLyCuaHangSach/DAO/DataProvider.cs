using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangSach.DAO
{
    class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }


        private DataProvider() { }

        private string connStr = @"Data Source=DESKTOP-61R69JO\SQLEXPRESS;Initial Catalog=BOOKSTORT;Integrated Security=True";

        public DataTable ExecuteQuery(string query)
        {
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            conn.Close();

            return data;
        }

        public void ExucuteNonQuery(string query)
        {
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);

            command.ExecuteNonQuery();

            conn.Close();
        }
    }
}
