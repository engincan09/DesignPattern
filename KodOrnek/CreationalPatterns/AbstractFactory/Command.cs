using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    //Komut işlemlerinin soyut sınıfı.
    // UML'deki Product sınıfına denk gelmektedir.
    public abstract class Command
    {
        public abstract void ExecuteCommand(string query);
               
    }
}
