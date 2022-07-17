using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCuaHangSach.DAO;

namespace QuanLyCuaHangSach.Dialog
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        public int idPhanLoai, id; //1=thêm, 2=sửa


        public string name, email, pass,sdt,phanquyen;

        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-61R69JO\SQLEXPRESS;Initial Catalog=BOOKSTORT;Integrated Security=True");
        private void LoadDataCmb(ComboBox cmb1, string name, string table)
        {
            cnn.Open();
            string sql = @"Select " + name + " from " + table;
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string[] tensp = new string[dt.Rows.Count];
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {

                tensp[i] = dr.Field<string>(0); //lấy trường đầu tiên trong DataTable
                cmb1.Items.Add(tensp[i]);
                i++;
            }
            cnn.Close();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            if (idPhanLoai == 1)
            {
                btnAdd.Text = "THÊM";
            }
            else
            {
                btnAdd.Text = "SỬA";
                txtName.Text = name;
                txtPass.Text = pass;
                txtEmail.Text = email;
                txtPhone.Text = sdt;
                cbbPhanQuyen.Text = phanquyen;
               
            }
            LoadDataCmb(cbbPhanQuyen, "TenPhanQuyen", "PhanQuyen");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (idPhanLoai == 1)
            {
                if (txtName.Text != "" && txtEmail.Text != "" && txtPass.Text != "" && txtPhone.Text != "")
                {
                    accountDAO.Instance.add(txtName.Text, txtPass.Text, txtEmail.Text, txtPhone.Text);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không được bỏ trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txtName.Text != "" && txtEmail.Text != "" && txtPass.Text != "" && txtPhone.Text != "")
                {
                    accountDAO.Instance.update(txtName.Text, txtPass.Text, txtEmail.Text, txtPhone.Text, id);
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
