using System;
using System.Reflection.Metadata;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer{DateOfBirth = new DateTime(1985,7,5), FirstName = "Akif", LastName = "TURAN", NationalityId = "19394629452"});
        }
    }
}
