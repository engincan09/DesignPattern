using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    //Bağlantı işlemlerinin soyut sınıfı.
    // UML'deki Product sınıfına denk gelmektedir.
    public abstract class Connection
    {
        public abstract bool Open();
        public abstract bool Close(); 
    }
}
