using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo2.Abstract;
using InterfaceAbstractDemo2.Concrete;
using InterfaceAbstractDemo2.Entities;

namespace InterfaceAbstractDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 7, 5), FirstName = "Akif", LastName = "TURAN", NationalityId = "19394629452" });
            Console.ReadLine();
        }
    }
}
