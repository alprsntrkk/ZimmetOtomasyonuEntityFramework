using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaProject
{
    public static class ZimmetController
    {
        public static void Zimmetle(zimmetdbEntities db,string _kullaniciAdi,string _urunAd,string _urunMarka,string _urunModel)
        {
            foreach (Kullanici k in db.Kullanici)
            {
                if (k.kullaniciAdi == _kullaniciAdi)
                {
                    foreach (Esya es in db.Esya)
                    {
                        if ((es.EsyaAdı == _urunAd) && (es.Marka == _urunMarka) && (es.Model == _urunModel))
                        {
                            
                            Zimmet z = new Zimmet();
                            z.EsyaId = es.EsyaId;
                            z.CalisanId = k.kullaniciId;
                            var depom = es.Depo;
                            depom.StokMiktari--;
                            z.ZimmetVakti = DateTime.Now;
                            db.Zimmet.Add(z);
                        }
                    }
                }
            }
            db.SaveChanges();
            System.Windows.Forms.MessageBox.Show("İşlem başarılı.");
        }
        public static void ZimmetKaldir(zimmetdbEntities db,string _kullaniciAdi,string _urunAdi,string _Marka,string _Model)
        {
            foreach (Kullanici k in db.Kullanici)
            {
                if (k.kullaniciAdi == _kullaniciAdi)
                {
                    foreach (Zimmet z in db.Zimmet)
                    {
                        if (z.CalisanId == k.kullaniciId)
                        {
                            foreach (Depo d in db.Depo)
                            {
                                if (d.EsyaId == z.EsyaId)
                                {
                                    d.StokMiktari++;
                                    db.Zimmet.Remove(z);
                                    System.Windows.Forms.MessageBox.Show("İşlem başarılı.");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            
        }
    }
}
