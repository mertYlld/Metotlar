using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            //sayilar1 in referans numarası = sayilar2 nin referans numarası.
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar2[0]?? 999

            //int, decimal, float, deouble, bool => Değer tip.
            //array, class, interface => Referans tip.
                
        }
    }
}
