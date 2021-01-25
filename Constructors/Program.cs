using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName="Akif", LastName="TURAN", City="Balıkesir"};
            //bir alttaki ve üstteki customer tanımlama, aynı şekilde parametre vermeden, ekleme yaparak
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Irmak";
            customer3.LastName = "Nisa";
            customer3.City = "Ankara";

            Customer customer2 = new Customer(2, "Ali", "Irmak", "Ordu"); //Burası 101

            Console.WriteLine(customer2.FirstName);


        }

    }

    class Customer
    {
        public Customer()
        {

        }
        //default constructor
        public Customer(int id, string firstName, string lastName, string city) //Burası 101 (üstteki 101 yazan yer burayı çalıştırır.
        {
            Console.WriteLine( "Yapıcı Blok Çalıştı.");
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
