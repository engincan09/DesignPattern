using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    public class OracleCommand : Command
    {
        public override void ExecuteCommand(string query)
        {
            // Gerekli operasyonlar
            Console.WriteLine("Oracle Komutu Çalıştırıldı");
        }
    }
}
