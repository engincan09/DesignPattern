using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    // Oluşturulacak sınıflarımıza ait metot imzalarımız
    public interface IDatabaseFactory
    {
        public Command CreateCommand();
        public Connection CreateConnection();
    }
}
