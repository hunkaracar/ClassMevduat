using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    public class Amevzuat : MevzuatBase
    {

        public int MevzuatValueA { get; set; }
        public int AylıkValueA { get; set; }
        public override void degerlendir()
        {
            Console.WriteLine("A mevzuatı değerlendirildi...");
        }

        public override int MevzuatHesapla(int MevzuatValueA,int AylıkValueA)
        {
            int resultA = MevzuatValueA * AylıkValueA;
            return resultA;
        }
    }
}
