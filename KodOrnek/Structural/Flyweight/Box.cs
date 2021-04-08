using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Flyweight
{
    //Nesnelerin ortak özelliklerini tutan sınıfımız
    // UML diyagramındaki Flyweight yapısına denk gelmektedir.
    public abstract class Box
    {
        public int Width;
        public int Height;
        public BoxColor boxColor;
        public abstract void Draw(int locX,int locY);
    }
}
