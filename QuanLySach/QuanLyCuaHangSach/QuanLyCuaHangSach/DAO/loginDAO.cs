using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangSach.DAO
{
    class loginDAO
    {
        private static loginDAO instance;

        public static loginDAO Instance
        {
            get { if (instance == null) instance = new loginDAO(); return instance; }
            private set { instance = value; }
        }

        private loginDAO() { }

        public bool LoginManager(string userName, string passWord)
        {
            string query = "SELECT * FROM TaiKhoan WHERE SDT=" + userName + " AND MatKhau='" + passWord + "' AND ID=1";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public bool LoginStaff(string userName, string passWord)
        {
            string query = "SELECT * FROM TaiKhoan WHERE SDT=" + userName + " AND MatKhau='" + passWord + "' AND ID=2";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public string getName(string phone)
        {
            string query = "SELECT TenTaiKhoan FROM TaiKhoan WHERE SDT=" + phone;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            string fullname = result.Rows[0].ItemArray[0].ToString();
            return fullname;
        }

        public int getId()
        {
            string query = "SELECT IDStaff FROM LuuID";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            int id = int.Parse(result.Rows[0].ItemArray[0].ToString());
            return id;
        }

        public void SaveId(string phone)
        {
            string query = "SELECT IDTaiKhoan FROM TaiKhoan WHERE SDT=" + phone;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            int id = int.Parse(result.Rows[0].ItemArray[0].ToString());

            string querySaveId = "update LuuID set IDStaff=" + id + " where IDChiTietHoaDon=1";
            DataProvider.Instance.ExucuteNonQuery(querySaveId);
        }
    }
}
