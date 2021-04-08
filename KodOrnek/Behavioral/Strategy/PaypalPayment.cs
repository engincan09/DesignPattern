using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Strategy
{
    public class PaypalPayment : IPayment
    {
        private string _email;
        private string _password;
        public PaypalPayment(string email,string password)
        {
            _email = email;
            _password = password;
        }

        
        public void Pay(int amount)
        {
            //Kredi kartı işlemleri....
            Console.WriteLine("Paypal İle Ödendi");
        }
    }
}
