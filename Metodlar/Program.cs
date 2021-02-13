using System;

namespace Metodlar
{
    class Program
    {
        private static object sepetManager;

        static void Main(string[] args)
        {

            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "amasya elması";


            string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            
            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(".....");


            }

            Console.WriteLine("......   Metodlar......");

            Console.WriteLine();

            SepetManager sepetManager = new SepetManager();

            
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut ", "Yeşil Armut",12,2);
            sepetManager.Ekle2("Elma ", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz ", "Diyarbakır", 12,0);
        }
    }
}
