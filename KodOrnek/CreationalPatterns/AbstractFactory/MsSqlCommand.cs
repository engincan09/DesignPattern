using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    //MsSql komutları için Somut sınıfımız
    public class MsSqlCommand : Command
    {
        public override void ExecuteCommand(string query)
        {
            // Gerekli operasyonlar
            Console.WriteLine("MsSQL Komutu Çalıştırıldı");
          
        }
    }
}
