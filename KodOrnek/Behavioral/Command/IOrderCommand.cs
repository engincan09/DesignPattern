using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Command
{
    //Yemel arayüzdür.
    //Komutların çalıştırılması için temel metotları içermektedir.
    //Uml diyagramındaki command arayüzüne denkgelmektedir.
    public interface IOrderCommand
    {
        void Execute();
    }
}
