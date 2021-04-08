using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    // UML'deki ConcreteProduct sınıfına denk gelmektedir.
    public class OracleConnection : Connection
    {
        public override bool Close()
        {
            //Gerekli operasyonlar
            return true;
        }

        public override bool Open()
        {
            //Gerekli operasyonlar
            return true;
        }
    }
}
