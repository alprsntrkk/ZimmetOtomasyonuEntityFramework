using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YazilimSinamaProject;

namespace UnitTestProject1
{
    [TestClass]
    public class ZimmetTest
    {
        [TestMethod]
        public void TestUrunSat()
        {
            zimmetdbEntities db = new zimmetdbEntities();
            UrunController.UrunSat(db, 5, "telefon", "iphone", "se");
        }
        [TestMethod]
        public void TestUrunStokArttir()
        {
            zimmetdbEntities db = new zimmetdbEntities();
            UrunController.UrunStokArttır(db, 5, "telefon", "iphone", "se");
        }
        [TestMethod]
        public void TestKullaniciEkle()
        {
            zimmetdbEntities db = new zimmetdbEntities();
            KullaniciController.KullaniciEkle(db,"A","Admin","hikmet35","Hikmet","Dönmez","1234");
        }
        [TestMethod]
        public void TestZimmetle()
        {
            zimmetdbEntities db = new zimmetdbEntities();
            ZimmetController.Zimmetle(db, "alprsntrkk", "telefon", "iphone", "se");
        }
    }
}
