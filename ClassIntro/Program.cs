using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C #";
            kurs1.KursEgitmeni = "ENGİN";
            kurs1.IzlenmeOrani = 68;

            

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C ++";

            kurs2.KursEgitmeni = "burak";
            kurs2.IzlenmeOrani = 78;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.KursEgitmeni = "berkay";
            kurs3.IzlenmeOrani = 70;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "python";
            kurs4.KursEgitmeni = "ayse";
            kurs4.IzlenmeOrani = 72;


            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursEgitmeni);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +":" + kurs.KursEgitmeni + " ve izlenme oranı " + kurs.IzlenmeOrani);
            }


            Console.WriteLine("Hello World!");

            
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
