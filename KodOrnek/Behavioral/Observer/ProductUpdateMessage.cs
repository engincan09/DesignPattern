using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Observer
{
    //Bildirilecek olan nesnelere parametre olarak giden mesaj;
    //UML diyagramı ile bir bağlantısı yoktur.
    public class ProductUpdateMessage
    {
        public string productName;
        public string message;

        public override string ToString()
        {
            return $"{productName} güncellendi. Mesaj: {message}";
        }
    }
}
