using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinamaProject
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnKullaniciIslemleri_Click(object sender, EventArgs e)
        {
            pnlBtn.Top = btnKullaniciIslemleri.Top;
            kullaniciIslemleriControl1.BringToFront();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            kullaniciIslemleriControl1.BringToFront();
            
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            pnlBtn.Top = btnUrunIslemleri.Top;
            urunIslemleriControl1.BringToFront();
        }

        private void btnUrunZimmetle_Click(object sender, EventArgs e)
        {
            pnlBtn.Top = btnUrunZimmetle.Top;
            urunZimmetControl1.BringToFront();
        }

        private void btnZimmetListele_Click(object sender, EventArgs e)
        {
            pnlBtn.Top = btnZimmetListele.Top;
            zimmetSorguControl2.BringToFront();
        }

        private void btnZimmetListele_Click_1(object sender, EventArgs e)
        {
            pnlBtn.Top = btnZimmetListele.Top;
            zimmetSorguControl2.BringToFront();
        }

        private void btnStokTakip_Click(object sender, EventArgs e)
        {
            pnlBtn.Top = btnStokTakip.Top;
            stokTakipControl1.BringToFront();
        }

        private void stokTakipControl1_Load(object sender, EventArgs e)
        {

        }

        private void lblCik_Click(object sender, EventArgs e)
        {
            GirisForm gs = new GirisForm();
            this.Hide();
            gs.Show();
        }
    }
}
