using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangSach.Dialog;
using QuanLyCuaHangSach.DAO;

namespace QuanLyCuaHangSach.FormChild
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }
        int id;
        string name, pass, email,sdt,phanquyen;
        
        
        
        private void dgv_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_Account.Rows[e.RowIndex];
                    id = int.Parse(row.Cells[0].Value.ToString());
                    name = row.Cells[1].Value.ToString();
                    sdt = row.Cells[2].Value.ToString();
                    pass = row.Cells[3].Value.ToString();
                    email = row.Cells[4].Value.ToString();
                    phanquyen = row.Cells[5].Value.ToString();
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtSearchAcount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchAcount.Text))
            {
                (dgv_Account.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                dgv_Account.ClearSelection();
            }
            else
            {
                (dgv_Account.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Họ Và Tên] LIKE '{0}%'", txtSearchAcount.Text);
                dgv_Account.ClearSelection();
            }
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            dgv_Account.DataSource = accountDAO.Instance.selectAccount();
            dgv_Account.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Account.Columns[0].Width = 100;
            dgv_Account.ClearSelection();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var mess = MessageBox.Show("Bạn có chắc muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (mess == DialogResult.Yes)
            {
                accountDAO.Instance.delete(id);
                dgv_Account.DataSource = accountDAO.Instance.selectAccount();
                dgv_Account.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Account.Columns[0].Width = 100;
                dgv_Account.ClearSelection();
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.idPhanLoai = 2;
            account.id = id;
            account.sdt = sdt;
            account.name = name;
            account.email = email;
            account.pass = pass;
            account.phanquyen = phanquyen;
            account.ShowDialog();
            dgv_Account.DataSource = accountDAO.Instance.selectAccount();
            dgv_Account.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Account.Columns[0].Width = 100;
            dgv_Account.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.idPhanLoai = 1;
            account.ShowDialog();
            dgv_Account.DataSource = accountDAO.Instance.selectAccount();
            dgv_Account.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Account.Columns[0].Width = 100;
            dgv_Account.ClearSelection();
        }
    }
}
