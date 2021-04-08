using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Memento
{
    //Saklamak istediğimiz değerlerin tanımlandığı yerdir.
    //UML Diyagramında Memento yapısında denk gelir.
    public class TextMemento
    {
        public string Text { get; set; }
        public int CursorPosition { get; set; }
    }
}
