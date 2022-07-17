using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyCuaHangSach.DAO
{
    class clientDAO
    {

        private static clientDAO instance;

        public static clientDAO Instance
        {
            get { if (instance == null) instance = new clientDAO(); return instance; }
            private set { instance = value; }
        }

        private clientDAO() { }

        public object selectClient()
        {
            string query = "select KhachHang.IDKhachHang as 'ID', KhachHang.TenKhachHang as N'Tên Khách Hàng', KhachHang.Email, KhachHang.SDT, KhachHang.CapBac as N'Cấp Bậc', KhachHang.SoTienDaMua as N'Số Tiền Đã Mua' from KhachHang ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void addClient(string name, string emal, string sdt)
        {
            string query = "insert into KhachHang(TenKhachHang,SDT,Email,SoTienDaMua) values(N'" + name + "','" + sdt + "','" + emal + "',0)";
            DataProvider.Instance.ExucuteNonQuery(query);
        }

        public void updateClient(int id, string name, string emal, string sdt)
        {
            string query = "update KhachHang set TenKhachHang=N'" + name + "', Email=N'" + emal + "', SDT='" + sdt + "' where IDKhachHang=" + id;
            DataProvider.Instance.ExucuteNonQuery(query);
        }
        public void delete(int id)
        {
            string query = "delete KhachHang where IDKhachHang=" + id;
            DataProvider.Instance.ExucuteNonQuery(query);
        }
    }
}
