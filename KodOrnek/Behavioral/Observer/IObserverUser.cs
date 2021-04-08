using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Observer
{
    //Değişimden etkilenecek, izleyecek olan sınıfların uyguladığı arayüzdür.
    //UML Diyagramındaki Observer yapısına denk gelmektedir.
    public interface IObserverUser
    {
        void SendNotification(ProductUpdateMessage message);
    }
}
