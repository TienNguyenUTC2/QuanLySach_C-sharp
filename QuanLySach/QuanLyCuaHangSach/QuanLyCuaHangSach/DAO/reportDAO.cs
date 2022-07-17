using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace QuanLyCuaHangSach.DAO
{
    class reportDAO
    {
        private static reportDAO instance;

        public static reportDAO Instance
        {
            get { if (instance == null) instance = new reportDAO(); return instance; }
            private set { instance = value; }
        }

        private reportDAO() { }

        public object see(int month)
        {
            string query = "select HoaDon.NgayInHoaDon as 'DateBill', Sum(HoaDon.TongTien) as 'TotalPrice' from HoaDon where HoaDon.NgayInHoaDon >= '2022-" + month + "-01' group by HoaDon.NgayInHoaDon";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }

        public DataTable excel(int month)
        {
            string query = "select HoaDon.NgayInHoaDon as 'DateBill', Sum(HoaDon.TongTien) as 'TotalPrice' from HoaDon where HoaDon.NgayInHoaDon >= '2022-" + month + "-01' group by HoaDon.NgayInHoaDon";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
    }
}
