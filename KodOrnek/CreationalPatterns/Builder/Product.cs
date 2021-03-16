using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CreationalPatterns.Builder
{
    public class Product 
    {
        //Birden fazla sunumu olan nesnemiz
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }
        public int DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }
    }
}
