using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Akif";
            customer.LastName = "TURAN";

            Customer customer2 = new Customer
            {
                Id = 2, City = "Eskişehir", FirstName="Irmak",LastName="TURAN"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();

            
        }
    }
}
