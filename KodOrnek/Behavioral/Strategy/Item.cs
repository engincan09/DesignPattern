using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Strategy
{
    // Sepette bulunan ürünleri temsil eden sınıf.
    // Ürün kodu ve fiyat bilgisi temel olarak yeterlidir.
    class Item
    {
        private string _upcCode;
        private int _price;

        public Item(string upcCode, int price)
        {
            _upcCode = upcCode;
            _price = price;
        }

        public int GetPrice()
        {
            return _price;
        }
    }
}
