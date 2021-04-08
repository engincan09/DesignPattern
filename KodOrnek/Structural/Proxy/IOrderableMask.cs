using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Proxy
{
    //Sipariş işlemlerini gerçekleştiren sınıflar tarafından uygulanacak arayüz
    //UML Diyagramında Service arayüzüdür.
    public interface IOrderableMask
    {
        void CreateOrder(Person person);
    }
}
