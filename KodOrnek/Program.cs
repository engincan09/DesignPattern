using DesignPattern.CreationalPatterns.Builder;
using DesignPattern.CreationalPatterns.Prototype;
using KodOrnek.CreationalPatterns.AbstractFactory;
using KodOrnek.CreationalPatterns.Factory;
using KodOrnek.Singleton;
using System;

namespace KodOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Gülizar", "Yılmaz");
            Customer cloneCustomer = customer.Clone();

            // Aynı nesne örneklerini farklı referanslarda tutuyor.
            // Birbirinin aynısı ve farklı referanslarda olan nesneler elde ettik.

            Console.WriteLine(customer == cloneCustomer); 
            //output: false

        }
    }
}
