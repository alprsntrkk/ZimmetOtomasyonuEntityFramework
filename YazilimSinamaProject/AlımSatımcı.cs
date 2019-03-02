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
    public partial class AlımSatımcı : Form
    {
        public AlımSatımcı()
        {
            InitializeComponent();
        }
        zimmetdbEntities db = new zimmetdbEntities();

        private void AlımSatımcı_Load(object sender, EventArgs e)
        {
            pnlBtn2.Top = btnUrunIslemleri.Top;
            userControl11.BringToFront();
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            pnlBtn2.Top = btnUrunIslemleri.Top;
            userControl11.BringToFront();
        }

        private void btnTakip_Click(object sender, EventArgs e)
        {
            pnlBtn2.Top = btnTakip.Top;
            userControl21.BringToFront();
        }

        private void lblCik_Click(object sender, EventArgs e)
        {
            GirisForm gs = new GirisForm();
            this.Hide();
            gs.Show();
        }
    }
}
