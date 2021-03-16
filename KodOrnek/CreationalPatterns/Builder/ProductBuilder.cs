using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPatterns.Builder
{
    // Product sınıfıa ait nesnenin oluşturulması için soyut arayüz sağlar.
    // Yapılması gereken adımlar içerisinde tanımlanır.
    public abstract class ProductBuilder
    {
        public Product product;
        public abstract void Get();
        public abstract void ApplyDiscount();
        public abstract Product GetResult();
    }
}
