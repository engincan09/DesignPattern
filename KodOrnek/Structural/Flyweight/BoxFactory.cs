using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Structural.Flyweight
{
    //Box havuzunu tutacak sınıf.
    //Daha önceden nesne oluşturulmamışsa havuza atılacak.
    //Oluşturulmuş ise havuzdan seçecek.
    // UML diyagramındaki FlyweightFactory sınıfına denk gelmektedir. 
    public class BoxFactory
    {
        private Dictionary<BoxColor, Box> _boxes;
        public BoxFactory()
        {
            _boxes = new Dictionary<BoxColor, Box>();
        }
        public Box Get(BoxColor color) 
        {
            if (_boxes.ContainsKey(color))
            {
                return _boxes[color];
            }
            Box box = null;
            if (color == BoxColor.Black)
            {
                box = new BlackBox(20, 20);
            }
            else if (color == BoxColor.Blue)
            {
                box = new BlueBox(20,20);
            }
            _boxes.Add(color,box);
            return box;
        }
    }
}
