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
using QuanLyCuaHangSach.DAO;

namespace QuanLyCuaHangSach
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string user = txtUserName.Text;
            string pass = txtPassWord.Text;
            if (LoginManager(user, pass) == true || LoginStaff(user, pass) == true)
            {
                if (LoginManager(user, pass) == true)
                {
                    this.Hide();
                    DisplayManager manager = new DisplayManager();
                    manager.ShowDialog();
                }
                else
                {
                    loginDAO.Instance.SaveId(user);
                    this.Hide();
                    DisplayStaff staff = new DisplayStaff();
                   // staff.nameStaff = getName(user);
                    staff.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Mật khẩu hoặc tài khoản sai!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        bool LoginManager(string user, string pass)
        {
            return loginDAO.Instance.LoginManager(user, pass);
        }

        bool LoginStaff(string user, string pass)
        {
            return loginDAO.Instance.LoginStaff(user, pass);
        }

        string getName(string phone)
        {
            return loginDAO.Instance.getName(phone);
        }
    }
}
