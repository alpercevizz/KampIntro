using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id = 1, FirstName = "Alper", LastName = "Ceviz", City = "Kocaeli"}; //parametre vermediğimiz için ilk constructor
            Customer customer2 = new Customer(2, "Ali", "Veli", "Kocaeli"); // Parametre olduğu için ikinci constructor çalışır.

            Console.WriteLine(customer2.FirstName);
            
        }

        
    }

    class Customer
    {
        public Customer()
        {
            // Parametresi olmadığı için default constructor
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
