using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Proxy
{
    //Maske Siparişi verecek olan kullanıcı
    public class Person
    {
        public string TC { get; set; }
        public string Adress { get; set; }

        public Person(string tc, string adress)
        {
            TC = tc;
            adress = Adress;
        }
    }
}
