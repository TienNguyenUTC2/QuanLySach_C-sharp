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
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private int id;
        public string tenSach, tenTacGia, NXB;
        public int soLuong;


        public int gia;

        private void frmBook_Load(object sender, EventArgs e)
        {
            dgv_Book.DataSource = bookDAO.Instance.selectBook();
            dgv_Book.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Book.Columns[0].Width = 50;
            dgv_Book.ClearSelection();
        }


        private void dgv_Book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgv_Book.Rows[e.RowIndex];
                    id = int.Parse(row.Cells[0].Value.ToString());
                    tenSach = row.Cells[1].Value.ToString();
                    NXB = row.Cells[2].Value.ToString();
                    tenTacGia = row.Cells[3].Value.ToString();                    
                    soLuong = int.Parse(row.Cells[4].Value.ToString());
                    gia = int.Parse(row.Cells[5].Value.ToString());
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var mess = MessageBox.Show("Bạn có muốn xóa sản phẩm này", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (mess == DialogResult.Yes)
            {
                bookDAO.Instance.delete(id);
                dgv_Book.DataSource = bookDAO.Instance.selectBook();
                //dgv_Book.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgv_Book.Columns[0].Width = 50;
                //dgv_Book.ClearSelection();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                (dgv_Book.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                dgv_Book.ClearSelection();
            }
            else
            {
                (dgv_Book.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Tên Sách] LIKE '{0}%'", txtSearch.Text);
                dgv_Book.ClearSelection();
            }
        }

        private void btnReportSach_Click(object sender, EventArgs e)
        {
            frmReportSach rptSach = new frmReportSach();
            rptSach.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Book sua = new Book();
            sua.check = 1;
            sua.tenSach = tenSach;
            sua.tenTacGia = tenTacGia;
            sua.NXB = NXB;
            sua.SL = soLuong;
            sua.id = id;
            sua.Gia = gia;
            sua.ShowDialog();
            dgv_Book.DataSource = bookDAO.Instance.selectBook();
            //dgv_Book.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           // dataGridViewBook.Columns[0].Width = 50;
           // dgv_Book.ClearSelection();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book nhap = new Book();
            nhap.check = 2;
            nhap.ShowDialog();
            dgv_Book.DataSource = bookDAO.Instance.selectBook();
            //dgv_Book.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_Book.Columns[0].Width = 50;
            //dgv_Book.ClearSelection();
        }



    }
}
