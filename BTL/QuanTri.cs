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
    public partial class QuanTri : Form
    {
        private readonly List<UserControl> controls = new List<UserControl>();
        
        public QuanTri()
        {
            InitializeComponent();
            this.Text = "Xin Chào " + LoginInfo.UserID;
            controls.Add(doiMK1);
            //controls.Add(quanLyLopHoc1);
            //controls.Add(quanLyHocSinh1);
        }

        private void Change(int n)
        {
            for (int i = 0; i < controls.Count; i++)
            {
                if (i == n)
                {
                    controls[i].Visible = true;
                }
                else
                {
                    controls[i].Visible = false;
                }
            }
            
        }

        private new void Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Đổi mật khẩu";
            Change(0);
        }


        private void QuảnLýKhoảnThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginInfo.loginf.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Quản lý lớp học";
            //Change(1);
            var frm = new QuanLyLopHoc();
            frm.ShowDialog();
        }

        private void QuanLyLopHoc1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void QuảnLýThuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QuảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Quản lý học sinh";
            //Change(2);
            var frm = new QuanLyHocSinh();
            frm.ShowDialog();
        }
    }
}
