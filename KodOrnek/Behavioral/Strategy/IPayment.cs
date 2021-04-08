using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Strategy
{
    //UML diyagramındaki Strategy arayüzüne denk gelir.
    //Benzer işlemleri yapan sınıflar bu arayüzden türeyecektir.
    public interface IPayment
    {
        void Pay(int amount);
    }
}
