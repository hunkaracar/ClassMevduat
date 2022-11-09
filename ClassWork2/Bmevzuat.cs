using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    public class Bmevzuat : MevzuatBase
    {
        public int MevzuatValue { get; set; }
        public int AylıkValue { get; set; }
        public override void degerlendir()
        {
            Console.WriteLine("B mevzuatı değerlendirildi...");
        }

        public override int MevzuatHesapla(int MevzuatValue,int AylıkValue)
        {
            int result = MevzuatValue * AylıkValue;
            return result;  
        }
    }
}
