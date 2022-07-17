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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        public int idPhanLoai; //1. sửa; 2. thêm
        public string id, name, email, phone, money, level;

        private void Client_Load(object sender, EventArgs e)
        {
            if (idPhanLoai == 2)
            {
                txtLevel.Text = "Đồng";
                txtSoTienDaMua.Text = "0";
                btnAdd.Text = "THÊM";
            }
            else
            {
                txtIdKhach.Text = id;
                txtTenKhach.Text = name;
                txtSoTienDaMua.Text = money;
                txtLevel.Text = level;
                txtEmail.Text = email;
                txtSDT.Text = phone;
                btnAdd.Text = "SỬA";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (idPhanLoai == 2)
            {
                if (txtEmail.Text != "" && txtSDT.Text != "" && txtTenKhach.Text != "")
                {
                    clientDAO.Instance.addClient(txtTenKhach.Text, txtEmail.Text,txtSDT.Text);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không được bỏ trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txtEmail.Text != "" && txtSDT.Text != "" && txtTenKhach.Text != "")
                {
                    clientDAO.Instance.updateClient(int.Parse(txtIdKhach.Text), txtTenKhach.Text, txtEmail.Text, txtSDT.Text);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không được bỏ trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
