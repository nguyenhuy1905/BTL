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
    public partial class QuanLyLopHoc : Form
    {
        public QuanLyLopHoc()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadGrid()
        {
            using(var db = new QLTHUCHIEntities())
            {
                var dslop = db.LOPs.ToList();
                grdLop.Rows.Clear();
                dslop.ForEach(lop => {
                    grdLop.Rows.Add(lop.tenlop, lop.namhoc, lop.HOCSINHs.Count,false,lop.id);
                });
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LOP lop = new LOP {namhoc=cbxNamHoc.Text,
            tenlop=txtTenLop.Text};
            using (var db = new QLTHUCHIEntities())
            {
                db.LOPs.Add(lop);
                db.SaveChanges();
                LoadGrid();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            List<int> dsid = new List<int>();
            
            for(int i = 0; i < grdLop.Rows.Count; i++)
            {
                if (Convert.ToBoolean(grdLop.Rows[i].Cells[3].Value))
                {
                    dsid.Add(Convert.ToInt32(grdLop.Rows[i].Cells[4].Value));
                }
            }
            if (dsid.Count>0)
            {
                var ms = MessageBox.Show("Bạn có muốn xóa " + dsid.Count + " lớp không?","Xác nhận xóa",MessageBoxButtons.YesNo);
                if (ms == DialogResult.No) return;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa");
            }
            

            using (var db = new QLTHUCHIEntities())
            {
                var dslop = db.LOPs.Where(l => dsid.Contains(l.id));
                db.LOPs.RemoveRange(dslop);
                db.SaveChanges();
                LoadGrid();
            }
        }

        private void Process1_Exited(object sender, EventArgs e)
        {

        }
    }
}
