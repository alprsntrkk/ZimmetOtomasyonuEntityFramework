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
    public partial class DepartmanŞefi : Form
    {
        public DepartmanŞefi()
        {
            InitializeComponent();
        }
        zimmetdbEntities db = new zimmetdbEntities();
        private void button2_Click(object sender, EventArgs e)
        {
            pnlBtn2.Top = btnSorgu.Top;

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Kullanıcı Adı", typeof(string));
            table.Columns.Add("Ürün Adı", typeof(string));
            table.Columns.Add("Markası", typeof(string));
            table.Columns.Add("Modeli", typeof(string));
            table.Columns.Add("Zimmet Tarihi", typeof(DateTime));
            table.Columns.Add("Departman", typeof(string));

            string departmanKullanici = cmbKullaniciAdiSef.Items[0].ToString();
            int departmanId = 0;
            foreach (Kullanici k in db.Kullanici)
            {
                if(k.kullaniciAdi == departmanKullanici)
                {
                    departmanId = k.DepartmanId;
                }
            }
            Departman dep = new Departman();
            foreach (Departman d in db.Departman)
            {
                if ( departmanId== d.DepartmanId)
                {

                    dep.DepartmanAdi = d.DepartmanAdi;
                    dep.DepartmanId = d.DepartmanId;
                }
            }
            foreach (Kullanici k in db.Kullanici)
            {
                if (k.DepartmanId == dep.DepartmanId)
                {
                    foreach (Zimmet z in db.Zimmet)
                    {
                        foreach (Esya es in db.Esya)
                        {
                            if ((es.EsyaId == z.EsyaId) && (k.kullaniciId == z.CalisanId))
                            {
                                table.Rows.Add(k.kullaniciAdi, es.EsyaAdı, es.Marka, es.Model, z.ZimmetVakti, dep.DepartmanAdi);
                            }

                        }

                    }

                }

            }
            grdZimmet.DataSource = table;
            
        }

        private void btnKullaniciSorgula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbKullaniciAdiSef.Text))
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez.");
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("Kullanıcı Adı", typeof(string));
            table.Columns.Add("Ürün Adı", typeof(string));
            table.Columns.Add("Markası", typeof(string));
            table.Columns.Add("Modeli", typeof(string));
            table.Columns.Add("Zimmet Tarihi", typeof(DateTime));
            table.Columns.Add("Departman", typeof(string));

            Departman dep = new Departman();
            foreach (Departman d in db.Departman)
            {
                if (GlobalKullanicim.Kullanicim.DepartmanId == d.DepartmanId)
                {

                    dep.DepartmanAdi = d.DepartmanAdi;
                    dep.DepartmanId = d.DepartmanId;
                }
            }
            foreach (Kullanici k in db.Kullanici)
            {

                foreach (Zimmet z in db.Zimmet)
                {
                    foreach (Esya es in db.Esya)
                    {
                        if ((es.EsyaId == z.EsyaId) && (k.kullaniciId == z.CalisanId)&&(k.kullaniciAdi==cmbKullaniciAdiSef.SelectedItem.ToString()))
                        {
                            table.Rows.Add(k.kullaniciAdi, es.EsyaAdı, es.Marka, es.Model, z.ZimmetVakti, dep.DepartmanAdi);
                        }

                    }

                }

            }
            grdZimmet.DataSource = table;
        }
        Kullanici kul = new Kullanici();
        private void DepartmanŞefi_Load(object sender, EventArgs e)
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
