using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class DoiMK : UserControl
    {
        public DoiMK()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (var db = new QLTHUCHIEntities())
            {
                var user = db.TAIKHOANs.Find(LoginInfo.UserID);
                    
                if(txtPass.Text!=user.password)
                {
                    MessageBox.Show("Sai mật khẩu cũ",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning
                        );
                }
                else
                {
                    if (txtNewPass.Text != txtReType.Text)
                    {
                        MessageBox.Show("Mật khẩu mới không trung khớp",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning
                        );
                    }
                    else
                    {
                        user.password = txtNewPass.Text;
                        db.SaveChanges();
                        MessageBox.Show("Đổi mật khẩu thành công",
                        "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                    }
                }
            }
        }
    }
}
