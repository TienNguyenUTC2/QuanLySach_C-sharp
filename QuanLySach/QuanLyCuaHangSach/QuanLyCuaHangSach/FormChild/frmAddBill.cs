using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangSach.DAO;

namespace QuanLyCuaHangSach.FormChild
{
    public partial class frmAddBill : Form
    {

        private int idBook;
        private string book;
        public frmAddBill()
        {
            InitializeComponent();
            txtSoHoaDon.Text = "";
            txtSoTienTra.Text = "";
            btnAdd.Enabled = false;
            //btnDelete.Enabled = false;
            //btnInBill.Enabled = false;
        }

        private void frmAddBill_Load(object sender, EventArgs e)
        {
            dataGridViewBook.DataSource = createBillDAO.Instance.selectCreateBill();
            dataGridViewBook.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewBook.Columns[0].Width = 20;
            dataGridViewBook.ClearSelection();

            cbbKhach.DataSource = createBillDAO.Instance.getKhach();
            cbbKhach.DisplayMember = "TenKhachHang";
            cbbKhach.ValueMember = "CapBac";

            cbbKhach.Text = "Ko co";
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSach.Text))
            {
                (dataGridViewBook.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                dataGridViewBook.ClearSelection();
            }
            else
            {
                (dataGridViewBook.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Tên Sách] LIKE '{0}%'", txtTenSach.Text);
                dataGridViewBook.ClearSelection();
            }
        }

        private void cbbKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhach.SelectedValue.ToString() == "Đồng")
            {
                txtGiamGia.Text = "0%";
            }
            else if (cbbKhach.SelectedValue.ToString() == "Bạc")
            {
                txtGiamGia.Text = "5%";
            }
            else if (cbbKhach.SelectedValue.ToString() == "Vàng")
            {
                txtGiamGia.Text = "10%";
            }
            else if (cbbKhach.SelectedValue.ToString() == "Bạch kim")
            {
                txtGiamGia.Text = "15%";
            }
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.ToString("yyyy/MM/dd");
            createBillDAO.Instance.createBill(date, time, loginDAO.Instance.getId());
            txtSoHoaDon.Text = createBillDAO.Instance.getIdBill().ToString();
            btnCreateBill.Enabled = false;

            dataGridViewBill.DataSource = createBillDAO.Instance.selectInfoBill(int.Parse(txtSoHoaDon.Text));
            dataGridViewBill.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewBill.Columns[1].Width = 70;
            dataGridViewBill.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createBillDAO.Instance.addBook(int.Parse(txtSoHoaDon.Text), idBook);
            btnAdd.Enabled = false;
            dataGridViewBill.DataSource = createBillDAO.Instance.selectInfoBill(int.Parse(txtSoHoaDon.Text));
            dataGridViewBill.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewBill.Columns[1].Width = 70;
            dataGridViewBill.ClearSelection();
            txtSoTien.Text = createBillDAO.Instance.getMoney(int.Parse(txtSoHoaDon.Text)).ToString();
        }

      

        private void btnDelete_Click(object sender, EventArgs e)
        {
            createBillDAO.Instance.deleteBook(int.Parse(txtSoHoaDon.Text), book);
            btnDelete.Enabled = false;
            dataGridViewBill.DataSource = createBillDAO.Instance.selectInfoBill(int.Parse(txtSoHoaDon.Text));
            dataGridViewBill.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewBill.Columns[1].Width = 70;
            dataGridViewBill.ClearSelection();
            txtSoTien.Text = createBillDAO.Instance.getMoney(int.Parse(txtSoHoaDon.Text)).ToString();
            
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (txtGiamGia.Text == "")
            {
                txtSoTienTra.Text = txtSoTien.Text; ;
            }
            else if (txtGiamGia.Text == "5%")
            {
                txtSoTienTra.Text = (int.Parse(txtSoTien.Text) * 95 / 100).ToString();
            }
            else if (txtGiamGia.Text == "10%")
            {
                txtSoTienTra.Text = (int.Parse(txtSoTien.Text) * 90 / 100).ToString();
            }
            else if (txtGiamGia.Text == "15%")
            {
                txtSoTienTra.Text = (int.Parse(txtSoTien.Text) * 85 / 100).ToString();
            }
        }

        private void btnInBill_Click(object sender, EventArgs e)
        {

            createBillDAO.Instance.updateBill(cbbKhach.Text, int.Parse(txtSoHoaDon.Text), int.Parse(txtSoTienTra.Text));
            createBillDAO.Instance.updateKho(int.Parse(txtSoHoaDon.Text));
            frmInHoaDon inHoaDon= new frmInHoaDon(txtSoHoaDon.Text);
            inHoaDon.ShowDialog();
            btnCreateBill.Enabled = true;
            txtSoHoaDon.Text = "";
            txtGiamGia.Text = "";
            txtSoTien.Text = "";
            txtSoTienTra.Text = "";
            dataGridViewBill.DataSource = createBillDAO.Instance.selectInfoBill(7);
            dataGridViewBill.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewBill.Columns[1].Width = 70;
            dataGridViewBill.ClearSelection();
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            if (txtGiamGia.Text == "")
            {
                txtSoTienTra.Text = txtSoTien.Text; ;
            }
            else if (txtGiamGia.Text == "5%")
            {
                txtSoTienTra.Text = (int.Parse(txtSoTien.Text) * 95 / 100).ToString();
            }
            else if (txtGiamGia.Text == "10%")
            {
                txtSoTienTra.Text = (int.Parse(txtSoTien.Text) * 90 / 100).ToString();
            }
            else if (txtGiamGia.Text == "15%")
            {
                txtSoTienTra.Text = (int.Parse(txtSoTien.Text) * 85 / 100).ToString();
            }

        }

        private void dataGridViewBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewBill.Rows[e.RowIndex];
                    book = row.Cells[0].Value.ToString();
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewBook.Rows[e.RowIndex];
                    idBook = int.Parse(row.Cells[0].Value.ToString());
                    if (txtSoHoaDon.Text != "")
                    {
                        btnAdd.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
