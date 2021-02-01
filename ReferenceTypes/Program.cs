using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine("Sayılar 1'in 0'ı : " + sayilar1[0]); //1000

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Alper";

            person2 = person1;
            person1.FirstName = "Ali"; //person2 ve person1'in referans adresi değiştiği için ismi de değişir. 



            Customer customer = new Customer();
            customer.FirstName = "Mehmet";
            customer.CreditCardNumber = "1234567890";
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer; // customer'ı person'ın parentı yaptığımız için inherit ettiğinden eşitleyebildik.
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }


    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
