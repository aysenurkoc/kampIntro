using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public  void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler sepete eklendi : "+ urun.Adi);


        }
        public void Ekle2(string urunAdi, string Aciklama, double Fiyati, int StokAdedi)
        {
            Console.WriteLine("Tebrikler sepete eklendi : " + urunAdi);
        }
    }
}

