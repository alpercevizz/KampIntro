using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Toyota", "Corolla");
            myDictionary.Add("Seat", "Leon");
            myDictionary.Add("Skoda", "Octavia");
           

            
        }

       
    }
}
