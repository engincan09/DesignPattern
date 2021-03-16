using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPatterns.Prototype
{
    // Customer sınıfına klonlama yeteneği kazandırmak için tanımladığımız arayüzü uyguladık.

    public class Customer : IClonablePrototype<Customer>
    {
        string _firstName;
        string _lastName;
        public Customer(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
    
        public Customer Clone()
        {
            return base.MemberwiseClone() as Customer;
        }
    }
}
