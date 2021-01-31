using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seçkin Bank'a Hoşgeldiniz\n\n");

            Musteri musteri1 = new Musteri() { Ad = "sami", Soyad = "samioğulları", Guven = 4, Id = 1, Referans = 2 };
            Musteri musteri2 = new Musteri() { Ad = "Mehmet", Soyad = "tosuncuk", Guven = -20, Id = 2, Referans = 1 };
            Musteri musteri3 = new Musteri() { Ad = "mustafa", Soyad = "yılmaz", Guven = 5, Id = 3, Referans = 1 };
            Musteri musteri4 = new Musteri() { Ad = "derya", Soyad = "yılmaz", Guven = 0, Id = 4, Referans = 0 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri3);
            musteriManager.Kontrol(musteri2);
            musteriManager.Kontrol(musteri3);
            musteriManager.Guven(musteri3);
            musteriManager.Listele();


        }
    }
}
