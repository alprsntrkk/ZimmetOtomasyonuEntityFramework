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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string errorMesage = "";
            bool isError = false;
            if (string.IsNullOrEmpty(kullaniciAdi))
            {
                errorMesage += "Kullanıcı adı alanını boş geçemezsiniz! \r\n";
                isError = true;
            }
            if (string.IsNullOrEmpty(sifre))
            {
                errorMesage += "Şifre alanını boş geçemezsiniz! \r\n";
                isError = true;
            }
            if (isError)
            {
                MessageBox.Show(errorMesage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isError = false;
                return;
            }
            Login(kullaniciAdi, sifre);
        }


        public bool Login(string _kullaniciAdi, string _sifre)
        {
            zimmetdbEntities db = new zimmetdbEntities();
            List<Kullanici> kullanicilar = db.Kullanici.ToList();
            bool logined = false;
            foreach (var k in kullanicilar)
            {
                if ((k.kullaniciAdi == _kullaniciAdi) && (k.sifre == _sifre) && (k.RutbeId == 4) && (k.Aktiflik != 0))
                {
                    AdminForm af = new AdminForm();
                    af.Show();
                    GlobalKullanicim.Kullanicim = k;
                    this.Hide();
                    logined = true;
                    break;
                }
                else if((k.kullaniciAdi == _kullaniciAdi) && (k.sifre == _sifre) && (k.RutbeId == 3) && (k.Aktiflik != 0))
                {
                    DepartmanŞefi ds = new DepartmanŞefi();
                    ds.Show();
                    foreach (Kullanici kd in db.Kullanici)
                    {
                        if (k.DepartmanId == kd.DepartmanId)
                        {
                            ds.cmbKullaniciAdiSef.Items.Add(kd.kullaniciAdi);
                        }
                    }
                    this.Hide();
                    logined = true;
                    break;
                }
                else if ((k.kullaniciAdi == _kullaniciAdi) && (k.sifre == _sifre) && (k.RutbeId == 2) && (k.Aktiflik != 0))
                {
                    AlımSatımcı alm = new AlımSatımcı();
                    alm.Show();
                    GlobalKullanicim.Kullanicim = k;
                    this.Hide();
                    logined = true;
                    break;
                }
                else if ((k.kullaniciAdi == _kullaniciAdi) && (k.sifre == _sifre) && (k.RutbeId == 1) && (k.Aktiflik != 0))
                {
                    MessageBox.Show("Giriş yapmaya yetkiniz yok.");
                    break;
                }

            }
            if (logined == false)
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre.");
            }
            return false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
