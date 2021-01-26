using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Akif"
                },
                new Student
                {
                    FirstName = "Irmak"
                },
                new Person
                {
                    FirstName = "Ali"
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }


    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    interface IPerson
    {

    }

    //Classların tek başlarına anlamı vardır ama interfacelerin tek başlarına bir anlamı yoktur. İkisi de inheritance gibi kullanılabiliyor.
    //Aslında interfaceler bir implementasyondur. Fakat yeni nesil dillerde interfacelerin inheritance gibi kullanım senaryoları söz konusudur.
    //Bir sınıfa ebeveyn atarken ve interface atarken önce sınıf yani inheritance, sonra interface veya interfaceler(kaç tane varsa) altaki örnekte
    class Customer : Person, IPerson
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
