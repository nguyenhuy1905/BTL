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
    public partial class ChiTietHocPhi : Form
    {
        private int idhs;
        public ChiTietHocPhi(int idhs)
        {
            InitializeComponent();
            this.idhs = idhs;
        }

        private void ChiTietHocPhi_Load(object sender, EventArgs e)
        {
            using (var db = new QLTHUCHIEntities())
            {
                HOCSINH hs = db.HOCSINHs.Find(idhs);
                lblTen.Text = hs.tenhs;
                lblLop.Text = hs.LOP.tenlop;
                txtBhyt.Text = hs.KHOANTHUs.Where(t => t.loaikhoanthu == 3)
                    .First().sotien?.ToString();
                txtCoSoVC.Text = hs.KHOANTHUs.Where(t => t.loaikhoanthu == 7)
                    .First().sotien?.ToString();
                txtDongPhuc.Text = hs.KHOANTHUs.Where(t => t.loaikhoanthu == 5)
                    .First().sotien?.ToString();
                txtHocPhi.Text = hs.KHOANTHUs.Where(t => t.loaikhoanthu == 1)
                    .First().sotien.ToString();
                txtQuyLop.Text = hs.KHOANTHUs.Where(t => t.loaikhoanthu == 4)
                    .First().sotien?.ToString();
                txtThietbiHocTap.Text = hs.KHOANTHUs.Where(t => t.loaikhoanthu == 6)
                    .First().sotien?.ToString();
                txtTienAn.Text = hs.KHOANTHUs.Where(t => t.loaikhoanthu == 2)
                    .First().sotien?.ToString();

                lblNgay.Text = String.Format("Cập nhật lần cuối vào {0 : dd/MM/yyyy hh:mm:ss}" , 
                    hs.KHOANTHUs.Max(kt => kt.ngay).Value);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Sua(true);
        }

        void Sua(bool isSua)
        {
            button2.Enabled = button3.Enabled = isSua;
            button1.Enabled = !isSua;
            txtBhyt.ReadOnly = txtCoSoVC.ReadOnly
                = txtDongPhuc.ReadOnly
                = txtHocPhi.ReadOnly
                = txtQuyLop.ReadOnly
                = txtThietbiHocTap.ReadOnly
                = txtTienAn.ReadOnly
                = !isSua;
            txtBhyt.Enabled = txtCoSoVC.Enabled
                = txtDongPhuc.Enabled
                = txtHocPhi.Enabled
                = txtQuyLop.Enabled
                = txtThietbiHocTap.Enabled
                = txtTienAn.Enabled
                = isSua;
        }

        decimal ToDec(string str)
        {
            return string.IsNullOrEmpty(str) ? 0 : Convert.ToDecimal(str);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using(var db = new QLTHUCHIEntities())
            {
                db.KHOANTHUs.Where(kt => kt.mahocsinh == idhs 
                    && kt.loaikhoanthu == 1).First()
                    .sotien = ToDec(txtHocPhi.Text);

                db.KHOANTHUs.Where(kt => kt.mahocsinh == idhs
                    && kt.loaikhoanthu == 2).First()
                    .sotien = ToDec(txtTienAn.Text);

                db.KHOANTHUs.Where(kt => kt.mahocsinh == idhs
                    && kt.loaikhoanthu == 3).First()
                    .sotien = ToDec(txtBhyt.Text);

                db.KHOANTHUs.Where(kt => kt.mahocsinh == idhs
                    && kt.loaikhoanthu == 4).First()
                    .sotien = ToDec(txtQuyLop.Text);

                db.KHOANTHUs.Where(kt => kt.mahocsinh == idhs
                    && kt.loaikhoanthu == 5).First()
                    .sotien = ToDec(txtDongPhuc.Text);

                db.KHOANTHUs.Where(kt => kt.mahocsinh == idhs
                    && kt.loaikhoanthu == 6).First()
                    .sotien = ToDec(txtThietbiHocTap.Text);

                db.KHOANTHUs.Where(kt => kt.mahocsinh == idhs
                    && kt.loaikhoanthu == 7).First()
                    .sotien = ToDec(txtCoSoVC.Text);

                db.SaveChanges();
            }

            MessageBox.Show("Sửa thành công");

            Sua(false);

            ChiTietHocPhi_Load(sender, e);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Sua(false);
            ChiTietHocPhi_Load(sender, e);
        }
    }
}
