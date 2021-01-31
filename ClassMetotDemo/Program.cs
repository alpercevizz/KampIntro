using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.AdiSoyadi = "Ahmet Örnek";
            musteri1.TCNo = "12432647547";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.AdiSoyadi = "Mehmet Örnek";
            musteri2.TCNo = "34647584352";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.AdiSoyadi = "Cemil Örnek";
            musteri3.TCNo = "23565786853";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add();
            musteriManager.Remove();
            musteriManager.CustomerList(musteri1.Id, musteri1.AdiSoyadi, musteri1.TCNo);
            musteriManager.CustomerList(musteri2.Id, musteri2.AdiSoyadi, musteri2.TCNo);
            musteriManager.CustomerList(musteri3.Id, musteri3.AdiSoyadi, musteri3.TCNo);

            Console.WriteLine(musteriManager);
        }
    }
}
