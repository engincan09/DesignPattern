using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    public class MsSqlConnection : Connection
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
