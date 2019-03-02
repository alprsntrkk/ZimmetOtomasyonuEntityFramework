using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaProject
{
    public static class UrunController
    {
        public static void UrunKaydet(zimmetdbEntities db,string _esyaAdi,string _esyaMarka,string _esyaModel)
        {
            foreach (Esya esya in db.Esya)
            {
                if ((esya.EsyaAdı == _esyaAdi) && (esya.Marka == _esyaMarka) && (esya.Model == _esyaModel))
                {
                    System.Windows.Forms.MessageBox.Show("Bu ürün zaten kayıtlı.");
                    return;
                }
            }
            if (string.IsNullOrEmpty(_esyaAdi) || string.IsNullOrEmpty(_esyaMarka) || string.IsNullOrEmpty(_esyaModel))
            {
                System.Windows.Forms.MessageBox.Show("Alanlar boş geçilemez!");
                return;
            }
            Esya es = new Esya();
            es.EsyaAdı = _esyaAdi;
            es.Marka = _esyaMarka;
            es.Model = _esyaModel;
            Depo d = new Depo();
            d.EsyaId = es.EsyaId;
            db.Esya.Add(es);
            db.Depo.Add(d);
            db.SaveChanges();
            System.Windows.Forms.MessageBox.Show("Ürün alımı başarı ile kaydedildi.");
        }
        public static void UrunStokArttır(zimmetdbEntities db,int _miktar,string _ad,string _marka,string _model)
        {
            try
            {
                int esyaId = 0;
                foreach (Esya es in db.Esya)
                {
                    if ((es.EsyaAdı == _ad) && (es.Marka == _marka) && (es.Model == _model))
                    {
                        esyaId = es.EsyaId;
                        Depo d = db.Depo.Where(a => a.EsyaId == es.EsyaId).FirstOrDefault();
                        d.StokMiktari += _miktar;
                        System.Windows.Forms.MessageBox.Show("Stok miktarı başarılı bir şekilde arttırıldı.");
                    }

                }
                if (esyaId == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Böyle bir ürün kayıtlı değil.Lütfen seçimlerinizi gözden geçiriniz.");
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Lütfen uygun bir sayı giriniz.");
            }
            db.SaveChanges();
        }
        public static void UrunSat(zimmetdbEntities db,int _miktar,string _ad,string _marka,string _model)
        {
            try
            {
                int esyaId = 0;
                foreach (Esya es in db.Esya)
                {
                    if ((es.EsyaAdı == _ad) && (es.Marka == _marka) && (es.Model == _model))
                    {
                        esyaId = es.EsyaId;
                    }
                }
                if (esyaId == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Böyle bir ürün kayıtlı değil.Lütfen seçimlerinizi gözden geçiriniz.");
                    return;
                }

                Depo d = db.Depo.Where(x => x.EsyaId == esyaId).FirstOrDefault();
                if ((d.StokMiktari < _miktar) || (_miktar < 0))
                {
                    System.Windows.Forms.MessageBox.Show("Stokta yeteri kadar ürün yok ya da miktar bilgisi yanlış.Lütfen tekrar deneyiniz.");
                    return;
                }
                d.StokMiktari -= _miktar;
                System.Windows.Forms.MessageBox.Show("Satış işlemi başarı ile kaydedildi.");
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Lütfen uygun bir sayı giriniz.");
            }

            db.SaveChanges();

        }
    }
}
