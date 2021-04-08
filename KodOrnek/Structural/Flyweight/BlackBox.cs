using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Flyweight
{
    //Box sınıfını uygulayan sınıfımız
    // UML diyagramındaki ConcreteFlyweight sınıfına denk gelmektedir.
    public class BlackBox : Box
    {
        public BlackBox(int width, int height)
        {
            this.Height = height;
            this.Width = width;
            this.boxColor = BoxColor.Blue;
        }
        public override void Draw(int locX, int locY)
        {
            Console.WriteLine("Box Çizildi.!" + locX, locY);
        }
    }
}
