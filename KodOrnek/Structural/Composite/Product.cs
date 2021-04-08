using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Composite
{
    //Somut sınıfımız
    //Hiyerarşinin en alt tabakası
    // UML diyagramındaki Leaf kısmına denk gelmektedir.
    public class Product : ICatalogComponent
    {
        private string _name;

        public Product(string name)
        {
            _name = name;
        }

        public void Hierarchy()
        {
            Console.WriteLine(_name);
        }
    }
}
