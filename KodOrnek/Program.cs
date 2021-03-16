using DesignPattern.CreationalPatterns.Builder;
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
            var productBuilder = new NewCustomerProductBuilder();
            ProductDirector productDirector = new ProductDirector(productBuilder);
            productDirector.Make();

            DesignPattern.CreationalPatterns.Builder.Product product = productBuilder.GetResult();
           
        }
    }
}
