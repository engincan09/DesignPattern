using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Proxy
{
    //istemcinin muhatap olacağı sınıftır.
    //Gerçek işi yapan MaskOrder sınıfının referansını tutar
    //Sipariş vermeden önce kişinin bilgilerini kontrol eder.
    public class AuthentictableMaskOrderProxy : IOrderableMask
    {
        private IOrderableMask _orderMask;
        public AuthentictableMaskOrderProxy()
        {
            _orderMask = new MaskOrder();
        }
        public void CreateOrder(Person person)
        {
            //Sipariş oluşturulmadan önce kimlik kontrolü yapılır.
            bool isValid = CheckPersonIsValid(person);
            if (isValid)
            {
                _orderMask.CreateOrder(person);
            }
            else
            {
                Console.WriteLine("Kullanıcı Doğrulama Hatası");
            }
        }

        private bool CheckPersonIsValid(Person person)
        {
            //Burada Mernis servislerimiz çalışır.
            return person.TC.Length == 11 && person.Adress != "" ? true : false;
        }
    }
}
