using DesignPattern.CreationalPatterns.Builder;
using DesignPattern.CreationalPatterns.Prototype;
using DesignPattern.Structural.Adapter;
using DesignPattern.Structural.Bridge;
using DesignPattern.Structural.Composite;
using DesignPattern.Structural.Decorator;
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
            //CompositeDesignPattern();
            //DecolatorDesignPattern();
        }

        private static void DecolatorDesignPattern()
        {
            IDataSource dataSource = new FileDataSource("data.sql");
            IDataSource compressedDataSource = new ComporessionDecorator(dataSource);
            compressedDataSource.ReadData();
            compressedDataSource.WriteData(new object());
        }

        private static void CompositeDesignPattern()
        {
            var items = new ProductCatalog("Ürünler");
            var phones = new ProductCatalog("Telefonlar");
            var iphone = new ProductCatalog("İphone Telefon");
            var samsung = new ProductCatalog("Samsung Telefon");
            var iphone5Item = new DesignPattern.Structural.Composite.Product("Iphone 5");
            var samsungGalaxyItem = new DesignPattern.Structural.Composite.Product("Samsung Galaxy");

            //En Üst hiyararşiye Telefonlar eklendi
            items.Add(phones);
            //Telefonlar hiyararşisine iphone ve samsung ekledik
            phones.Add(iphone);
            phones.Add(samsung);

            //Iphone ve samsung hiyerarşisine Iphone5 ve samsung galaxy ekledik
            iphone.Add(iphone5Item);
            samsung.Add(samsungGalaxyItem);
            //hiyerarşiyi ekrana yazdık
            items.Hierarchy();
        }
    }
}
