using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type Safety = tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Giriş Yapıldı");
            }

            else
            {
                Console.WriteLine("Lütfen Giriş Yapın !");
            }
        }
    }
}
