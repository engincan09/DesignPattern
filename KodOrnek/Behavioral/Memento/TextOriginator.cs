using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Memento
{
    //Değerleri tutulacak olan ve önceki değerlerine geri dönebilen sınıftır.
    //UML Diyagramındaki Originator yapısına denk gelmektedir.
    //Geriye dönebilme özelliği olduğu için önceki durumları tutan CareTaker referansını tutmaktadır.
    public class TextOriginator
    {
        public string Text { get; set; }
        public int CursorPosition { get; set; }

        private TextUndoCareTaker _textCateTaker;
        public TextOriginator()
        {
            _textCateTaker = new TextUndoCareTaker();
        }

        //Anlık kayıt değerlerini UML diyagramındaki CareTaker üzerinden yığına eklemektedir.
        public void Save()
        {
            _textCateTaker.TextMemento = new TextMemento
            {
                CursorPosition = this.CursorPosition,
                Text = this.Text
            };
        }
        // Geri alma işleminde yığının en üstündeki değeri alır.
        // Değer alma işleminden sonra sınıfın mevcut değerlerine atanır.
        public void Undo()
        {
            TextMemento previousTextMemento = _textCateTaker.TextMemento;
            CursorPosition = previousTextMemento.CursorPosition;
            Text = previousTextMemento.Text;
        }

        public override string ToString()
        {
            return $"Text: {Text}, Cursor Position: {CursorPosition}";
        }
    }
}
