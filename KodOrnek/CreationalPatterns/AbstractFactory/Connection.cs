using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    //Bağlantı işlemlerinin soyut sınıfı.
    public abstract class Connection
    {
        public abstract bool Open();
        public abstract bool Close(); 
    }
}
