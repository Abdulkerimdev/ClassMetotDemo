using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriList = new List<Musteri> { };
        public void Ekle(Musteri musteri)
        {
            if (musteri.Referans>0)
            {
                Console.WriteLine("Sisteme eklendi " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Referans + " adet referans ile");
                musteriList.Add(musteri);
            }
            else
            {
                Console.WriteLine("Üzgünüz.. Mutlaka bir referansınız olmalı.");
            }
        }
        public void Listele()
        {
            Console.WriteLine("*******************\nMüşteri listesi");
            foreach (var musteri in musteriList)
            {
                Console.WriteLine("\nAd: " + musteri.Ad + "\nSoyad:" + musteri.Soyad +
                    "\nGüven Puanı: " + musteri.Guven + "\nReferans Sayısı: " + musteri.Referans + "\n*********************");
            }
        }
        public void Guven(Musteri musteri)
        {
           musteri.Guven += 1;
           Console.WriteLine(musteri.Ad + " " + musteri.Soyad + "kişisine 1 güven puanı verildi. Güncel güven puanı: " + musteri.Guven);
        }

        public void Sil(Musteri musteri)
        {
            musteriList.Remove(musteri);
            Console.WriteLine(musteri.Ad + musteri.Soyad + "Yönetimin kararıyla başarıyla silinmiştir.");
        }

        public void Kontrol(Musteri musteri)
        {
            if (musteri.Guven < -4)
            {
                musteriList.Remove(musteri);
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Güven puanı düşüklüğü sebebiyle kaydı silinmiştir.");
            }
            else
            {
                Console.WriteLine("Müşterinin güven puanı gereken düzeydedir.Puanı: "+ musteri.Guven + "\nİyi günler \n");
            }
            
        }


    }
}
