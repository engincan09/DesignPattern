using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPatterns.Builder
{
    // ProductBuilder sınıfından türer ve orada tanımlı adımları gerçekleştirir.
    public class NewCustomerProductBuilder : ProductBuilder
    {
        //Yeni müşteriler için indirim uygulama işlemi
        public override void ApplyDiscount()
        {
            product.Price = 250;
            product.DiscountApplied = true;
        }

        //Ürün getirme işlemi
        public override void Get()
        {
            product = new Product
            {
                Id = 1, Price = 500, CategoryId = 1
            };
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
