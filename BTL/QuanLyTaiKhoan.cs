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
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            LoadGrid();
        }

        void LoadGrid()
        {
            using(var db = new QLTHUCHIEntities())
            {
                //List<TAIKHOAN> dstk = db.TAIKHOANs.ToList();
                //dstk.ForEach(tk => {
                //    grdTK.Rows.Add(false, tk.username,
                //        tk.username.StartsWith("admin",StringComparison.CurrentCultureIgnoreCase));
                //});
            }
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
