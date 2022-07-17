using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangSach.DAO
{
    class billDAO
    {
        private static billDAO instance;

        public static billDAO Instance
        {
            get { if (instance == null) instance = new billDAO(); return instance; }
            private set { instance = value; }
        }

        private billDAO() { }

        public object selectBill()
        {
            string query = "select IDHoaDon as N'ID HĐ' ,NgayInHoaDon as N'Ngày In HĐ', GioInHoaDon as N'Giờ In HĐ',TongTien as N'Tổng Tiền',TenKhachHang as N'Tên Khách Hàng' , TenTaiKhoan as N'Nhân Viên Bán' from HoaDon ,TaiKhoan,KhachHang where HoaDon.IDTaiKhoan = TaiKhoan.IDTaiKhoan and HoaDon.IDKhachHang = KhachHang.IDKhachHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
