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

namespace QuanLyCuaHangSach.Dialog
{
    public partial class Book : Form
    {
        public string tenSach, tenTacGia, NXB;
        public int SL, id, Gia;


        public int check; //nếu = 1 là sửa; = 2 là thêm
        public Book()
        {
            InitializeComponent();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (check == 2)
            {
                if (txtTenSach.Text != "" && txtTacGia.Text != "" && txtNXB.Text != "" && txtSL.Text != "" && txtGiaTien.Text != "")
                {
                    bookDAO.Instance.add(txtTenSach.Text, txtTacGia.Text, txtNXB.Text, int.Parse(txtSL.Text), int.Parse(txtGiaTien.Text));
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không được bỏ trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txtTenSach.Text != "" && txtTacGia.Text != "" && txtNXB.Text != "" && txtSL.Text != "")
                {
                    bookDAO.Instance.update(txtTenSach.Text, txtTacGia.Text, txtNXB.Text, int.Parse(txtSL.Text), id, int.Parse(txtGiaTien.Text));
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không được bỏ trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private void Book_Load(object sender, EventArgs e)
        {
            if (check == 1)
            {
                lblHeader.Text = "SỬA SÁCH";
                btnThem.Text = "SỬA";
            }
            else
            {
                lblHeader.Text = "NHẬP SÁCH";
                btnThem.Text = "THÊM";
            }
            txtTacGia.Text = tenTacGia;
            txtTenSach.Text = tenSach;
            txtNXB.Text = NXB;
            txtGiaTien.Text = Gia.ToString();
            txtSL.Text = SL.ToString();
        }

    }
}
