using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    // UML'deki ConcreteProduct sınıfına denk gelmektedir.
    public class OracleCommand : Command
    {
        public override void ExecuteCommand(string query)
        {
            // Gerekli operasyonlar
            Console.WriteLine("Oracle Komutu Çalıştırıldı");
        }
    }
}
