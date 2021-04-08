using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Facade
{
    //Müşterimizi temsil eden sınıfımız
    public class Customer
    {
        public Customer(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string  FirstName { get; set; }
        public string LastName { get; set; }
    }
}
