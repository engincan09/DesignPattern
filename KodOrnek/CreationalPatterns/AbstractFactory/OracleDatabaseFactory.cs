using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    // UML'deki ConcreteFactory sınıfına denk gelmektedir.
    public class OracleDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        {
            return new OracleCommand();
        }

        public Connection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
