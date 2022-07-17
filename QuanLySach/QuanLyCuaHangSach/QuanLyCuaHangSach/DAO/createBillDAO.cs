using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangSach.DAO
{
    class createBillDAO
    {
        private static createBillDAO instance;
        public static createBillDAO Instance
        {
            get { if (instance == null) instance = new createBillDAO(); return instance; }
            private set { instance = value; }
        }

        private createBillDAO() { }

        public object selectCreateBill()
        {
            string query = "select Sach.IDSach as 'ID', Sach.TenSach as N'Tên Sách', Sach.Gia as N'Giá' from Sach";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public object getKhach()
        {
            string query = "select * from KhachHang ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void createBill(string date, string time, int idStaff)
        {
            string query = "Insert into HoaDon(NgayInHoaDon,GioInHoaDon,IDTaiKhoan) values('" + date + "','" + time + "'," + idStaff + ")";
            DataProvider.Instance.ExucuteNonQuery(query);
        }

        public int getIdBill()
        {
            string query = " select Top(1) IDHoaDon from HoaDon order by IDHoaDon DESC";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            int id = int.Parse(result.Rows[0].ItemArray[0].ToString());
            return id;
        }

        public object selectInfoBill(int idBill)
        {
            string query = " select Sach.TenSach as N'Tên Sách', SUM(ChiTietHoaDon.SoLuong) as N'Số Lượng' from ChiTietHoaDon, Sach, HoaDon where HoaDon.IDHoaDon = ChiTietHoaDon.IDHoaDon and ChiTietHoaDon.IDSach = Sach.IDSach and ChiTietHoaDon.IDHoaDon = " + idBill + "Group by Sach.TenSach";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void addBook(int bill, int idBook)
        {
            string query = "insert into ChiTietHoaDon(IDSach,IDHoaDon,SoLuong) values(" + idBook + "," + bill + ",1)";
            DataProvider.Instance.ExucuteNonQuery(query);
        }

        public void deleteBook(int idBill, string Book)
        {
            string selectId = "select IDSach from Sach where Sach.TenSach = N'" + Book + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(selectId);
            int id = int.Parse(result.Rows[0].ItemArray[0].ToString());

            string query = "delete from ChiTietHoaDon where IDHoaDon=" + idBill + " and IDSach=" + id;
            DataProvider.Instance.ExucuteNonQuery(query);
        }

        public int getMoney(int idBill)
        {
            string query = " select SUM(Sach.Gia) from Sach, ChiTietHoaDon where ChiTietHoaDon.IDHoaDon = " + idBill + " and ChiTietHoaDon.IDSach = Sach.IDSach and Sach.Gia > 0";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            int money;
            try
            {
                money = int.Parse(result.Rows[0].ItemArray[0].ToString());
            }
            catch (Exception)
            {
                money = 0;
            }
            return money;
        }

        public void updateBill(string nameClient, int idBill, int money)
        {
            if (nameClient == "Không Có")
            {
                string query = "update HoaDon set TongTien=" + money + " where IDHoaDon=" + idBill;
                DataProvider.Instance.ExucuteNonQuery(query);
            }
            else
            {
                string selectId = "select IDKhachHang from KhachHang where TenKhachHang = N'" + nameClient + "'";
                DataTable result = DataProvider.Instance.ExecuteQuery(selectId);
                int id = int.Parse(result.Rows[0].ItemArray[0].ToString());

                string query = "update HoaDon set TongTien=" + money + ", IDKhachHang=" + id + " where IDHoaDon=" + idBill;
                DataProvider.Instance.ExucuteNonQuery(query);

                string upMeneyKhach = "update KhachHang set SoTienDaMua=SoTienDaMua + " + money + " where IDKhachHang=" + id;
                DataProvider.Instance.ExucuteNonQuery(upMeneyKhach);

              

                //Check vào update cấp bậc
                string selectToTalMoner = " select Sum(TongTien) from HoaDon where IDKhachHang = " + id + " and TongTien > 0";
                DataTable resultToTalMoner = DataProvider.Instance.ExecuteQuery(selectToTalMoner);
                int ToTalMoner = int.Parse(resultToTalMoner.Rows[0].ItemArray[0].ToString());
                Console.WriteLine(ToTalMoner.ToString());
                if (ToTalMoner < 300000)
                {
                    string update = "update KhachHang set CapBac=N'Đồng' where IDKhachHang=" + id;
                    DataProvider.Instance.ExucuteNonQuery(update);
                }
                else if (ToTalMoner >= 300000 && ToTalMoner < 800000)
                {
                    string update = "update KhachHang set CapBac=N'Bạc' where IDKhachHang=" + id;
                    DataProvider.Instance.ExucuteNonQuery(update);
                }
                else if (ToTalMoner >= 800000 && ToTalMoner < 1500000)
                {
                    string update = "update KhachHang set CapBac=N'Vàng' where IDKhachHang=" + id;
                    DataProvider.Instance.ExucuteNonQuery(update);
                }
                else if (ToTalMoner >= 1500000)
                {
                    string update = "update KhachHang set CapBac=N'Bạch Kim' where IDKhachHang=" + id;
                    DataProvider.Instance.ExucuteNonQuery(update);
                }
            }
        }

        public void updateKho(int idBill)
        {
            string query1 = " select ChiTietHoaDon.IDSach, SUM(ChiTietHoaDon.SoLuong) from ChiTietHoaDon where ChiTietHoaDon.IDHoaDon = " + idBill + " group by ChiTietHoaDon.IDSach";
            DataTable result = DataProvider.Instance.ExecuteQuery(query1);

            int len = result.Rows.Count;

            for (int i = 0; i < len; i++)
            {
                string query2 = "update Sach set SoLuong=SoLuong-" + int.Parse(result.Rows[i].ItemArray[1].ToString()) + " where IDSach=" + int.Parse(result.Rows[i].ItemArray[0].ToString());
                DataProvider.Instance.ExucuteNonQuery(query2);
            }
        }
    }
}
