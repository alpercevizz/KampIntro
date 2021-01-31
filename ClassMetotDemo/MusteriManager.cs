using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri başarıyla eklendi!");
        }

        public void Remove()
        {
            Console.WriteLine("Müşteri başarıyla silindi");
        }

        public void CustomerList(int Id, string AdiSoyadi, string MusteriTc)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Müşteri Listeleniyor...");
            Console.WriteLine(Id + " - " + AdiSoyadi + " - " + MusteriTc);
        }
    }
}
