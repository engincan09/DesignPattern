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
            ProductManager productManager = new ProductManager(new MsSqlDatabaseFactory());          
        }
    }
}
