using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Observer
{
    //Observer arayüzünü uygulayan, değişimi takip eden sınıflardır.
    //Değişim update metotu ile bildirilir.
    //UML Diyagramındaki ConcreteObserver yapısına denk gelmektedir.
    public class ObserverUser : IObserverUser
    {
        public void SendNotification(ProductUpdateMessage message)
        {
            Console.WriteLine(message.ToString());
        }
    }
}
