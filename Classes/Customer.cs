using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //Field
        //public string FirstName;

        //Property
        public int Id { get; set; }

        private string _firstName;
        //public string FirstName
        //{
        //    get { return "Mrs." + _firstName; }
        //    set { _firstName = value;} 
        //}

        //Auto Property özelliği sonradan gelen
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
