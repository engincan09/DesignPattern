using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Composite
{
    //Somut yapımız
    // UML diyagramındaki Composite kısmına denk gelmektedir.
    public class ProductCatalog : ICatalogComponent
    {
        private string _name;
        private List<ICatalogComponent> _components;
        public ProductCatalog(string name)
        {
            _name = name;
            _components = new List<ICatalogComponent>();
        }
        public void Add(ICatalogComponent catalogComponent)
        {
            _components.Add(catalogComponent);
        }
        public void Delete(ICatalogComponent catalogComponent)
        {
            _components.Remove(catalogComponent);
        }
        public void Hierarchy()
        {
            Console.WriteLine(_name);
            foreach (var component in _components)
            {
                component.Hierarchy();
            }
        }
    }
}
