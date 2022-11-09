using ClassWork2;

namespace ClassWork2;


class Program
{
    public static void Main()
    {

        //List<string> list = new List<string>();

        //list.Add("arda");
        //list.Add("omer");
        //list.Add("semih");
        //list.Add("hunkar");

        //list.Remove("arda");


        //foreach (string value in list)
        //{
        //    Console.WriteLine(value);
        //}

        Bmevzuat bmevzuat = new Bmevzuat()
        {
            MevzuatValue = 126,
            AylıkValue = 7

        };


        Amevzuat amevzuat = new Amevzuat();

        amevzuat.MevzuatValueA = 324;
        amevzuat.AylıkValueA = 5;

        bmevzuat.degerlendir();
        Console.WriteLine("Mevzuat Değeri=>{0}", bmevzuat.MevzuatHesapla(bmevzuat.MevzuatValue, bmevzuat.AylıkValue));
        int sonuc1 = bmevzuat.MevzuatHesapla(bmevzuat.MevzuatValue, bmevzuat.AylıkValue);
        bmevzuat.kaydet();
        Console.WriteLine("----------------------");
        amevzuat.degerlendir();
        Console.WriteLine("Mevzuat Değeri=>{0}", amevzuat.MevzuatHesapla(amevzuat.MevzuatValueA,bmevzuat.AylıkValue));
        int sonuc2 = amevzuat.MevzuatHesapla(amevzuat.MevzuatValueA, bmevzuat.AylıkValue);
        amevzuat.kaydet();

        Console.WriteLine("--------------------------------------------");

        if (sonuc1 < sonuc2)
        {
            Console.WriteLine("A mevzuatı değeri B mevzuatı değerinden büyüktür>>");
        }
        else
        {
            Console.WriteLine("B mevzuatı değeri A mevzuatı değerinden büyüktür>>");
        }


        while (sonuc1 < sonuc2)
        {
            Console.WriteLine("Döngü sonlansın mı?");
            string? karar = Console.ReadLine();

            if (karar == "k")
            {
                sonuc2 = 1;
            }
            else
            {
                continue;
            }
            

            
        }





    }
}