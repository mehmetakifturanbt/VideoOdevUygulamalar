using System;

namespace Interfaces2
{
    class Program
    {
        //interface new'lenemez.
        static void Main(string[] args)
        {
            //interface ler onu implemente eden class'ın referansı numarasını (referansını) tutabilirler.
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Update();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());
            projectManager.Update(new CustomerManager());
        }
    }

    interface IPersonManager
    {
        //unimplemented operation 
        void Add();
        void Update();
    }

    class PersonManager
    {
        //implemented operation
        public void AddPerson()
        {
            Console.WriteLine("Eklendi");
        }
    }

    //inherits - class -------------- implements - interface
    class CustomerManager : PersonManager, IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager) //parametre olarak interface verdik. Dikkat...
        {
            personManager.Add();
        }

        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
