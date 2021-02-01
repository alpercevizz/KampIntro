using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> sehirler = new List <string>();
            sehirler.Add("Kocaeli");
            Console.WriteLine(sehirler.Count);

            MyList <string>sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count);
            
        }
    }

    class MyList<T> // Generic class executes T type.
    {
        T[] array;
        T[] tempArray;
        public MyList()
        {
            array = new T[0]; // 0 elemanlı bir array yaptık.
        }
        public void Add(T item)
        {
            tempArray = array;
            array = new T[array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }

            array[array.Length - 1] = item;
        }

        private int _count;

        public int Count
        {
            get { return array.Length; }
            
        }

    }
}
