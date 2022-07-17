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
using QuanLyCuaHangSach.Dialog;

namespace QuanLyCuaHangSach.FormChild
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        string id, name, email, phone, level, money;

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchClient.Text))
            {
                (dgv_Client.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                dgv_Client.ClearSelection();
            }
            else
            {
                (dgv_Client.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Tên Khách Hàng] LIKE '{0}%'", txtSearchClient.Text);
                dgv_Client.ClearSelection();
            }

        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            dgv_Client.DataSource = clientDAO.Instance.selectClient();
            dgv_Client.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Client.Columns[0].Width = 50;
            dgv_Client.ClearSelection();

        }

        private void dgv_Client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_Client.Rows[e.RowIndex];
                    id = row.Cells[0].Value.ToString();
                    name = row.Cells[1].Value.ToString();
                    email = row.Cells[2].Value.ToString();
                    phone = row.Cells[3].Value.ToString();
                    level = row.Cells[4].Value.ToString();
                    money = row.Cells[5].Value.ToString();
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception)
            {

            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.idPhanLoai = 2;
            client.ShowDialog();
            dgv_Client.DataSource = clientDAO.Instance.selectClient();
            dgv_Client.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Client.Columns[0].Width = 50;
            dgv_Client.ClearSelection();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.idPhanLoai = 1;
            client.id = id;
            client.name = name;
            client.email = email;
            client.phone = phone;
            client.level = level;
            client.money = money;
            client.ShowDialog();
            dgv_Client.DataSource = clientDAO.Instance.selectClient();
            dgv_Client.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Client.Columns[0].Width = 50;
            dgv_Client.ClearSelection();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var mess = MessageBox.Show("Bạn có muốn đăng xuất", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (mess == DialogResult.Yes)
            {
                clientDAO.Instance.delete(int.Parse(id));
                dgv_Client.DataSource = clientDAO.Instance.selectClient();
                dgv_Client.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Client.Columns[0].Width = 50;
                dgv_Client.ClearSelection();
            }
        }


    }
}
