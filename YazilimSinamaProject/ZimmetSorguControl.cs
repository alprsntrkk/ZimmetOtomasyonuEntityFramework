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
    public partial class ZimmetSorguControl : UserControl
    {
        public ZimmetSorguControl()
        {
            InitializeComponent();
        }
        zimmetdbEntities db = new zimmetdbEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Kullanıcı Adı", typeof(string));
            table.Columns.Add("Ürün Adı", typeof(string));
            table.Columns.Add("Markası", typeof(string));
            table.Columns.Add("Modeli", typeof(string));
            table.Columns.Add("Zimmet Tarihi", typeof(DateTime));
            table.Columns.Add("Departman", typeof(string));
            foreach (Kullanici k in db.Kullanici)
            {
                foreach (Zimmet z in db.Zimmet)
                {
                    foreach (Esya es in db.Esya)
                    {
                        foreach (Departman d in db.Departman)
                        {
                            if ((es.EsyaId == z.EsyaId)&&(d.DepartmanId==k.DepartmanId)&&(k.kullaniciId==z.CalisanId))
                            {
                                table.Rows.Add(k.kullaniciAdi, es.EsyaAdı, es.Marka, es.Model, z.ZimmetVakti,d.DepartmanAdi);
                            }
                        }

                     }
                        
                 }
                
            }
            grdZimmet.DataSource = table;
        }

        private void ZimmetSorguControl_Load(object sender, EventArgs e)
        {
            foreach(Kullanici k in db.Kullanici)
            {
                cmbKullaniciAdi.Items.Add(k.kullaniciAdi.ToString());
            }
        }

        private void btnKullaniciSorgula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı adı boş geçilemez.");
                return;
            }
            DataTable table = new DataTable();
            table.Columns.Add("Kullanıcı Adı",typeof(string));
            table.Columns.Add("Ürün Adı", typeof(string));
            table.Columns.Add("Markası", typeof(string));
            table.Columns.Add("Modeli", typeof(string));
            table.Columns.Add("Zimmet Tarihi", typeof(DateTime));
            table.Columns.Add("Departman", typeof(string));
            foreach (Kullanici k in db.Kullanici)
            {
                if (k.kullaniciAdi == cmbKullaniciAdi.Text)
                {

                    foreach(Zimmet z in db.Zimmet)
                    {
                        if (k.kullaniciId == z.CalisanId)
                        {
                            foreach(Esya es in db.Esya)
                            {
                                foreach (Departman d in db.Departman)
                                {
                                    if ((es.EsyaId == z.EsyaId)&&(d.DepartmanId==k.DepartmanId))
                                    {
                                        table.Rows.Add(k.kullaniciAdi, es.EsyaAdı, es.Marka, es.Model, z.ZimmetVakti,d.DepartmanAdi);
                                    }
                                }
                                
                            }
                        }
                    }
                }
            }
            grdZimmet.DataSource = table; 
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            cmbKullaniciAdi.Items.Clear();
            foreach (Kullanici k in db.Kullanici)
            {
                cmbKullaniciAdi.Items.Add(k.kullaniciAdi.ToString());
            }

        }
    }
}
