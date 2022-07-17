using Microsoft.Reporting.WinForms;
using QuanLyCuaHangSach.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangSach.FormChild
{
    public partial class frmInHoaDon : Form
    {
        private string idhd;
        public frmInHoaDon(string idhd)
        {
            InitializeComponent();
            this.idhd = idhd;
          
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            inHoaDonDAO inHoaDon = new inHoaDonDAO();
            SqlConnection con = inHoaDon.sqlConnection();
            con.Open();
            string query = "select ChiTietHoaDon.IDHoaDon,ChiTietHoaDon.IDSach,TenSach,Gia,ChiTietHoaDon.SoLuong,HoaDon.NgayInHoaDon,HoaDon.GioInHoaDon, HoaDon.TongTien ,KhachHang.TenKhachHang ,TaiKhoan.TenTaiKhoan from Sach,ChiTietHoaDon,HoaDon ,KhachHang,TaiKhoan where  Sach.IDSach = ChiTietHoaDon.IDSach and HoaDon.IDHoaDon = ChiTietHoaDon.IDHoaDon and HoaDon.IDKhachHang = KhachHang.IDKhachHang and HoaDon.IDTaiKhoan = TaiKhoan.IDTaiKhoan and ChiTietHoaDon.IDHoaDon ='" + idhd + "' ";
            SqlDataAdapter dta = new SqlDataAdapter(query, con);
            inbill dataSet1 = new inbill();
            dta.Fill(dataSet1, "DataTable1");
            ReportDataSource dataSource = new ReportDataSource("DataSet1", dataSet1.Tables["DataTable1"]);
            con.Close();

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
