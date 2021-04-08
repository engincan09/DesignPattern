using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    // UML'deki ConcreteFactory sınıfına denk gelmektedir.
    public class MsSqlDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        {
            return new MsSqlCommand();
        }

        public Connection CreateConnection()
        {
            return new MsSqlConnection();
        }
    }
}
