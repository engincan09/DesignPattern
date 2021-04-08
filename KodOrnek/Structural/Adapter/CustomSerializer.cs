using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Adapter
{
    // Sisteme daha sonradan dahil olan yapı.
    // Sistemin kullandığı arayüzü uygulamamaktadır.
    // UML diyagramındaki Adaptee'ye denk gelmektedir.
    public class CustomSerializer
    {
        public string Serialize(object obj)
        {
            // Gelen nesneyi serilize etmek için temel operasyonel işlemler..
            // Daha sonradan da gerekli değerin geri döndürülmesi...
            return "Serilize yapıldı";

        }
    }
}
