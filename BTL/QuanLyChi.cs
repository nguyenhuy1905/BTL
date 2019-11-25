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
    public partial class QuanLyChi : Form
    {
        public QuanLyChi()
        {
            InitializeComponent();
        }

        private void QuanLyChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTHUCHIDataSet1.LOAIKHOANCHI' table. You can move, or remove it, as needed.
            this.lOAIKHOANCHITableAdapter.Fill(this.qLTHUCHIDataSet1.LOAIKHOANCHI);
            load_data();
        }
        private void load_data()
        {
            dataGridView1.Rows.Clear();
            using (var db = new QLTHUCHIEntities())
            {

                var dskc = db.KHOANCHIs
                    .OrderByDescending(kc=>kc.ngay).ToList();
                var tong = dskc.Sum(kc => kc.sotien);
                lbltong.Text = Convert.ToInt32(tong)+ " vnd";
                foreach (var kc in dskc)
                {
                    dataGridView1.Rows.Add(
                        kc.sotien,
                        kc.ngay,
                        kc.chitiet,
                        kc.LOAIKHOANCHI1.tenkhoanchi,
                        kc.nguoithem,
                        kc.ID
                        );

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new QLTHUCHIEntities())
            {
                KHOANCHI kc = new KHOANCHI {
                    sotien = Convert.ToDecimal(txtSoTien.Text),
                    chitiet = txtChiTiet.Text,
                    loaikhoanchi = Convert.ToInt32(comboLoaiKhoanChi.SelectedValue),
                    ngay = DateTime.Now,
                    nguoithem = LoginInfo.UserID
                };
                db.KHOANCHIs.Add(kc);
                db.SaveChanges();
                load_data();

            }
        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            var index = dataGridView1.SelectedCells[0].RowIndex;
            var row = dataGridView1.Rows[index];
            txtSoTien.Text = row.Cells[0].Value?.ToString();
            txtChiTiet.Text = row.Cells[2].Value?.ToString();
            comboLoaiKhoanChi.Text = row.Cells[3].Value?.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.SelectedCells[0].RowIndex;
            var row = dataGridView1.Rows[index];
            var id = Convert.ToInt32(row.Cells[5].Value);
            using (var db = new QLTHUCHIEntities())
            {
                
                var kc = db.KHOANCHIs.Find(id);
                kc.ngay = DateTime.Now;
                kc.sotien = Convert.ToDecimal(txtSoTien.Text);
                kc.chitiet = txtChiTiet.Text;
                kc.loaikhoanchi = Convert.ToInt32(comboLoaiKhoanChi.SelectedValue);
                kc.nguoithem = LoginInfo.UserID;
                db.SaveChanges();
                MessageBox.Show("Sửa thành công! ");
            }
            load_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            using (var db = new QLTHUCHIEntities())
            {
                var dskc = db.KHOANCHIs.Where(kc=>kc.ngay.Value
                >= startDate.Value.Date && kc.ngay.Value <= endDate.Value.Date)
                    .OrderByDescending(kc => kc.ngay).ToList();
                var tong = dskc.Sum(kc => kc.sotien);
                lbltong.Text = Convert.ToInt32(tong) + " vnd";
                foreach (var kc in dskc)
                {
                    dataGridView1.Rows.Add(
                        kc.sotien,
                        kc.ngay,
                        kc.chitiet,
                        kc.LOAIKHOANCHI1.tenkhoanchi,
                        kc.nguoithem,
                        kc.ID
                        );

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.SelectedCells[0].RowIndex;
            var row = dataGridView1.Rows[index];
            var id = Convert.ToInt32(row.Cells[5].Value);
            if (MessageBox.Show("Chắc chưa?","Xóa",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new QLTHUCHIEntities())
                {
                    var kc=db.KHOANCHIs.Find(id);
                    db.KHOANCHIs.Remove(kc);
                    db.SaveChanges();
                    load_data();
                }
            }

        }
    }
}
