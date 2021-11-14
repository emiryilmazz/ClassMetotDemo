using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Emir";
            musteri1.Soyad = "Yılmaz";
            musteri1.telefon= 53504425;
            musteri1.ePosta = "emir@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Emir3";
            musteri2.Soyad = "Yılmaz3";
            musteri2.telefon = 535044253;
            musteri2.ePosta = "emir3@gmail.com";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Emir2";
            musteri3.Soyad = "Yılmaz2";
            musteri3.telefon = 535044252;
            musteri3.ePosta = "emir2@gmail.com";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine();
            musteriManager.MusteriSil(musteri2);
            Console.WriteLine();
            musteriManager.MusteriGuncelle(musteri3);
            Console.WriteLine();
            musteriManager.MusteriListele(musteri1);
            
        }

        class MusteriManager
        {
            public void MusteriEkle (Musteri musteri)
            {
                Console.WriteLine("Müşteri Eklendi");
                Console.WriteLine(musteri.Id+" "+ musteri.Ad+" "+musteri.Soyad+" "+musteri.telefon+" "+musteri.ePosta);
            }
            public void MusteriSil(Musteri musteri)
            {
                Console.WriteLine("Müşteri Silindi");
                Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.telefon + " " + musteri.ePosta);
            }
            public void MusteriGuncelle(Musteri musteri)
            {
                Console.WriteLine("Müşteri Güncellendi");
                Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.telefon + " " + musteri.ePosta);
            }
            public void MusteriListele(Musteri musteri)
            {
                Console.WriteLine("Müşteri Listelendi");
                Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.telefon + " " + musteri.ePosta);
            }
        }
    }
}
