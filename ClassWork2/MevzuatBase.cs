using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    public abstract class MevzuatBase
    {
        protected MevzuatBase()
        {
            Console.WriteLine("Mevzuat Bilgileri|");
        }

        public abstract void degerlendir();
        public abstract int MevzuatHesapla(int val1,int val2);

        public void kaydet()
        {
            Console.WriteLine("Mevzuat Bilgileri Kaydedildi...");
        }
    }
}
