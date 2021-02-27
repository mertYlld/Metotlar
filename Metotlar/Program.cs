using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 10;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("--------Metotlar-------");
            //instance - ornek
            //encapsulation - kapsülleme. 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "yeşil armut", 12, 10);
            sepetManager.Ekle2("elma", "yeşil elma", 12, 8);
            sepetManager.Ekle2("karpuz", "Diyarbakır karpuzu", 12, 20);
        }
    }
}
//metotlar-tekrar tekrar kullanılabilirliği sağlayan ortam sağlıyor.
//dont repeat yourself - DRY - Clean code - Best practice/doğru uygulama teknikleri. - 