using System;
using System.Collections.Generic;
using System.Text;

namespace KodOrnek.CreationalPatterns.AbstractFactory
{
    //Komut işlemlerinin soyut sınıfı.
    public abstract class Command
    {
        public abstract void ExecuteCommand(string query);
               
    }
}
