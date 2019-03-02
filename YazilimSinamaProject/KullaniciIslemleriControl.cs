using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core;

namespace YazilimSinamaProject
{
    public partial class KullaniciIslemleriControl : UserControl
    {
        public KullaniciIslemleriControl()
        {
            InitializeComponent();
        }
        zimmetdbEntities db = new zimmetdbEntities();
        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(cmbDepartman.Text))||(string.IsNullOrEmpty(cmbGorev.Text))||(string.IsNullOrEmpty(txtKullaniciAdi.Text))|| (string.IsNullOrEmpty(txtAd.Text))|| (string.IsNullOrEmpty(txtSoyad.Text))|| (string.IsNullOrEmpty(txtSifre.Text)))
            {
                MessageBox.Show("Alanlar boş geçilemez.");
                return;
            }
            
            KullaniciController.KullaniciEkle(db,cmbDepartman.SelectedItem.ToString(),cmbGorev.SelectedItem.ToString(),txtKullaniciAdi.Text,txtAd.Text,txtSoyad.Text,txtSifre.Text);
            cmbSilinen.Items.Clear();
            foreach (Kullanici k in db.Kullanici)
            {
                if (k.Aktiflik == 0)
                    continue;
                cmbSilinen.Items.Add(k.kullaniciAdi);
            }


        }

        private void KullaniciIslemleriControl_Load(object sender, EventArgs e)
        {
            foreach (Departman d in db.Departman)
            {
                cmbDepartman.Items.Add(d.DepartmanAdi);
            }
            foreach (Rutbe r in db.Rutbe)
            {
                cmbGorev.Items.Add(r.Rutbe1);
            }
            foreach(Kullanici k in db.Kullanici)
            {
                if (k.Aktiflik == 0)
                    continue;
                cmbSilinen.Items.Add(k.kullaniciAdi);
            }
        }
        
        private void btnKullaniciCikar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbSilinen.Text))
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez.");
                return;
            }
            foreach (Kullanici k in db.Kullanici)
            {
                if (k.kullaniciAdi == cmbSilinen.SelectedItem.ToString())
                {
                    foreach (Zimmet z in db.Zimmet)
                    {
                        if (k.kullaniciId == z.CalisanId)
                        {
                            MessageBox.Show("Kullanıcıya zimmetli ürünler var.");
                            return;
                        }
                    }
                }
                
            }
            KullaniciController.KullaniciSil(db, cmbSilinen.SelectedItem.ToString());
            cmbSilinen.Items.Clear();
            foreach (Kullanici k in db.Kullanici)
            {
                if (k.Aktiflik == 0)
                    continue;
                cmbSilinen.Items.Add(k.kullaniciAdi);
            }
            cmbSilinen.SelectedIndex = cmbSilinen.Items.Count - 1;

        }
    }
    }

