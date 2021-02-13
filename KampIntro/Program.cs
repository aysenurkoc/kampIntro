using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.46;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.35;

            if (dolarDun > dolarBugun)

            {
                Console.WriteLine("Azalis butonu");
            }
            else if (dolarDun < dolarBugun) 
            {
                Console.WriteLine("Artıış butonu");
            }

            else 
            {
                Console.WriteLine("Esitir butonu");
            }




            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("kulanici ayarlari butonu");
            }

            else
            {
                Console.WriteLine("sisteme girisyap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
