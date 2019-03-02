using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinamaProject
{
    public partial class UrunZimmetControl : UserControl
    {
        public UrunZimmetControl()
        {
            InitializeComponent();
        }
        zimmetdbEntities db = new zimmetdbEntities();
        private void UrunZimmetControl_Load(object sender, EventArgs e)
        {
            foreach(Kullanici k in db.Kullanici)
            {
                if (k.Aktiflik == 0)
                    continue;
                cmbKullaniciAdi.Items.Add(k.kullaniciAdi.ToString());
                cmbCikarilanKullaniciAdi.Items.Add(k.kullaniciAdi.ToString());
            }
            foreach(Esya es in db.Esya)
            {
                foreach (Depo d in db.Depo)
                {
                    if ((es.EsyaId == d.EsyaId)&&(d.StokMiktari>0) && !(cmbUrunAd.Items.Contains(es.EsyaAdı)))
                    {
                        cmbUrunAd.Items.Add(es.EsyaAdı);
                    }
                }
                
            }
        }

        private void cmbUrunAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMarka.Items.Clear();
            foreach(Esya es in db.Esya)
            {
                if ((es.EsyaAdı == cmbUrunAd.SelectedItem.ToString())&&!(cmbMarka.Items.Contains(es.Marka)))
                {
                    cmbMarka.Items.Add(es.Marka);
                }
            }
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            foreach(Esya es in db.Esya)
            {
                if (es.EsyaAdı == cmbUrunAd.SelectedItem.ToString() && es.Marka == cmbMarka.SelectedItem.ToString()&& !(cmbModel.Items.Contains(es.Model)))
                {
                    cmbModel.Items.Add(es.Model);
                }
            }
        }

        private void btnZimmetle_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(cmbKullaniciAdi.Text))|| (string.IsNullOrEmpty(cmbUrunAd.Text))|| (string.IsNullOrEmpty(cmbMarka.Text))|| (string.IsNullOrEmpty(cmbModel.Text)))
            {
                MessageBox.Show("Alanlar boş geçilemez.");
                return;
            }
            
            ZimmetController.Zimmetle(db, cmbKullaniciAdi.SelectedItem.ToString(), cmbUrunAd.SelectedItem.ToString(), cmbMarka.SelectedItem.ToString(), cmbModel.SelectedItem.ToString());
            cmbUrunAd.Items.Clear();
            foreach (Esya es in db.Esya)
            {
                foreach (Depo d in db.Depo)
                {
                    if ((es.EsyaId == d.EsyaId) && (d.StokMiktari > 0) && !(cmbUrunAd.Items.Contains(es.EsyaAdı)))
                    {
                        cmbUrunAd.Items.Add(es.EsyaAdı);
                    }
                }

            }
            cmbMarka.Items.Clear();
            cmbModel.Items.Clear();
        }

        private void cmbCikarilanAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCikarilanMarka.Items.Clear();
            foreach(Esya es in db.Esya)
            {
                if ((es.EsyaAdı == cmbCikarilanAd.SelectedItem.ToString())&& !(cmbCikarilanMarka.Items.Contains(es.Marka)))
                {
                    cmbCikarilanMarka.Items.Add(es.Marka);
                }
            }
        }

        private void cmbCikarilanMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCikarilanModel.Items.Clear();
            foreach(Esya es in db.Esya)
            {
                if ((es.EsyaAdı == cmbCikarilanAd.SelectedItem.ToString()) && (es.Marka == cmbCikarilanMarka.SelectedItem.ToString())&& !(cmbCikarilanModel.Items.Contains(es.Model)))
                {
                    cmbCikarilanModel.Items.Add(es.Model);
                }
            }
        }

        private void cmbCikarilanKullaniciAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach(Kullanici k in db.Kullanici)
            {
                if (k.kullaniciAdi == cmbCikarilanKullaniciAdi.SelectedItem.ToString())
                {
                    cmbCikarilanAd.Items.Clear();
                    foreach (Zimmet z in db.Zimmet)
                    {
                        foreach (Esya es in db.Esya)
                        {
                            if ((z.CalisanId == k.kullaniciId) && (z.EsyaId == es.EsyaId) && !(cmbCikarilanAd.Items.Contains(es.EsyaAdı)))
                            {
                                cmbCikarilanAd.Items.Add(es.EsyaAdı);
                            }
                        }
                    }
                }
                
            }
        }

        private void btnZimmetCikar_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(cmbCikarilanKullaniciAdi.Text))||(string.IsNullOrEmpty(cmbCikarilanAd.Text))|| (string.IsNullOrEmpty(cmbCikarilanMarka.Text))|| (string.IsNullOrEmpty(cmbCikarilanModel.Text)))
            {
                MessageBox.Show("Alanlar boş geçilemez.");
                return;
            }

            ZimmetController.ZimmetKaldir(db, cmbCikarilanKullaniciAdi.SelectedItem.ToString(), cmbCikarilanAd.SelectedItem.ToString(), cmbCikarilanMarka.SelectedItem.ToString(), cmbCikarilanModel.SelectedItem.ToString());
            string secilen = cmbCikarilanAd.SelectedItem.ToString();
            cmbCikarilanAd.Items.Clear();
            cmbCikarilanMarka.Items.Clear();
            cmbCikarilanModel.Items.Clear();
            db.SaveChanges();
        }

        private void cmbKullaniciAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbKullaniciAdi.Items.Clear();
            cmbCikarilanKullaniciAdi.Items.Clear();
            foreach (Kullanici k in db.Kullanici)
            {
                if (k.Aktiflik == 0)
                    continue;
                cmbKullaniciAdi.Items.Add(k.kullaniciAdi.ToString());
                cmbCikarilanKullaniciAdi.Items.Add(k.kullaniciAdi.ToString());
            }
            cmbUrunAd.Items.Clear();
            foreach (Esya es in db.Esya)
            {
                foreach (Depo d in db.Depo)
                {
                    if ((es.EsyaId == d.EsyaId) && (d.StokMiktari > 0) && !(cmbUrunAd.Items.Contains(es.EsyaAdı)))
                    {
                        cmbUrunAd.Items.Add(es.EsyaAdı);
                    }
                }

            }

        }
    }
}
