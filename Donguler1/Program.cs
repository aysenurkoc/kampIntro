using System;

namespace Donguler1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazilim gelistirme kampi";
            string kurs2 = " proglamlamaya baslangic icin temel kurs";
            string kurs3 = "java";

            string[] kurslar = new string[] { "yazilim gelistirme kampi" ,
                " proglamlamaya baslangic icin temel kurs",
                "java" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
	{
                Console.WriteLine(kurs);
	}

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
