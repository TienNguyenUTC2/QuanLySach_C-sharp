using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangSach.DAO;

namespace QuanLyCuaHangSach.FormChild
{
    public partial class frmBills : Form
    {
        public frmBills()
        {
            InitializeComponent();
        }

        private void frmBills_Load(object sender, EventArgs e)
        {
            dgv_Bill.DataSource = billDAO.Instance.selectBill();
            dgv_Bill.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Bill.Columns[0].Width = 50;
            dgv_Bill.ClearSelection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmReportHD rptHD = new frmReportHD();
            rptHD.ShowDialog();
        }
    }
}
