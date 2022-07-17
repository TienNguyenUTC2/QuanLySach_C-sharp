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
    public partial class frmReportHD : Form
    {
        public frmReportHD()
        {
            InitializeComponent();
        }

        private void frmReportHD_Load(object sender, EventArgs e)
        {
            inHoaDonDAO inHoaDon = new inHoaDonDAO();
            SqlConnection con = inHoaDon.sqlConnection();
            con.Open();
            string query = "select IDHoaDon ,NgayInHoaDon, GioInHoaDon,TongTien,TenKhachHang  , TenTaiKhoan from HoaDon ,TaiKhoan,KhachHang where HoaDon.IDTaiKhoan = TaiKhoan.IDTaiKhoan and HoaDon.IDKhachHang = KhachHang.IDKhachHang";
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
