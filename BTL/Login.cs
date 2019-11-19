
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void Key_pressed(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                login();
        }

        private void login()
        {
            using (var db = new QLTHUCHIEntities())
            {
                
                string username = txtUname.Text;
                string pwd = txtpwd.Text;
                var select = db.TAIKHOANs.Where(tk => tk.password == pwd && tk.username == username);
                if (select.Count()>0)
                {
                    LoginInfo.UserID = select.First().username;
                    LoginInfo.loginf = this;
                    var qt = new QuanTri();
                    qt.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu",
                        "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Warning
                        );
                }
            }
        }
    }

    public static class LoginInfo
    {
        public static string UserID;
        public static Form loginf;
    }
}
