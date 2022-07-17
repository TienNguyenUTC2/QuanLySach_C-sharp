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
    public partial class frmReportSach : Form
    {
        public frmReportSach()
        {
            InitializeComponent();
        }

        private void frmReportSach_Load(object sender, EventArgs e)
        {
            inHoaDonDAO inHoaDon = new inHoaDonDAO();
            SqlConnection con = inHoaDon.sqlConnection();
            con.Open();
            string query = "select Sach.IDSach, Sach.TenSach  , Sach.NXB , Sach.TenTacGia , Sach.SoLuong, Sach.Gia from Sach ";
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
