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
    public partial class DisplayManager : Form
    {

        private Form currentChildForm;


        public DisplayManager()
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
            btnSach.FillColor = Color.Transparent;
            btnSach.ForeColor = Color.FromArgb(94, 94, 94);
            btnSach.BorderColor = Color.Black;

            btnHoaDon.FillColor = Color.Transparent;
            btnHoaDon.ForeColor = Color.FromArgb(94, 94, 94);
            btnHoaDon.BorderColor = Color.Black;

            btnTaiKhoan.FillColor = Color.Transparent;
            btnTaiKhoan.ForeColor = Color.FromArgb(94, 94, 94);
            btnTaiKhoan.BorderColor = Color.Black;

            btnKhachHang.FillColor = Color.Transparent;
            btnKhachHang.ForeColor = Color.FromArgb(94, 94, 94);
            btnKhachHang.BorderColor = Color.Black;

            btnReport.FillColor = Color.Transparent;
            btnReport.ForeColor = Color.FromArgb(94, 94, 94);
            btnReport.BorderColor = Color.Black;

            btnLogout.FillColor = Color.Transparent;
            btnLogout.ForeColor = Color.FromArgb(94, 94, 94);
            btnLogout.BorderColor = Color.Black;
        }
        private void btnSach_Click(object sender, EventArgs e)
        {
            resetColor();
            btnSach.FillColor = Color.FromArgb(65, 105, 225);
            btnSach.ForeColor = Color.White;
            btnSach.BorderColor = Color.White;
            OpenChildForm(new frmBook());
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            resetColor();
            btnHoaDon.FillColor = Color.FromArgb(65, 105, 225);
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.BorderColor = Color.White;
            OpenChildForm(new frmBills());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            resetColor();
            btnKhachHang.FillColor = Color.FromArgb(65, 105, 225);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.BorderColor = Color.White;
            OpenChildForm(new frmClient());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            resetColor();
            btnTaiKhoan.FillColor = Color.FromArgb(65, 105, 225);
            btnTaiKhoan.ForeColor = Color.White;
            btnTaiKhoan.BorderColor = Color.White;
            OpenChildForm(new frmAccount());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            resetColor();
            btnReport.FillColor = Color.FromArgb(65, 105, 225);
            btnReport.ForeColor = Color.White;
            btnReport.BorderColor = Color.White;
            OpenChildForm(new FrmReport());
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
