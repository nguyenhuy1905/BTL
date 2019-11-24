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
    public partial class QuanLyHocSinh : Form
    {
        public QuanLyHocSinh()
        {
            InitializeComponent();
            using(var db = new QLTHUCHIEntities())
            {
                cbxLop.DisplayMember = "Text";
                cbxLop.ValueMember = "Value";
                var li = db.LOPs.ToList();
                cbxLop.DataSource = li;
                li.ForEach(l =>
                {
                    cbxLop.Items.Add(new {
                        Text = l.tenlop,
                        Value = l.id
                    });
                });
            }
            
        }

        void LoadHS()
        {
            int idLop = (cbxLop.SelectedItem as dynamic).Value;
            using (var db = new QLTHUCHIEntities())
            {
                grdLop.Rows.Clear();
                var dshs = db.LOPs.Find(idLop).HOCSINHs.ToList();
                dshs.ForEach(hs => {
                    var tien = hs.KHOANTHUs.Sum(kt => kt.sotien);
                    grdLop.Rows.Add(false, hs.tenhs, hs.diachi, tien, hs.id);
                });
            }
            
        }

        private void CbxNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHS();
            txtDiaChi.Clear();
            txtTenHS.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int idLop = (cbxLop.SelectedItem as dynamic).Value;
            
            using (var db = new QLTHUCHIEntities())
            {
                var tk = db.TAIKHOANs.Find(LoginInfo.UserID);
                HOCSINH hs = new HOCSINH
                {
                    diachi = txtDiaChi.Text,
                    tenhs = txtTenHS.Text,
                };
                hs.KHOANTHUs.Add(new KHOANTHU { loaikhoanthu = 1, TAIKHOAN = tk, ngay= DateTime.Now });
                hs.KHOANTHUs.Add(new KHOANTHU { loaikhoanthu = 2, TAIKHOAN = tk, ngay = DateTime.Now });
                hs.KHOANTHUs.Add(new KHOANTHU { loaikhoanthu = 3, TAIKHOAN = tk, ngay = DateTime.Now });
                hs.KHOANTHUs.Add(new KHOANTHU { loaikhoanthu = 4, TAIKHOAN = tk, ngay = DateTime.Now });
                hs.KHOANTHUs.Add(new KHOANTHU { loaikhoanthu = 5, TAIKHOAN = tk, ngay = DateTime.Now });
                hs.KHOANTHUs.Add(new KHOANTHU { loaikhoanthu = 6, TAIKHOAN = tk, ngay = DateTime.Now });
                hs.KHOANTHUs.Add(new KHOANTHU { loaikhoanthu = 7, TAIKHOAN = tk, ngay = DateTime.Now });
                db.LOPs.Find(idLop).HOCSINHs.Add(hs);
                db.SaveChanges();
            }
            LoadHS();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            List<int> dsid = new List<int>();

            for (int i = 0; i < grdLop.Rows.Count; i++)
            {
                if (Convert.ToBoolean(grdLop.Rows[i].Cells["chon"].Value))
                {
                    dsid.Add(Convert.ToInt32(grdLop.Rows[i].Cells["id"].Value));
                }
            }
            if (dsid.Count > 0)
            {
                var ms = MessageBox.Show("Bạn có muốn xóa " + dsid.Count + " học sinh?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (ms == DialogResult.No) return;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học sinh cần xóa");
            }


            using (var db = new QLTHUCHIEntities())
            {
                var dshs = db.HOCSINHs.Where(hs => dsid.Contains(hs.id));
                db.HOCSINHs.RemoveRange(dshs);
                db.SaveChanges();
            }
            LoadHS();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var index = grdLop.SelectedCells[0].RowIndex;
            var idHs = Convert.ToInt32(grdLop.Rows[index].Cells["id"].Value??-1);
            if (idHs != -1)
            {
                var frm = new ChiTietHocPhi(idHs);
                frm.FormClosed += CbxNamHoc_SelectedIndexChanged;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 học sinh");
            }
            
        }
    }
}
