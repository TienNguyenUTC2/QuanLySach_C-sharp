using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangSach.DAO;

namespace QuanLyCuaHangSach.FormChild
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }
        private readonly int month = int.Parse(DateTime.Now.ToString("MM"));

        private void frmReport_Load(object sender, EventArgs e)
        {
            chart1.DataSource = reportDAO.Instance.see(month);
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Doanh thu của tháng " + month.ToString();

            chart1.Series["Tiền"].XValueMember = "DateBill";
            chart1.Series["Tiền"].YValueMembers = "TotalPrice";
        }

     
   
    }
}
