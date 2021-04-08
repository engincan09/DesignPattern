using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Proxy
{
    //Maske siparişinin oluşturulduğu sınıf
    //İstemcinin direkt olarak erişmesini engellediğimiz sınıf
    //UML Diyagramında ConcreteService
    public class MaskOrder : IOrderableMask
    {
        public void CreateOrder(Person person)
        {
            //Sipariş oluşturma işlemleri
            Console.WriteLine("Sipariş oluşturuldu!");
        }
    }
}
