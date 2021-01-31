using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Alper";
            int yas = 25;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

            ProductPhone product1 = new ProductPhone();
            product1.Marka = "Apple";
            product1.Model = "iPhone 12 Pro Max";
            product1.Hafiza = "128 GB";
            product1.ProductFiyat = 16899;

            ProductPhone product2 = new ProductPhone();
            product2.Marka = "Apple";
            product2.Model = "iPhone XR";
            product2.Hafiza = "64 GB";
            product2.ProductFiyat = 6179;

            ProductPhone product3 = new ProductPhone();
            product3.Marka = "Samsung";
            product3.Model = "Galaxy Note 10 Plus";
            product3.Hafiza = "256 GB";
            product3.ProductFiyat = 7449;

            ProductPhone[] phones = new ProductPhone[] { product1, product2, product3 };

            foreach(ProductPhone products in phones)
            {
                Console.WriteLine(products.Marka + " " + products.Model + " " + products.Hafiza + " " + products.ProductFiyat + " T");
            }

            for (int i = 0; i < phones.Length; i++)
            {
                Console.WriteLine(phones[i]);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

    class ProductPhone
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Hafiza { get; set; }
        public int ProductFiyat { get; set; }
    }
}
