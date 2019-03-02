using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaProject
{
    class GlobalKullanicim
    {
        private static Kullanici kullanicim =new Kullanici();

        public static Kullanici Kullanicim
        {
            get { return kullanicim; }
            set { kullanicim = value; }
        }
    }
}
