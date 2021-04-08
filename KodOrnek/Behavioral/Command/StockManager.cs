using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Command
{
    //Komutları nesneler haline getirelecek olan sınıftır.
    //Uml diyagramında ki Receiver sınıfına denk gelmektedir.
    public class StockManager
    {
        private string _name;
        private int _quantity;
        public StockManager(string name,int quantity)
        {
            _name = name;
            _quantity = quantity;
        }
        public void Buy()
        {
            Console.WriteLine($"Stock: { _name},{_quantity }");
        }
        public void Sell()
        {
            Console.WriteLine($"Stock: { _name},{_quantity }");
        }
    }
}
