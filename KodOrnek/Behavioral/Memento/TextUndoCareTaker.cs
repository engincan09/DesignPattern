using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Memento
{
    //Memento'ların referansını tutulduğu yerdir.
    //UML Diyagramındaki CareTaker yapısında denk gelmektedir.
    public class TextUndoCareTaker
    {
        private Stack<TextMemento> _mementos;
        public TextUndoCareTaker()
        {
            _mementos = new Stack<TextMemento>();
        }

        //Çağrılma işlemi yapıldığında yığının en üstündeki memento örneği silinir ve geriye dönülür.
        //Ekleme işlemi yapıldığında yığının en üstüne memento örneği eklenir.
        public TextMemento TextMemento
        {
            get
            {
                //Stack en üstündeki nesneyi çıkarır
                return _mementos.Pop();
            }
            set
            {
                //Stack en üstüne bir nesne ekler
                _mementos.Push(value);
            }
        }
    }
}
