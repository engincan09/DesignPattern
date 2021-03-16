using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPatterns.Builder
{
    //Builder arayüzünü kullanarak nesne örneklemesi yapar.
    class ProductDirector
    {
        private ProductBuilder _productBuilder;

        public ProductDirector(ProductBuilder productBuilder)
        {
            _productBuilder = productBuilder;
        }

        public void Make()
        {
            _productBuilder.Get();
            _productBuilder.ApplyDiscount();
            _productBuilder.GetResult();
        }
    }
}
