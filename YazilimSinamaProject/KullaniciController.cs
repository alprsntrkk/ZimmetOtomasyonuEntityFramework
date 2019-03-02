using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaProject
{
    public static class KullaniciController
    {
        public static void KullaniciEkle(zimmetdbEntities db,string _departmanAdi,string _gorev,string _kullaniciAdi,string _ad,string _soyad,string _sifre)
        {
            int departmanId = 0;
            int rutbeId = 0;
            foreach (Departman d in db.Departman)
            {
                if (d.DepartmanAdi == _departmanAdi)
                {
                    departmanId = d.DepartmanId;
                }
            }
            foreach (Rutbe r in db.Rutbe)
            {
                if (r.Rutbe1 == _gorev)
                {
                    rutbeId = r.RutbeId;
                }
            }
            foreach (Kullanici k in db.Kullanici)
            {
                if (k.kullaniciAdi == _kullaniciAdi)
                {
                    System.Windows.Forms.MessageBox.Show("Böyle bir kullanıcı adı zaten kayıtlı.");
                    return;
                }
            }
            Kullanici kul = new Kullanici();
            kul.kullaniciAdi = _kullaniciAdi;
            kul.Ad = _ad;
            kul.Soyad = _soyad;
            kul.sifre = _sifre;
            kul.RutbeId = rutbeId;
            kul.DepartmanId = departmanId;
            kul.Aktiflik = 1;
            db.Kullanici.Add(kul);
            db.SaveChanges();
            System.Windows.Forms.MessageBox.Show("Kullanıcı başarılı bir şekilde eklendi.");
        }
        public static void KullaniciSil(zimmetdbEntities db,string _kullaniciAdi)
        {
            Kullanici k = db.Kullanici.Where(a => a.kullaniciAdi == _kullaniciAdi).FirstOrDefault();
            k.Aktiflik = 0;
            db.SaveChanges();
            System.Windows.Forms.MessageBox.Show("İşlem başarılı.");
        }
    }
}
