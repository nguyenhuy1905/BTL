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
            grdTK.Rows.Clear();
            using(var db = new QLTHUCHIEntities())
            {
                List<TAIKHOAN> dstk = db.TAIKHOANs.ToList();
                dstk.ForEach(tk =>
                {
                    grdTK.Rows.Add(false, tk.username,
                        tk.username.StartsWith("admin", StringComparison.CurrentCultureIgnoreCase));
                });
            }
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var listId = new List<string>();
            foreach(DataGridViewRow r in grdTK.Rows)
            {
                if (Convert.ToBoolean(r.Cells["chon"].Value))
                {
                    listId.Add(r.Cells["tk"].Value.ToString());
                }
            }
            if (listId.Count == 0)
            {
                MessageBox.Show("Vui long chọn tài khoản cần xóa");
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn xóa " + listId.Count + " tài khoản?",
               "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                using(var db = new QLTHUCHIEntities())
                {
                    var dstk = db.TAIKHOANs.Where(tk => listId.Contains(tk.username));
                    db.TAIKHOANs.RemoveRange(dstk);
                    db.SaveChanges();
                }
                LoadGrid();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using(var db = new QLTHUCHIEntities())
            {
                errorProvider1.Clear();
                if (txtTk.Text.Length < 5 || txtTk.Text.Contains(' '))
                {
                    errorProvider1.SetError(txtTk, "Tài khoản phải dài hơn 5 kí tự và không được chứa dấu cách");
                    return;
                }
                if (db.TAIKHOANs.Find(txtTk.Text) != null)
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                    errorProvider1.SetError(txtTk, "Tài khoản đã tồn tạ!");
                    return;
                }
                if (txtpwd.Text.Length < 5 || txtpwd.Text.Contains(' '))
                {
                    errorProvider1.SetError(txtpwd, "Mật khẩu phải dài hơn 5 kí tự và không được chứa dấu cách");
                    return;
                }
                db.TAIKHOANs.Add(new TAIKHOAN {
                    password = txtpwd.Text,
                    username = txtTk.Text
                });
                db.SaveChanges();
                MessageBox.Show("Thêm thành công");
                LoadGrid();
                errorProvider1.Clear();
                txtTk.Clear();
                txtpwd.Clear();
            }
        }
    }
}
