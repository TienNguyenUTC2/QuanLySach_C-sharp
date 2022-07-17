using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangSach.DAO
{
    class accountDAO
    {
        private static accountDAO instance;
        public static accountDAO Instance
        {
            get { if (instance == null) instance = new accountDAO(); return instance; }
            private set { instance = value; }
        }

        private accountDAO() { }
        public object selectAccount()
        {
            string query = "Select IDTaiKhoan as 'ID Tài Khoản',TenTaiKhoan as N'Họ Và Tên',SDT,MatKhau  as N'Mật Khẩu',Email ,PhanQuyen.TenPhanQuyen as N'Loại Tài Khoản' from TaiKhoan ,PhanQuyen where TaiKhoan.ID = PhanQuyen.ID";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        

        public void add(string name, string pass, string email, string sdt)
        {
            string query = "insert into TaiKhoan(TenTaiKhoan,MatKhau,Email,SDT,ID) values(N'" + name + "','" + pass + "','" + email + "'," + sdt + ",2)";
            DataProvider.Instance.ExucuteNonQuery(query);
        }

        public void delete(int id)
        {
            string query = "delete TaiKhoan where IDTaiKhoan=" + id;
            DataProvider.Instance.ExucuteNonQuery(query);
        }

        public void update(string name, string pass, string email, string sdt, int id)
        {
            string query = "update TaiKhoan set TenTaiKhoan=N'" + name + "', MatKhau=N'" + pass + "', Email='" + email + "', SDT='" + sdt + "' where IDTaiKhoan=" + id;
            DataProvider.Instance.ExucuteNonQuery(query);
        }
    }
}
