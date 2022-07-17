using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangSach.FormChild;

namespace QuanLyCuaHangSach
{
    public partial class DisplayStaff : Form
    {
       
        private Form currentChildForm;
        public DisplayStaff()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Display.Controls.Add(childForm);
            Display.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void resetColor()
        {
            //reset button in hóa đơn
            btnInHoaDon.FillColor = Color.Transparent;
            btnInHoaDon.ForeColor = Color.FromArgb(94, 94, 94);
            btnInHoaDon.BorderColor = Color.Black;
            //reset button khách hàng
            btnKhachHang.FillColor = Color.Transparent;
            btnKhachHang.ForeColor = Color.FromArgb(94, 94, 94);
            btnKhachHang.BorderColor = Color.Black;
            //reset button logout
            btnLogout.FillColor = Color.Transparent;
            btnLogout.ForeColor = Color.FromArgb(94, 94, 94);
            btnLogout.BorderColor = Color.Black;

        }
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            resetColor();
            btnInHoaDon.FillColor = Color.FromArgb(65, 105, 225);
            btnInHoaDon.ForeColor = Color.White;
            btnInHoaDon.BorderColor = Color.White;
            OpenChildForm(new frmAddBill());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            resetColor();
            btnKhachHang.FillColor = Color.FromArgb(65, 105, 225);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.BorderColor = Color.White;
            OpenChildForm(new frmClient());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            resetColor();
            btnLogout.FillColor = Color.FromArgb(65, 105, 225);
            btnLogout.ForeColor = Color.White;
            btnLogout.BorderColor = Color.White;
            var mess = MessageBox.Show("Bạn có muốn đăng xuất", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (mess == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }
    }
}
