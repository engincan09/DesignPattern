using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    // Oluşturulacak sınıflarımıza ait metot imzalarımız
    // UML'deki AbstractFactory sınıfına denk gelmektedir..

    public interface IDatabaseFactory
    {
        public Command CreateCommand();
        public Connection CreateConnection();
    }
}
